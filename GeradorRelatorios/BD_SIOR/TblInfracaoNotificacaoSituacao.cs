using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoNotificacaoSituacao
    {
        public TblInfracaoNotificacaoSituacao()
        {
            TblInfracaoNotificacao = new HashSet<TblInfracaoNotificacao>();
        }

        public int CodigoInfracaoNotificacaoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoNotificacao> TblInfracaoNotificacao { get; set; }
    }
}
