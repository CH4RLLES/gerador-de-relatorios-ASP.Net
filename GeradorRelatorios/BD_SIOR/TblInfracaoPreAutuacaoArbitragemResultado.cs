using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoPreAutuacaoArbitragemResultado
    {
        public TblInfracaoPreAutuacaoArbitragemResultado()
        {
            TblInfracaoPreAutuacao = new HashSet<TblInfracaoPreAutuacao>();
        }

        public int CodigoInfracaoPreAutuacaoArbitragemResultado { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacao { get; set; }
    }
}
