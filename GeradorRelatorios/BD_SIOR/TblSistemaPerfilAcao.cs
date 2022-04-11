using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSistemaPerfilAcao
    {
        public int CodigoSistemaPerfilAcao { get; set; }
        public int CodigoSistemaAcao { get; set; }
        public int CodigoSistemaPerfil { get; set; }
        public int CodigoSistemaMenu { get; set; }

        public virtual TblSistemaAcao CodigoSistemaAcaoNavigation { get; set; }
        public virtual TblSistemaMenu CodigoSistemaMenuNavigation { get; set; }
        public virtual TblSistemaPerfil CodigoSistemaPerfilNavigation { get; set; }
    }
}
