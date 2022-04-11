using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoSolicitacaoAdvertenciaEvento
    {
        public long CodigoInfracaoSolicitacaoAdvertenciaEvento { get; set; }
        public long CodigoInfracaoSolicitacaoAdvertencia { get; set; }
        public int CodigoInfracaoSolicitacaoAdvertenciaSituacao { get; set; }
        public int CodigoInfracaoSolicitacaoAdvertenciaFase { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblInfracaoSolicitacaoAdvertenciaFase CodigoInfracaoSolicitacaoAdvertenciaFaseNavigation { get; set; }
        public virtual TblInfracaoSolicitacaoAdvertencia CodigoInfracaoSolicitacaoAdvertenciaNavigation { get; set; }
        public virtual TblInfracaoSolicitacaoAdvertenciaSituacao CodigoInfracaoSolicitacaoAdvertenciaSituacaoNavigation { get; set; }
    }
}
