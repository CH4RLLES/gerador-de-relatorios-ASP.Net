using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
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
