using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaPerfilPerfil
    {
        public int CodigoSistemaPerfilPerfil { get; set; }
        public int CodigoSistemaPerfilPai { get; set; }
        public int CodigoSistemaPerfilFilho { get; set; }

        public virtual TblSistemaPerfil CodigoSistemaPerfilFilhoNavigation { get; set; }
        public virtual TblSistemaPerfil CodigoSistemaPerfilPaiNavigation { get; set; }
    }
}
