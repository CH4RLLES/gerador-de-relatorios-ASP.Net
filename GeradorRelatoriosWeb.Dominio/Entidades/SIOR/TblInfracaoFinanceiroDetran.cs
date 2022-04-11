using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroDetran
    {
        public TblInfracaoFinanceiroDetran()
        {
            TblInfracaoFinanceiroPagamentoDetran = new HashSet<TblInfracaoFinanceiroPagamentoDetran>();
            TblInfracaoFinanceiroRepasseDetran = new HashSet<TblInfracaoFinanceiroRepasseDetran>();
        }

        public int CodigoInfracaoFinanceiroDetran { get; set; }
        public int CodigoBaseGrucodigoRecolhimentoTes { get; set; }
        public string SiglaUf { get; set; }
        public string Nome { get; set; }
        public string NumeroCnpj { get; set; }

        public virtual TblBaseGruCodigoRecolhimentoTes CodigoBaseGrucodigoRecolhimentoTesNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroPagamentoDetran> TblInfracaoFinanceiroPagamentoDetran { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroRepasseDetran> TblInfracaoFinanceiroRepasseDetran { get; set; }
    }
}
