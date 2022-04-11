using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class Paralisacoes
    {
        public string CodigoEquipamentoDnit { get; set; }
        public string Faixa { get; set; }
        public string Inicio { get; set; }
        public string Fim { get; set; }
    }
}
