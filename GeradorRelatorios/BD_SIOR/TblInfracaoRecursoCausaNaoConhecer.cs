using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoRecursoCausaNaoConhecer
    {
        public TblInfracaoRecursoCausaNaoConhecer()
        {
            TblInfracaoRecursoInstrucaoNaoConhecer = new HashSet<TblInfracaoRecursoInstrucaoNaoConhecer>();
            TblInfracaoRecursoRelatoNaoConhecer = new HashSet<TblInfracaoRecursoRelatoNaoConhecer>();
        }

        public int CodigoInfracaoRecursoCausaNaoConhecer { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TblInfracaoRecursoInstrucaoNaoConhecer> TblInfracaoRecursoInstrucaoNaoConhecer { get; set; }
        public virtual ICollection<TblInfracaoRecursoRelatoNaoConhecer> TblInfracaoRecursoRelatoNaoConhecer { get; set; }
    }
}
