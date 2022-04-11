using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoImgsValidasInvalidas
    {
        [Display(Name = "Data Infração")]
        public string Data { get; set; }
        [Display(Name = "Válidas")]
        public string Validos { get; set; }
        [Display(Name = "Inválidas")]
        public string Invalidos { get; set; }
    }
}
