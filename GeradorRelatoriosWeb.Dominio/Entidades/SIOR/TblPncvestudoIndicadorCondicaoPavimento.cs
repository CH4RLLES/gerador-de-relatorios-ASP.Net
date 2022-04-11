using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoIndicadorCondicaoPavimento
    {
        public TblPncvestudoIndicadorCondicaoPavimento()
        {
            TblPncvestudoTecnicoInstalacaoFaixa = new HashSet<TblPncvestudoTecnicoInstalacaoFaixa>();
            TblPncvestudoTecnicoMonitoramentoFaixa = new HashSet<TblPncvestudoTecnicoMonitoramentoFaixa>();
            TblPncvestudoViabilidadeFaixa = new HashSet<TblPncvestudoViabilidadeFaixa>();
        }

        public int CodigoPncvestudoIndicadorCondicaoPavimento { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoTecnicoInstalacaoFaixa> TblPncvestudoTecnicoInstalacaoFaixa { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramentoFaixa> TblPncvestudoTecnicoMonitoramentoFaixa { get; set; }
        public virtual ICollection<TblPncvestudoViabilidadeFaixa> TblPncvestudoViabilidadeFaixa { get; set; }
    }
}
