using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblJariintegranteVinculo
    {
        public TblJariintegranteVinculo()
        {
            TblJariintegrante = new HashSet<TblJariintegrante>();
        }

        public int CodigoJariintegranteVinculo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblJariintegrante> TblJariintegrante { get; set; }
    }
}
