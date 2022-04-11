using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSistemaUsuarioPncveditalLote
    {
        public int CodigoSistemaUsuarioPncveditalLote { get; set; }
        public int CodigoPncveditalLote { get; set; }
        public int CodigoSistemaUsuario { get; set; }

        public virtual TblPncveditalLote CodigoPncveditalLoteNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioNavigation { get; set; }
    }
}
