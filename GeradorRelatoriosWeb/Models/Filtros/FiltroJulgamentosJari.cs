using GeradorRelatoriosWeb.Dominio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorRelatoriosWeb.Models.Filtros
{
    public class FiltroJulgamentosJari
    {
        [Display(Name = "Data Início")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data Fim")]
        [DataType(DataType.Date)]
        public DateTime DataFim { get; set; }

        public string Ano { get; set; }
        [Display(Name = "Mês")]
        public string Mes { get; set; }
        public string JARI { get; set; }
        public string Fase { get; set; }
        [Display(Name = "Quantidade de Julgamentos")]
        public string QuantidadeJulgados { get; set; }


        public List<RetornoJulgamentosJari> RetornoJulgamentosJari { get; set; }

        public FiltroJulgamentosJari()
        {
            RetornoJulgamentosJari = new List<RetornoJulgamentosJari>();
        }
    }
}
