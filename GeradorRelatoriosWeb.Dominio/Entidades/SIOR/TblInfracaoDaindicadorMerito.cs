using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoDaindicadorMerito
    {
        public TblInfracaoDaindicadorMerito()
        {
            TblInfracaoDa = new HashSet<TblInfracaoDa>();
        }

        public int CodigoInfracaoDaindicadorMerito { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoDa> TblInfracaoDa { get; set; }
    }
}
