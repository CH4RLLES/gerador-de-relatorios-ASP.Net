using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
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
