using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoEstudosTecnicos
    {
        [Display(Name = "Código de Identificação")]
        public string CodigoDeIdentificação { get; set; }
        [Display(Name = "Situação ET")]
        public string SituacaoET { get; set; }
        [Display(Name = "Código EV")]
        public string CodigoEV { get; set; }
        [Display(Name = "Situação EV")]
        public string SituacaoEV { get; set; }
        [Display(Name = "Código de Equipamento")]
        public string CodigoDeEquipamento { get; set; }
        [Display(Name = "Situação EQ")]
        public string SituacaoEQ { get; set; }

        public List<RetornoEstudosTecnicos> ListaEstudosTecnicos { get; set; }

        public RetornoEstudosTecnicos()
        {
            ListaEstudosTecnicos = new List<RetornoEstudosTecnicos>();
        }
    }
}
