using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
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
