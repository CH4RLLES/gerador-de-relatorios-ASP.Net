using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoSolicitacaoAdvertenciaIndicadorMerito
    {
        public TblInfracaoSolicitacaoAdvertenciaIndicadorMerito()
        {
            TblInfracaoSolicitacaoAdvertencia = new HashSet<TblInfracaoSolicitacaoAdvertencia>();
        }

        public int CodigoInfracaoSolicitacaoAdvertenciaIndicadorMerito { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoSolicitacaoAdvertencia> TblInfracaoSolicitacaoAdvertencia { get; set; }
    }
}
