using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSistemaUsuarioPncvabrangencia
    {
        public int CodigoSistemaUsuarioPncvabrangencia { get; set; }
        public int CodigoSistemaUsuario { get; set; }
        public int CodigoBaseUf { get; set; }

        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioNavigation { get; set; }
    }
}
