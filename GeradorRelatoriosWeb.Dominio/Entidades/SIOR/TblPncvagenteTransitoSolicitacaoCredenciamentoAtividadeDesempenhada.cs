using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada
    {
        public int CodigoPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada { get; set; }
        public int CodigoPncvagenteTransitoSolicitacaoCredenciamento { get; set; }
        public int CodigoPncvagenteTransitoAtividadeDesempenhada { get; set; }

        public virtual TblPncvagenteTransitoAtividadeDesempenhada CodigoPncvagenteTransitoAtividadeDesempenhadaNavigation { get; set; }
        public virtual TblPncvagenteTransitoSolicitacaoCredenciamento CodigoPncvagenteTransitoSolicitacaoCredenciamentoNavigation { get; set; }
    }
}
