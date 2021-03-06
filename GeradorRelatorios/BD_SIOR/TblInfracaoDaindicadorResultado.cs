using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoDaindicadorResultado
    {
        public TblInfracaoDaindicadorResultado()
        {
            TblInfracaoDa = new HashSet<TblInfracaoDa>();
        }

        public int CodigoInfracaoDaindicadorResultado { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoDa> TblInfracaoDa { get; set; }
    }
}
