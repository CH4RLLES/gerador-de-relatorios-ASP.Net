using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblJarisessaoJulgamentoSituacao
    {
        public TblJarisessaoJulgamentoSituacao()
        {
            TblJarisessaoJulgamento = new HashSet<TblJarisessaoJulgamento>();
            TblJarisessaoJulgamentoEvento = new HashSet<TblJarisessaoJulgamentoEvento>();
        }

        public int CodigoJarisessaoJulgamentoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblJarisessaoJulgamento> TblJarisessaoJulgamento { get; set; }
        public virtual ICollection<TblJarisessaoJulgamentoEvento> TblJarisessaoJulgamentoEvento { get; set; }
    }
}
