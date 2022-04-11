using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoRecursoTipo
    {
        public TblInfracaoRecursoTipo()
        {
            TblInfracaoRecurso = new HashSet<TblInfracaoRecurso>();
            TblJarisessaoJulgamento = new HashSet<TblJarisessaoJulgamento>();
        }

        public int CodigoInfracaoRecursoTipo { get; set; }
        public string Nome { get; set; }
        public string OrgaoJulgador { get; set; }

        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecurso { get; set; }
        public virtual ICollection<TblJarisessaoJulgamento> TblJarisessaoJulgamento { get; set; }
    }
}
