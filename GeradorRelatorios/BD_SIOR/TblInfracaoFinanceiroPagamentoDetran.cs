using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoFinanceiroPagamentoDetran
    {
        public long CodigoInfracaoFinanceiroPagamentoDetran { get; set; }
        public int CodigoInfracaoFinanceiroDetran { get; set; }
        public int? CodigoInfracaoFinanceiroRepasseDetran { get; set; }
        public string Ufpagamento { get; set; }
        public string NumeroDocumentoArrecadacao { get; set; }
        public string NumeroTerminalFinanceiro { get; set; }
        public string NumeroAutenticacao { get; set; }
        public DateTime? DataCreditoOrgaoAutuador { get; set; }
        public decimal? ValorFunset { get; set; }
        public decimal? ValorDenatran { get; set; }
        public decimal? ValorDetran { get; set; }
        public decimal? ValorOrgaoAutuador { get; set; }

        public virtual TblInfracaoFinanceiroDetran CodigoInfracaoFinanceiroDetranNavigation { get; set; }
        public virtual TblInfracaoFinanceiroPagamento CodigoInfracaoFinanceiroPagamentoDetranNavigation { get; set; }
        public virtual TblInfracaoFinanceiroRepasseDetran CodigoInfracaoFinanceiroRepasseDetranNavigation { get; set; }
    }
}
