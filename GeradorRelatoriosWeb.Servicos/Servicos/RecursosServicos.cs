using GeradorRelatoriosWeb.Dominio.Entidades.SIOR;
using GeradorRelatoriosWeb.Dominio.Models;
using GeradorRelatoriosWeb.Dominio.Utils;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
 
namespace GeradorRelatoriosWeb.Servicos.Servicos
{
    public class RecursosServicos : ServiceBaseSior<TblInfracaoRecurso>
    {
        public List<RetornoRecursosJariLista> BuscaRecursosJari(DateTime dataInicio, DateTime dataFim, bool refProtocolo)
        {
            try
            {
                var retorno = new List<RetornoRecursosJariLista>();
                var dataReferenciaInicio = refProtocolo ? dataInicio : dataInicio.AddYears(-3);
                var dataReferenciaFim = refProtocolo ? dataFim : dataFim.AddYears(-3);

                using (var db = new BD_SIORContext())
                {
                    var dadosRecurso = db.TblInfracaoRecurso.AsNoTracking()
                        .Include("CodigoJariNavigation")
                        .Include("CodigoInfracaoNavigation").Select(a => new {
                            a.DataProtocolo,
                            a.RecorrenteNumeroCpfcnpjformatado,
                            NomeJari = a.CodigoJariNavigation == null ? "Não encaminhado" : a.CodigoJariNavigation.Nome,
                            a.CodigoInfracaoNavigation.NumeroAit,
                            a.NumeroProcesso
                        })
                        .Where(a => a.DataProtocolo >= dataReferenciaInicio && a.DataProtocolo <= dataReferenciaFim)
                        .ToList();

                    foreach (var item in dadosRecurso)
                    {
                        var dados = new RetornoRecursosJariLista
                        {
                            CpfCnpjRecorrente = item.RecorrenteNumeroCpfcnpjformatado,
                            DataProtocolo = item.DataProtocolo.ToShortDateString(),
                            JARI = item.NomeJari,
                            NumeroAIT = item.NumeroAit,
                            NumeroProcesso = item.NumeroProcesso
                        };

                        retorno.Add(dados);
                    }

                    db.Dispose();
                }

                return retorno;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Stream ExportarRecursosJari(DateTime dataInicio, DateTime dataFim, bool refProtocolo)
        {
            try
            {
                var retorno = new List<RetornoRecursosJari>();
                var dataReferenciaInicio = refProtocolo ? dataInicio : dataInicio.AddYears(-3);
                var dataReferenciaFim = refProtocolo ? dataFim : dataFim.AddYears(-3);

                var dadosRecurso = ListarInclude(a => a.DataProtocolo >= dataReferenciaInicio && a.DataProtocolo <= dataReferenciaFim,
                    "CodigoInfracaoRecursoFaseNavigation,CodigoInfracaoNavigation,CodigoJariNavigation,CodigoInfracaoRecursoTipoNavigation,CodigoInfracaoRecursoSituacaoNavigation");

                foreach (var item in dadosRecurso)
                {
                    var dados = new RetornoRecursosJari
                    {
                        CpfCnpjRecorrente = item.RecorrenteNumeroCpfcnpjformatado,
                        DataProtocolo = item.DataProtocolo.ToShortDateString(),
                        JARI = item.CodigoJari == null ? "Não encaminhado" : item.CodigoJariNavigation.Nome,
                        NumeroAIT = item.CodigoInfracaoNavigation.NumeroAit,
                        NumeroProcesso = item.NumeroProcesso,
                        FaseRecurso = item.CodigoInfracaoRecursoFaseNavigation.Nome,
                        Instancia = item.CodigoInfracaoRecursoTipoNavigation.Nome,
                        PrevisaoPrescricao = item.DataProtocolo.AddYears(3).ToShortDateString(),
                        SituacaoRecurso = item.CodigoInfracaoRecursoSituacaoNavigation.Nome
                    };

                    using (var db = new BD_SIORContext())
                    {
                        dados.QuantidadedeArquivos = db.TblInfracaoRecursoArquivo.Where(a => a.CodigoInfracaoRecurso == item.CodigoInfracaoRecurso).Count().ToString();
                        dados.UF = item.CodigoJari == null ? "Não Identificado" : db.TblBaseUf.Where(a => a.CodigoBaseUf == item.CodigoJariNavigation.CodigoBaseUf).FirstOrDefault().Sigla;
                        db.Dispose();
                    }

                    retorno.Add(dados);
                }

                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("Tabela1");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoRecursosJari), planilha);

                    package.Save();
                }
                stream.Position = 0;

                return stream;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<RetornoRecursosJulgados> BuscaRecursosJulgados(int ano)
        {
            try
            {
                var ret = new List<RetornoRecursosJulgados>();

                var dadosRecurso = ListarInclude(a => a.DataJulgamento.Value.Year == ano && a.CodigoInfracaoRecursoSituacao == 2, "CodigoJariNavigation")
                    .Select(a => new
                    {
                        a.DataJulgamento,
                        Jari = a.CodigoJariNavigation == null ? "" : a.CodigoJariNavigation.Nome
                    })
                    .GroupBy(a => a.Jari);

                foreach (var item in dadosRecurso)
                {
                    var dados = new RetornoRecursosJulgados
                    {
                        Janeiro = item.Count(a => a.DataJulgamento.Value.Month == 1),
                        Fevereiro = item.Count(a => a.DataJulgamento.Value.Month == 2),
                        Marco = item.Count(a => a.DataJulgamento.Value.Month == 3),
                        Abril = item.Count(a => a.DataJulgamento.Value.Month == 4),
                        Maio = item.Count(a => a.DataJulgamento.Value.Month == 5),
                        Junho = item.Count(a => a.DataJulgamento.Value.Month == 6),
                        Julho = item.Count(a => a.DataJulgamento.Value.Month == 7),
                        Agosto = item.Count(a => a.DataJulgamento.Value.Month == 8),
                        Setembro = item.Count(a => a.DataJulgamento.Value.Month == 9),
                        Outubro = item.Count(a => a.DataJulgamento.Value.Month == 10),
                        Novembro = item.Count(a => a.DataJulgamento.Value.Month == 11),
                        Dezembro = item.Count(a => a.DataJulgamento.Value.Month == 12),
                        JARI = item.FirstOrDefault().Jari == "" ? "Não Informada" : MontaNomeJari(item.FirstOrDefault().Jari)
                    };

                    ret.Add(dados);
                }

                ret.ForEach(a => a.Total = a.Janeiro + a.Fevereiro + a.Marco + a.Abril + a.Maio + a.Junho + a.Julho + a.Agosto + a.Setembro + a.Outubro + a.Novembro + a.Dezembro);
                return ret;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private string MontaNomeJari(string jari)
        {
            switch (jari)
            {
                case "JARI 01":
                    return jari + " (JARI-SE)";
                case "JARI 02":
                    return jari + " (JARI-SP)";
                case "JARI 03":
                    return jari + " (JARI-CE)";
                case "JARI 04":
                    return jari + " (JARI-RN)";
                case "JARI 05":
                    return jari + " (JARI-MT 2)";
                case "JARI 06":
                    return jari + " (JARI-SEDE 3)";
                case "JARI 07":
                    return jari + " (JARI-MG)";
                case "JARI 08":
                    return jari + " (JARI-PB 3)";
                case "JARI 09":
                    return jari + " (JARI-SC)";
                case "JARI 10":
                    return jari + " (JARI-PB 1)";
                case "JARI 11":
                    return jari + " (JARI-PB 2)";
                case "JARI 12":
                    return jari + " (JARI-AL 1)";
                case "JARI 13":
                    return jari + " (JARI-AL 2)";
                case "JARI 14":
                    return jari + " (JARI-GO 1)";
                case "JARI 15":
                    return jari + " (JARI-RO)";
                case "JARI 16":
                    return jari + " (JARI-PI)";
                case "JARI 17":
                    return jari + " (JARI-PB 4)";
                case "JARI 18":
                    return jari + " (JARI-SEDE 4)";
                case "JARI 19":
                    return jari + " (JARI-GO 2)";
                case "JARI 20":
                    return jari + " (JARI-PR)";
                case "JARI 21":
                    return jari + " (JARI-GO 3)";
                default:
                    return jari;
            }
        }

        public Stream ExportarRecursosJulgados(int ano)
        {
            try
            {
                var retorno = BuscaRecursosJulgados(ano);
                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("Tabela1");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoRecursosJulgados), planilha);

                    package.Save();
                }
                stream.Position = 0;

                return stream;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<RetornoRecursosJariLista> BuscaTempestividade(DateTime dataInicio, DateTime dataFim, bool refProtocolo)
        {
            try
            {
                var retorno = new List<RetornoRecursosJariLista>();
                var dataReferenciaInicio = refProtocolo ? dataInicio : dataInicio.AddYears(-3);
                var dataReferenciaFim = refProtocolo ? dataFim : dataFim.AddYears(-3);

                using (var db = new BD_SIORContext())
                {
                    var dadosRecurso = db.TblInfracaoRecurso.AsNoTracking()
                        .Include("CodigoJariNavigation")
                        .Include("CodigoInfracaoNavigation").Select(a => new {
                            a.DataProtocolo,
                            a.RecorrenteNumeroCpfcnpjformatado,
                            NomeJari = a.CodigoJariNavigation == null ? "Não encaminhado" : a.CodigoJariNavigation.Nome,
                            a.CodigoInfracaoNavigation.NumeroAit,
                            a.NumeroProcesso,
                            a.DataJulgamento,
                            a.CodigoInfracaoRecursoSituacao
                        })
                        .Where(a => a.DataProtocolo >= dataReferenciaInicio && a.DataProtocolo <= dataReferenciaFim && a.DataJulgamento == null 
                                && (a.CodigoInfracaoRecursoSituacao == 1 || a.CodigoInfracaoRecursoSituacao == 5)).OrderBy(a => a.DataProtocolo)
                        .ToList();

                    foreach (var item in dadosRecurso)
                    {
                        var dados = new RetornoRecursosJariLista
                        {
                            CpfCnpjRecorrente = item.RecorrenteNumeroCpfcnpjformatado,
                            DataProtocolo = item.DataProtocolo.ToShortDateString(),
                            JARI = item.NomeJari,
                            NumeroAIT = item.NumeroAit,
                            NumeroProcesso = item.NumeroProcesso
                        };

                        retorno.Add(dados);
                    }

                    db.Dispose();
                }

                return retorno;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Stream ExportarTempestividade(DateTime dataInicio, DateTime dataFim, bool refProtocolo)
        {
            try
            {
                var retorno = new List<RetornoTempestividade>();
                var dataReferenciaInicio = refProtocolo ? dataInicio : dataInicio.AddYears(-3);
                var dataReferenciaFim = refProtocolo ? dataFim : dataFim.AddYears(-3);

                using (var db = new BD_SIORContext())
                {
                    var dadosRecurso = db.TblInfracaoRecurso.AsNoTracking()
                        .Include("CodigoJariNavigation")
                        .Include("CodigoInfracaoNavigation").Select(a => new {
                            a.DataProtocolo,
                            a.RecorrenteNumeroCpfcnpjformatado,
                            NomeJari = a.CodigoJariNavigation == null ? "Não encaminhado" : a.CodigoJariNavigation.Nome,
                            a.CodigoInfracaoNavigation.NumeroAit,
                            a.NumeroProcesso,
                            a.CodigoInfracao,
                            a.DataJulgamento,
                            a.CodigoInfracaoRecursoSituacao
                        })
                        .Where(a => a.DataProtocolo >= dataReferenciaInicio && a.DataProtocolo <= dataReferenciaFim && a.DataJulgamento == null
                                && (a.CodigoInfracaoRecursoSituacao == 1 || a.CodigoInfracaoRecursoSituacao == 5)).OrderBy(a => a.DataProtocolo)
                        .ToList();

                    foreach (var item in dadosRecurso)
                    {
                        var NP = db.TblInfracaoNotificacao.Where(a => a.CodigoInfracao == item.CodigoInfracao && a.CodigoInfracaoNotificacaoTipo == 2).FirstOrDefault();

                        var dados = new RetornoTempestividade
                        {
                            CpfCnpjRecorrente = item.RecorrenteNumeroCpfcnpjformatado,
                            DataProtocolo = item.DataProtocolo.ToShortDateString(),
                            JARI = item.NomeJari,
                            NumeroAIT = item.NumeroAit,
                            NumeroProcesso = item.NumeroProcesso,
                            Tempestividade = item.DataProtocolo != null && NP.DataVencimentoAtual != null && item.DataProtocolo <= NP.DataVencimentoAtual ? "Tempestivo"
                                : item.DataProtocolo != null && NP.DataVencimentoAtual != null && item.DataProtocolo > NP.DataVencimentoAtual ? "Intempestivo" : " - ",
                            DataVencimentoNP = NP.DataVencimentoAtual.Value
                        };

                        retorno.Add(dados);
                    }

                    db.Dispose();
                }

                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("Tabela1");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoTempestividade), planilha);

                    package.Save();
                }
                stream.Position = 0;

                return stream;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
