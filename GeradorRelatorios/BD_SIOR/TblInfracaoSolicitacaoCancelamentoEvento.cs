using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoSolicitacaoCancelamentoEvento
    {
        public long CodigoInfracaoSolicitacaoCancelamentoEvento { get; set; }
        public int CodigoInfracaoSolicitacaoCancelamento { get; set; }
        public int CodigoInfracaoSolicitacaoCancelamentoSituacao { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblInfracaoSolicitacaoCancelamento CodigoInfracaoSolicitacaoCancelamentoNavigation { get; set; }
        public virtual TblInfracaoSolicitacaoCancelamentoSituacao CodigoInfracaoSolicitacaoCancelamentoSituacaoNavigation { get; set; }
    }
}
