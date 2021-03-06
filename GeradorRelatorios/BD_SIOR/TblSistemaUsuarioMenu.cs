using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSistemaUsuarioMenu
    {
        public int CodigoSistemaUsuarioMenu { get; set; }
        public int CodigoSistemaUsuario { get; set; }
        public int CodigoSistemaMenu { get; set; }

        public virtual TblSistemaMenu CodigoSistemaMenuNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioNavigation { get; set; }
    }
}
