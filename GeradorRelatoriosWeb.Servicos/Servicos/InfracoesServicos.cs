using GeradorRelatoriosWeb.Dominio.Entidades.RENAVAM;
using GeradorRelatoriosWeb.Dominio.Entidades.SINPEV;
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
    public class InfracoesServicos : ServicoBase<TblInfracao>
    {
        public List<RetornoExcessoPesoLista> BuscaExcessoPesoLista(DateTime dataInicio, DateTime dataFim, string cnpj)
        {
            try
            {
                var retorno = new List<RetornoExcessoPesoLista>();
                var data = dataInicio;

                using (var db = new BD_SIORContext())
                {
                    var peso = db.TblInfracao.Include("CodigoInfracaoEmbarcadorNavigation")
                        .Include("CodigoInfracaoTransportadorNavigation")
                        .Include("CodigoInfracaoProprietarioNavigation")
                        .Include("CodigoInfracaoSituacaoNavigation")
                        .Join(db.TblInfracaoInfrator, infracao => infracao.CodigoInfracaoInfrator, infrator => infrator.CodigoInfracaoInfrator, (infracao, infrator) => new { infracao, infrator })
                        .Where(a => a.infracao.CodigoInfracaoInfrator == a.infrator.CodigoInfracaoInfrator && a.infrator.NumeroCpfcnpj.StartsWith(cnpj) && a.infracao.DataInfracao >= dataInicio && a.infracao.DataInfracao <= dataFim
                        && (a.infracao.CodigoInfracaoOrigem == 3 || a.infracao.CodigoInfracaoOrigem == 4 || a.infracao.CodigoInfracaoOrigem == 5))
                        .Select(a => new {
                            a.infracao.DataInfracao, a.infrator.NumeroCpfcnpjformatado, a.infracao.NumeroAit,
                            embarcador = a.infracao.CodigoInfracaoEmbarcadorNavigation == null ? " - " : a.infracao.CodigoInfracaoEmbarcadorNavigation.NumeroCpfcnpjformatado,
                            transportador = a.infracao.CodigoInfracaoTransportadorNavigation == null ? " - " : a.infracao.CodigoInfracaoTransportadorNavigation.NumeroCpfcnpjformatado,
                            proprietario = a.infracao.CodigoInfracaoProprietarioNavigation == null ? " - " : a.infracao.CodigoInfracaoProprietarioNavigation.NumeroCpfcnpjformatado,
                            situacao = a.infracao.CodigoInfracaoSituacaoNavigation == null ? " - " : a.infracao.CodigoInfracaoSituacaoNavigation.Nome,
                            a.infracao.CodigoInfracaoVeiculo
                        }).ToList();

                    foreach (var item in peso)
                    {
                        var veiculo = db.TblInfracaoVeiculo.Where(a => a.CodigoInfracaoVeiculo == item.CodigoInfracaoVeiculo).AsNoTracking().FirstOrDefault();

                        var dados = new RetornoExcessoPesoLista
                        {
                            DataInfracao = item.DataInfracao.ToShortDateString(),
                            Embarcador = item.embarcador,
                            Infrator = item.NumeroCpfcnpjformatado,
                            NumeroAIT = item.NumeroAit,
                            PlacaVeiculo = veiculo.Placa,
                            Proprietario = item.proprietario,
                            Transportador = item.transportador,
                            SituacaoAIT = item.situacao
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

        public RetornoExcessoPeso BuscaExcessoPesoDetalhado(string numeroAit)
        {
            try
            {

                using (var db = new BD_SIORContext())
                {
                    var item = db.TblInfracao.Join(db.TblInfracaoInfrator, infracao => infracao.CodigoInfracaoInfrator, infrator => infrator.CodigoInfracaoInfrator, (infracao, infrator) => new { infracao, infrator })
                        .Where(a => a.infracao.CodigoInfracaoInfrator == a.infrator.CodigoInfracaoInfrator && a.infracao.NumeroAit == numeroAit).AsNoTracking().FirstOrDefault();

                    var embarcador = db.TblInfracaoEmbarcador.Where(a => a.CodigoInfracaoEmbarcador == item.infracao.CodigoInfracaoEmbarcador).AsNoTracking().FirstOrDefault();
                    var proprietario = db.TblInfracaoProprietario.Where(a => a.CodigoInfracaoProprietario == item.infracao.CodigoInfracaoProprietario).AsNoTracking().FirstOrDefault();
                    var transportador = db.TblInfracaoTransportador.Where(a => a.CodigoInfracaoTransportador == item.infracao.CodigoInfracaoTransportador).AsNoTracking().FirstOrDefault();
                    var pesagem = db.TblInfracaoPesagem.Where(a => a.CodigoInfracaoPesagem == item.infracao.CodigoInfracaoPesagem).AsNoTracking().FirstOrDefault();
                    var veiculo = db.TblInfracaoVeiculo.Where(a => a.CodigoInfracaoVeiculo == item.infracao.CodigoInfracaoVeiculo).AsNoTracking().FirstOrDefault();
                    var financeiro = db.TblInfracaoFinanceiroDebito.Join(db.TblInfracaoFinanceiroDebitoSituacao, debito => debito.CodigoInfracaoFinanceiroDebitoSituacao,
                                                                                                                    situacao => situacao.CodigoInfracaoFinanceiroDebitoSituacao, (debito, situacao) => new { debito, situacao })
                        .Where(a => a.debito.CodigoInfracaoFinanceiroDebitoSituacao == a.situacao.CodigoInfracaoFinanceiroDebitoSituacao && a.debito.CodigoInfracaoFinanceiroDebito == item.infracao.CodigoInfracao).AsNoTracking().FirstOrDefault();
                    var enquadramento = db.TblInfracaoEnquadramento.Where(a => a.CodigoInfracaoEnquadramento == item.infracao.CodigoInfracaoEnquadramento).AsNoTracking().FirstOrDefault();
                    var notificacao = db.TblInfracaoNotificacao.Where(a => a.CodigoInfracao == item.infracao.CodigoInfracao).AsNoTracking();
                    var defesaAutuacao = db.TblInfracaoDa.Where(a => a.CodigoInfracao == item.infracao.CodigoInfracao).AsNoTracking().FirstOrDefault();
                    var situacaoAit = db.TblInfracaoSituacao.Where(a => a.CodigoInfracaoSituacao == item.infracao.CodigoInfracaoSituacao).AsNoTracking().FirstOrDefault();

                    var NA = notificacao.Where(a => a.CodigoInfracaoNotificacaoTipo == 1).FirstOrDefault();
                    var NP = notificacao.Where(a => a.CodigoInfracaoNotificacaoTipo == 2).FirstOrDefault();
                    var detalheSituacao = "";

                    try
                    {
                        detalheSituacao = situacaoAit.Nome == "Encerrado" && NP == null ? "Encerrado" :
                                          situacaoAit.Nome == "Encerrado" && numeroAit.StartsWith('B') && NP.DataPostagem >= new DateTime(2013, 4, 17) && NP.DataPostagem <= new DateTime(2015, 4, 17) ? "Encerrado: Lei 13.103/2015" :
                                          situacaoAit.Nome == "Encerrado" && NP != null && financeiro.debito.ValorPago > 0 ? "Encerrado: Constituição do Crédito" :
                                          situacaoAit.Nome == "Cancelado" && NP == null && defesaAutuacao.DataProtocolo != null && defesaAutuacao.DataJulgamento == null ? "Cancelado: Prescrição Intercorrente (3 anos). Motivo(s): NP não expedida por falta de Julgamento da DA no tempo hábil" :
                                          situacaoAit.Nome == "Cancelado" && NP == null && NA.CodigoInfracaoNotificacaoExpedicaoServico == 1 && NA.CodigoBaseCorreiosCodigoBaixa != 1 ? "Cancelado: Prescrição Intercorrente (3 anos). Motivo(s): AR de NA não entregue ao Destinatário via ECT; NP não expedida" :
                                          situacaoAit.Nome == "Cancelado" && NP == null && NA.CodigoInfracaoNotificacaoExpedicaoServico == 1 && NA.CodigoBaseCorreiosCodigoBaixa == 1 ? "Cancelado: Prescrição Intercorrente (3 anos). Motivo(s): Demora no Retorno Lógico oriundo da ECT; NP não expedida" :
                                          situacaoAit.Nome == "Cobrança" ? "Cobrança: Tramitado para a Unidade de Cobrança e Recuperação de Crédito (UNICRED)" :
                                          situacaoAit.Nome;
                    }
                    catch (Exception)
                    {
                        detalheSituacao = situacaoAit.Nome;
                    }
                    

                    var dados = new RetornoExcessoPeso
                    {
                        DataInfracao = item.infracao.DataHoraInfracao.ToString(),
                        DataExpNA = NA == null ? "" : NA.DataPostagem.Value.ToShortDateString(),
                        DataExpNP = NP == null ? "" : NP.DataPostagem.Value.ToShortDateString(),
                        LimiteRegulamentadoRegistroRENAINF = item.infracao.LimiteRegulamentado.ToString(),
                        MedicaoRealizadaRegistroRENAINF = item.infracao.MedicaoRealizada.ToString(),
                        ValorConsideradoRegistroRENAINF = item.infracao.ValorConsiderado.ToString(),
                        SituacaoAIT = detalheSituacao,
                        Embarcador = embarcador != null ? embarcador.NumeroCpfcnpjformatado + "-->" + embarcador.Nome : " - ",
                        Enquadramento = enquadramento.CodigoEnquadramentoTexto + ": " + enquadramento.DescricaoInfracao,
                        ExcessoAferidoCMT = pesagem != null ? pesagem.ExcessoAferidoCmt.ToString() : "",
                        ExcessoAferidoEixo1 = pesagem != null ? pesagem.ExcessoAferidoEixo1.ToString() : "",
                        ExcessoAferidoEixo2 = pesagem != null ? pesagem.ExcessoAferidoEixo2.ToString() : "",
                        ExcessoAferidoEixo3 = pesagem != null ? pesagem.ExcessoAferidoEixo3.ToString() : "",
                        ExcessoAferidoEixo4 = pesagem != null ? pesagem.ExcessoAferidoEixo4.ToString() : "",
                        ExcessoAferidoEixo5 = pesagem != null ? pesagem.ExcessoAferidoEixo5.ToString() : "",
                        ExcessoAferidoEixo6 = pesagem != null ? pesagem.ExcessoAferidoEixo6.ToString() : "",
                        ExcessoAferidoEixo7 = pesagem != null ? pesagem.ExcessoAferidoEixo7.ToString() : "",
                        ExcessoAferidoPBT = pesagem != null ? pesagem.ExcessoAferidoPbt.ToString() : "",
                        Infrator = item.infrator.NumeroCpfcnpjformatado + "-->" + item.infrator.Nome,
                        LimiteRegulamentarCMT = pesagem != null ? pesagem.LimiteRegulamentarCmt.ToString() : "",
                        LimiteRegulamentarComToleranciaCMT = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaCmt.ToString() : "",
                        LimiteRegulamentarComToleranciaEixo1 = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaEixo1.ToString() : "",
                        LimiteRegulamentarComToleranciaEixo2 = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaEixo2.ToString() : "",
                        LimiteRegulamentarComToleranciaEixo3 = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaEixo3.ToString() : "",
                        LimiteRegulamentarComToleranciaEixo4 = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaEixo4.ToString() : "",
                        LimiteRegulamentarComToleranciaEixo5 = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaEixo5.ToString() : "",
                        LimiteRegulamentarComToleranciaEixo6 = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaEixo6.ToString() : "",
                        LimiteRegulamentarComToleranciaEixo7 = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaEixo7.ToString() : "",
                        LimiteRegulamentarComToleranciaPBT = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaPbt.ToString() : "",
                        LimiteRegulamentarEixo1 = pesagem != null ? pesagem.LimiteRegulamentarEixo1.ToString() : "",
                        LimiteRegulamentarEixo2 = pesagem != null ? pesagem.LimiteRegulamentarEixo2.ToString() : "",
                        LimiteRegulamentarEixo3 = pesagem != null ? pesagem.LimiteRegulamentarEixo3.ToString() : "",
                        LimiteRegulamentarEixo4 = pesagem != null ? pesagem.LimiteRegulamentarEixo4.ToString() : "",
                        LimiteRegulamentarEixo5 = pesagem != null ? pesagem.LimiteRegulamentarEixo5.ToString() : "",
                        LimiteRegulamentarEixo6 = pesagem != null ? pesagem.LimiteRegulamentarEixo6.ToString() : "",
                        LimiteRegulamentarEixo7 = pesagem != null ? pesagem.LimiteRegulamentarEixo7.ToString() : "",
                        LimiteRegulamentarPBT = pesagem != null ? pesagem.LimiteRegulamentarPbt.ToString() : "",
                        MedicaoRealizadaCMT = pesagem != null ? pesagem.MedicaoRealizadaCmt.ToString() : "",
                        MedicaoRealizadaEixo1 = pesagem != null ? pesagem.MedicaoRealizadaEixo1.ToString() : "",
                        MedicaoRealizadaEixo2 = pesagem != null ? pesagem.MedicaoRealizadaEixo2.ToString() : "",
                        MedicaoRealizadaEixo3 = pesagem != null ? pesagem.MedicaoRealizadaEixo3.ToString() : "",
                        MedicaoRealizadaEixo4 = pesagem != null ? pesagem.MedicaoRealizadaEixo4.ToString() : "",
                        MedicaoRealizadaEixo5 = pesagem != null ? pesagem.MedicaoRealizadaEixo5.ToString() : "",
                        MedicaoRealizadaEixo6 = pesagem != null ? pesagem.MedicaoRealizadaEixo6.ToString() : "",
                        MedicaoRealizadaEixo7 = pesagem != null ? pesagem.MedicaoRealizadaEixo7.ToString() : "",
                        MedicaoRealizadaPBT = pesagem != null ? pesagem.MedicaoRealizadaPbt.ToString() : "",
                        NumeroAIT = item.infracao.NumeroAit,
                        PlacaVeiculo = veiculo.Placa,
                        Proprietario = proprietario != null ? proprietario.NumeroCpfcnpjformatado + "-->" + proprietario.Nome : " - ",
                        RodoviaKmLocalInfracao = item.infracao.LocalInfracao,
                        SituacaoDebito = financeiro != null ? financeiro.situacao.Nome : "",
                        ToleranciaCMT = pesagem != null ? pesagem.ToleranciaCmt.ToString() : "",
                        ToleranciaEixo1 = pesagem != null ? pesagem.ToleranciaEixo1.ToString() : "",
                        ToleranciaEixo2 = pesagem != null ? pesagem.ToleranciaEixo2.ToString() : "",
                        ToleranciaEixo3 = pesagem != null ? pesagem.ToleranciaEixo3.ToString() : "",
                        ToleranciaEixo4 = pesagem != null ? pesagem.ToleranciaEixo4.ToString() : "",
                        ToleranciaEixo5 = pesagem != null ? pesagem.ToleranciaEixo5.ToString() : "",
                        ToleranciaEixo6 = pesagem != null ? pesagem.ToleranciaEixo6.ToString() : "",
                        ToleranciaEixo7 = pesagem != null ? pesagem.ToleranciaEixo7.ToString() : "",
                        ToleranciaPBT = pesagem != null ? pesagem.ToleranciaPbt.ToString() : "",
                        Transportador = transportador != null ? transportador.NumeroCpfcnpjformatado + "-->" + transportador.Nome : " - ",
                        ValorPago = financeiro != null ? financeiro.debito.ValorPago.ToString() : "0,00",
                        ValorPrincipal = item.infracao.ValorOriginal.ToString()
                    };

                    db.Dispose();

                    using (var sinpev = new BD_DADOS_SINPEVContext())
                    {
                        var notas = sinpev.TblDadosSinpev.Where(a => a.NumeroAit == item.infracao.NumeroAit).FirstOrDefault();
                        dados.NotasFiscais = notas != null ? notas.NotasFiscais : "";

                        sinpev.Dispose();
                    }

                    using (var renavam = new BD_SIOR_RENAVAMContext())
                    {
                        var municipio = renavam.TblRenavammunicipio.Where(a => a.CodigoRenavammunicipio == item.infracao.CodigoRenavammunicipioLocalInfracao).FirstOrDefault();
                        dados.Municipio = municipio != null ? municipio.Nome : "";

                        renavam.Dispose();
                    }

                    return dados;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public RetornoExcessoPeso BuscaExcessoPesoDetalhado2(string numeroAit)
        {
            try
            {
                using (var db = new BD_SIORContext())
                {
                    var item = db.TblInfracao
                        .Include("CodigoInfracaoEmbarcadorNavigation")
                        .Include("CodigoInfracaoProprietarioNavigation")
                        .Include("CodigoInfracaoTransportadorNavigation")
                        .Include("CodigoInfracaoVeiculoNavigation")
                        .Include("CodigoInfracaoInfratorNavigation")
                        .Include("CodigoInfracaoEnquadramentoNavigation")
                        .Include("CodigoInfracaoSituacaoNavigation")
                        .Where(a => a.NumeroAit == numeroAit).Select(a => new
                            {
                                CpfCnpEmbarcador = a.CodigoInfracaoEmbarcadorNavigation != null ? a.CodigoInfracaoEmbarcadorNavigation.NumeroCpfcnpjformatado : "",
                                NomeEmbarcador = a.CodigoInfracaoEmbarcadorNavigation != null ? a.CodigoInfracaoEmbarcadorNavigation.Nome : "",
                                CpfCnpProprietario = a.CodigoInfracaoProprietarioNavigation != null ? a.CodigoInfracaoProprietarioNavigation.NumeroCpfcnpjformatado : "",
                                NomeProprietario = a.CodigoInfracaoProprietarioNavigation != null ? a.CodigoInfracaoProprietarioNavigation.Nome : "",
                                CpfCnpTransportador = a.CodigoInfracaoTransportadorNavigation != null ? a.CodigoInfracaoTransportadorNavigation.NumeroCpfcnpjformatado : "",
                                NomeTransportador = a.CodigoInfracaoTransportadorNavigation != null ? a.CodigoInfracaoTransportadorNavigation.Nome : "",
                                CpfCnpInfrator = a.CodigoInfracaoInfratorNavigation != null ? a.CodigoInfracaoInfratorNavigation.NumeroCpfcnpjformatado : "",
                                NomeInfrator = a.CodigoInfracaoInfratorNavigation != null ? a.CodigoInfracaoInfratorNavigation.Nome : "",
                                PlacaVeiculo = a.CodigoInfracaoVeiculoNavigation != null ? a.CodigoInfracaoVeiculoNavigation.Placa : "",
                                CodigoEnquadramentoTexto = a.CodigoInfracaoEnquadramentoNavigation != null ? a.CodigoInfracaoEnquadramentoNavigation.CodigoEnquadramentoTexto : "",
                                DescricaoInfracao = a.CodigoInfracaoEnquadramentoNavigation != null ? a.CodigoInfracaoEnquadramentoNavigation.DescricaoInfracao : "",
                                situacaoAit = a.CodigoInfracaoSituacaoNavigation != null ? a.CodigoInfracaoSituacaoNavigation.Nome : "",
                                a.CodigoInfracaoPesagem,
                                a.CodigoInfracao,
                                a.DataHoraInfracao,
                                a.LimiteRegulamentado,
                                a.MedicaoRealizada,
                                a.ValorConsiderado,
                                a.NumeroAit,
                                a.LocalInfracao,
                                a.ValorOriginal,
                                a.CodigoRenavammunicipioLocalInfracao,
                                Pesagem = a.CodigoInfracaoPesagemNavigation != null ? new {
                                    a.CodigoInfracaoPesagemNavigation.ExcessoAferidoCmt,
                                    a.CodigoInfracaoPesagemNavigation.ExcessoAferidoEixo1,
                                    a.CodigoInfracaoPesagemNavigation.ExcessoAferidoEixo2,
                                    a.CodigoInfracaoPesagemNavigation.ExcessoAferidoEixo3,
                                    a.CodigoInfracaoPesagemNavigation.ExcessoAferidoEixo4,
                                    a.CodigoInfracaoPesagemNavigation.ExcessoAferidoEixo5,
                                    a.CodigoInfracaoPesagemNavigation.ExcessoAferidoEixo6,
                                    a.CodigoInfracaoPesagemNavigation.ExcessoAferidoEixo7,
                                    a.CodigoInfracaoPesagemNavigation.ExcessoAferidoPbt,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarCmt,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarComToleranciaCmt,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarComToleranciaEixo1,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarComToleranciaEixo2,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarComToleranciaEixo3,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarComToleranciaEixo4,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarComToleranciaEixo5,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarComToleranciaEixo6,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarComToleranciaEixo7,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarComToleranciaPbt,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarEixo1,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarEixo2,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarEixo3,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarEixo4,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarEixo5,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarEixo6,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarEixo7,
                                    a.CodigoInfracaoPesagemNavigation.LimiteRegulamentarPbt,
                                    a.CodigoInfracaoPesagemNavigation.MedicaoRealizadaCmt,
                                    a.CodigoInfracaoPesagemNavigation.MedicaoRealizadaEixo1,
                                    a.CodigoInfracaoPesagemNavigation.MedicaoRealizadaEixo2,
                                    a.CodigoInfracaoPesagemNavigation.MedicaoRealizadaEixo3,
                                    a.CodigoInfracaoPesagemNavigation.MedicaoRealizadaEixo4,
                                    a.CodigoInfracaoPesagemNavigation.MedicaoRealizadaEixo5,
                                    a.CodigoInfracaoPesagemNavigation.MedicaoRealizadaEixo6,
                                    a.CodigoInfracaoPesagemNavigation.MedicaoRealizadaEixo7,
                                    a.CodigoInfracaoPesagemNavigation.MedicaoRealizadaPbt,
                                    a.CodigoInfracaoPesagemNavigation.ToleranciaCmt,
                                    a.CodigoInfracaoPesagemNavigation.ToleranciaEixo1,
                                    a.CodigoInfracaoPesagemNavigation.ToleranciaEixo2,
                                    a.CodigoInfracaoPesagemNavigation.ToleranciaEixo3,
                                    a.CodigoInfracaoPesagemNavigation.ToleranciaEixo4,
                                    a.CodigoInfracaoPesagemNavigation.ToleranciaEixo5,
                                    a.CodigoInfracaoPesagemNavigation.ToleranciaEixo6,
                                    a.CodigoInfracaoPesagemNavigation.ToleranciaEixo7,
                                    a.CodigoInfracaoPesagemNavigation.ToleranciaPbt
                                } : null
                            }).AsNoTracking().FirstOrDefault();

                    var finan = db.TblInfracaoFinanceiroDebito
                        .Include("CodigoInfracaoFinanceiroDebitoSituacaoNavigation")
                        .Where(a => a.CodigoInfracaoFinanceiroDebito == item.CodigoInfracao).Select(a => new
                            {
                                a.ValorPago,
                                NomeSituacao = a.CodigoInfracaoFinanceiroDebitoSituacaoNavigation.Nome
                            }).AsNoTracking().FirstOrDefault();

                    var defesaAutuacao = db.TblInfracaoDa.Where(a => a.CodigoInfracao == item.CodigoInfracao).AsNoTracking().FirstOrDefault();

                    var notificacao = db.TblInfracaoNotificacao.Where(a => a.CodigoInfracao == item.CodigoInfracao).AsNoTracking();
                    var NA = notificacao.Where(a => a.CodigoInfracaoNotificacaoTipo == 1).FirstOrDefault();
                    var NP = notificacao.Where(a => a.CodigoInfracaoNotificacaoTipo == 2).FirstOrDefault();

                    var detalheSituacao = item.situacaoAit == "Encerrado" && NP == null ? "Encerrado" :
                                          item.situacaoAit == "Encerrado" && numeroAit.StartsWith('B') && NP.DataPostagem >= new DateTime(2013, 4, 17) && NP.DataPostagem <= new DateTime(2015, 4, 17) ? "Encerrado: Lei 13.103/2015" :
                                          item.situacaoAit == "Encerrado" && NP != null && finan.ValorPago > 0 ? "Encerrado: Constituição do Crédito" :
                                          item.situacaoAit == "Cancelado" && NP == null && defesaAutuacao.DataProtocolo != null && defesaAutuacao.DataJulgamento == null ? "Cancelado: Prescrição Intercorrente (3 anos). Motivo(s): NP não expedida por falta de Julgamento da DA no tempo hábil" :
                                          item.situacaoAit == "Cancelado" && NP == null && NA.CodigoInfracaoNotificacaoExpedicaoServico == 1 && NA.CodigoBaseCorreiosCodigoBaixa != 1 ? "Cancelado: Prescrição Intercorrente (3 anos). Motivo(s): AR de NA não entregue ao Destinatário via ECT; NP não expedida" :
                                          item.situacaoAit == "Cancelado" && NP == null && NA.CodigoInfracaoNotificacaoExpedicaoServico == 1 && NA.CodigoBaseCorreiosCodigoBaixa == 1 ? "Cancelado: Prescrição Intercorrente (3 anos). Motivo(s): Demora no Retorno Lógico oriundo da ECT; NP não expedida" :
                                          item.situacaoAit == "Cobrança" ? "Cobrança: Tramitado para a Unidade de Cobrança e Recuperação de Crédito (UNICRED)" :
                                          item.situacaoAit;

                    var dados = new RetornoExcessoPeso
                    {
                        DataInfracao = item.DataHoraInfracao.ToString(),
                        DataExpNA = NA.DataPostagem.Value.ToShortDateString(),
                        DataExpNP = NP == null ? "" : NP.DataPostagem.Value.ToShortDateString(),
                        LimiteRegulamentadoRegistroRENAINF = item.LimiteRegulamentado.ToString(),
                        MedicaoRealizadaRegistroRENAINF = item.MedicaoRealizada.ToString(),
                        ValorConsideradoRegistroRENAINF = item.ValorConsiderado.ToString(),
                        SituacaoAIT = detalheSituacao,
                        Embarcador = item.CpfCnpEmbarcador + "-->" + item.NomeEmbarcador,
                        Enquadramento = item.CodigoEnquadramentoTexto + ": " + item.DescricaoInfracao,
                        Infrator = item.CpfCnpInfrator + "-->" + item.NomeInfrator,
                        NumeroAIT = item.NumeroAit,
                        PlacaVeiculo = item.PlacaVeiculo,
                        Proprietario = item.CpfCnpProprietario + "-->" + item.NomeProprietario,
                        RodoviaKmLocalInfracao = item.LocalInfracao,
                        SituacaoDebito = finan != null ? finan.NomeSituacao : "",
                        Transportador = item.CpfCnpTransportador + "-->" + item.NomeTransportador,
                        ValorPago = finan != null ? finan.ValorPago.ToString() : "0,00",
                        ValorPrincipal = item.ValorOriginal.ToString()
                    };

                    if (item.Pesagem != null)
                    {

                        dados.ExcessoAferidoCMT = item.Pesagem.ExcessoAferidoCmt.ToString();
                        dados.ExcessoAferidoEixo1 = item.Pesagem.ExcessoAferidoEixo1.ToString();
                        dados.ExcessoAferidoEixo2 = item.Pesagem.ExcessoAferidoEixo2.ToString();
                        dados.ExcessoAferidoEixo3 = item.Pesagem.ExcessoAferidoEixo3.ToString();
                        dados.ExcessoAferidoEixo4 = item.Pesagem.ExcessoAferidoEixo4.ToString();
                        dados.ExcessoAferidoEixo5 = item.Pesagem.ExcessoAferidoEixo5.ToString();
                        dados.ExcessoAferidoEixo6 = item.Pesagem.ExcessoAferidoEixo6.ToString();
                        dados.ExcessoAferidoEixo7 = item.Pesagem.ExcessoAferidoEixo7.ToString();
                        dados.ExcessoAferidoPBT = item.Pesagem.ExcessoAferidoPbt.ToString();
                        dados.LimiteRegulamentarCMT = item.Pesagem.LimiteRegulamentarCmt.ToString();
                        dados.LimiteRegulamentarComToleranciaCMT = item.Pesagem.LimiteRegulamentarComToleranciaCmt.ToString();
                        dados.LimiteRegulamentarComToleranciaEixo1 = item.Pesagem.LimiteRegulamentarComToleranciaEixo1.ToString();
                        dados.LimiteRegulamentarComToleranciaEixo2 = item.Pesagem.LimiteRegulamentarComToleranciaEixo2.ToString();
                        dados.LimiteRegulamentarComToleranciaEixo3 = item.Pesagem.LimiteRegulamentarComToleranciaEixo3.ToString();
                        dados.LimiteRegulamentarComToleranciaEixo4 = item.Pesagem.LimiteRegulamentarComToleranciaEixo4.ToString();
                        dados.LimiteRegulamentarComToleranciaEixo5 = item.Pesagem.LimiteRegulamentarComToleranciaEixo5.ToString();
                        dados.LimiteRegulamentarComToleranciaEixo6 = item.Pesagem.LimiteRegulamentarComToleranciaEixo6.ToString();
                        dados.LimiteRegulamentarComToleranciaEixo7 = item.Pesagem.LimiteRegulamentarComToleranciaEixo7.ToString();
                        dados.LimiteRegulamentarComToleranciaPBT = item.Pesagem.LimiteRegulamentarComToleranciaPbt.ToString();
                        dados.LimiteRegulamentarEixo1 = item.Pesagem.LimiteRegulamentarEixo1.ToString();
                        dados.LimiteRegulamentarEixo2 = item.Pesagem.LimiteRegulamentarEixo2.ToString();
                        dados.LimiteRegulamentarEixo3 = item.Pesagem.LimiteRegulamentarEixo3.ToString();
                        dados.LimiteRegulamentarEixo4 = item.Pesagem.LimiteRegulamentarEixo4.ToString();
                        dados.LimiteRegulamentarEixo5 = item.Pesagem.LimiteRegulamentarEixo5.ToString();
                        dados.LimiteRegulamentarEixo6 = item.Pesagem.LimiteRegulamentarEixo6.ToString();
                        dados.LimiteRegulamentarEixo7 = item.Pesagem.LimiteRegulamentarEixo7.ToString();
                        dados.LimiteRegulamentarPBT = item.Pesagem.LimiteRegulamentarPbt.ToString();
                        dados.MedicaoRealizadaCMT = item.Pesagem.MedicaoRealizadaCmt.ToString();
                        dados.MedicaoRealizadaEixo1 = item.Pesagem.MedicaoRealizadaEixo1.ToString();
                        dados.MedicaoRealizadaEixo2 = item.Pesagem.MedicaoRealizadaEixo2.ToString();
                        dados.MedicaoRealizadaEixo3 = item.Pesagem.MedicaoRealizadaEixo3.ToString();
                        dados.MedicaoRealizadaEixo4 = item.Pesagem.MedicaoRealizadaEixo4.ToString();
                        dados.MedicaoRealizadaEixo5 = item.Pesagem.MedicaoRealizadaEixo5.ToString();
                        dados.MedicaoRealizadaEixo6 = item.Pesagem.MedicaoRealizadaEixo6.ToString();
                        dados.MedicaoRealizadaEixo7 = item.Pesagem.MedicaoRealizadaEixo7.ToString();
                        dados.MedicaoRealizadaPBT = item.Pesagem.MedicaoRealizadaPbt.ToString();
                        dados.ToleranciaCMT = item.Pesagem.ToleranciaCmt.ToString();
                        dados.ToleranciaEixo1 = item.Pesagem.ToleranciaEixo1.ToString();
                        dados.ToleranciaEixo2 = item.Pesagem.ToleranciaEixo2.ToString();
                        dados.ToleranciaEixo3 = item.Pesagem.ToleranciaEixo3.ToString();
                        dados.ToleranciaEixo4 = item.Pesagem.ToleranciaEixo4.ToString();
                        dados.ToleranciaEixo5 = item.Pesagem.ToleranciaEixo5.ToString();
                        dados.ToleranciaEixo6 = item.Pesagem.ToleranciaEixo6.ToString();
                        dados.ToleranciaEixo7 = item.Pesagem.ToleranciaEixo7.ToString();
                        dados.ToleranciaPBT = item.Pesagem.ToleranciaPbt.ToString();
                    }

                    db.Dispose();

                    using (var sinpev = new BD_DADOS_SINPEVContext())
                    {
                        var notas = sinpev.TblDadosSinpev.Where(a => a.NumeroAit == item.NumeroAit).FirstOrDefault();
                        dados.NotasFiscais = notas != null ? notas.NotasFiscais : "";

                        sinpev.Dispose();
                    }

                    using (var renavam = new BD_SIOR_RENAVAMContext())
                    {
                        var municipio = renavam.TblRenavammunicipio.Where(a => a.CodigoRenavammunicipio == item.CodigoRenavammunicipioLocalInfracao).FirstOrDefault();
                        dados.Municipio = municipio != null ? municipio.Nome : "";

                        renavam.Dispose();
                    }

                    return dados;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Stream ExportaExcessoPeso(DateTime dataInicio, DateTime dataFim, string cnpj)
        {
            try
            {
                var retorno = new List<RetornoExcessoPeso>();
                var dados = BuscaExcessoPesoLista(dataInicio, dataFim, cnpj).Select(a => a.NumeroAIT).ToList();
                foreach (var item in dados)
                {
                    retorno.Add(BuscaExcessoPesoDetalhado(item));
                }

                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("Tabela1");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoExcessoPeso), planilha);

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

        public Stream ExportarMedicaoSR(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = BuscarInfracoesSR(dataInicio, dataFim);
                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("SA");
                    planilha.Cells.LoadFromCollection(retorno.Where(a => a.Tipo == "SA"), true);

                    planilha = Util.MontaCabecalho(typeof(RetornoMedicaoSR), planilha);

                    var planilha1 = package.Workbook.Worksheets.Add("DA");
                    planilha1.Cells.LoadFromCollection(retorno.Where(a => a.Tipo == "DA"), true);

                    planilha1 = Util.MontaCabecalho(typeof(RetornoMedicaoSR), planilha1);

                    var planilha2 = package.Workbook.Worksheets.Add("Recurso");
                    planilha2.Cells.LoadFromCollection(retorno.Where(a => a.Tipo == "Recurso"), true);

                    planilha2 = Util.MontaCabecalho(typeof(RetornoMedicaoSR), planilha2);

                    var planilha3 = package.Workbook.Worksheets.Add("FICI");
                    planilha3.Cells.LoadFromCollection(retorno.Where(a => a.Tipo == "FICI"), true);

                    planilha3 = Util.MontaCabecalho(typeof(RetornoMedicaoSR), planilha3);

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

        public List<RetornoMedicaoSR> BuscarInfracoesSR(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var usuarios = Util.BuscaUsuariosSRs();
                var ret = new List<RetornoMedicaoSR>();

                using (var db = new BD_SIORContext())
                {
                    var SA = db.TblInfracaoSolicitacaoAdvertenciaArquivo.Join(db.TblInfracaoSolicitacaoAdvertenciaEvento, arquivo => arquivo.DataCriacao, evento => evento.Data, (arquivo, evento) => new { arquivo, evento })
                        .Where(a => a.arquivo.DataCriacao == a.evento.Data && a.arquivo.DataCriacao >= dataInicio && a.arquivo.DataCriacao <= dataFim)
                        .Join(db.TblSistemaUsuario, tipo => tipo.evento.NomeSistemaUsuario, usuario => usuario.Nome, (tipo, usuario) => new { tipo, usuario })
                        .Where(a => a.tipo.evento.NomeSistemaUsuario == a.usuario.Nome && usuarios.Contains(a.usuario.Nome)).ToList();

                    var DA = db.TblInfracaoDaarquivo.Join(db.TblInfracaoDaevento, arquivo => arquivo.DataCriacao, evento => evento.Data, (arquivo, evento) => new { arquivo, evento })
                        .Where(a => a.arquivo.DataCriacao == a.evento.Data && a.arquivo.DataCriacao >= dataInicio && a.arquivo.DataCriacao <= dataFim)
                        .Join(db.TblSistemaUsuario, tipo => tipo.evento.NomeSistemaUsuario, usuario => usuario.Nome, (tipo, usuario) => new { tipo, usuario })
                        .Where(a => a.tipo.evento.NomeSistemaUsuario == a.usuario.Nome && usuarios.Contains(a.usuario.Nome)).ToList();

                    var FICI = db.TblInfracaoIdentificacaoInfratorCondutorArquivo.Join(db.TblInfracaoIdentificacaoInfratorCondutorEvento, arquivo => arquivo.DataCriacao, evento => evento.Data, (arquivo, evento) => new { arquivo, evento })
                        .Where(a => a.arquivo.DataCriacao == a.evento.Data && a.arquivo.DataCriacao >= dataInicio && a.arquivo.DataCriacao <= dataFim)
                        .Join(db.TblSistemaUsuario, tipo => tipo.evento.NomeSistemaUsuario, usuario => usuario.Nome, (tipo, usuario) => new { tipo, usuario })
                        .Where(a => a.tipo.evento.NomeSistemaUsuario == a.usuario.Nome && usuarios.Contains(a.usuario.Nome)).ToList();

                    var REC = db.TblInfracaoRecursoArquivo.Join(db.TblInfracaoRecursoEvento, arquivo => arquivo.DataCriacao, evento => evento.Data, (arquivo, evento) => new { arquivo, evento })
                        .Where(a => a.arquivo.DataCriacao == a.evento.Data && a.arquivo.DataCriacao >= dataInicio && a.arquivo.DataCriacao <= dataFim)
                        .Join(db.TblSistemaUsuario, tipo => tipo.evento.NomeSistemaUsuario, usuario => usuario.Nome, (tipo, usuario) => new { tipo, usuario })
                        .Where(a => a.tipo.evento.NomeSistemaUsuario == a.usuario.Nome && usuarios.Contains(a.usuario.Nome)).ToList();

                    db.Dispose();

                    foreach (var item in SA)
                    {
                        var dados = new RetornoMedicaoSR
                        {
                            Tipo = "SA",
                            CpfDoFuncionario = item.usuario.Cpf,
                            DataDigitalizacao = item.tipo.arquivo.DataCriacao.ToShortDateString(),
                            NomeDoArquivo = item.tipo.arquivo.Nome,
                            NomeDoFuncionario = item.usuario.Nome,
                            SR = item.usuario.Descricao,
                            TamanhoDoArquivo = item.tipo.arquivo.Tamanho.ToString()
                        };

                        ret.Add(dados);
                    }

                    foreach (var item in DA)
                    {
                        var dados = new RetornoMedicaoSR
                        {
                            Tipo = "DA",
                            CpfDoFuncionario = item.usuario.Cpf,
                            DataDigitalizacao = item.tipo.arquivo.DataCriacao.ToShortDateString(),
                            NomeDoArquivo = item.tipo.arquivo.Nome,
                            NomeDoFuncionario = item.usuario.Nome,
                            SR = item.usuario.Descricao,
                            TamanhoDoArquivo = item.tipo.arquivo.Tamanho.ToString()
                        };

                        ret.Add(dados);
                    }

                    foreach (var item in FICI)
                    {
                        var dados = new RetornoMedicaoSR
                        {
                            Tipo = "FICI",
                            CpfDoFuncionario = item.usuario.Cpf,
                            DataDigitalizacao = item.tipo.arquivo.DataCriacao.ToShortDateString(),
                            NomeDoArquivo = item.tipo.arquivo.Nome,
                            NomeDoFuncionario = item.usuario.Nome,
                            SR = item.usuario.Descricao,
                            TamanhoDoArquivo = item.tipo.arquivo.Tamanho.ToString()
                        };

                        ret.Add(dados);
                    }

                    foreach (var item in REC)
                    {
                        var dados = new RetornoMedicaoSR
                        {
                            Tipo = "Recurso",
                            CpfDoFuncionario = item.usuario.Cpf,
                            DataDigitalizacao = item.tipo.arquivo.DataCriacao.ToShortDateString(),
                            NomeDoArquivo = item.tipo.arquivo.Nome,
                            NomeDoFuncionario = item.usuario.Nome,
                            SR = item.usuario.Descricao,
                            TamanhoDoArquivo = item.tipo.arquivo.Tamanho.ToString()
                        };

                        ret.Add(dados);
                    }
                }

                return ret;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
