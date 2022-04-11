using GeradorRelatoriosWeb.Dominio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorRelatoriosWeb.Models.Filtros
{
    public class FiltroResumoEquipamentos
    {
        public int Edital { get; set; }
        [Display(Name = "Situação")]
        public int Situacao { get; set; }

        public List<RetornoResumoEquipamentosLista> ResumoEquipamentosLista { get; set; }

        public FiltroResumoEquipamentos()
        {
            ResumoEquipamentosLista = new List<RetornoResumoEquipamentosLista>();

        }

    }
}
