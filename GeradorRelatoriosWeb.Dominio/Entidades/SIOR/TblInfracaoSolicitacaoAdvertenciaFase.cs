using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoSolicitacaoAdvertenciaFase
    {
        public TblInfracaoSolicitacaoAdvertenciaFase()
        {
            TblInfracaoSolicitacaoAdvertencia = new HashSet<TblInfracaoSolicitacaoAdvertencia>();
            TblInfracaoSolicitacaoAdvertenciaEvento = new HashSet<TblInfracaoSolicitacaoAdvertenciaEvento>();
        }

        public int CodigoInfracaoSolicitacaoAdvertenciaFase { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoSolicitacaoAdvertencia> TblInfracaoSolicitacaoAdvertencia { get; set; }
        public virtual ICollection<TblInfracaoSolicitacaoAdvertenciaEvento> TblInfracaoSolicitacaoAdvertenciaEvento { get; set; }
    }
}
