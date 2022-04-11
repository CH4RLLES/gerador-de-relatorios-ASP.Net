using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvagenteTransitoIndicadorResultadoVerificacao
    {
        public TblPncvagenteTransitoIndicadorResultadoVerificacao()
        {
            TblPncvagenteTransitoSolicitacaoCredenciamentoCodigoPncvagenteTransitoIndicadorResultadoVerificacaoPortariaNavigation = new HashSet<TblPncvagenteTransitoSolicitacaoCredenciamento>();
            TblPncvagenteTransitoSolicitacaoCredenciamentoCodigoPncvagenteTransitoIndicadorResultadoVerificacaoSolicitacaoNavigation = new HashSet<TblPncvagenteTransitoSolicitacaoCredenciamento>();
            TblPncvagenteTransitoSolicitacaoDescredenciamento = new HashSet<TblPncvagenteTransitoSolicitacaoDescredenciamento>();
        }

        public int CodigoPncvagenteTransitoIndicadorResultadoVerificacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvagenteTransitoSolicitacaoCredenciamento> TblPncvagenteTransitoSolicitacaoCredenciamentoCodigoPncvagenteTransitoIndicadorResultadoVerificacaoPortariaNavigation { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoCredenciamento> TblPncvagenteTransitoSolicitacaoCredenciamentoCodigoPncvagenteTransitoIndicadorResultadoVerificacaoSolicitacaoNavigation { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoDescredenciamento> TblPncvagenteTransitoSolicitacaoDescredenciamento { get; set; }
    }
}
