using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoIndicadorRelevo
    {
        public TblPncvestudoIndicadorRelevo()
        {
            TblPncvestudoTecnicoInstalacao = new HashSet<TblPncvestudoTecnicoInstalacao>();
            TblPncvestudoTecnicoMonitoramento = new HashSet<TblPncvestudoTecnicoMonitoramento>();
            TblPncvestudoViabilidade = new HashSet<TblPncvestudoViabilidade>();
        }

        public int CodigoPncvestudoIndicadorRelevo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoTecnicoInstalacao> TblPncvestudoTecnicoInstalacao { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramento> TblPncvestudoTecnicoMonitoramento { get; set; }
        public virtual ICollection<TblPncvestudoViabilidade> TblPncvestudoViabilidade { get; set; }
    }
}
