using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoFinanceiroGrusituacao
    {
        public TblInfracaoFinanceiroGrusituacao()
        {
            TblInfracaoFinanceiroGru = new HashSet<TblInfracaoFinanceiroGru>();
        }

        public int CodigoInfracaoFinanceiroGrusituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroGru> TblInfracaoFinanceiroGru { get; set; }
    }
}
