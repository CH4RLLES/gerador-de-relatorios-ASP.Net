using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoFinanceiroGrutipoValor
    {
        public TblInfracaoFinanceiroGrutipoValor()
        {
            TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrunptipoValorNavigation = new HashSet<TblInfracaoFinanceiroDebito>();
            TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrutipoValorNavigation = new HashSet<TblInfracaoFinanceiroDebito>();
            TblInfracaoFinanceiroGru = new HashSet<TblInfracaoFinanceiroGru>();
        }

        public int CodigoInfracaoFinanceiroGrutipoValor { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroDebito> TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrunptipoValorNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroDebito> TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrutipoValorNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroGru> TblInfracaoFinanceiroGru { get; set; }
    }
}
