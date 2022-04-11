using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoListaDA
    {
        public string Tipo { get; set; }
        [Display(Name = "Com Arquivo")]
        public int ComArquivo { get; set; }
        [Display(Name = "Sem Arquivo")]
        public int SemArquivo { get; set; }
        public int Total { get; set; }

    }
}
