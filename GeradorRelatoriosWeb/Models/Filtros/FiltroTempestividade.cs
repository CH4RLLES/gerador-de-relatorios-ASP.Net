using GeradorRelatoriosWeb.Dominio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorRelatoriosWeb.Models.Filtros
{
    public class FiltroTempestividade
    {
        [Display(Name = "Data Início")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data Fim")]
        [DataType(DataType.Date)]
        public DateTime DataFim { get; set; }
        [Display(Name = "Data de Referência")]
        public bool DataReferencia { get; set; }

        public List<RetornoRecursosJariLista> TempestividadeLista { get; set; }

        public FiltroTempestividade()
        {
            TempestividadeLista = new List<RetornoRecursosJariLista>();
        }
    }
}
