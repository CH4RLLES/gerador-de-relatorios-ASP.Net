using GeradorRelatoriosWeb.Dominio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorRelatoriosWeb.Models.Filtros
{
    public class FiltroPendentesPreparacao
    {
        [Display(Name = "Dias Pendentes")]
        public int DiasPendentes { get; set; }

        public List<RetornoPendentesPreparacao> PendentesPreparacao { get; set; }

        public FiltroPendentesPreparacao()
        {
            PendentesPreparacao = new List<RetornoPendentesPreparacao>();
        }
    }
}
