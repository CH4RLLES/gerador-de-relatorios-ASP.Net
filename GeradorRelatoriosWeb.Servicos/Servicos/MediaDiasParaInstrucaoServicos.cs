using GeradorRelatoriosWeb.Dominio.Entidades.SIOR;
using GeradorRelatoriosWeb.Dominio.Models;
using GeradorRelatoriosWeb.Dominio.Utils;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GeradorRelatoriosWeb.Servicos.Servicos
{
    public class MediaDiasParaInstrucaoServicos
    {
        public List<RetornoMediaDiasParaInstrucao> BuscaMediaDiasParaInstrucao(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var ret = new List<RetornoMediaDiasParaInstrucao>();
                RetornoMediaDiasParaInstrucao dados;

                using (var db = new BD_SIORContext())
                {
                    var DA = db.TblInfracaoDa.Where(a => a.DataInstrucao.Value.Date >= dataInicio && a.DataInstrucao.Value.Date <= dataFim)
                        .Select(a => new
                        {
                            Dias = (a.DataInstrucao - a.DataCadastroDnit).Value.Days
                        }).ToList();

                    dados = new RetornoMediaDiasParaInstrucao
                    {
                        Tipo = "DA",
                        Valor = DA.Count() > 0 ? (DA.Sum(a => a.Dias) / DA.Count()).ToString() : "0"
                    };

                    ret.Add(dados);

                    var SA = db.TblInfracaoSolicitacaoAdvertencia.Where(a => a.DataInstrucao.Value.Date >= dataInicio && a.DataInstrucao.Value.Date <= dataFim)
                        .Select(a => new
                        {
                            Dias = (a.DataInstrucao - a.DataInfracao).Value.Days
                        }).ToList();

                    dados = new RetornoMediaDiasParaInstrucao
                    {
                        Tipo = "SA",
                        Valor = SA.Count() > 0 ? (SA.Sum(a => a.Dias) / SA.Count()).ToString() : "0"
                    };

                    ret.Add(dados);

                    var FICI = db.TblInfracaoIdentificacaoInfratorCondutor.Where(a => a.DataConferencia.Value.Date >= dataInicio && a.DataConferencia.Value.Date <= dataFim)
                        .Select(a => new
                        {
                            Dias = (a.DataConferencia - a.DataCadastro).Value.Days
                        }).ToList();

                    dados = new RetornoMediaDiasParaInstrucao
                    {
                        Tipo = "FICI",
                        Valor = FICI.Count() > 0 ? (FICI.Sum(a => a.Dias) / FICI.Count()).ToString() : "0"
                    };

                    ret.Add(dados);

                    var FIRI = db.TblInfracaoIdentificacaoInfratorResponsavel.Where(a => a.DataConferencia.Value.Date >= dataInicio && a.DataConferencia.Value.Date <= dataFim)
                        .Select(a => new
                        {
                            Dias = (a.DataConferencia - a.DataCadastro).Value.Days
                        }).ToList();

                    dados = new RetornoMediaDiasParaInstrucao
                    {
                        Tipo = "FIRI",
                        Valor = FIRI.Count() > 0 ? (FIRI.Sum(a => a.Dias) / FIRI.Count()).ToString() : "0"
                    };

                    ret.Add(dados);

                    var recursos = db.TblInfracaoRecurso.Where(a => a.DataInstrucao.Value.Date >= dataInicio && a.DataInstrucao.Value.Date <= dataFim)
                        .Select(a => new
                        {
                            Dias = (a.DataInstrucao - a.DataCadastro).Value.Days
                        }).ToList();

                    dados = new RetornoMediaDiasParaInstrucao
                    {
                        Tipo = "Recursos",
                        Valor = recursos.Count() > 0 ? (recursos.Sum(a => a.Dias) / recursos.Count()).ToString() : "0"
                    };

                    ret.Add(dados);
                }

                return ret;
            }

            catch (Exception ex)
            {
                return null;
            }
        }


        public Stream ExportarMediaDiasParaInstrucao(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = BuscaMediaDiasParaInstrucao(dataInicio, dataFim);
                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("Tabela1");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoMediaDiasParaInstrucao), planilha);

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
