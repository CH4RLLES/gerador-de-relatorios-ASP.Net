using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoFinanceiroPagamentoTipo
    {
        public TblInfracaoFinanceiroPagamentoTipo()
        {
            TblInfracaoFinanceiroPagamento = new HashSet<TblInfracaoFinanceiroPagamento>();
        }

        public int CodigoInfracaoFinanceiroPagamentoTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroPagamento> TblInfracaoFinanceiroPagamento { get; set; }
    }
}
