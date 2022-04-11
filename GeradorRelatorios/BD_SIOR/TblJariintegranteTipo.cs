using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblJariintegranteTipo
    {
        public TblJariintegranteTipo()
        {
            TblJariintegrante = new HashSet<TblJariintegrante>();
        }

        public int CodigoJariintegranteTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblJariintegrante> TblJariintegrante { get; set; }
    }
}
