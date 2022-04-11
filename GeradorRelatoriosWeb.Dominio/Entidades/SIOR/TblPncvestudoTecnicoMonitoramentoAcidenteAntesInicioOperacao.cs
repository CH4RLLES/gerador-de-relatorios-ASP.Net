using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoTecnicoMonitoramentoAcidenteAntesInicioOperacao
    {
        public int CodigoPncvestudoTecnicoMonitoramentoAcidenteAntesInicioOperacao { get; set; }
        public int CodigoPncvestudoTecnicoMonitoramento { get; set; }
        public int Ano { get; set; }
        public int QuantidadeAcidenteSemVitima { get; set; }
        public int QuantidadeAcidenteComFeridoNaoAtropelado { get; set; }
        public int QuantidadeAcidenteComFeridoAtropelado { get; set; }
        public int QuantidadeAcidenteComMorto { get; set; }
        public int Ups { get; set; }

        public virtual TblPncvestudoTecnicoMonitoramento CodigoPncvestudoTecnicoMonitoramentoNavigation { get; set; }
    }
}
