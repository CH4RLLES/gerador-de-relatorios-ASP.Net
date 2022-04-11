using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidade
    {
        public TblInfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidade()
        {
            TblInfracaoSolicitacaoAdvertencia = new HashSet<TblInfracaoSolicitacaoAdvertencia>();
        }

        public int CodigoInfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidade { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoSolicitacaoAdvertencia> TblInfracaoSolicitacaoAdvertencia { get; set; }
    }
}
