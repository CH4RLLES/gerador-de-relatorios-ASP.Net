using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvagenteTransitoSolicitacaoCredenciamentoEvento
    {
        public long CodigoPncvagenteTransitoSolicitacaoCredenciamentoEvento { get; set; }
        public int CodigoPncvagenteTransitoSolicitacaoCredenciamento { get; set; }
        public int CodigoPncvagenteTransitoSolicitacaoCredenciamentoSituacao { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblPncvagenteTransitoSolicitacaoCredenciamento CodigoPncvagenteTransitoSolicitacaoCredenciamentoNavigation { get; set; }
        public virtual TblPncvagenteTransitoSolicitacaoCredenciamentoSituacao CodigoPncvagenteTransitoSolicitacaoCredenciamentoSituacaoNavigation { get; set; }
    }
}
