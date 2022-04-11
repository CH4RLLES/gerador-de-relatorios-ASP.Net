using GeradorRelatoriosWeb.Dominio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorRelatoriosWeb.Models.Filtros
{
    public class FiltroExcessoPeso
    {
        [Display(Name = "Data Início")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data Fim")]
        [DataType(DataType.Date)]
        public DateTime DataFim { get; set; }
        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }

        public List<RetornoExcessoPesoLista> ExcessoPesoLista { get; set; }

        public FiltroExcessoPeso()
        {
            ExcessoPesoLista = new List<RetornoExcessoPesoLista>();
        }
    }
}
