using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoJulgamentosJari
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
    }
}
