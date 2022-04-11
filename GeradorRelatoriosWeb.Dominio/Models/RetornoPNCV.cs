using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoPNCV
    {
        [Display(AutoGenerateField = false)]
        public long Id { get; set; }
        public string Data { get; set; }
        [Display(Name = "Horário")]
        public string Horario { get; set; }
        [Display(Name = "Código Equipamento DNIT")]
        public string CodigoEquipamentoDnit { get; set; }
        [Display(Name = "Local/Sentido Rodovia")]
        public string LocalSentidoRodovia { get; set; }
        public string Classe { get; set; }
        public string Velocidade { get; set; }
        public string Placa { get; set; }
    }
}
