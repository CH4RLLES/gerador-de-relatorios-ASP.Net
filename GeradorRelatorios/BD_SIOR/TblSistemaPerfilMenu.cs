using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSistemaPerfilMenu
    {
        public int CodigoSistemaPerfilMenu { get; set; }
        public int CodigoSistemaPerfil { get; set; }
        public int CodigoSistemaMenu { get; set; }

        public virtual TblSistemaMenu CodigoSistemaMenuNavigation { get; set; }
        public virtual TblSistemaPerfil CodigoSistemaPerfilNavigation { get; set; }
    }
}
