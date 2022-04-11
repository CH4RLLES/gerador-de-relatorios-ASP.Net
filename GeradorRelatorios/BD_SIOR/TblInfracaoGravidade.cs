using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoGravidade
    {
        public TblInfracaoGravidade()
        {
            TblInfracao = new HashSet<TblInfracao>();
            TblInfracaoEnquadramentoValor = new HashSet<TblInfracaoEnquadramentoValor>();
            TblInfracaoPreAutuacao = new HashSet<TblInfracaoPreAutuacao>();
        }

        public int CodigoInfracaoGravidade { get; set; }
        public int Pontos { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
        public virtual ICollection<TblInfracaoEnquadramentoValor> TblInfracaoEnquadramentoValor { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacao { get; set; }
    }
}
