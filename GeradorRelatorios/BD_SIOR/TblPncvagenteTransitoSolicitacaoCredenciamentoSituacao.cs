using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvagenteTransitoSolicitacaoCredenciamentoSituacao
    {
        public TblPncvagenteTransitoSolicitacaoCredenciamentoSituacao()
        {
            TblPncvagenteTransitoSolicitacaoCredenciamento = new HashSet<TblPncvagenteTransitoSolicitacaoCredenciamento>();
            TblPncvagenteTransitoSolicitacaoCredenciamentoEvento = new HashSet<TblPncvagenteTransitoSolicitacaoCredenciamentoEvento>();
        }

        public int CodigoPncvagenteTransitoSolicitacaoCredenciamentoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvagenteTransitoSolicitacaoCredenciamento> TblPncvagenteTransitoSolicitacaoCredenciamento { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoCredenciamentoEvento> TblPncvagenteTransitoSolicitacaoCredenciamentoEvento { get; set; }
    }
}
