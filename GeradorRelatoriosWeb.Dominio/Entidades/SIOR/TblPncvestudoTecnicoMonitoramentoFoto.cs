using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoTecnicoMonitoramentoFoto
    {
        public int CodigoPncvestudoTecnicoMonitoramentoFoto { get; set; }
        public int CodigoPncvestudoTecnicoMonitoramento { get; set; }
        public string Descricao { get; set; }
        public string ArquivoNome { get; set; }
        public string ArquivoNomeFisico { get; set; }
        public int? ArquivoTamanho { get; set; }

        public virtual TblPncvestudoTecnicoMonitoramento CodigoPncvestudoTecnicoMonitoramentoNavigation { get; set; }
    }
}
