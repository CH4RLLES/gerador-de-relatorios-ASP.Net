using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class AuxMigracaoFinanceiro
    {
        public long CodigoProcesso { get; set; }
        public long? CodigoInfracao { get; set; }
        public bool? IndicadorProcessado { get; set; }
        public int? QuantidadePagamentos { get; set; }
        public DateTime? DataVencimentoNp { get; set; }
        public int? CodigoInfracaoFinanceiroDebitoSituacao { get; set; }
        public bool? IndicadorReconhecidoCometimentoInfracao { get; set; }
        public decimal? ValorPagoAteVencimentoNp { get; set; }
        public decimal? ValorPago { get; set; }
        public string IndicadorReprocessar { get; set; }
    }
}
