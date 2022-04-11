using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoExpedicaoEvento
    {
        public long CodigoInfracaoNotificacaoExpedicaoEvento { get; set; }
        public long CodigoInfracaoNotificacaoExpedicao { get; set; }
        public int CodigoInfracaoNotificacaoExpedicaoSituacao { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }
        public int CodigoInfracaoNotificacaoExpedicaoFase { get; set; }

        public virtual TblInfracaoNotificacaoExpedicaoFase CodigoInfracaoNotificacaoExpedicaoFaseNavigation { get; set; }
        public virtual TblInfracaoNotificacaoExpedicao CodigoInfracaoNotificacaoExpedicaoNavigation { get; set; }
        public virtual TblInfracaoNotificacaoExpedicaoSituacao CodigoInfracaoNotificacaoExpedicaoSituacaoNavigation { get; set; }
    }
}
