using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoDaalegacaoEnquadramento
    {
        public int CodigoInfracaoDaalegacaoEnquadramento { get; set; }
        public int CodigoInfracaoDaalegacao { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }

        public virtual TblInfracaoDaalegacao CodigoInfracaoDaalegacaoNavigation { get; set; }
        public virtual TblInfracaoEnquadramento CodigoInfracaoEnquadramentoNavigation { get; set; }
    }
}
