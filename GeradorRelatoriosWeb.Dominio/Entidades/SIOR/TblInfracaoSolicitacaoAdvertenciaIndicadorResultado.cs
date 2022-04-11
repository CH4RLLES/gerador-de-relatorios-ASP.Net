using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoSolicitacaoAdvertenciaIndicadorResultado
    {
        public TblInfracaoSolicitacaoAdvertenciaIndicadorResultado()
        {
            TblInfracaoSolicitacaoAdvertencia = new HashSet<TblInfracaoSolicitacaoAdvertencia>();
        }

        public int CodigoInfracaoSolicitacaoAdvertenciaIndicadorResultado { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoSolicitacaoAdvertencia> TblInfracaoSolicitacaoAdvertencia { get; set; }
    }
}
