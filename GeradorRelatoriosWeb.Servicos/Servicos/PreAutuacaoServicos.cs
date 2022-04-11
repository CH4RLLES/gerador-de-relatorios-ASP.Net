using GeradorRelatoriosWeb.Dominio.Entidades.SIOR;
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
    public class PreAutuacaoServicos : ServiceBaseSior<TblInfracaoPreAutuacao>
    {
        public List<RetornoPendentesPreparacao> BuscaPendentesPreparacao(int DiasPendentes)
        {
            try
            {
                var ret = new List<RetornoPendentesPreparacao>();
                var imagens = ListarInclude(a => a.CodigoInfracaoPreAutuacaoFase == 4 && a.CodigoInfracaoPreAutuacaoSituacao != 3
                                && (DateTime.Now - a.ConferenciaData).Value.Days > DiasPendentes, "CodigoUflocalInfracaoNavigation");

                foreach (var item in imagens)
                {
                    using (var db = new BD_SIORContext())
                    {
                        var usuarioArbitrage = item.CodigoSistemaUsuarioConferenciaRevisao == null ? "": db.TblSistemaUsuario.Where(a => a.CodigoSistemaUsuario == item.CodigoSistemaUsuarioConferenciaRevisao).FirstOrDefault().Nome;
                        var usuarioConf1 = db.TblSistemaUsuario.Where(a => a.CodigoSistemaUsuario == item.CodigoSistemaUsuarioConferenciaUm).FirstOrDefault().Nome;
                        var usuarioConf2 = db.TblSistemaUsuario.Where(a => a.CodigoSistemaUsuario == item.CodigoSistemaUsuarioConferenciaDois).FirstOrDefault().Nome;

                        db.Dispose();

                        var dados = new RetornoPendentesPreparacao
                        {
                            Arbitragem = usuarioArbitrage,
                            CodigoInfracaoPreAutuacao = item.CodigoInfracaoPreAutuacao,
                            DataHoraInfracao = item.DataHoraInfracao.ToString(),
                            Equipamento = item.EquipamentoAfericaoCodigoDnit,
                            Conferencia1 = usuarioConf1,
                            Conferencia2 = usuarioConf2,
                            UF = item.CodigoUflocalInfracaoNavigation.Sigla,
                            DataConferencia2 = item.ConferenciaDoisData.Value.ToString(),
                            DataArbitragem = item.ConferenciaRevisaoData == null? "" : item.ConferenciaRevisaoData.Value.ToString()
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

        public Stream ExportarPendentesPreparacao(int diasPendentes)
        {
            try
            {
                var retorno = BuscaPendentesPreparacao(diasPendentes);
                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("Tabela1");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoPendentesPreparacao), planilha);

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
