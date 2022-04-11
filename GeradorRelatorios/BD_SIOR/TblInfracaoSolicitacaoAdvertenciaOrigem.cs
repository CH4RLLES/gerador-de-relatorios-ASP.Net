using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoSolicitacaoAdvertenciaOrigem
    {
        public TblInfracaoSolicitacaoAdvertenciaOrigem()
        {
            TblInfracaoSolicitacaoAdvertencia = new HashSet<TblInfracaoSolicitacaoAdvertencia>();
        }

        public int CodigoInfracaoSolicitacaoAdvertenciaOrigem { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<TblInfracaoSolicitacaoAdvertencia> TblInfracaoSolicitacaoAdvertencia { get; set; }
    }
}
