using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoImgsValidasInvalidasPorHora
    {
        public int Hora { get; set; }
        public int QuantidadeValida { get; set; }
        public int QuantidadeInvalida { get; set; }
    }
}
