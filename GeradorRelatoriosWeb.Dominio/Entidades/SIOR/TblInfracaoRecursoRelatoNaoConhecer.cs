using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoRecursoRelatoNaoConhecer
    {
        public long CodigoInfracaoRecursoRelatoNaoConhecer { get; set; }
        public long CodigoInfracaoRecurso { get; set; }
        public int CodigoInfracaoRecursoCausaNaoConhecer { get; set; }

        public virtual TblInfracaoRecursoCausaNaoConhecer CodigoInfracaoRecursoCausaNaoConhecerNavigation { get; set; }
        public virtual TblInfracaoRecurso CodigoInfracaoRecursoNavigation { get; set; }
    }
}
