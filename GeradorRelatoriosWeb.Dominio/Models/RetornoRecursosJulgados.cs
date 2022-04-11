using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoRecursosJulgados
    {
        public string JARI { get; set; }
        public int Janeiro { get; set; }
        public int Fevereiro { get; set; }
        [Display(Name = "Março")]
        public int Marco { get; set; }
        public int Abril { get; set; }
        public int Maio { get; set; }
        public int Junho { get; set; }
        public int Julho { get; set; }
        public int Agosto { get; set; }
        public int Setembro { get; set; }
        public int Outubro { get; set; }
        public int Novembro { get; set; }
        public int Dezembro { get; set; }
        public int Total { get; set; }
    }
}
