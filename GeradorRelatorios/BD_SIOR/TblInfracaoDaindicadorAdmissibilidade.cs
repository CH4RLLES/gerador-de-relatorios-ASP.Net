using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoDaindicadorAdmissibilidade
    {
        public TblInfracaoDaindicadorAdmissibilidade()
        {
            TblInfracaoDa = new HashSet<TblInfracaoDa>();
        }

        public int CodigoInfracaoDaindicadorAdmissibilidade { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoDa> TblInfracaoDa { get; set; }
    }
}
