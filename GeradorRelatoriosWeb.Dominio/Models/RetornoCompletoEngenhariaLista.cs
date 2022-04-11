using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoCompletoEngenhariaLista
    {
        public string Contrato { get; set; }
        [Display(Name = "Código Equipamento")]
        public string EquipamentoAfericaoCodigoDnit { get; set; }
        [Display(Name = "Local da Infração km")]
        public string LocalInfracaoKm { get; set; }
        [Display(Name = "Local da Infração Rodovia")]
        public string LocalInfracaoRodovia { get; set; }
        [Display(Name = "Município")]
        public string Municipio { get; set; }
    }
}
