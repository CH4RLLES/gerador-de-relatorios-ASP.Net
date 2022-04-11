using GeradorRelatoriosWeb.Dominio.Entidades.PNCV_168;
using GeradorRelatoriosWeb.Dominio.Entidades.SIOR;
using GeradorRelatoriosWeb.Dominio.Models;
using GeradorRelatoriosWeb.Dominio.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GeradorRelatoriosWeb.Servicos.Servicos
{
    public class PNCV168Servico
    {
        public List<RetornoPNCV> ListarPNVC(DateTime dataInicio, DateTime dataFim, int tipoVeiculo, string equipamento, int lote)
        {
            try
            {
                var retorno = new List<RetornoPNCV>();
                dataFim = dataFim.AddDays(1).AddTicks(-1);
                int loteRemessa = 0;
                using (var db = new BD_SIORContext())
                {
                    if (lote > 0)
                    {
                        loteRemessa = db.TblPncveditalLote.Where(a => a.NumeroLote == lote && a.CodigoPncvedital == 122).FirstOrDefault().CodigoPncveditalLote;
                    }
                    db.Dispose();
                }

                using (var db = new BD_SIOR_PNCV_168_2016Context())
                {
                    var join = db.TblRegistroContagem.Join(db.TblRemessaDados, registro => registro.CodigoRemessaDados, remessa => remessa.CodigoRemessaDados, (registro, remessa) => new { registro, remessa })
                        .Where(a => a.registro.CodigoRemessaDados == a.remessa.CodigoRemessaDados && a.registro.DataHora >= dataInicio && a.registro.DataHora < dataFim
                        && (tipoVeiculo == 0 ? a.registro.CodigoRegistroClasseVeiculo == null : tipoVeiculo == 5 ? a.registro.CodigoRegistroContagem > 0 : a.registro.CodigoRegistroClasseVeiculo == tipoVeiculo)
                        && (string.IsNullOrEmpty(equipamento) ? a.remessa.CodigoEquipamentoDnit != null : a.remessa.CodigoEquipamentoDnit == equipamento)
                        && (lote == 0 ? a.remessa.CodigoPncveditalLote > 0 : a.remessa.CodigoPncveditalLote == loteRemessa)).AsNoTracking()
                        .Take(100).ToList();

                    foreach (var item in join)
                    {
                        var registro = new RetornoPNCV
                        {
                            Id = item.registro.CodigoRegistroContagem,
                            Classe = item.registro.CodigoRegistroClasseVeiculo == 1 ? "Motos" :
                                        item.registro.CodigoRegistroClasseVeiculo == 2 ? "Carros e Veículos Pequenos" :
                                        item.registro.CodigoRegistroClasseVeiculo == 3 ? "Caminhões Leves e Ônibus" :
                                        item.registro.CodigoRegistroClasseVeiculo == 4 ? "Caminhões Pesados e Especiais" : "Não Especificado",
                            CodigoEquipamentoDnit = item.remessa.CodigoEquipamentoDnit,
                            Data = item.registro.DataHora.ToShortDateString(),
                            Horario = item.registro.DataHora.ToShortTimeString(),
                            LocalSentidoRodovia = item.remessa.LocalSentidoRodovia,
                            Velocidade = item.registro.Velocidade.ToString(),
                            Placa = item.registro.PlacaVeiculo
                        };

                        retorno.Add(registro);
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

        public Stream ExportarPNVC(DateTime dataInicio, DateTime dataFim, int tipoVeiculo, string equipamento, int lote)
        {
            try
            {
                var retorno = new List<RetornoPNCV>();
                int loteRemessa = 0;
                dataFim = dataFim.AddDays(1).AddTicks(-1);
                using (var db = new BD_SIORContext())
                {
                    if (lote > 0)
                    {
                        loteRemessa = db.TblPncveditalLote.Where(a => a.NumeroLote == lote && a.CodigoPncvedital == 122).FirstOrDefault().CodigoPncveditalLote;
                    }
                    db.Dispose();
                }

                using (var db = new BD_SIOR_PNCV_168_2016Context())
                {
                    var join = db.TblRegistroContagem.Join(db.TblRemessaDados, registro => registro.CodigoRemessaDados, remessa => remessa.CodigoRemessaDados, (registro, remessa) => new { registro, remessa })
                        .Where(a => a.registro.CodigoRemessaDados == a.remessa.CodigoRemessaDados && a.registro.DataHora >= dataInicio && a.registro.DataHora < dataFim
                        && (tipoVeiculo == 0 ? a.registro.CodigoRegistroClasseVeiculo == null : tipoVeiculo == 5 ? a.registro.CodigoRegistroContagem > 0 : a.registro.CodigoRegistroClasseVeiculo == tipoVeiculo)
                        && (string.IsNullOrEmpty(equipamento) ? a.remessa.CodigoEquipamentoDnit != null : a.remessa.CodigoEquipamentoDnit == equipamento)
                        && (lote == 0 ? a.remessa.CodigoPncveditalLote > 0 : a.remessa.CodigoPncveditalLote == loteRemessa));

                    foreach (var item in join)
                    {
                        var registro = new RetornoPNCV
                        {
                            Id = item.registro.CodigoRegistroContagem,
                            Classe = item.registro.CodigoRegistroClasseVeiculo == 1 ? "Motos" :
                                        item.registro.CodigoRegistroClasseVeiculo == 2 ? "Carros e Veículos Pequenos" :
                                        item.registro.CodigoRegistroClasseVeiculo == 3 ? "Caminhões Leves e Ônibus" :
                                        item.registro.CodigoRegistroClasseVeiculo == 4 ? "Caminhões Pesados e Especiais" : "Não Especificado",
                            CodigoEquipamentoDnit = item.remessa.CodigoEquipamentoDnit,
                            Data = item.registro.DataHora.ToShortDateString(),
                            Horario = item.registro.DataHora.ToShortTimeString(),
                            LocalSentidoRodovia = item.remessa.LocalSentidoRodovia,
                            Velocidade = item.registro.Velocidade.ToString(),
                            Placa = item.registro.PlacaVeiculo
                        };

                        retorno.Add(registro);
                    }

                    db.Dispose();
                }

                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("Tabela1");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoPNCV), planilha);

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
