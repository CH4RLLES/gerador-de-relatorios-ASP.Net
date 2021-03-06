using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoSolicitacaoAdvertenciaCausaNaoConhecer
    {
        public TblInfracaoSolicitacaoAdvertenciaCausaNaoConhecer()
        {
            TblInfracaoSolicitacaoAdvertenciaNaoConhecer = new HashSet<TblInfracaoSolicitacaoAdvertenciaNaoConhecer>();
        }

        public int CodigoInfracaoSolicitacaoAdvertenciaCausaNaoConhecer { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TblInfracaoSolicitacaoAdvertenciaNaoConhecer> TblInfracaoSolicitacaoAdvertenciaNaoConhecer { get; set; }
    }
}
