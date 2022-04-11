using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaUsuarioPerfil
    {
        public int CodigoSistemaUsuarioPerfil { get; set; }
        public int CodigoSistemaUsuario { get; set; }
        public int CodigoSistemaPerfil { get; set; }

        public virtual TblSistemaPerfil CodigoSistemaPerfilNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioNavigation { get; set; }
    }
}
