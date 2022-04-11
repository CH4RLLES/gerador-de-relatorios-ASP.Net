using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoRecursoFase
    {
        public TblInfracaoRecursoFase()
        {
            TblInfracaoRecurso = new HashSet<TblInfracaoRecurso>();
            TblInfracaoRecursoEvento = new HashSet<TblInfracaoRecursoEvento>();
        }

        public int CodigoInfracaoRecursoFase { get; set; }
        public string Nome { get; set; }
        public bool IndicadorPrimeiraInstancia { get; set; }
        public bool IndicadorSegundaInstanciaJari { get; set; }
        public bool IndicadorSegundaInstanciaContran { get; set; }

        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecurso { get; set; }
        public virtual ICollection<TblInfracaoRecursoEvento> TblInfracaoRecursoEvento { get; set; }
    }
}
