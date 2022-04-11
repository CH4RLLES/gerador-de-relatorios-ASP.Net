using GeradorRelatoriosWeb.Dominio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorRelatoriosWeb.Models.Filtros
{
    public class FiltroLevantamentoDeConferencia
    {
        [Display(Name = "Data Início")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data Fim")]
        [DataType(DataType.Date)]
        public DateTime DataFim { get; set; }

        public List<RetornoLevantamentoDeConferencia> RetornoLevantamentoDeConferencia { get; set; }

        public FiltroLevantamentoDeConferencia()
        {
            RetornoLevantamentoDeConferencia = new List<RetornoLevantamentoDeConferencia>();
        }
    }
}
