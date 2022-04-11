using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoEnquadramentoTipoInfracional
    {
        public TblInfracaoEnquadramentoTipoInfracional()
        {
            TblInfracaoEnquadramento = new HashSet<TblInfracaoEnquadramento>();
        }

        public int CodigoInfracaoEnquadramentoTipoInfracional { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoEnquadramento> TblInfracaoEnquadramento { get; set; }
    }
}
