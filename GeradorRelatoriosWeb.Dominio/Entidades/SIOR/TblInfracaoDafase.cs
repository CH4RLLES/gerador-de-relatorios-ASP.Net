using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoDafase
    {
        public TblInfracaoDafase()
        {
            TblInfracaoDa = new HashSet<TblInfracaoDa>();
            TblInfracaoDaevento = new HashSet<TblInfracaoDaevento>();
        }

        public int CodigoInfracaoDafase { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoDa> TblInfracaoDa { get; set; }
        public virtual ICollection<TblInfracaoDaevento> TblInfracaoDaevento { get; set; }
    }
}
