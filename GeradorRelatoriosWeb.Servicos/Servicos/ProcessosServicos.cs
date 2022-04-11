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
    public class ProcessosServicos : ServicoBase<TblInfracaoSolicitacaoAdvertencia>
    {
        public List<RetornoProcessosSIOR> BuscaRegistrosProcessosSIOR(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = new List<RetornoProcessosSIOR>();
                var data = dataInicio;

                using (var db = new BD_SIORContext())
                {
                    var dadosSA = db.TblInfracaoSolicitacaoAdvertencia.Where(a => a.DataCadastroDnit >= dataInicio && a.DataCadastroDnit <= dataFim).OrderBy(a => a.DataCadastroDnit).ToList();
                    var dadosFICI = db.TblInfracaoIdentificacaoInfratorCondutor.Where(a => a.DataCadastro >= dataInicio && a.DataCadastro <= dataFim).OrderBy(a => a.DataCadastro).ToList();
                    var dadosFIRI = db.TblInfracaoIdentificacaoInfratorResponsavel.Where(a => a.DataCadastro >= dataInicio && a.DataCadastro <= dataFim).OrderBy(a => a.DataCadastro).ToList();
                    var dadosDA = db.TblInfracaoDa.Where(a => a.DataCadastroDnit >= dataInicio && a.DataCadastroDnit <= dataFim).OrderBy(a => a.DataCadastroDnit).ToList();
                    var dadosRec1 = db.TblInfracaoRecurso.Where(a => a.DataCadastro >= dataInicio && a.DataCadastro <= dataFim.AddDays(1).AddTicks(-1) && a.CodigoInfracaoRecursoTipo == 1).OrderBy(a => a.DataCadastro).ToList();
                    var dadosRec2 = db.TblInfracaoRecurso.Where(a => a.DataCadastro >= dataInicio && a.DataCadastro <= dataFim.AddDays(1).AddTicks(-1) && a.CodigoInfracaoRecursoTipo != 1).OrderBy(a => a.DataCadastro).ToList();

                    while (data <= dataFim)
                    {
                        var dados = new RetornoProcessosSIOR
                        {
                            Data = data.ToShortDateString(),
                            DA = dadosDA.Where(a => a.DataCadastroDnit == data).Count().ToString(),
                            FICI = dadosFICI.Where(a => a.DataCadastro == data).Count().ToString(),
                            FIRI = dadosFIRI.Where(a => a.DataCadastro == data).Count().ToString(),
                            SA = dadosSA.Where(a => a.DataCadastroDnit == data).Count().ToString(),
                            Recurso1instancia = dadosRec1.Where(a => a.DataCadastro >= data && a.DataCadastro <= data.AddDays(1).AddTicks(-1)).Count().ToString(),
                            Recurso2instancia = dadosRec2.Where(a => a.DataCadastro >= data && a.DataCadastro <= data.AddDays(1).AddTicks(-1)).Count().ToString()
                        };

                        retorno.Add(dados);
                        data = data.AddDays(1);
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

        public List<RetornoProcessosSIOR> BuscaRegistrosProcessosSIORComArquivo(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = new List<RetornoProcessosSIOR>();
                var data = dataInicio;

                using (var db = new BD_SIORContext())
                {
                    var dadosSA = db.TblInfracaoSolicitacaoAdvertenciaArquivo.Where(a => a.CodigoInfracaoSolicitacaoAdvertenciaNavigation.DataCadastroDnit >= dataInicio && a.CodigoInfracaoSolicitacaoAdvertenciaNavigation.DataCadastroDnit <= dataFim).OrderBy(a => a.CodigoInfracaoSolicitacaoAdvertenciaNavigation.DataCadastroDnit).Select(a => a.CodigoInfracaoSolicitacaoAdvertenciaNavigation).Distinct().ToList();
                    var dadosFICI = db.TblInfracaoIdentificacaoInfratorCondutorArquivo.Where(a => a.CodigoInfracaoIdentificacaoInfratorCondutorNavigation.DataCadastro >= dataInicio && a.CodigoInfracaoIdentificacaoInfratorCondutorNavigation.DataCadastro <= dataFim).OrderBy(a => a.CodigoInfracaoIdentificacaoInfratorCondutorNavigation.DataCadastro).Select(a => a.CodigoInfracaoIdentificacaoInfratorCondutorNavigation).Distinct().ToList();
                    var dadosFIRI = db.TblInfracaoIdentificacaoInfratorResponsavelArquivo.Where(a => a.CodigoInfracaoIdentificacaoInfratorResponsavelNavigation.DataCadastro >= dataInicio && a.CodigoInfracaoIdentificacaoInfratorResponsavelNavigation.DataCadastro <= dataFim).OrderBy(a => a.CodigoInfracaoIdentificacaoInfratorResponsavelNavigation.DataCadastro).Select(a => a.CodigoInfracaoIdentificacaoInfratorResponsavelNavigation).Distinct().ToList();
                    var dadosDA = db.TblInfracaoDaarquivo.Where(a => a.CodigoInfracaoDaNavigation.DataCadastroDnit >= dataInicio && a.CodigoInfracaoDaNavigation.DataCadastroDnit <= dataFim).OrderBy(a => a.CodigoInfracaoDaNavigation.DataCadastroDnit).Select(a => a.CodigoInfracaoDaNavigation).Distinct().ToList();
                    var dadosRec1 = db.TblInfracaoRecursoArquivo.Where(a => a.CodigoInfracaoRecursoNavigation.DataCadastro >= dataInicio && a.CodigoInfracaoRecursoNavigation.DataCadastro <= dataFim.AddDays(1).AddTicks(-1) && a.CodigoInfracaoRecursoNavigation.CodigoInfracaoRecursoTipo == 1).OrderBy(a => a.CodigoInfracaoRecursoNavigation.DataCadastro).Select(a => a.CodigoInfracaoRecursoNavigation).Distinct().ToList();
                    var dadosRec2 = db.TblInfracaoRecursoArquivo.Where(a => a.CodigoInfracaoRecursoNavigation.DataCadastro >= dataInicio && a.CodigoInfracaoRecursoNavigation.DataCadastro <= dataFim.AddDays(1).AddTicks(-1) && a.CodigoInfracaoRecursoNavigation.CodigoInfracaoRecursoTipo != 1).OrderBy(a => a.CodigoInfracaoRecursoNavigation.DataCadastro).Select(a => a.CodigoInfracaoRecursoNavigation).Distinct().ToList();

                    while (data <= dataFim)
                    {
                        var dados = new RetornoProcessosSIOR
                        {
                            Data = data.ToShortDateString(),
                            DA = dadosDA.Where(a => a.DataCadastroDnit == data).Count().ToString(),
                            FICI = dadosFICI.Where(a => a.DataCadastro == data).Count().ToString(),
                            FIRI = dadosFIRI.Where(a => a.DataCadastro == data).Count().ToString(),
                            SA = dadosSA.Where(a => a.DataCadastroDnit == data).Count().ToString(),
                            Recurso1instancia = dadosRec1.Where(a => a.DataCadastro >= data && a.DataCadastro <= data.AddDays(1).AddTicks(-1)).Count().ToString(),
                            Recurso2instancia = dadosRec2.Where(a => a.DataCadastro >= data && a.DataCadastro <= data.AddDays(1).AddTicks(-1)).Count().ToString()
                        };

                        retorno.Add(dados);
                        data = data.AddDays(1);
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

        public Stream ExportarRegistrosProcessosSIOR(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = BuscaRegistrosProcessosSIOR(dataInicio, dataFim);
                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("Tabela1");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoProcessosSIOR), planilha);

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

        public Stream ExportarRegistrosProcessosSIORComArquivo(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = BuscaRegistrosProcessosSIORComArquivo(dataInicio, dataFim);
                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("Tabela1");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoProcessosSIOR), planilha);

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

        public List<RetornoProcessosSIOR> BuscaProcessosRealizadosSIOR(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = new List<RetornoProcessosSIOR>();
                var data = dataInicio;

                using (var db = new BD_SIORContext())
                {
                    var dadosSA = db.TblInfracaoSolicitacaoAdvertenciaEvento.Where(a => a.Data >= dataInicio && a.Data <= dataFim.AddDays(1).AddTicks(-1) && a.CodigoInfracaoSolicitacaoAdvertenciaFase == 6
                                  && a.NomeSistemaUsuario != "SIOR" && a.CodigoInfracaoSolicitacaoAdvertenciaSituacao == 1).OrderBy(a => a.Data).ToList();
                    var dadosFICI = db.TblInfracaoIdentificacaoInfratorCondutor.Where(a => a.DataConferencia >= dataInicio && a.DataConferencia <= dataFim).OrderBy(a => a.DataConferencia).ToList();
                    var dadosFIRI = db.TblInfracaoIdentificacaoInfratorResponsavel.Where(a => a.DataConferencia >= dataInicio && a.DataConferencia <= dataFim).OrderBy(a => a.DataConferencia).ToList();
                    var dadosDA = db.TblInfracaoDaevento.Where(a => a.Data >= dataInicio && a.Data <= dataFim.AddDays(1).AddTicks(-1) && a.CodigoInfracaoDafase == 6
                                  && a.NomeSistemaUsuario != "SIOR" && a.CodigoInfracaoDasituacao == 1).OrderBy(a => a.Data).ToList();
                    var dadosRec1 = db.TblInfracaoRecursoEvento.
                                  Include("CodigoInfracaoRecursoNavigation")
                                  .Where(a => a.Data >= dataInicio && a.Data <= dataFim.AddDays(1).AddTicks(-1) 
                                  && a.CodigoInfracaoRecursoFase == 13 && a.Descricao == null).OrderBy(a => a.Data).ToList();
                    
                    while (data <= dataFim)
                    {
                        var dados = new RetornoProcessosSIOR
                        {
                            Data = data.ToShortDateString(),
                            DA = dadosDA.Where(a => a.Data >= data && a.Data <= data.AddDays(1).AddTicks(-1)).Count().ToString(),
                            FICI = dadosFICI.Where(a => a.DataConferencia == data).Count().ToString(),
                            FIRI = dadosFIRI.Where(a => a.DataConferencia == data).Count().ToString(),
                            SA = dadosSA.Where(a => a.Data >= data && a.Data <= data.AddDays(1).AddTicks(-1)).Count().ToString(),
                            Recurso1instancia = dadosRec1.Where(a => a.Data >= data && a.Data <= data.AddDays(1).AddTicks(-1) && a.CodigoInfracaoRecursoNavigation.CodigoInfracaoRecursoTipo == 1).Count().ToString(),
                            Recurso2instancia = dadosRec1.Where(a => a.Data >= data && a.Data <= data.AddDays(1).AddTicks(-1) && a.CodigoInfracaoRecursoNavigation.CodigoInfracaoRecursoTipo != 1).Count().ToString()
                        };

                        retorno.Add(dados);
                        data = data.AddDays(1);
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

        public Stream ExportarProcessosRealizadosSIOR(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = BuscaProcessosRealizadosSIOR(dataInicio, dataFim);
                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("Tabela1");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoProcessosSIOR), planilha);

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

        public RetornoProcessosInstruir BuscaProcessosInstruir()
        {
            try
            {
                var ret = new RetornoProcessosInstruir();

                using (var db = new BD_SIORContext())
                {
                    var DA = db.TblInfracaoDa.Where(a => (a.CodigoInfracaoDasituacao == 1 || a.CodigoInfracaoDasituacao == 3)
                                            && (a.CodigoInfracaoDafase == 1 || a.CodigoInfracaoDafase == 2
                                            || a.CodigoInfracaoDafase == 3))
                        .Join(db.TblInfracao.Where(a => (a.CodigoInfracaoSituacao == 1
                                            || a.CodigoInfracaoSituacao == 4) && a.DataInfracao >= new DateTime(2010, 1, 1)), da => da.CodigoInfracao, infracao => infracao.CodigoInfracao, (da, infracao) => new { da, infracao })
                        .GroupBy(a => a.infracao.CodigoInfracaoOrigem)
                        .ToList();

                    //var DA = db.TblInfracaoDa
                    //    .Include("CodigoInfracaoNavigation")
                    //    .Include("CodigoInfracaoNavigation.CodigoInfracaoOrigemNavigation")
                    //    .Where(a => (a.CodigoInfracaoDasituacao == 1 || a.CodigoInfracaoDasituacao == 3)
                    //                        && (a.CodigoInfracaoDafase == 1 || a.CodigoInfracaoDafase == 2
                    //                        || a.CodigoInfracaoDafase == 3)
                    //                        && (a.CodigoInfracaoNavigation.CodigoInfracaoSituacao == 1
                    //                        || a.CodigoInfracaoNavigation.CodigoInfracaoSituacao == 4))
                    //    .GroupBy(a => a.CodigoInfracaoNavigation.CodigoInfracaoOrigem)
                    //    .ToList();

                    foreach (var item in DA)
                    {
                        var codigosDA = item.Select(a => a.da.CodigoInfracaoDa);
                        var comArqDA = db.TblInfracaoDaarquivo.Where(a => codigosDA.Contains(a.CodigoInfracaoDa)).Select(a => a.CodigoInfracaoDa).Distinct().Count();

                        RetornoListaDA itemDA = new RetornoListaDA
                        {
                            Tipo = item.FirstOrDefault().infracao.CodigoInfracaoOrigemNavigation.Nome,
                            ComArquivo = comArqDA,
                            SemArquivo = codigosDA.Count() - comArqDA,
                            Total = codigosDA.Count()
                        };

                        ret.ListaDAs.Add(itemDA);
                    }

                    var SA = db.TblInfracaoSolicitacaoAdvertencia
                        .AsNoTracking().Where(a => (a.CodigoInfracaoSolicitacaoAdvertenciaFase == 3 || a.CodigoInfracaoSolicitacaoAdvertenciaFase == 4)
                                                && (a.CodigoInfracaoSolicitacaoAdvertenciaSituacao == 1 || a.CodigoInfracaoSolicitacaoAdvertenciaSituacao == 3))
                        .ToList();

                    var codigosSA = SA.Select(a => a.CodigoInfracaoSolicitacaoAdvertencia);
                    var comArqSA = db.TblInfracaoSolicitacaoAdvertenciaArquivo.Where(a => codigosSA.Contains(a.CodigoInfracaoSolicitacaoAdvertencia)).Select(a => a.CodigoInfracaoSolicitacaoAdvertencia).Distinct().Count();

                    var itemSA = new RetornoListaSA
                    {
                        ComArquivo = comArqSA,
                        SemArquivo = codigosSA.Count() - comArqSA,
                        Total = codigosSA.Count()
                    };

                    ret.ListaSAs.Add(itemSA);

                    var FICI = db.TblInfracaoIdentificacaoInfratorCondutor
                        .AsNoTracking().Where(a => (a.CodigoInfracaoIdentificacaoInfratorCondutorSituacao == 1 || a.CodigoInfracaoIdentificacaoInfratorCondutorSituacao == 3)
                                                && (a.CodigoInfracaoIdentificacaoInfratorCondutorFase == 1 || a.CodigoInfracaoIdentificacaoInfratorCondutorFase == 2))
                        .ToList();

                    var codigosFICI = FICI.Select(a => a.CodigoInfracaoIdentificacaoInfratorCondutor);
                    var comArqFICI = db.TblInfracaoIdentificacaoInfratorCondutorArquivo.Where(a => codigosFICI.Contains(a.CodigoInfracaoIdentificacaoInfratorCondutor)).Select(a => a.CodigoInfracaoIdentificacaoInfratorCondutor).Distinct().Count();

                    var itemFICI = new RetornoListaFICI
                    {
                        ComArquivo = comArqFICI,
                        SemArquivo = codigosFICI.Count() - comArqFICI,
                        Total = codigosFICI.Count()
                    };

                    ret.ListaFICIs.Add(itemFICI);

                    var FIRI = db.TblInfracaoIdentificacaoInfratorResponsavel
                        .AsNoTracking().Where(a => (a.CodigoInfracaoIdentificacaoInfratorResponsavelSituacao == 1 || a.CodigoInfracaoIdentificacaoInfratorResponsavelSituacao == 3)
                                                && (a.CodigoInfracaoIdentificacaoInfratorResponsavelFase == 1 || a.CodigoInfracaoIdentificacaoInfratorResponsavelFase == 2))
                        .ToList();

                    var codigosFIRI = FIRI.Select(a => a.CodigoInfracaoIdentificacaoInfratorResponsavel);
                    var comArqFIRI = db.TblInfracaoIdentificacaoInfratorResponsavelArquivo.Where(a => codigosFIRI.Contains(a.CodigoInfracaoIdentificacaoInfratorResponsavel)).Select(a => a.CodigoInfracaoIdentificacaoInfratorResponsavel).Distinct().Count();

                    var itemFIRI = new RetornoListaFIRI
                    {
                        ComArquivo = comArqFIRI,
                        SemArquivo = codigosFIRI.Count() - comArqFIRI,
                        Total = codigosFIRI.Count()
                    };

                    ret.ListaFIRIs.Add(itemFIRI);

                    var recursos = db.TblInfracaoRecurso
                        .Include("CodigoInfracaoNavigation")
                        .Include("CodigoInfracaoNavigation.CodigoInfracaoOrigemNavigation")
                        .Include("CodigoInfracaoRecursoTipoNavigation")
                        .AsNoTracking().Where(a => (a.CodigoInfracaoRecursoSituacao == 1 || a.CodigoInfracaoRecursoSituacao == 3)
                                            && (a.CodigoInfracaoRecursoFase == 1 || a.CodigoInfracaoRecursoFase == 2
                                            || a.CodigoInfracaoRecursoFase == 3 || a.CodigoInfracaoRecursoFase == 10
                                            || a.CodigoInfracaoRecursoFase == 11 || a.CodigoInfracaoRecursoFase == 12)
                                            && (a.CodigoInfracaoNavigation.CodigoInfracaoSituacao == 1
                                            || a.CodigoInfracaoNavigation.CodigoInfracaoSituacao == 4))
                        .Select(a => new
                        {
                            a.CodigoInfracaoRecurso,
                            a.CodigoInfracaoNavigation.CodigoInfracaoOrigem,
                            Tipo = a.CodigoInfracaoNavigation.CodigoInfracaoOrigemNavigation.Nome,
                            a.CodigoInfracaoRecursoTipoNavigation.Nome
                        })
                        .GroupBy(a => new { a.CodigoInfracaoOrigem, a.Nome })
                        .ToList();

                    foreach (var item in recursos)
                    {
                        var codigosRecursos = item.Select(a => a.CodigoInfracaoRecurso).ToList();
                        var todosArqs = db.TblInfracaoRecursoArquivo.AsNoTracking().Select(a => a.CodigoInfracaoRecurso).Distinct().ToList();
                        var comArqRecursos = codigosRecursos.Count(a => todosArqs.Contains(a));

                        var itemRecursos = new RetornoListaRecurso
                        {
                            Tipo = item.FirstOrDefault().Tipo,
                            Instancia = item.FirstOrDefault().Nome,
                            ComArquivo = comArqRecursos,
                            SemArquivo = codigosRecursos.Count() - comArqRecursos,
                            Total = codigosRecursos.Count()
                        };

                        ret.ListaRecursos.Add(itemRecursos);
                    }
                }

                return ret;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Stream ExportarProcessosInstruir()
        {
            try
            {
                var retorno = BuscaProcessosInstruir();
                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("DAs");
                    planilha.Cells.LoadFromCollection(retorno.ListaDAs, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoListaDA), planilha);

                    var planilha2 = package.Workbook.Worksheets.Add("SAs");
                    planilha2.Cells.LoadFromCollection(retorno.ListaSAs, true);

                    planilha2 = Util.MontaCabecalho(typeof(RetornoListaSA), planilha2);

                    var planilha3 = package.Workbook.Worksheets.Add("FICIs");
                    planilha3.Cells.LoadFromCollection(retorno.ListaFICIs, true);

                    planilha3 = Util.MontaCabecalho(typeof(RetornoListaFICI), planilha3);

                    var planilha4 = package.Workbook.Worksheets.Add("Recursos");
                    planilha4.Cells.LoadFromCollection(retorno.ListaRecursos, true);

                    planilha4 = Util.MontaCabecalho(typeof(RetornoListaRecurso), planilha4);

                    var planilha5 = package.Workbook.Worksheets.Add("FIRIs");
                    planilha5.Cells.LoadFromCollection(retorno.ListaFIRIs, true);

                    planilha5 = Util.MontaCabecalho(typeof(RetornoListaFIRI), planilha5);

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
