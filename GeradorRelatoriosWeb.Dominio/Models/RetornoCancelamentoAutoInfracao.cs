using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoCancelamentoAutoInfracao
    {
        [DataType(DataType.Date)]
        public string Data { get; set; }
        [Display(Name = "Qtd. Autos Cancelados")]
        public string QtdAutosCancelados { get; set; }
        [Display(Name = "Valor Autos Cancelados")]
        public string ValorAutosCancelados { get; set; }
        [Display(Name = "Motivo Autos Cancelados")]
        public string MotivoAutosCancelados { get; set; }
        [Display(Name = "Nº da Solicitação")]
        public string NumeroSolicitacao { get; set; }
        [Display(Name = "Situação")]
        public string Situacao { get; set; }        
    }
}
