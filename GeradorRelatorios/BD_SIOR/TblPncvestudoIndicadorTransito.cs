using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvestudoIndicadorTransito
    {
        public TblPncvestudoIndicadorTransito()
        {
            TblPncvestudoTecnicoInstalacaoCodigoPncvestudoIndicadorTransitoCiclistaNavigation = new HashSet<TblPncvestudoTecnicoInstalacao>();
            TblPncvestudoTecnicoInstalacaoCodigoPncvestudoIndicadorTransitoPedestreNavigation = new HashSet<TblPncvestudoTecnicoInstalacao>();
            TblPncvestudoViabilidadeCodigoPncvestudoIndicadorTransitoCiclistaNavigation = new HashSet<TblPncvestudoViabilidade>();
            TblPncvestudoViabilidadeCodigoPncvestudoIndicadorTransitoPedestreNavigation = new HashSet<TblPncvestudoViabilidade>();
        }

        public int CodigoPncvestudoIndicadorTransito { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoTecnicoInstalacao> TblPncvestudoTecnicoInstalacaoCodigoPncvestudoIndicadorTransitoCiclistaNavigation { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacao> TblPncvestudoTecnicoInstalacaoCodigoPncvestudoIndicadorTransitoPedestreNavigation { get; set; }
        public virtual ICollection<TblPncvestudoViabilidade> TblPncvestudoViabilidadeCodigoPncvestudoIndicadorTransitoCiclistaNavigation { get; set; }
        public virtual ICollection<TblPncvestudoViabilidade> TblPncvestudoViabilidadeCodigoPncvestudoIndicadorTransitoPedestreNavigation { get; set; }
    }
}
