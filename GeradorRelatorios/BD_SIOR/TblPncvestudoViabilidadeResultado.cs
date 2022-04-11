using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvestudoViabilidadeResultado
    {
        public TblPncvestudoViabilidadeResultado()
        {
            TblPncvestudoViabilidade = new HashSet<TblPncvestudoViabilidade>();
        }

        public int CodigoPncvestudoViabilidadeResultado { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoViabilidade> TblPncvestudoViabilidade { get; set; }
    }
}
