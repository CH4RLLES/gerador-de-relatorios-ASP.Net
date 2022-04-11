using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoTecnicoMonitoramentoEvento
    {
        public int CodigoPncvestudoTecnicoMonitoramentoEvento { get; set; }
        public int CodigoPncvestudoTecnicoMonitoramento { get; set; }
        public int CodigoPncvestudoTecnicoMonitoramentoSituacao { get; set; }
        public DateTime? Data { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblPncvestudoTecnicoMonitoramento CodigoPncvestudoTecnicoMonitoramentoNavigation { get; set; }
        public virtual TblPncvestudoTecnicoMonitoramentoSituacao CodigoPncvestudoTecnicoMonitoramentoSituacaoNavigation { get; set; }
    }
}
