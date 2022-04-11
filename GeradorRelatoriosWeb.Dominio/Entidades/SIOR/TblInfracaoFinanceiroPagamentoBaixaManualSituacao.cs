using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroPagamentoBaixaManualSituacao
    {
        public TblInfracaoFinanceiroPagamentoBaixaManualSituacao()
        {
            TblInfracaoFinanceiroPagamentoBaixaManual = new HashSet<TblInfracaoFinanceiroPagamentoBaixaManual>();
            TblInfracaoFinanceiroPagamentoBaixaManualEvento = new HashSet<TblInfracaoFinanceiroPagamentoBaixaManualEvento>();
        }

        public int CodigoInfracaoFinanceiroPagamentoBaixaManualSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroPagamentoBaixaManual> TblInfracaoFinanceiroPagamentoBaixaManual { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroPagamentoBaixaManualEvento> TblInfracaoFinanceiroPagamentoBaixaManualEvento { get; set; }
    }
}
