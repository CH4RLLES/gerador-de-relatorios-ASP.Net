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
    public class EstudosTecnicosServicos
    {
        public List<RetornoEstudosTecnicos> BuscaEstudosTecnicos()
        {
            var ret = new List<RetornoEstudosTecnicos>();
            try
            {
                using (var db = new BD_SIORContext())
                {
                    var ET = db.TblPncvestudoTecnicoInstalacao.Where(a => a.CodigoIdentificacaoDnit != null);
                    foreach (var item in ET)
                    {
                        var dados = new RetornoEstudosTecnicos();

                        dados.CodigoDeIdentificação = item.CodigoIdentificacaoDnit;
                        dados.SituacaoET = db.TblPncvestudoTecnicoInstalacaoSituacao.Where(a => a.CodigoPncvestudoTecnicoInstalacaoSituacao == item.CodigoPncvestudoTecnicoInstalacaoSituacao).FirstOrDefault().Nome;

                        var EV = db.TblPncvestudoViabilidade.Where(a => a.CodigoPncvestudoViabilidade == item.CodigoPncvestudoViabilidade).FirstOrDefault();
                        dados.CodigoEV = EV != null ? EV.CodigoIdentificacaoDnit : "";
                        dados.SituacaoEV = EV != null ? db.TblPncvestudoViabilidadeSituacao.Where(a => a.CodigoPncvestudoViabilidadeSituacao == EV.CodigoPncvestudoViabilidadeSituacao).FirstOrDefault().Nome : "";

                        var EQ = db.TblPncvequipamento.Where(a => a.CodigoPncvestudoTecnicoInstalacao == item.CodigoPncvestudoTecnicoInstalacao).FirstOrDefault();
                        dados.CodigoDeEquipamento = EQ != null ? EQ.CodigoEquipamentoDnit : "";

                        ret.Add(dados);
                    }

                    return ret;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Stream ExportarEstudosTecnicos()
        {
            try
            {
                var retorno = BuscaEstudosTecnicos();
                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("EstudosTecnicos");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoEstudosTecnicos), planilha);

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
