using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBaseCorreiosCodigoBaixa
    {
        public TblBaseCorreiosCodigoBaixa()
        {
            TblInfracaoNotificacao = new HashSet<TblInfracaoNotificacao>();
        }

        public int CodigoBaseCorreiosCodigoBaixa { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoNotificacao> TblInfracaoNotificacao { get; set; }
    }
}
