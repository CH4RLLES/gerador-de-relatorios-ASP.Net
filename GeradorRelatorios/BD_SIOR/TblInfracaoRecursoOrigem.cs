using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoRecursoOrigem
    {
        public TblInfracaoRecursoOrigem()
        {
            TblInfracaoRecurso = new HashSet<TblInfracaoRecurso>();
        }

        public int CodigoInfracaoRecursoOrigem { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecurso { get; set; }
    }
}
