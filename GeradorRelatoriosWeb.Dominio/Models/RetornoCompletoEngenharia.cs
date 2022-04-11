using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoCompletoEngenharia
    {
        public string Contrato { get; set; }
        [Display(Name = "Código Equipamento")]
        public string EquipamentoAfericaoCodigoDnit { get; set; }
        [Display(Name = "Data e hora da Infração")]
        public string DataHoraInfracao { get; set; }
        [Display(Name = "Data do Cadastro")]
        public string DataCadastro { get; set; }
        [Display(Name = "Data da Coferencia")]
        public string DataConferencia2 { get; set; }
        [Display(Name = "Data da Revisão")]
        public string DataRevisão { get; set; }
        [Display(Name = "Data da Premiação")]
        public string DataPreparação { get; set; }
        [Display(Name = "Local da Infração km")]
        public string LocalInfracaoKm { get; set; }
        [Display(Name = "Local da Infração Rodovia")]
        public string LocalInfracaoRodovia { get; set; }
        [Display(Name = "Medição Realizada")]
        public string MedicaoRealizada { get; set; }
        [Display(Name = "Limite Regulamentado")]
        public string LimiteRegulamentado { get; set; }
        [Display(Name = "Valor Considerado")]
        public string ValorConsiderado { get; set; }
        [Display(Name = "Placa do Veiculo Final")]
        public string VeiculoPlacaFinal { get; set; }
        [Display(Name = "Conferencia Um Placa do Veiculo")]
        public string ConferenciaUmPlacaVeiculo { get; set; }
        [Display(Name = "Conferencia Dois Placa do Veiculo")]
        public string ConferenciaDoisPlacaVeiculo { get; set; }
        [Display(Name = "Conferencia Revisão Placa do Veiculo")]
        public string ConferenciaRevisaoPlacaVeiculo { get; set; }
        [Display(Name = "Descrição da Infração")]
        public string DescricaoInfracaoResumo { get; set; }
        [Display(Name = "Motivo Invalidação Final")]
        public string MotivoInvalidaçãoFinal { get; set; }
        [Display(Name = "Faixa Sentido da Via")]
        public string FaixaSentidoVia { get; set; }
        [Display(Name = "Tipo de Equipamento")]
        public string TipoEquipamento { get; set; }
        [Display(Name = "Modelo do Equipamento")]
        public string MarcaModeloEquipamento { get; set; }
        public string UF { get; set; }
        [Display(Name = "Município")]
        public string Municipio { get; set; }
        [Display(Name = "Conferencia Dois Placa do Veiculo")]
        public string OnlineOffline { get; set; }
    }
}
