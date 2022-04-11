using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoCausaCancelamento
    {
        public TblInfracaoCausaCancelamento()
        {
            TblInfracao = new HashSet<TblInfracao>();
        }

        public int CodigoInfracaoCausaCancelamento { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
    }
}
