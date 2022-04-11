using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
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
