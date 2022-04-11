using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoRecursoFundamentacaoEnquadramento
    {
        public int CodigoInfracaoRecursoFundamentacaoEnquadramento { get; set; }
        public int CodigoInfracaoRecursoFundamentacao { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }

        public virtual TblInfracaoEnquadramento CodigoInfracaoEnquadramentoNavigation { get; set; }
        public virtual TblInfracaoRecursoFundamentacao CodigoInfracaoRecursoFundamentacaoNavigation { get; set; }
    }
}
