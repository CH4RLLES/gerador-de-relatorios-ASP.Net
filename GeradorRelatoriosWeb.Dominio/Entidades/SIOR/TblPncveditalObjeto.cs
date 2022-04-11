using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncveditalObjeto
    {
        public TblPncveditalObjeto()
        {
            TblPncvedital = new HashSet<TblPncvedital>();
        }

        public int CodigoPncveditalObjeto { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvedital> TblPncvedital { get; set; }
    }
}
