using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroRepasseDetransituacao
    {
        public TblInfracaoFinanceiroRepasseDetransituacao()
        {
            TblInfracaoFinanceiroRepasseDetran = new HashSet<TblInfracaoFinanceiroRepasseDetran>();
            TblInfracaoFinanceiroRepasseDetranevento = new HashSet<TblInfracaoFinanceiroRepasseDetranevento>();
        }

        public int CodigoInfracaoFinanceiroRepasseDetransituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroRepasseDetran> TblInfracaoFinanceiroRepasseDetran { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroRepasseDetranevento> TblInfracaoFinanceiroRepasseDetranevento { get; set; }
    }
}
