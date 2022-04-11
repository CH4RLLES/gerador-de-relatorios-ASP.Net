using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoProcessosSIOR
    {
        public string Data { get; set; }
        public string FICI { get; set; }
        public string FIRI { get; set; }
        public string DA { get; set; }
        public string SA { get; set; }
        [Display(Name = "Recurso 1ª Instância")]
        public string Recurso1instancia { get; set; }
        [Display(Name = "Recurso 2ª Instância")]
        public string Recurso2instancia { get; set; }
    }
}
