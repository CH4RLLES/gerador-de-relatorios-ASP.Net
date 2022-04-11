using System;
using System.Collections.Generic;

namespace GeradorRelatorios
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
