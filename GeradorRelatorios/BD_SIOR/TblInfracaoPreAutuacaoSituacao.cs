using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoPreAutuacaoSituacao
    {
        public TblInfracaoPreAutuacaoSituacao()
        {
            TblInfracaoPreAutuacao = new HashSet<TblInfracaoPreAutuacao>();
        }

        public int CodigoInfracaoPreAutuacaoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacao { get; set; }
    }
}
