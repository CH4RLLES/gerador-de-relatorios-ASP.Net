using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoExpedicaoServico
    {
        public TblInfracaoNotificacaoExpedicaoServico()
        {
            TblBaseCorreiosPlanoTriagem = new HashSet<TblBaseCorreiosPlanoTriagem>();
            TblInfracaoNotificacao = new HashSet<TblInfracaoNotificacao>();
            TblInfracaoNotificacaoExpedicao = new HashSet<TblInfracaoNotificacaoExpedicao>();
        }

        public int CodigoInfracaoNotificacaoExpedicaoServico { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblBaseCorreiosPlanoTriagem> TblBaseCorreiosPlanoTriagem { get; set; }
        public virtual ICollection<TblInfracaoNotificacao> TblInfracaoNotificacao { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoExpedicao> TblInfracaoNotificacaoExpedicao { get; set; }
    }
}
