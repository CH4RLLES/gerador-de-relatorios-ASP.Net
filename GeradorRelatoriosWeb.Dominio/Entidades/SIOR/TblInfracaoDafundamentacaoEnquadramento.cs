using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
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
