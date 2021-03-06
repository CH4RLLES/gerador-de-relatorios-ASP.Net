using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoSolicitacaoAdvertenciaNaoConhecer
    {
        public long CodigoInfracaoSolicitacaoAdvertenciaNaoConhecer { get; set; }
        public long CodigoInfracaoSolicitacaoAdvertencia { get; set; }
        public int CodigoInfracaoSolicitacaoAdvertenciaCausaNaoConhecer { get; set; }

        public virtual TblInfracaoSolicitacaoAdvertenciaCausaNaoConhecer CodigoInfracaoSolicitacaoAdvertenciaCausaNaoConhecerNavigation { get; set; }
        public virtual TblInfracaoSolicitacaoAdvertencia CodigoInfracaoSolicitacaoAdvertenciaNavigation { get; set; }
    }
}
