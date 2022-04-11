using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvagenteTransitoIndicadorVinculo
    {
        public TblPncvagenteTransitoIndicadorVinculo()
        {
            TblPncvagenteTransitoCredenciamento = new HashSet<TblPncvagenteTransitoCredenciamento>();
            TblPncvagenteTransitoCredenciamentoCredencial = new HashSet<TblPncvagenteTransitoCredenciamentoCredencial>();
            TblPncvagenteTransitoSolicitacaoCredenciamento = new HashSet<TblPncvagenteTransitoSolicitacaoCredenciamento>();
        }

        public int CodigoPncvagenteTransitoIndicadorVinculo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvagenteTransitoCredenciamento> TblPncvagenteTransitoCredenciamento { get; set; }
        public virtual ICollection<TblPncvagenteTransitoCredenciamentoCredencial> TblPncvagenteTransitoCredenciamentoCredencial { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoCredenciamento> TblPncvagenteTransitoSolicitacaoCredenciamento { get; set; }
    }
}
