using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoOrigem
    {
        public TblInfracaoOrigem()
        {
            TblCobrancaInfracao = new HashSet<TblCobrancaInfracao>();
            TblInfracao = new HashSet<TblInfracao>();
            TblInfracaoPreAutuacao = new HashSet<TblInfracaoPreAutuacao>();
        }

        public int CodigoInfracaoOrigem { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracao { get; set; }
        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacao { get; set; }
    }
}
