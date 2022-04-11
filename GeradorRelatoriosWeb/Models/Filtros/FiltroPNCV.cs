using GeradorRelatoriosWeb.Dominio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorRelatoriosWeb.Models.Filtros
{
    public class FiltroPNCV
    {
        [Display(Name = "Data Início")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data Fim")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/2000", "1/1/2020")]
        public DateTime DataFim { get; set; }
        [Display(Name = "Tipo Veículo")]
        public int TipoVeiculo { get; set; }
        public string Equipamento { get; set; }
        public int Lote { get; set; }
        [Display(Name = "Início registros")]
        public int Inicio { get; set; }
        [Display(Name = "Final registros")]
        public int Fim { get; set; }

        public List<RetornoPNCV> RetornoPNCVs { get; set; }

        public FiltroPNCV()
        {
            RetornoPNCVs = new List<RetornoPNCV>();
        }
    }
}
