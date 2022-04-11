using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
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
