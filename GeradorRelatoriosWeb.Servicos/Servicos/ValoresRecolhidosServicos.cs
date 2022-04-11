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
    public class ValoresRecolhidosServicos
    {
        public List<RetornoValoresRecolhidos> BuscaValoresRecolhidos (DateTime DataInicio, DateTime DataFim)
        {
            try
            {
                var ret = new List<RetornoValoresRecolhidos>();

                using (var db = new BD_SIORContext())
                {
                    var repasses = db.TblInfracaoFinanceiroPagamentoDetran.Include("CodigoInfracaoFinanceiroRepasseDetranNavigation")
                        .AsNoTracking().Where(a => a.CodigoInfracaoFinanceiroRepasseDetran != null && a.CodigoInfracaoFinanceiroRepasseDetran > 0)
                        .Where(a => a.CodigoInfracaoFinanceiroRepasseDetranNavigation.RespostaDetrandataRepasse >= DataInicio && a.CodigoInfracaoFinanceiroRepasseDetranNavigation.RespostaDetrandataRepasse <= DataFim)
                        .GroupBy(a => a.CodigoInfracaoFinanceiroRepasseDetran).ToList();

                    foreach (var item in repasses)
                    {
                        var dados = new RetornoValoresRecolhidos
                        {
                            DataRepasse = item.FirstOrDefault().CodigoInfracaoFinanceiroRepasseDetranNavigation.RespostaDetrandataRepasse.Value.ToShortDateString(),
                            DENATRAN = item.Sum(a => a.ValorDenatran).Value.ToString(),
                            DETRAN = item.Sum(a => a.ValorDetran).Value.ToString(),
                            FUNSET = item.Sum(a => a.ValorFunset).Value.ToString(),
                            OrgaoAutuador = item.Sum(a => a.ValorOrgaoAutuador).Value.ToString(),
                            IdentificacaoRepasse = item.FirstOrDefault().CodigoInfracaoFinanceiroRepasseDetranNavigation.IdentificacaoRepasse
                        };

                        ret.Add(dados);
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

        public Stream ExportarValoresRecolhidos(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = BuscaValoresRecolhidos(dataInicio, dataFim);
                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("Tabela1");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoValoresRecolhidos), planilha);

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

        public List<RetornoValoresRecolhidosDnit> BuscaValoresRecolhidosDnit(DateTime DataInicio, DateTime DataFim)
        {
            try
            {
                var ret = new List<RetornoValoresRecolhidosDnit>();

                using (var db = new BD_SIORContext())
                {
                    var pagamento = db.TblInfracaoFinanceiroPagamentoGru
                        .AsNoTracking()
                        .Where(a => a.DataCredito >= DataInicio && a.DataCredito <= DataFim)
                        .GroupBy(a => a.DataCredito.Month).ToList();

                    foreach (var item in pagamento)
                    {
                        var dados = new RetornoValoresRecolhidosDnit
                        {
                            Data = item.FirstOrDefault().DataCredito.Month + "/" + item.FirstOrDefault().DataCredito.Year,
                            ValorRecolhido = item.Sum(a => a.ValorLiquido).ToString()
                        };

                        ret.Add(dados);
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

        public Stream ExportarValoresRecolhidosDnit(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = BuscaValoresRecolhidosDnit(dataInicio, dataFim);
                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("Tabela1");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoValoresRecolhidosDnit), planilha);

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
