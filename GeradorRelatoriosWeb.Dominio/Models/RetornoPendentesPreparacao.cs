using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoPendentesPreparacao
    {
        [Display(Name = "Código da Infração Pre Autuação")]
        public long CodigoInfracaoPreAutuacao { get; set; }
        [Display(Name = "Data e Hora da Infração")]
        public string DataHoraInfracao { get; set; }
        public string Equipamento { get; set; }
        public string Local { get; set; }
        public string UF { get; set; }
        public string Conferencia1 { get; set; }       
        public string Conferencia2 { get; set; }
        [Display(Name = "Data da Conferência 2")]
        public string DataConferencia2 { get; set; }
        public string Arbitragem { get; set; }
        [Display(Name = "Data da Arbitragem")]
        public string DataArbitragem { get; set; }
    }
}
