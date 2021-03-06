using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaSolicitacaoAcessoSituacao
    {
        public TblSistemaSolicitacaoAcessoSituacao()
        {
            TblSistemaSolicitacaoAcesso = new HashSet<TblSistemaSolicitacaoAcesso>();
        }

        public int CodigoSistemaSolicitacaoAcessoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblSistemaSolicitacaoAcesso> TblSistemaSolicitacaoAcesso { get; set; }
    }
}
