using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvestudoIndicadorDefensaMetalicaTerminal
    {
        public TblPncvestudoIndicadorDefensaMetalicaTerminal()
        {
            TblPncvestudoTecnicoInstalacaoCodigoPncvestudoIndicadorDefensaMetalicaTerminalEntradaNavigation = new HashSet<TblPncvestudoTecnicoInstalacao>();
            TblPncvestudoTecnicoInstalacaoCodigoPncvestudoIndicadorDefensaMetalicaTerminalSaidaNavigation = new HashSet<TblPncvestudoTecnicoInstalacao>();
        }

        public int CodigoPncvestudoIndicadorDefensaMetalicaTerminal { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoTecnicoInstalacao> TblPncvestudoTecnicoInstalacaoCodigoPncvestudoIndicadorDefensaMetalicaTerminalEntradaNavigation { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacao> TblPncvestudoTecnicoInstalacaoCodigoPncvestudoIndicadorDefensaMetalicaTerminalSaidaNavigation { get; set; }
    }
}
