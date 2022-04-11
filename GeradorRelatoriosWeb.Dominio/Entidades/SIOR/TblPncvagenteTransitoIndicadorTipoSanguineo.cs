using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvagenteTransitoIndicadorTipoSanguineo
    {
        public TblPncvagenteTransitoIndicadorTipoSanguineo()
        {
            TblPncvagenteTransitoCredenciamentoCredencial = new HashSet<TblPncvagenteTransitoCredenciamentoCredencial>();
        }

        public int CodigoPncvagenteTransitoIndicadorTipoSanguineo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvagenteTransitoCredenciamentoCredencial> TblPncvagenteTransitoCredenciamentoCredencial { get; set; }
    }
}
