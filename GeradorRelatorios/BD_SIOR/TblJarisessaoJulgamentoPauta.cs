using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblJarisessaoJulgamentoPauta
    {
        public long CodigoJarisessaoJulgamentoPauta { get; set; }
        public long CodigoJarisessaoJulgamento { get; set; }
        public long CodigoInfracaoRecurso { get; set; }
        public int? CodigoInfracaoRecursoIndicadorResultado { get; set; }

        public virtual TblInfracaoRecursoIndicadorResultado CodigoInfracaoRecursoIndicadorResultadoNavigation { get; set; }
        public virtual TblInfracaoRecurso CodigoInfracaoRecursoNavigation { get; set; }
        public virtual TblJarisessaoJulgamento CodigoJarisessaoJulgamentoNavigation { get; set; }
    }
}
