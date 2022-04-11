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
    public class CancelamentoAutoInfracaoServicos : ServiceBaseSior<TblInfracaoSolicitacaoCancelamentoInfracao>
    {
        public List<RetornoCancelamentoAutoInfracao> BuscaCancelamentoAutoInfracao(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var ret = new List<RetornoCancelamentoAutoInfracao>();

                using (var db = new BD_SIORContext())
                {
                    var cancelamentos = ListarInclude(a => a.CodigoInfracaoSolicitacaoCancelamentoNavigation.DataAnalise >= dataInicio && a.CodigoInfracaoSolicitacaoCancelamentoNavigation.DataAnalise <= dataFim,
                    "CodigoInfracaoSolicitacaoCancelamentoNavigation,CodigoInfracaoNavigation," +
                    "CodigoInfracaoSolicitacaoCancelamentoNavigation.CodigoInfracaoSolicitacaoCancelamentoMotivoNavigation," +
                    "CodigoInfracaoSolicitacaoCancelamentoNavigation.CodigoInfracaoSolicitacaoCancelamentoSituacaoNavigation")
                    .GroupBy(a => a.CodigoInfracaoSolicitacaoCancelamento)
                    .ToList();

                    foreach (var item in cancelamentos)
                    {
                        var dados = new RetornoCancelamentoAutoInfracao
                        {
                            Data = item.FirstOrDefault().CodigoInfracaoSolicitacaoCancelamentoNavigation.DataAnalise.Value.ToShortDateString(),
                            MotivoAutosCancelados = item.FirstOrDefault().CodigoInfracaoSolicitacaoCancelamentoNavigation.CodigoInfracaoSolicitacaoCancelamentoMotivoNavigation.Nome,
                            NumeroSolicitacao = item.FirstOrDefault().CodigoInfracaoSolicitacaoCancelamentoNavigation.NumeroSolicitacao,
                            QtdAutosCancelados = item.FirstOrDefault().CodigoInfracaoSolicitacaoCancelamentoNavigation.TotalInfracao.ToString(),
                            Situacao = item.FirstOrDefault().CodigoInfracaoSolicitacaoCancelamentoNavigation.CodigoInfracaoSolicitacaoCancelamentoSituacaoNavigation.Nome,
                            ValorAutosCancelados = item.Sum(a => a.CodigoInfracaoNavigation.ValorOriginal).Value.ToString()
                        };
                        ret.Add(dados);
                    }

                    return ret;
                }

                //using (var db = new BD_SIORContext())
                //{
                //    var cancelamentos = ListarInclude(a => a.DataAnalise >= dataInicio && a.DataAnalise <= dataFim,
                //    "CodigoInfracaoSolicitacaoCancelamentoMotivoNavigation,CodigoInfracaoSolicitacaoCancelamentoSituacaoNavigation")
                //    .Select(a => new RetornoCancelamentoAutoInfracao
                //    {
                //        Data = a.DataAnalise.Value.ToShortDateString(),
                //        QtdAutosCancelados = a.TotalInfracao.ToString(),
                //        MotivoAutosCancelados = a.CodigoInfracaoSolicitacaoCancelamentoMotivoNavigation.Nome,
                //        NumeroSolicitacao = a.NumeroSolicitacao,
                //        Situacao = a.CodigoInfracaoSolicitacaoCancelamentoSituacaoNavigation.Nome,
                //        ValorAutosCancelados = db.TblInfracaoSolicitacaoCancelamentoInfracao.AsNoTracking().Where(b => b.CodigoInfracaoSolicitacaoCancelamentoNavigation.CodigoInfracaoSolicitacaoCancelamento == a.CodigoInfracaoSolicitacaoCancelamento)
                //            .Sum(b => b.CodigoInfracaoNavigation.ValorOriginal).Value.ToString()
                //    })
                //    .ToList();

                //    return cancelamentos;
                //}
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Stream ExportarCancelamentoAutoInfracao(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = BuscaCancelamentoAutoInfracao(dataInicio, dataFim);
                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("Tabela1");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoCancelamentoAutoInfracao), planilha);

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
