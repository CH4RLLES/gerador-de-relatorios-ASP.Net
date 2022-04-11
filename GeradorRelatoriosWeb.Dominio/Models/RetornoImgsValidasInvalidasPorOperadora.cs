using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoImgsValidasInvalidasPorOperadora
    {
        public string Operadora { get; set; }
        public int QuantidadeValida { get; set; }
        public int QuantidadeInvalida { get; set; }
    }
}
