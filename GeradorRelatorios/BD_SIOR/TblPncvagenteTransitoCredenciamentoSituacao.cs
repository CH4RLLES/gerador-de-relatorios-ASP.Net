using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvagenteTransitoCredenciamentoSituacao
    {
        public TblPncvagenteTransitoCredenciamentoSituacao()
        {
            TblPncvagenteTransitoCredenciamento = new HashSet<TblPncvagenteTransitoCredenciamento>();
            TblPncvagenteTransitoCredenciamentoEvento = new HashSet<TblPncvagenteTransitoCredenciamentoEvento>();
        }

        public int CodigoPncvagenteTransitoCredenciamentoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvagenteTransitoCredenciamento> TblPncvagenteTransitoCredenciamento { get; set; }
        public virtual ICollection<TblPncvagenteTransitoCredenciamentoEvento> TblPncvagenteTransitoCredenciamentoEvento { get; set; }
    }
}
