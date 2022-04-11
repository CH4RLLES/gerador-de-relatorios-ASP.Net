using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoRecursoIndicadorResultado
    {
        public TblInfracaoRecursoIndicadorResultado()
        {
            TblInfracaoRecursoCodigoInfracaoRecursoIndicadorResultadoInstrucaoNavigation = new HashSet<TblInfracaoRecurso>();
            TblInfracaoRecursoCodigoInfracaoRecursoIndicadorResultadoJulgamentoNavigation = new HashSet<TblInfracaoRecurso>();
            TblInfracaoRecursoCodigoInfracaoRecursoIndicadorResultadoVotoRelatoNavigation = new HashSet<TblInfracaoRecurso>();
            TblJarisessaoJulgamentoPauta = new HashSet<TblJarisessaoJulgamentoPauta>();
            TblJarisessaoJulgamentoVoto = new HashSet<TblJarisessaoJulgamentoVoto>();
        }

        public int CodigoInfracaoRecursoIndicadorResultado { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecursoCodigoInfracaoRecursoIndicadorResultadoInstrucaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecursoCodigoInfracaoRecursoIndicadorResultadoJulgamentoNavigation { get; set; }
        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecursoCodigoInfracaoRecursoIndicadorResultadoVotoRelatoNavigation { get; set; }
        public virtual ICollection<TblJarisessaoJulgamentoPauta> TblJarisessaoJulgamentoPauta { get; set; }
        public virtual ICollection<TblJarisessaoJulgamentoVoto> TblJarisessaoJulgamentoVoto { get; set; }
    }
}
