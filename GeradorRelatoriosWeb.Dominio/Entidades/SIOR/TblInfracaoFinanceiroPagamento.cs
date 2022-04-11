using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroPagamento
    {
        public long CodigoInfracaoFinanceiroPagamento { get; set; }
        public int CodigoInfracaoFinanceiroPagamentoTipo { get; set; }
        public long CodigoInfracao { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataProcessamento { get; set; }
        public decimal ValorPago { get; set; }
        public string CodigoBancoPagamento { get; set; }
        public string CodigoAgenciaPagamento { get; set; }
        public string DigitoVerificadorAgenciaPagamento { get; set; }
        public decimal? CodigoRenainf { get; set; }
        public string NumeroAit { get; set; }
        public int? CodigoInfracaoCtb { get; set; }
        public bool IndicadorPagamentoCancelado { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public string NomeUsuarioCancelamento { get; set; }
        public bool? IndicadorRegistroRenainf { get; set; }

        public virtual TblInfracaoFinanceiroPagamentoTipo CodigoInfracaoFinanceiroPagamentoTipoNavigation { get; set; }
        public virtual TblInfracao CodigoInfracaoNavigation { get; set; }
        public virtual TblInfracaoFinanceiroPagamentoBaixaManual TblInfracaoFinanceiroPagamentoBaixaManual { get; set; }
        public virtual TblInfracaoFinanceiroPagamentoDetran TblInfracaoFinanceiroPagamentoDetran { get; set; }
        public virtual TblInfracaoFinanceiroPagamentoGru TblInfracaoFinanceiroPagamentoGru { get; set; }
    }
}
