using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvestudoViabilidadeOrigem
    {
        public TblPncvestudoViabilidadeOrigem()
        {
            TblPncvestudoViabilidade = new HashSet<TblPncvestudoViabilidade>();
        }

        public int CodigoPncvestudoViabilidadeOrigem { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoViabilidade> TblPncvestudoViabilidade { get; set; }
    }
}
