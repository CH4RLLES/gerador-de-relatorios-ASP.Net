using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoLevantamentoDeConferencia
    {
        [Display(Name = "Usuáario")]
        public string Usuario { get; set; }
        [Display(Name = "Instituição")]
        public string Instituicao { get; set; }
        [Display(Name = "Periodo da Atividade")]
        public string PeriodoDaAtividade { get; set; }
        [Display(Name = "Qtd de Conferência 1 Realizadas")]
        public string QtdDeConferencia1Realizadas { get; set; }
        [Display(Name = "Qtd de Conferência 2 Realizadas")]
        public string QtdDeConferencia2Realizadas { get; set; }
        [Display(Name = "Qtd de Arbitragem Realizada")]
        public string QtdDeArbitragemRealizada { get; set; }
        [Display(Name = "Qtd de Preparação Imagem Realizada")]
        public string QtdDePreparacaoImagemRealizada { get; set; }
        [Display(Name = "Conferências que Coincidiram")]
        public string ConferenciasQueCoincidiram { get; set; }
        [Display(Name = "Conferências que Divergiram")]
        public string ConferenciasQueDivergiram { get; set; }
    }
}
