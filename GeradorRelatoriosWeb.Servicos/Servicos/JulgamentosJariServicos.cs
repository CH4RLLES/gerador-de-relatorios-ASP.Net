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
    public class JulgamentosJariServicos
    {
        public List<RetornoJulgamentosJari> BuscaJulgamentosJari(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = new List<RetornoJulgamentosJari>();
                List<TblInfracaoRecurso> recursos;
                List<TblInfracaoRecursoFase> fase;
                List<TblJari> jari;

                using (var db = new BD_SIORContext())
                {
                    recursos = db.TblInfracaoRecurso.Where(a => a.DataJulgamento >= dataInicio && a.DataJulgamento <= dataFim && (a.CodigoInfracaoRecursoFase == 21 || a.CodigoInfracaoRecursoFase == 22)).ToList();
                    fase = db.TblInfracaoRecursoFase.ToList();
                    jari = db.TblJari.ToList();

                    db.Dispose();
                }

                var lista = new List<RetornoJulgamentosJari>();

                foreach (var item in recursos)
                {
                    var itemFase = fase.Where(a => a.CodigoInfracaoRecursoFase == item.CodigoInfracaoRecursoFase).FirstOrDefault().Nome;
                    var itemJari = jari.Where(a => a.CodigoJari == item.CodigoJari).FirstOrDefault();

                    var dados = new RetornoJulgamentosJari
                    {
                        Ano = item.DataJulgamento.Value.Year.ToString(),
                        Mes = item.DataJulgamento.Value.Month.ToString(),
                        Fase = itemFase,
                        JARI = itemJari == null ? "Não Informada" : itemJari.Nome
                    };

                    lista.Add(dados);
                }

                var grupo = lista.GroupBy(a => new { a.Ano, a.Mes, a.JARI, a.Fase }).Select(g => new
                {
                    Ano = g.Select(v => v.Ano),
                    Mes = g.Select(v => v.Mes),
                    Fase = g.Select(v => v.Fase),
                    JARI = g.Select(v => v.JARI),
                    Qtd = g.Count()
                });


                foreach (var item in grupo)
                {
                    var dados = new RetornoJulgamentosJari
                    {
                        Ano = item.Ano.FirstOrDefault(),
                        Mes = item.Mes.FirstOrDefault(),
                        Fase = item.Fase.FirstOrDefault(),
                        JARI = item.JARI.FirstOrDefault(),
                        QuantidadeJulgados = item.Qtd.ToString()
                    };

                    retorno.Add(dados);
                }

                return retorno.OrderBy(a => a.Ano).ThenBy(a => a.Mes).ThenBy(a => a.JARI).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public Stream ExportarJulgamentosJari(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = BuscaJulgamentosJari(dataInicio, dataFim);
                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var planilha = package.Workbook.Worksheets.Add("Tabela1");
                    planilha.Cells.LoadFromCollection(retorno, true);

                    planilha = Util.MontaCabecalho(typeof(RetornoJulgamentosJari), planilha);

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
