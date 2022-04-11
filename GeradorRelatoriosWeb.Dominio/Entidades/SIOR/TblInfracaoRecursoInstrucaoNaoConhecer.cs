using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoRecursoInstrucaoNaoConhecer
    {
        public long CodigoInfracaoRecursoInstrucaoNaoConhecer { get; set; }
        public long CodigoInfracaoRecurso { get; set; }
        public int CodigoInfracaoRecursoCausaNaoConhecer { get; set; }

        public virtual TblInfracaoRecursoCausaNaoConhecer CodigoInfracaoRecursoCausaNaoConhecerNavigation { get; set; }
        public virtual TblInfracaoRecurso CodigoInfracaoRecursoNavigation { get; set; }
    }
}
