using GeradorRelatoriosWeb.Dominio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorRelatoriosWeb.Models.Filtros
{
    public class FiltroProcessosSIOR
    {
        [Display(Name = "Data Início")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data Fim")]
        [DataType(DataType.Date)]
        public DateTime DataFim { get; set; }

        [Display(Name = "Arquivo")]
        public bool ComArquivo { get; set; }

        public List<RetornoProcessosSIOR> ProcessosSIOR { get; set; }

        public FiltroProcessosSIOR()
        {
            ProcessosSIOR = new List<RetornoProcessosSIOR>();
        }
    }
}
