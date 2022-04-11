using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoTecnicoMonitoramentoSituacao
    {
        public TblPncvestudoTecnicoMonitoramentoSituacao()
        {
            TblPncvestudoTecnicoMonitoramento = new HashSet<TblPncvestudoTecnicoMonitoramento>();
            TblPncvestudoTecnicoMonitoramentoEvento = new HashSet<TblPncvestudoTecnicoMonitoramentoEvento>();
        }

        public int CodigoPncvestudoTecnicoMonitoramentoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoTecnicoMonitoramento> TblPncvestudoTecnicoMonitoramento { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramentoEvento> TblPncvestudoTecnicoMonitoramentoEvento { get; set; }
    }
}
