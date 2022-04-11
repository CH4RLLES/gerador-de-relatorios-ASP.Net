using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvestudoIndicadorCondicaoPavimento
    {
        public TblPncvestudoIndicadorCondicaoPavimento()
        {
            TblPncvestudoTecnicoInstalacaoFaixa = new HashSet<TblPncvestudoTecnicoInstalacaoFaixa>();
            TblPncvestudoViabilidadeFaixa = new HashSet<TblPncvestudoViabilidadeFaixa>();
        }

        public int CodigoPncvestudoIndicadorCondicaoPavimento { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoTecnicoInstalacaoFaixa> TblPncvestudoTecnicoInstalacaoFaixa { get; set; }
        public virtual ICollection<TblPncvestudoViabilidadeFaixa> TblPncvestudoViabilidadeFaixa { get; set; }
    }
}
