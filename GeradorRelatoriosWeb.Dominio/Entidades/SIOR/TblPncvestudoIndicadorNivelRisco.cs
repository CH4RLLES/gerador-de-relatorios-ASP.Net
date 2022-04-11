using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoIndicadorNivelRisco
    {
        public TblPncvestudoIndicadorNivelRisco()
        {
            TblPncvestudoViabilidade = new HashSet<TblPncvestudoViabilidade>();
        }

        public int CodigoPncvestudoIndicadorNivelRisco { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoViabilidade> TblPncvestudoViabilidade { get; set; }
    }
}
