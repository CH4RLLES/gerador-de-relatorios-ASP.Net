using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSistemaUsuarioAcao
    {
        public int CodigoSistemaUsuarioAcao { get; set; }
        public int CodigoSistemaAcao { get; set; }
        public int CodigoSistemaUsuario { get; set; }
        public int CodigoSistemaMenu { get; set; }

        public virtual TblSistemaAcao CodigoSistemaAcaoNavigation { get; set; }
        public virtual TblSistemaMenu CodigoSistemaMenuNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioNavigation { get; set; }
    }
}
