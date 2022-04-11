using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoExcessoPesoLista
    {
        [Display(Name = "Número do AIT")]
        public string NumeroAIT { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data da Infração")]
        public string DataInfracao { get; set; }
        [Display(Name = "Situação do AIT")]
        public string SituacaoAIT { get; set; }
        [Display(Name = "Placa do Veículo")]
        public string PlacaVeiculo { get; set; }
        public string Infrator { get; set; }
        [Display(Name = "Proprietário")]
        public string Proprietario { get; set; }
        public string Embarcador { get; set; }
        public string Transportador { get; set; }
    }
}
