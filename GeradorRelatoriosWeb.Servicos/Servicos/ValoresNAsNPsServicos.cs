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
    public class ValoresNAsNPsServicos
    {

        public RetornoValoresNAsNPs BuscaValoresNAsNPs(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var ret = new RetornoValoresNAsNPs();

                using (var db = new BD_SIORContext())
                {
                    var NAs = db.TblInfracaoNotificacao.AsNoTracking().Include("CodigoInfracaoNavigation").AsNoTracking()
                        .Where(a => a.CodigoInfracaoNotificacaoTipo == 1
                        && a.DataPostagem.Value.Date >= dataInicio && a.DataPostagem.Value.Date <= dataFim).AsNoTracking().ToList();
                        
                    var itens = NAs.GroupBy(a => a.DataPostagem.Value.Month)
                        .Select(a => new
                        {
                            MesAno = a.FirstOrDefault().DataPostagem.Value.Month + "/" + a.FirstOrDefault().DataPostagem.Value.Year,
                            Quantidade = a.Count(),
                            ValorTotal = a.Sum(b => b.CodigoInfracaoNavigation.ValorOriginal)
                        });

                    foreach (var item in itens)
                    {
                        var dados = new RetornoListaNA
                        {
                            Mes = item.MesAno,
                            Quantidade = item.Quantidade.ToString(),
                            ValorTotal = item.ValorTotal.ToString()
                        };

                        ret.ListaNAs.Add(dados);
                    }

                    var NPs = db.TblInfracaoNotificacao.AsNoTracking().Include("CodigoInfracaoNavigation").AsNoTracking()
                        .GroupJoin(db.TblInfracaoFinanceiroDebito, not => not.CodigoInfracaoNavigation.NumeroAit, fin => fin.NumeroAit, (n, f) => new { not = n, fin = f })
                        .SelectMany(a => a.fin.DefaultIfEmpty(), (a, f) => new { not = a, fin = f })
                        .Where(a => a.not.not.CodigoInfracaoNotificacaoTipo == 2
                        && a.not.not.DataPostagem.Value.Date >= dataInicio && a.not.not.DataPostagem.Value.Date <= dataFim).AsNoTracking().ToList();

                    var itensNP = NPs.GroupBy(a => a.not.not.DataPostagem.Value.Month)
                        .Select(a => new
                        {
                            MesAno = a.FirstOrDefault().not.not.DataPostagem.Value.Month + "/" + a.FirstOrDefault().not.not.DataPostagem.Value.Year,
                            Quantidade = a.Count(),
                            ValorTotal = a.Sum(b => b.not.not.CodigoInfracaoNavigation.ValorOriginal),
                            ValorPago = a.Sum(b => b.fin.ValorPago).ToString()
                        }).ToList();

                    foreach (var item in itensNP)
                    {
                        var dados = new RetornoListaNP
                        {
                            Mes = item.MesAno,
                            Quantidade = item.Quantidade.ToString(),
                            ValorTotal = item.ValorTotal.ToString(),
                            ValorPago = item.ValorPago.ToString()
                        };

                        ret.ListaNPs.Add(dados);
                    }

                    db.Dispose();
                }

                return ret;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Stream ExportarValoresNAsNPs(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = BuscaValoresNAsNPs(dataInicio, dataFim);
                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("NAs");
                    planilha.Cells.LoadFromCollection(retorno.ListaNAs, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoListaNA), planilha);

                    var planilha2 = package.Workbook.Worksheets.Add("NPs");
                    planilha2.Cells.LoadFromCollection(retorno.ListaNPs, true);

                    planilha2 = Util.MontaCabecalho(typeof(RetornoListaNP), planilha2);

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
