using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoRecursosJariLista
    {
        [Display(Name = "Número Auto")]
        public string NumeroAIT { get; set; }
        [Display(Name = "Número Processo")]
        public string NumeroProcesso { get; set; }
        [Display(Name = "CPF/CNPJ")]
        public string CpfCnpjRecorrente { get; set; }
        [Display(Name = "Data Protocolo")]
        public string DataProtocolo { get; set; }
        public string JARI { get; set; }
    }
}
