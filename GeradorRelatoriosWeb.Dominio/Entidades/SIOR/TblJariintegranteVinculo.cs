using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
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
