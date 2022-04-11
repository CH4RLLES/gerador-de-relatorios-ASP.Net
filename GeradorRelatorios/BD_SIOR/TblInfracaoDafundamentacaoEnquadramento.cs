using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoDafundamentacaoEnquadramento
    {
        public int CodigoInfracaoDafundamentacaoEnquadramento { get; set; }
        public int CodigoInfracaoDafundamentacao { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }

        public virtual TblInfracaoDafundamentacao CodigoInfracaoDafundamentacaoNavigation { get; set; }
        public virtual TblInfracaoEnquadramento CodigoInfracaoEnquadramentoNavigation { get; set; }
    }
}
