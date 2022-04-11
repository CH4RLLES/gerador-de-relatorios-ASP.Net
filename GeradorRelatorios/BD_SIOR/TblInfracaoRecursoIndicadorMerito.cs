using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoRecursoIndicadorMerito
    {
        public TblInfracaoRecursoIndicadorMerito()
        {
            TblInfracaoRecursoCodigoInfracaoRecursoIndicadorMeritoInstrucaoNavigation = new HashSet<TblInfracaoRecurso>();
            TblInfracaoRecursoCodigoInfracaoRecursoIndicadorMeritoRelatoNavigation = new HashSet<TblInfracaoRecurso>();
        }

        public int CodigoInfracaoRecursoIndicadorMerito { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecursoCodigoInfracaoRecursoIndicadorMeritoInstrucaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecursoCodigoInfracaoRecursoIndicadorMeritoRelatoNavigation { get; set; }
    }
}
