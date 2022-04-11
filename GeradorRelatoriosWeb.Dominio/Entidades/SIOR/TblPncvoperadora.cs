using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvoperadora
    {
        public TblPncvoperadora()
        {
            TblPncveditalLote = new HashSet<TblPncveditalLote>();
        }

        public int CodigoPncvoperadora { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncveditalLote> TblPncveditalLote { get; set; }
    }
}
