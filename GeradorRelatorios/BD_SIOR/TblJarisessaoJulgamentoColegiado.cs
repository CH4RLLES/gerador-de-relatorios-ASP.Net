using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblJarisessaoJulgamentoColegiado
    {
        public long CodigoJarisessaoJulgamentoColegiado { get; set; }
        public long CodigoJarisessaoJulgamento { get; set; }
        public int CodigoSistemaUsuario { get; set; }

        public virtual TblJarisessaoJulgamento CodigoJarisessaoJulgamentoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioNavigation { get; set; }
    }
}
