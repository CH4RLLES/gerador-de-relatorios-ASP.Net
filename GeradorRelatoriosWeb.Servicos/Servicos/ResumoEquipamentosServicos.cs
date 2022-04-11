using GeradorRelatoriosWeb.Dominio.Entidades.RENAVAM;
using GeradorRelatoriosWeb.Dominio.Entidades.SIOR;
using GeradorRelatoriosWeb.Dominio.Models;
using GeradorRelatoriosWeb.Dominio.Utils;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class ResumoEquipamentosServicos : ServiceBaseSior<TblPncvedital>
    {
        public SelectList[] GerarCombos()
        {
            var ret = new List<SelectList>();
            using (var db = new BD_SIORContext())
            {
                ret.Add(new SelectList(db.TblPncvedital.ToList(), "CodigoPncvedital", "Numero"));
                ret.Add(new SelectList(db.TblPncvequipamentoFaixaSituacao.ToList(), "CodigoPncvequipamentoFaixaSituacao", "Nome"));
            }
            return ret.ToArray();
        }

        public List<RetornoResumoEquipamentosLista> ResumoEquipamentos(int edital, int situacao)
        {
            try
            {
                var retorno = new List<RetornoResumoEquipamentosLista>();
                using (var db = new BD_SIORContext())
                {
                    var equipamentos = db.TblPncvequipamentoFaixa.Include("CodigoPncvequipamentoNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoBaseRodoviaNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncveditalNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncvoperadoraNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoPncvequipamentoTipoNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoBaseUfNavigation")
                        .Include("CodigoPncvtipoViaNavigation")
                        .Include("CodigoPncvsentidoRodoviaNavigation")
                        .Include("CodigoPncvequipamentoFaixaSituacaoNavigation")
                        .Where(a => a.CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncvedital == edital
                        && situacao > 0 ? a.CodigoPncvequipamentoFaixaSituacao == situacao : a.CodigoPncvequipamentoFaixaSituacao > 0).OrderBy(a => a.CodigoPncvequipamento);
                    
                    foreach (var item in equipamentos)
                    {

                        if (item.CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncvedital != edital)
                            continue;

                        var dados = new RetornoResumoEquipamentosLista
                        {
                            BR = item.CodigoPncvequipamentoNavigation.CodigoBaseRodoviaNavigation.Numero,
                            CodigoEquipamentoDnit = item.CodigoPncvequipamentoNavigation.CodigoEquipamentoDnit,
                            EditalLoteOperadora = item.CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncveditalNavigation.Numero + " / " +
                                                  item.CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.NumeroLote + " (" +
                                                  item.CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncvoperadoraNavigation.Nome + ")",                           
                            InicioOperacao = item.DataInicioOperacao == null ? "" : DateTime.Parse(item.DataInicioOperacao.ToString()).ToShortDateString(),
                            TipoEquipamento = item.CodigoPncvequipamentoNavigation.CodigoPncvequipamentoTipoNavigation.Sigla,
                            UF = item.CodigoPncvequipamentoNavigation.CodigoBaseUfNavigation.Sigla
                        };

                        using (var renavam = new BD_SIOR_RENAVAMContext())
                        {
                            var municipio = renavam.TblRenavammunicipio.Where(a => a.CodigoRenavammunicipio == item.CodigoPncvequipamentoNavigation.CodigoRenavammunicipio).FirstOrDefault();
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

        public Stream ExportarResumoEquipamentos(int edital, int situacao)
        {
            try
            {
                var _paralisacoes = new List<Paralisacoes>();
                var retorno = new List<RetornoResumoEquipamentos>();
                using (var db = new BD_SIORContext())
                {
                    var equipamentos = db.TblPncvequipamentoFaixa.Include("CodigoPncvequipamentoNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoBaseRodoviaNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncveditalNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncvoperadoraNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoPncvequipamentoTipoNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoBaseUfNavigation")
                        .Include("CodigoPncvtipoViaNavigation")
                        .Include("CodigoPncvsentidoRodoviaNavigation")
                        .Include("CodigoPncvequipamentoFaixaSituacaoNavigation")
                        .Where(a => a.CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncvedital == edital
                        && situacao > 0 ? a.CodigoPncvequipamentoFaixaSituacao == situacao : a.CodigoPncvequipamentoFaixaSituacao > 0).OrderBy(a => a.CodigoPncvequipamento);

                    foreach (var item in equipamentos)
                    {
                        if (item.CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncvedital != edital)
                            continue;

                        var estudo = db.TblPncvequipamentoEstudoTecnicoFaixa
                            .Include("CodigoPncvequipamentoEstudoTecnicoNavigation")
                            .Include("CodigoPncvequipamentoEstudoTecnicoNavigation.CodigoPncvestudoTecnicoInstalacaoNavigation")
                            .Include("CodigoPncvequipamentoEstudoTecnicoNavigation.CodigoPncvestudoTecnicoInstalacaoNavigation.CodigoPncvestudoViabilidadeNavigation")
                            .Where(a => a.CodigoPncvequipamentoEstudoTecnicoNavigation.CodigoPncvequipamento == item.CodigoPncvequipamento
                            ).FirstOrDefault();

                        var dados = new RetornoResumoEquipamentos
                        {
                            BR = item.CodigoPncvequipamentoNavigation.CodigoBaseRodoviaNavigation.Numero,
                            CodigoEquipamentoDnit = item.CodigoPncvequipamentoNavigation.CodigoEquipamentoDnit,
                            EditalLoteOperadora = item.CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncveditalNavigation.Numero + " / " +
                                                  item.CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.NumeroLote + " (" +
                                                  item.CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncvoperadoraNavigation.Nome + ")",
                            SNV = item.CodigoPncvequipamentoNavigation.CodigoSnv,
                            InicioOperacao = item.DataInicioOperacao == null ? "" : DateTime.Parse(item.DataInicioOperacao.ToString()).ToShortDateString(),
                            KM = item.CodigoPncvequipamentoNavigation.NumeroKm.ToString(),
                            NoFaixas = equipamentos.Where(a => a.CodigoPncvequipamento == item.CodigoPncvequipamento).Count().ToString(),
                            Faixas = item.CodigoPncvtipoViaNavigation.Sigla + "-" + item.CodigoPncvsentidoRodoviaNavigation.Sigla + "-" + item.Numero,
                            Situacao = item.CodigoPncvequipamentoFaixaSituacaoNavigation.Nome,
                            TipoEquipamento = item.CodigoPncvequipamentoNavigation.CodigoPncvequipamentoTipoNavigation.Sigla,
                            UF = item.CodigoPncvequipamentoNavigation.CodigoBaseUfNavigation.Sigla,
                            ValocidadeRegulamentada = estudo.VelocidadeVeiculoLeve.ToString() + "/" + estudo.VelocidadeVeiculoPesado.ToString(),
                            Latitude = item.CodigoPncvequipamentoNavigation.Coordenadas.Y.ToString(),
                            Longitude = item.CodigoPncvequipamentoNavigation.Coordenadas.X.ToString(),
                            CodigoEstudoTecnico = estudo.CodigoPncvequipamentoEstudoTecnicoNavigation != null ?
                                                  estudo.CodigoPncvequipamentoEstudoTecnicoNavigation.CodigoPncvestudoTecnicoInstalacaoNavigation != null ?
                                                  estudo.CodigoPncvequipamentoEstudoTecnicoNavigation.CodigoPncvestudoTecnicoInstalacaoNavigation.CodigoIdentificacaoDnit
                                                  : "" : "",
                            CodigoEstudoViabilidade = estudo.CodigoPncvequipamentoEstudoTecnicoNavigation != null ?
                                                  estudo.CodigoPncvequipamentoEstudoTecnicoNavigation.CodigoPncvestudoTecnicoInstalacaoNavigation != null ?
                                                  estudo.CodigoPncvequipamentoEstudoTecnicoNavigation.CodigoPncvestudoTecnicoInstalacaoNavigation.CodigoPncvestudoViabilidadeNavigation != null ?
                                                  estudo.CodigoPncvequipamentoEstudoTecnicoNavigation.CodigoPncvestudoTecnicoInstalacaoNavigation.CodigoPncvestudoViabilidadeNavigation.CodigoIdentificacaoDnit
                                                  : "" : "" : ""
                        };

                        var paralisacao = db.TblPncvequipamentoFaixaParalisacao.Where(a => a.CodigoPncvequipamentoFaixa == item.CodigoPncvequipamentoFaixa).ToList();
                        
                        foreach (var paradas in paralisacao)
                        {
                            var parada = new Paralisacoes
                            {
                                CodigoEquipamentoDnit = item.CodigoPncvequipamentoNavigation.CodigoEquipamentoDnit,
                                Faixa = dados.Faixas,
                                Inicio = paradas.DataInicio.ToShortDateString(),
                                Fim = paradas.DataEncerramento == null ? "" : DateTime.Parse(paradas.DataEncerramento.ToString()).ToShortDateString()
                            };

                            _paralisacoes.Add(parada);
                        }

                        using (var renavam = new BD_SIOR_RENAVAMContext())
                        {
                            var municipio = renavam.TblRenavammunicipio.Where(a => a.CodigoRenavammunicipio == item.CodigoPncvequipamentoNavigation.CodigoRenavammunicipio).FirstOrDefault();
                            dados.Municipio = municipio != null ? municipio.Nome : "";

                            renavam.Dispose();
                        }

                        retorno.Add(dados);
                    }

                    db.Dispose();
                }

                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("Tabela1");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoResumoEquipamentos), planilha);

                    var planilha2 = package.Workbook.Worksheets.Add("Paralisações");
                    planilha2.Cells.LoadFromCollection(_paralisacoes, true);

                    planilha2 = Util.MontaCabecalho(typeof(Paralisacoes), planilha2);
                    
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
