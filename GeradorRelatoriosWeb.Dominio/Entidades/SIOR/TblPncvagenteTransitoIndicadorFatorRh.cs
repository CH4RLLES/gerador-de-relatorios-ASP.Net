using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvagenteTransitoIndicadorFatorRh
    {
        public TblPncvagenteTransitoIndicadorFatorRh()
        {
            TblPncvagenteTransitoCredenciamentoCredencial = new HashSet<TblPncvagenteTransitoCredenciamentoCredencial>();
        }

        public int CodigoPncvagenteTransitoIndicadorFatorRh { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvagenteTransitoCredenciamentoCredencial> TblPncvagenteTransitoCredenciamentoCredencial { get; set; }
    }
}
