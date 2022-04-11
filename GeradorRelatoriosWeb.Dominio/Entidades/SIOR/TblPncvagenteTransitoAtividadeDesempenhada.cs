using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvagenteTransitoAtividadeDesempenhada
    {
        public TblPncvagenteTransitoAtividadeDesempenhada()
        {
            TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada = new HashSet<TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada>();
            TblPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada = new HashSet<TblPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada>();
        }

        public int CodigoPncvagenteTransitoAtividadeDesempenhada { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada> TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada> TblPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada { get; set; }
    }
}
