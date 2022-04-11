using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroDebitoSituacao
    {
        public TblInfracaoFinanceiroDebitoSituacao()
        {
            TblInfracaoFinanceiroDebito = new HashSet<TblInfracaoFinanceiroDebito>();
            TblInfracaoFinanceiroDebitoEvento = new HashSet<TblInfracaoFinanceiroDebitoEvento>();
        }

        public int CodigoInfracaoFinanceiroDebitoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroDebito> TblInfracaoFinanceiroDebito { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroDebitoEvento> TblInfracaoFinanceiroDebitoEvento { get; set; }
    }
}
