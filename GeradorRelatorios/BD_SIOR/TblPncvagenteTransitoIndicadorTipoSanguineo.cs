using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvagenteTransitoIndicadorTipoSanguineo
    {
        public TblPncvagenteTransitoIndicadorTipoSanguineo()
        {
            TblPncvagenteTransitoCredenciamento = new HashSet<TblPncvagenteTransitoCredenciamento>();
            TblPncvagenteTransitoSolicitacaoCredenciamento = new HashSet<TblPncvagenteTransitoSolicitacaoCredenciamento>();
        }

        public int CodigoPncvagenteTransitoIndicadorTipoSanguineo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvagenteTransitoCredenciamento> TblPncvagenteTransitoCredenciamento { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoCredenciamento> TblPncvagenteTransitoSolicitacaoCredenciamento { get; set; }
    }
}
