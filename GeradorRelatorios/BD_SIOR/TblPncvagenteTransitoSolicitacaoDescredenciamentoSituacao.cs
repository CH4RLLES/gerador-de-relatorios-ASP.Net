using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvagenteTransitoSolicitacaoDescredenciamentoSituacao
    {
        public TblPncvagenteTransitoSolicitacaoDescredenciamentoSituacao()
        {
            TblPncvagenteTransitoSolicitacaoDescredenciamento = new HashSet<TblPncvagenteTransitoSolicitacaoDescredenciamento>();
            TblPncvagenteTransitoSolicitacaoDescredenciamentoEvento = new HashSet<TblPncvagenteTransitoSolicitacaoDescredenciamentoEvento>();
        }

        public int CodigoPncvagenteTransitoSolicitacaoDescredenciamentoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvagenteTransitoSolicitacaoDescredenciamento> TblPncvagenteTransitoSolicitacaoDescredenciamento { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoDescredenciamentoEvento> TblPncvagenteTransitoSolicitacaoDescredenciamentoEvento { get; set; }
    }
}
