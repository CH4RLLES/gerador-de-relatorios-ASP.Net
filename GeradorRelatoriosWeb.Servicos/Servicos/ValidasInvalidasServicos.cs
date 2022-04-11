using GeradorRelatoriosWeb.Dominio.Entidades.SIOR;
using GeradorRelatoriosWeb.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeradorRelatoriosWeb.Servicos.Servicos
{
    public class ValidasInvalidasServicos
    {
        public List<RetornoImgsValidasInvalidas> BuscaRegistrosImngsValidasInvalidas(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = new List<RetornoImgsValidasInvalidas>();
                var data = dataInicio;

                using (var db = new BD_SIORContext())
                {
                    var dadosValidos = db.TblInfracaoPreAutuacao.Where(a => a.DataInfracao.Date >= dataInicio && a.DataInfracao.Date <= dataFim).AsNoTracking().ToList();

                    db.Dispose();

                    while (data <= dataFim)
                    {
                        var dados = new RetornoImgsValidasInvalidas
                        {
                            Data = data.ToShortDateString(),
                            Validos = dadosValidos.Where(a => a.DataInfracao.Date == data && a.PreparacaoImagemData != null).Count().ToString(),
                            Invalidos = dadosValidos.Where(a => a.DataInfracao.Date == data && a.ConferenciaDoisData != null && 
                                        ((a.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUm == a.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDois
                                        && a.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUm != null) || a.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaRevisao != null)).Count().ToString()
                        };

                        retorno.Add(dados);
                        data = data.AddDays(1);
                    }
                }

                return retorno;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<RetornoImgsValidasInvalidasPorHora> ImngsValidasInvalidasPorHora(DateTime data)
        {
            try
            {
                var retorno = new List<RetornoImgsValidasInvalidasPorHora>();
                
                using (var db = new BD_SIORContext())
                {
                    var dadosValidos = db.TblInfracaoPreAutuacao.Where(a => a.DataInfracao == data.Date && a.PreparacaoImagemData != null).AsNoTracking().GroupBy(a => a.DataHoraInfracao.Hour).Select(a => new { hora = a.Key, t = a.Count() }).ToList();
                    var dadosInvalidos = db.TblInfracaoPreAutuacao.Where(a => a.DataInfracao == data.Date)
                                         .Where(a => (a.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUm == a.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDois
                                         && a.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUm != null) || a.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaRevisao != null).AsNoTracking()
                                         .GroupBy(a => a.DataHoraInfracao.Hour).Select(a => new { hora = a.Key, t = a.Count() }).ToList();
                    db.Dispose();

                    for (int i = 0; i < 24; i++)
                    {
                        var hora = new RetornoImgsValidasInvalidasPorHora
                        {
                            Hora = i,
                            QuantidadeValida = dadosValidos.Where(a => a.hora == i).Select(a => a.t).FirstOrDefault(),
                            QuantidadeInvalida = dadosInvalidos.Where(a => a.hora == i).Select(a => a.t).FirstOrDefault()
                        };

                        retorno.Add(hora);
                    }
                }

                return retorno;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<RetornoImgsValidasInvalidasPorOperadora> ImngsValidasInvalidasPorOperadora(DateTime data)
        {
            try
            {
                var retorno = new List<RetornoImgsValidasInvalidasPorOperadora>();

                using (var db = new BD_SIORContext())
                {
                    var joinValidos = db.TblInfracaoPreAutuacao.Include("CodigoPncveditalLoteNavigation.CodigoPncvoperadoraNavigation")
                            .Join(db.TblPncvequipamento, infracao => infracao.EquipamentoAfericaoCodigoDnit, equipamento => equipamento.CodigoEquipamentoDnit, (infracao, equipamento) => new { infracao, equipamento })
                            .Where(a => a.equipamento.CodigoEquipamentoDnit == a.infracao.EquipamentoAfericaoCodigoDnit && a.infracao.DataInfracao == data.Date && a.infracao.PreparacaoImagemData != null).AsNoTracking()
                            .GroupBy(a => a.equipamento.CodigoPncveditalLoteNavigation.CodigoPncvoperadoraNavigation.Nome).Select(a => new { Equipamento = a.Key, t = a.Count() });

                    var joinInvalidos = db.TblInfracaoPreAutuacao.Include("CodigoPncveditalLoteNavigation.CodigoPncvoperadoraNavigation")
                            .Join(db.TblPncvequipamento, infracao => infracao.EquipamentoAfericaoCodigoDnit, equipamento => equipamento.CodigoEquipamentoDnit, (infracao, equipamento) => new { infracao, equipamento })
                            .Where(a => a.equipamento.CodigoEquipamentoDnit == a.infracao.EquipamentoAfericaoCodigoDnit && a.infracao.DataInfracao == data.Date)
                            .Where(a => (a.infracao.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUm == a.infracao.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDois
                                && a.infracao.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUm != null) || a.infracao.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaRevisao != null).AsNoTracking()
                            .GroupBy(a => a.equipamento.CodigoPncveditalLoteNavigation.CodigoPncvoperadoraNavigation.Nome).Select(a => new { Equipamento = a.Key, t = a.Count() });

                    foreach (var item in joinValidos)
                    {
                        var equip = new RetornoImgsValidasInvalidasPorOperadora
                        {
                            Operadora = item.Equipamento,
                            QuantidadeValida = item.t
                        };

                        retorno.Add(equip);
                    }

                    foreach (var item in joinInvalidos)
                    {
                        if (retorno.Exists(a => a.Operadora == item.Equipamento))
                        {
                            retorno.FirstOrDefault(a => a.Operadora == item.Equipamento).QuantidadeInvalida = item.t;
                        }
                        else
                        {
                            var equip = new RetornoImgsValidasInvalidasPorOperadora
                            {
                                Operadora = item.Equipamento,
                                QuantidadeInvalida = item.t
                            };

                            retorno.Add(equip);
                        }
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

        public List<RetornoImgsValidasInvalidas> BuscaMedicaoImagens(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = new List<RetornoImgsValidasInvalidas>();
                var data = dataInicio;

                using (var db = new BD_SIORContext())
                {
                    var dadosValidos = db.TblInfracaoPreAutuacao.AsNoTracking().Where(a => a.PreparacaoImagemData.Value.Date >= dataInicio && a.PreparacaoImagemData.Value.Date <= dataFim);
                    var dadosInvalidos = db.TblInfracaoPreAutuacao.AsNoTracking().Where(a => a.ConferenciaData >= dataInicio && a.ConferenciaData <= dataFim.AddDays(1).AddTicks(-1)
                                         && (a.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUm == a.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDois
                                         && a.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUm != null) || a.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaRevisao != null);
                    
                    while (data <= dataFim)
                    {
                        var dataf = data.AddDays(1).AddTicks(-1);
                        var dados = new RetornoImgsValidasInvalidas
                        {
                            Data = data.ToShortDateString(),
                            Validos = dadosValidos.Where(a => a.PreparacaoImagemData >= data && a.PreparacaoImagemData <= dataf).Count().ToString(),
                            Invalidos = dadosInvalidos.Where(a => a.ConferenciaData >= data && a.ConferenciaData <= dataf).Count().ToString()
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
    }
}
