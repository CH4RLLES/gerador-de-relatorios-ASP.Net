using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoListaNP
    {
        [Display(Name = "Mês")]
        public string Mes { get; set; }
        public string Quantidade { get; set; }
        [Display(Name = "Valor Total")]
        public string ValorTotal { get; set; }
        [Display(Name = "Valor Pago")]
        public string ValorPago { get; set; }
    }
}
