using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoIndicadorTransito
    {
        public TblPncvestudoIndicadorTransito()
        {
            TblPncvestudoTecnicoInstalacaoCodigoPncvestudoIndicadorTransitoCiclistaNavigation = new HashSet<TblPncvestudoTecnicoInstalacao>();
            TblPncvestudoTecnicoInstalacaoCodigoPncvestudoIndicadorTransitoPedestreNavigation = new HashSet<TblPncvestudoTecnicoInstalacao>();
            TblPncvestudoTecnicoMonitoramentoCodigoPncvestudoIndicadorTransitoCiclistaNavigation = new HashSet<TblPncvestudoTecnicoMonitoramento>();
            TblPncvestudoTecnicoMonitoramentoCodigoPncvestudoIndicadorTransitoPedestreNavigation = new HashSet<TblPncvestudoTecnicoMonitoramento>();
            TblPncvestudoViabilidadeCodigoPncvestudoIndicadorTransitoCiclistaNavigation = new HashSet<TblPncvestudoViabilidade>();
            TblPncvestudoViabilidadeCodigoPncvestudoIndicadorTransitoPedestreNavigation = new HashSet<TblPncvestudoViabilidade>();
        }

        public int CodigoPncvestudoIndicadorTransito { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoTecnicoInstalacao> TblPncvestudoTecnicoInstalacaoCodigoPncvestudoIndicadorTransitoCiclistaNavigation { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacao> TblPncvestudoTecnicoInstalacaoCodigoPncvestudoIndicadorTransitoPedestreNavigation { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramento> TblPncvestudoTecnicoMonitoramentoCodigoPncvestudoIndicadorTransitoCiclistaNavigation { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramento> TblPncvestudoTecnicoMonitoramentoCodigoPncvestudoIndicadorTransitoPedestreNavigation { get; set; }
        public virtual ICollection<TblPncvestudoViabilidade> TblPncvestudoViabilidadeCodigoPncvestudoIndicadorTransitoCiclistaNavigation { get; set; }
        public virtual ICollection<TblPncvestudoViabilidade> TblPncvestudoViabilidadeCodigoPncvestudoIndicadorTransitoPedestreNavigation { get; set; }
    }
}
