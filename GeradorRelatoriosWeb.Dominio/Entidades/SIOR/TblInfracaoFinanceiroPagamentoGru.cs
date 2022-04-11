using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroPagamentoGru
    {
        public long CodigoInfracaoFinanceiroPagamentoGru { get; set; }
        public long CodigoInfracaoFinanceiroGru { get; set; }
        public decimal? ValorAcrescimo { get; set; }
        public decimal? ValorDesconto { get; set; }
        public decimal? ValorAbatimento { get; set; }
        public decimal? ValorLiquido { get; set; }
        public decimal? ValorOutrasDespesas { get; set; }
        public decimal? ValorOutrosCreditos { get; set; }
        public DateTime DataCredito { get; set; }
        public bool RenainfIndicadorPago { get; set; }
        public decimal? RenainfValorPago { get; set; }
        public long? CodigoInfracaoFinanceiroArquivoCobrancaRetornoTitulo { get; set; }

        public virtual TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo CodigoInfracaoFinanceiroArquivoCobrancaRetornoTituloNavigation { get; set; }
        public virtual TblInfracaoFinanceiroGru CodigoInfracaoFinanceiroGruNavigation { get; set; }
        public virtual TblInfracaoFinanceiroPagamento CodigoInfracaoFinanceiroPagamentoGruNavigation { get; set; }
    }
}
