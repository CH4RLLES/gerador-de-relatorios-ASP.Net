using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaUsuarioBrlegalContrato
    {
        public int CodigoSistemaUsuarioBrlegalContrato { get; set; }
        public int CodigoSistemaUsuario { get; set; }
        public int CodigoBrlegalContrato { get; set; }

        public virtual TblBrlegalContrato CodigoBrlegalContratoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioNavigation { get; set; }
    }
}
