using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvestudoIndicadorComparacaoVelocidade
    {
        public TblPncvestudoIndicadorComparacaoVelocidade()
        {
            TblPncvestudoTecnicoInstalacaoFaixa = new HashSet<TblPncvestudoTecnicoInstalacaoFaixa>();
        }

        public int CodigoPncvestudoIndicadorComparacaoVelocidade { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoTecnicoInstalacaoFaixa> TblPncvestudoTecnicoInstalacaoFaixa { get; set; }
    }
}
