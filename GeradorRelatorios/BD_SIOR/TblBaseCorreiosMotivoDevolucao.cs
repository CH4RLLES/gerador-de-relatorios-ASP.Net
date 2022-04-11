using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBaseCorreiosMotivoDevolucao
    {
        public TblBaseCorreiosMotivoDevolucao()
        {
            TblInfracaoNotificacao = new HashSet<TblInfracaoNotificacao>();
        }

        public int CodigoBaseCorreiosMotivoDevolucao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoNotificacao> TblInfracaoNotificacao { get; set; }
    }
}
