using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoRecursoIndicadorAdmissibilidade
    {
        public TblInfracaoRecursoIndicadorAdmissibilidade()
        {
            TblInfracaoRecursoCodigoInfracaoRecursoIndicadorAdmissibilidadeInstrucaoNavigation = new HashSet<TblInfracaoRecurso>();
            TblInfracaoRecursoCodigoInfracaoRecursoIndicadorAdmissibilidadeRelatoNavigation = new HashSet<TblInfracaoRecurso>();
        }

        public int CodigoInfracaoRecursoIndicadorAdmissibilidade { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecursoCodigoInfracaoRecursoIndicadorAdmissibilidadeInstrucaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecursoCodigoInfracaoRecursoIndicadorAdmissibilidadeRelatoNavigation { get; set; }
    }
}
