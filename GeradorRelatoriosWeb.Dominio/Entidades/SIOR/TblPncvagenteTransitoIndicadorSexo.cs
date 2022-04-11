using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvagenteTransitoIndicadorSexo
    {
        public TblPncvagenteTransitoIndicadorSexo()
        {
            TblPncvagenteTransitoCredenciamentoCredencial = new HashSet<TblPncvagenteTransitoCredenciamentoCredencial>();
        }

        public int CodigoPncvagenteTransitoIndicadorSexo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvagenteTransitoCredenciamentoCredencial> TblPncvagenteTransitoCredenciamentoCredencial { get; set; }
    }
}
