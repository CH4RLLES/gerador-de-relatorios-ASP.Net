using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoExcessoPeso
    {
        [Display(Name = "Número do AIT")]
        public string NumeroAIT { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data da Infração")]
        public string DataInfracao { get; set; }
        [Display(Name = "Data Exp. Notificação de Autuação")]
        [DataType(DataType.Date)]
        public string DataExpNA { get; set; }
        [Display(Name = "Data Exp. Notificação de Penalidade")]
        [DataType(DataType.Date)]
        public string DataExpNP { get; set; }
        [Display(Name = "Situação do AIT")]
        public string SituacaoAIT { get; set; }
        [Display(Name = "Rodovia/Km Local Infração")]
        public string RodoviaKmLocalInfracao { get; set; }
        [Display(Name = "Município Local Infração")]
        public string Municipio { get; set; }
        public string Enquadramento { get; set; }
        [Display(Name = "Placa do Veículo")]
        public string PlacaVeiculo { get; set; }
        //public string RENAVAM { get; set; }
        //public string MarcaModelo { get; set; }
        [DataType(DataType.Currency)]

        [Display(Name = "Valor Principal (R$)")]
        public string ValorPrincipal { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "Valor Pago (R$)")]
        public string ValorPago { get; set; }
        [Display(Name = "Situação do Débito")]
        public string SituacaoDebito { get; set; }
        public string Infrator { get; set; }
        [Display(Name = "Proprietário")]
        public string Proprietario { get; set; }
        public string Embarcador { get; set; }
        public string Transportador { get; set; }
        public string MedicaoRealizadaRegistroRENAINF { get; set; }
        public string LimiteRegulamentadoRegistroRENAINF { get; set; }
        public string ValorConsideradoRegistroRENAINF { get; set; }

        public string LimiteRegulamentarPBT { get; set; }
        public string LimiteRegulamentarComToleranciaPBT { get; set; }
        public string ToleranciaPBT { get; set; }
        public string MedicaoRealizadaPBT { get; set; }
        public string ExcessoAferidoPBT { get; set; }

        public string LimiteRegulamentarEixo1 { get; set; }
        public string LimiteRegulamentarComToleranciaEixo1 { get; set; }
        public string ToleranciaEixo1 { get; set; }
        public string MedicaoRealizadaEixo1 { get; set; }
        public string ExcessoAferidoEixo1 { get; set; }

        public string LimiteRegulamentarEixo2 { get; set; }
        public string LimiteRegulamentarComToleranciaEixo2 { get; set; }
        public string ToleranciaEixo2 { get; set; }
        public string MedicaoRealizadaEixo2 { get; set; }
        public string ExcessoAferidoEixo2 { get; set; }

        public string LimiteRegulamentarEixo3 { get; set; }
        public string LimiteRegulamentarComToleranciaEixo3 { get; set; }
        public string ToleranciaEixo3 { get; set; }
        public string MedicaoRealizadaEixo3 { get; set; }
        public string ExcessoAferidoEixo3 { get; set; }

        public string LimiteRegulamentarEixo4 { get; set; }
        public string LimiteRegulamentarComToleranciaEixo4 { get; set; }
        public string ToleranciaEixo4 { get; set; }
        public string MedicaoRealizadaEixo4 { get; set; }
        public string ExcessoAferidoEixo4 { get; set; }

        public string LimiteRegulamentarEixo5 { get; set; }
        public string LimiteRegulamentarComToleranciaEixo5 { get; set; }
        public string ToleranciaEixo5 { get; set; }
        public string MedicaoRealizadaEixo5 { get; set; }
        public string ExcessoAferidoEixo5 { get; set; }

        public string LimiteRegulamentarEixo6 { get; set; }
        public string LimiteRegulamentarComToleranciaEixo6 { get; set; }
        public string ToleranciaEixo6 { get; set; }
        public string MedicaoRealizadaEixo6 { get; set; }
        public string ExcessoAferidoEixo6 { get; set; }

        public string LimiteRegulamentarEixo7 { get; set; }
        public string LimiteRegulamentarComToleranciaEixo7 { get; set; }
        public string ToleranciaEixo7 { get; set; }
        public string MedicaoRealizadaEixo7 { get; set; }
        public string ExcessoAferidoEixo7 { get; set; }

        //public string LimiteRegulamentarEixo8 { get; set; }
        //public string LimiteRegulamentarComToleranciaEixo8 { get; set; }
        //public string ToleranciaEixo8 { get; set; }
        //public string MedicaoRealizadaEixo8 { get; set; }
        //public string ExcessoAferidoEixo8 { get; set; }

        //public string LimiteRegulamentarEixo9 { get; set; }
        //public string LimiteRegulamentarComToleranciaEixo9 { get; set; }
        //public string ToleranciaEixo9 { get; set; }
        //public string MedicaoRealizadaEixo9 { get; set; }
        //public string ExcessoAferidoEixo9 { get; set; }

        public string LimiteRegulamentarCMT { get; set; }
        public string LimiteRegulamentarComToleranciaCMT { get; set; }
        public string ToleranciaCMT { get; set; }
        public string MedicaoRealizadaCMT { get; set; }
        public string ExcessoAferidoCMT { get; set; }
        [Display(Name = "Notas Fiscais")]
        public string NotasFiscais { get; set; }
    }
}
