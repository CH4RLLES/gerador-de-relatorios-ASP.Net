using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvequipamentoIndicadorCapturaImagem
    {
        public TblPncvequipamentoIndicadorCapturaImagem()
        {
            TblPncvestudoTecnicoInstalacaoFaixa = new HashSet<TblPncvestudoTecnicoInstalacaoFaixa>();
            TblPncvestudoTecnicoMonitoramentoFaixa = new HashSet<TblPncvestudoTecnicoMonitoramentoFaixa>();
        }

        public int CodigoPncvequipamentoIndicadorCapturaImagem { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoTecnicoInstalacaoFaixa> TblPncvestudoTecnicoInstalacaoFaixa { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramentoFaixa> TblPncvestudoTecnicoMonitoramentoFaixa { get; set; }
    }
}
