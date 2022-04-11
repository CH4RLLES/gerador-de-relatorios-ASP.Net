using GeradorRelatoriosWeb.Dominio.Entidades.PNCV_LIC_4;
using GeradorRelatoriosWeb.Dominio.Models;
using GeradorRelatoriosWeb.Dominio.Utils;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GeradorRelatoriosWeb.Servicos.Servicos
{
    public class Lic4Servicos
    {
        public List<RetornoPNCV> BuscaRegistrosPNVCLIC4(DateTime dataInicio, DateTime dataFim, int tipoVeiculo, string codEquipamento)
        {
            try
            {
                var retorno = new List<RetornoPNCV>();

                using (var db = new BD_SIOR_PNCV_DISP_LIC_4_2018Context())
                {
                    var join = db.TblRegistroContagem.Join(db.TblRemessaDados, registro => registro.CodigoRemessaDados, remessa => remessa.CodigoRemessaDados, (registro, remessa) => new { registro, remessa })
                        .Where(a => a.registro.CodigoRemessaDados == a.remessa.CodigoRemessaDados && a.registro.DataHora >= dataInicio && a.registro.DataHora <= dataFim
                        && a.remessa.CodigoEquipamentoDnit == codEquipamento && (tipoVeiculo == 0 ? a.registro.CodigoRegistroClasseVeiculo == null : tipoVeiculo == 5 ? a.registro.CodigoRegistroContagem > 0 : a.registro.CodigoRegistroClasseVeiculo == tipoVeiculo))
                        .Take(100);

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
                            Velocidade = item.registro.Velocidade.ToString()
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

        public Stream ExportarPNVCLIC4(DateTime dataInicio, DateTime dataFim, int tipoVeiculo, string codEquipamento)
        {
            try
            {
                var retorno = new List<RetornoPNCV>();

                using (var db = new BD_SIOR_PNCV_DISP_LIC_4_2018Context())
                {
                    var join = db.TblRegistroContagem.Join(db.TblRemessaDados, registro => registro.CodigoRemessaDados, remessa => remessa.CodigoRemessaDados, (registro, remessa) => new { registro, remessa })
                        .Where(a => a.registro.CodigoRemessaDados == a.remessa.CodigoRemessaDados && a.registro.DataHora >= dataInicio && a.registro.DataHora <= dataFim
                        && a.remessa.CodigoEquipamentoDnit == codEquipamento && (tipoVeiculo == 0 ? a.registro.CodigoRegistroClasseVeiculo == null : tipoVeiculo == 5 ? a.registro.CodigoRegistroContagem > 0 : a.registro.CodigoRegistroClasseVeiculo == tipoVeiculo));

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
                            Velocidade = item.registro.Velocidade.ToString()
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
