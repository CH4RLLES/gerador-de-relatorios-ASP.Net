using GeradorRelatoriosWeb.Dominio.Entidades.RENAVAM;
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
    public class CompletoEngenhariaServicos
    {
        public List<RetornoCompletoEngenhariaLista> BuscaRegistrosCompletoEngenharia(DateTime dataInicio, DateTime dataFim)
        {
            var retorno = new List<RetornoCompletoEngenhariaLista>();

            try
            {
                using (var db = new BD_SIORContext())
                {
                    var dadosInfracao = db.TblInfracaoPreAutuacao.Where(a => a.DataInfracao >= dataInicio && a.DataInfracao <= dataFim).ToList();
                    
                    foreach (var item in dadosInfracao)
                    {
                        var dados = new RetornoCompletoEngenhariaLista
                        {
                            Contrato = item.CodigoInfracaoOrigemContratacao.ToString(),                           
                            EquipamentoAfericaoCodigoDnit = item.EquipamentoAfericaoCodigoDnit,                                                      
                            LocalInfracaoKm = item.LocalInfracaoKm.ToString(),
                            LocalInfracaoRodovia = item.LocalInfracaoRodovia
                        };

                        using (var renavam = new BD_SIOR_RENAVAMContext())
                        {
                            var municipio = renavam.TblRenavammunicipio.Where(a => a.CodigoRenavammunicipio == item.CodigoRenavammunicipioLocalInfracao).FirstOrDefault();
                            dados.Municipio = municipio != null ? municipio.Nome : "";

                            renavam.Dispose();
                        }

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

        public Stream ExportarRegistrosCompletoEngenharia(DateTime dataInicio, DateTime dataFim)
        {
            var retorno = new List<RetornoCompletoEngenharia>();

            try
            {
                using (var db = new BD_SIORContext())
                {
                    var dadosInfracao = db.TblInfracaoPreAutuacao.Where(a => a.DataInfracao >= dataInicio && a.DataInfracao <= dataFim).AsNoTracking().OrderBy(a => a.DataHoraInfracao).ToList();
                    var equipamentos = dadosInfracao.Select(a => a.EquipamentoAfericaoCodigoDnit);
                    var dadosEquipamentos = db.TblPncvequipamento.Where(a => equipamentos.Contains(a.CodigoEquipamentoDnit)).ToList();
                    var dadosTipo = db.TblPncvequipamentoTipo;
                    var dadosModelo = db.TblPncvmodeloEquipamento;
                    var dadosEnquadramento = db.TblInfracaoEnquadramento;
                    var dadosUf = db.TblBaseUf;
                    var estudos = dadosEquipamentos.Select(a => a.CodigoPncvestudoTecnicoInstalacaoEquipamento);
                    var dadosEstudo = db.TblPncvestudoTecnicoInstalacaoEquipamento.Where(a => estudos.Contains(a.CodigoPncvestudoTecnicoInstalacaoEquipamento)).ToList();
                    var dadosComunicacao = db.TblPncvequipamentoIndicadorComunicacao;
                    var dadosMotivo = db.TblInfracaoPreAutuacaoMotivoInvalidacao;

                    foreach (var item in dadosInfracao)
                    {
                        var eqp = dadosEquipamentos.Where(a => a.CodigoEquipamentoDnit == item.EquipamentoAfericaoCodigoDnit).FirstOrDefault();
                        var estudo = dadosEstudo.Where(a => a.CodigoPncvestudoTecnicoInstalacaoEquipamento == eqp.CodigoPncvestudoTecnicoInstalacaoEquipamento).FirstOrDefault();
                        var dados = new RetornoCompletoEngenharia
                        {
                            ConferenciaDoisPlacaVeiculo = item.ConferenciaDoisPlacaVeiculo,
                            ConferenciaUmPlacaVeiculo = item.ConferenciaUmPlacaVeiculo,
                            ConferenciaRevisaoPlacaVeiculo = item.ConferenciaRevisaoPlacaVeiculo,
                            Contrato = item.CodigoInfracaoOrigemContratacao.ToString(),
                            DataCadastro = item.DataCadastro.ToString(),
                            DataConferencia2 = item.ConferenciaDoisData.ToString(),
                            DataHoraInfracao = item.DataHoraInfracao.ToString(),
                            DataPreparação = item.PreparacaoImagemData.ToString(),
                            DataRevisão = item.ConferenciaRevisaoData.ToString(),
                            DescricaoInfracaoResumo = dadosEnquadramento.Where(a => a.CodigoInfracaoEnquadramento == item.CodigoInfracaoEnquadramento) != null ?
                                                      dadosEnquadramento.Where(a => a.CodigoInfracaoEnquadramento == item.CodigoInfracaoEnquadramento).FirstOrDefault().DescricaoInfracaoResumo : "",
                            EquipamentoAfericaoCodigoDnit = item.EquipamentoAfericaoCodigoDnit,
                            FaixaSentidoVia = item.LocalInfracaoRodoviaFaixa,
                            LimiteRegulamentado = item.LimiteRegulamentado.ToString(),
                            LocalInfracaoKm = item.LocalInfracaoKm.ToString(),
                            LocalInfracaoRodovia = item.LocalInfracaoRodovia,
                            MarcaModeloEquipamento = dadosModelo.Where(a => a.CodigoPncvmodeloEquipamento == eqp.CodigoPncvmodeloEquipamento) != null ?
                                                     dadosModelo.Where(a => a.CodigoPncvmodeloEquipamento == eqp.CodigoPncvmodeloEquipamento).FirstOrDefault().Nome : "",
                            MedicaoRealizada = item.MedicaoRealizada.ToString(),
                            MotivoInvalidaçãoFinal = item.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferencia != null ? dadosMotivo.Where(a => a.CodigoInfracaoPreAutuacaoMotivoInvalidacao == item.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferencia) != null ?
                                                     dadosMotivo.Where(a => a.CodigoInfracaoPreAutuacaoMotivoInvalidacao == item.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferencia).FirstOrDefault().Descricao : "" : "",
                            Municipio = item.CodigoRenavammunicipioLocalInfracao.ToString(),
                            OnlineOffline = estudo != null ? dadosComunicacao.Where(a => a.CodigoPncvequipamentoIndicadorComunicacao == estudo.CodigoPncvequipamentoIndicadorComunicacao) != null ?
                                            dadosComunicacao.Where(a => a.CodigoPncvequipamentoIndicadorComunicacao == estudo.CodigoPncvequipamentoIndicadorComunicacao).FirstOrDefault().Nome : "" : "",
                            TipoEquipamento = dadosTipo.Where(a => a.CodigoPncvequipamentoTipo == eqp.CodigoPncvequipamentoTipo) != null ?
                                              dadosTipo.Where(a => a.CodigoPncvequipamentoTipo == eqp.CodigoPncvequipamentoTipo).FirstOrDefault().Sigla : "",
                            UF = dadosUf.Where(a => a.CodigoBaseUf == item.CodigoUflocalInfracao) != null ?
                                 dadosUf.Where(a => a.CodigoBaseUf == item.CodigoUflocalInfracao).FirstOrDefault().Sigla : "",
                            ValorConsiderado = item.ValorConsiderado.ToString(),
                            VeiculoPlacaFinal = item.VeiculoPlacaFinal
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

                    planilha = Util.MontaCabecalho(typeof(RetornoCompletoEngenharia), planilha);

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

        public void teste()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
