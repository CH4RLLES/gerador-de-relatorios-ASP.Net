using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoRecursoAlegacaoEnquadramento
    {
        public int CodigoInfracaoRecursoAlegacaoEnquadramento { get; set; }
        public int CodigoInfracaoRecursoAlegacao { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }

        public virtual TblInfracaoEnquadramento CodigoInfracaoEnquadramentoNavigation { get; set; }
        public virtual TblInfracaoRecursoAlegacao CodigoInfracaoRecursoAlegacaoNavigation { get; set; }
    }
}
