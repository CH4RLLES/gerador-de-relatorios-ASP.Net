using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroGrutipoValor
    {
        public TblInfracaoFinanceiroGrutipoValor()
        {
            TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrundr1tipoValorNavigation = new HashSet<TblInfracaoFinanceiroDebito>();
            TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrundr2tipoValorNavigation = new HashSet<TblInfracaoFinanceiroDebito>();
            TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrunptipoValorNavigation = new HashSet<TblInfracaoFinanceiroDebito>();
            TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrutipoValorNavigation = new HashSet<TblInfracaoFinanceiroDebito>();
            TblInfracaoFinanceiroGru = new HashSet<TblInfracaoFinanceiroGru>();
        }

        public int CodigoInfracaoFinanceiroGrutipoValor { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroDebito> TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrundr1tipoValorNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroDebito> TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrundr2tipoValorNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroDebito> TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrunptipoValorNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroDebito> TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrutipoValorNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroGru> TblInfracaoFinanceiroGru { get; set; }
    }
}
