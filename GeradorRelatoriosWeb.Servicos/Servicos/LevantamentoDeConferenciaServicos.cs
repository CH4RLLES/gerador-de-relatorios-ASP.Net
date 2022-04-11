using GeradorRelatoriosWeb.Dominio.Models;
using GeradorRelatoriosWeb.Dominio.Utils;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeradorRelatoriosWeb.Servicos.Servicos
{
    public class LevantamentoDeConferenciaServicos
    {
        public List<RetornoLevantamentoDeConferencia> BuscaLevantamentoDeConferencia(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                return null;
            }

            catch (Exception ex)
            {
                return null;
            }
        }


        public Stream ExportarLevantamentoDeConferencia(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = BuscaLevantamentoDeConferencia(dataInicio, dataFim);
                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("Tabela1");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoLevantamentoDeConferencia), planilha);

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
