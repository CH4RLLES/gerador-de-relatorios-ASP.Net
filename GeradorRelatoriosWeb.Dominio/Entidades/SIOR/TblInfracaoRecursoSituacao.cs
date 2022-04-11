using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoRecursoSituacao
    {
        public TblInfracaoRecursoSituacao()
        {
            TblInfracaoRecurso = new HashSet<TblInfracaoRecurso>();
            TblInfracaoRecursoEvento = new HashSet<TblInfracaoRecursoEvento>();
        }

        public int CodigoInfracaoRecursoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecurso { get; set; }
        public virtual ICollection<TblInfracaoRecursoEvento> TblInfracaoRecursoEvento { get; set; }
    }
}
