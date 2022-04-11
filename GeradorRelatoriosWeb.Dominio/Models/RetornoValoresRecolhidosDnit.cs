using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoValoresRecolhidosDnit
    {
        public string Data { get; set; }
        [Display(Name = "Valor Recolhido")]
        public string ValorRecolhido { get; set; }
    }
}
