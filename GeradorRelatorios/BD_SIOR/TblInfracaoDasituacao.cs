using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoDasituacao
    {
        public TblInfracaoDasituacao()
        {
            TblInfracaoDa = new HashSet<TblInfracaoDa>();
            TblInfracaoDaevento = new HashSet<TblInfracaoDaevento>();
        }

        public int CodigoInfracaoDasituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoDa> TblInfracaoDa { get; set; }
        public virtual ICollection<TblInfracaoDaevento> TblInfracaoDaevento { get; set; }
    }
}
