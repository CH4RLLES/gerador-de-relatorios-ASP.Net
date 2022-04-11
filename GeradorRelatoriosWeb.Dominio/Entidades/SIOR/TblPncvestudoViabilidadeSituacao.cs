using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoViabilidadeSituacao
    {
        public TblPncvestudoViabilidadeSituacao()
        {
            TblPncvestudoViabilidade = new HashSet<TblPncvestudoViabilidade>();
            TblPncvestudoViabilidadeEvento = new HashSet<TblPncvestudoViabilidadeEvento>();
        }

        public int CodigoPncvestudoViabilidadeSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoViabilidade> TblPncvestudoViabilidade { get; set; }
        public virtual ICollection<TblPncvestudoViabilidadeEvento> TblPncvestudoViabilidadeEvento { get; set; }
    }
}
