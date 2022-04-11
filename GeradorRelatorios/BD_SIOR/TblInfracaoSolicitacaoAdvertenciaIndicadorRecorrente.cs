using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoSolicitacaoAdvertenciaIndicadorRecorrente
    {
        public TblInfracaoSolicitacaoAdvertenciaIndicadorRecorrente()
        {
            TblInfracaoSolicitacaoAdvertencia = new HashSet<TblInfracaoSolicitacaoAdvertencia>();
        }

        public int CodigoInfracaoSolicitacaoAdvertenciaIndicadorRecorrente { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoSolicitacaoAdvertencia> TblInfracaoSolicitacaoAdvertencia { get; set; }
    }
}
