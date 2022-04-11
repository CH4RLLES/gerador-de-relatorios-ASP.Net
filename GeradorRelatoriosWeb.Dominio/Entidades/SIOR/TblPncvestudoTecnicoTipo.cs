using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoTecnicoTipo
    {
        public TblPncvestudoTecnicoTipo()
        {
            TblPncvestudoTecnicoMonitoramento = new HashSet<TblPncvestudoTecnicoMonitoramento>();
        }

        public int CodigoPncvestudoTecnicoTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoTecnicoMonitoramento> TblPncvestudoTecnicoMonitoramento { get; set; }
    }
}
