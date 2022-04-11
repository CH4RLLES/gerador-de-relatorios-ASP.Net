using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoSolicitacaoCancelamentoInfracao
    {
        public long CodigoInfracaoSolicitacaoCancelamentoInfracao { get; set; }
        public int CodigoInfracaoSolicitacaoCancelamento { get; set; }
        public long CodigoInfracao { get; set; }
        public int? CodigoInfracaoNotificacaoTipo { get; set; }
        public string NumeroAuto { get; set; }

        public virtual TblInfracao CodigoInfracaoNavigation { get; set; }
        public virtual TblInfracaoNotificacaoTipo CodigoInfracaoNotificacaoTipoNavigation { get; set; }
        public virtual TblInfracaoSolicitacaoCancelamento CodigoInfracaoSolicitacaoCancelamentoNavigation { get; set; }
    }
}
