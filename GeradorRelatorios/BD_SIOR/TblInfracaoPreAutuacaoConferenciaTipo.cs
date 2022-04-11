using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoPreAutuacaoConferenciaTipo
    {
        public TblInfracaoPreAutuacaoConferenciaTipo()
        {
            TblInfracaoPreAutuacao = new HashSet<TblInfracaoPreAutuacao>();
        }

        public int CodigoInfracaoPreAutuacaoConferenciaTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacao { get; set; }
    }
}
