using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblJarisessaoJulgamentoVoto
    {
        public long CodigoJarisessaoJulgamentoVoto { get; set; }
        public long CodigoJarisessaoJulgamento { get; set; }
        public long CodigoInfracaoRecurso { get; set; }
        public int CodigoSistemaUsuario { get; set; }
        public int? CodigoInfracaoRecursoIndicadorResultado { get; set; }
        public DateTime? DataVoto { get; set; }
        public string Fundamentacao { get; set; }

        public virtual TblInfracaoRecursoIndicadorResultado CodigoInfracaoRecursoIndicadorResultadoNavigation { get; set; }
        public virtual TblInfracaoRecurso CodigoInfracaoRecursoNavigation { get; set; }
        public virtual TblJarisessaoJulgamento CodigoJarisessaoJulgamentoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioNavigation { get; set; }
    }
}
