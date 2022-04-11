using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaPerfil
    {
        public TblSistemaPerfil()
        {
            TblSistemaPerfilAcao = new HashSet<TblSistemaPerfilAcao>();
            TblSistemaPerfilMenu = new HashSet<TblSistemaPerfilMenu>();
            TblSistemaPerfilPerfilCodigoSistemaPerfilFilhoNavigation = new HashSet<TblSistemaPerfilPerfil>();
            TblSistemaPerfilPerfilCodigoSistemaPerfilPaiNavigation = new HashSet<TblSistemaPerfilPerfil>();
            TblSistemaUsuarioPerfil = new HashSet<TblSistemaUsuarioPerfil>();
        }

        public int CodigoSistemaPerfil { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TblSistemaPerfilAcao> TblSistemaPerfilAcao { get; set; }
        public virtual ICollection<TblSistemaPerfilMenu> TblSistemaPerfilMenu { get; set; }
        public virtual ICollection<TblSistemaPerfilPerfil> TblSistemaPerfilPerfilCodigoSistemaPerfilFilhoNavigation { get; set; }
        public virtual ICollection<TblSistemaPerfilPerfil> TblSistemaPerfilPerfilCodigoSistemaPerfilPaiNavigation { get; set; }
        public virtual ICollection<TblSistemaUsuarioPerfil> TblSistemaUsuarioPerfil { get; set; }
    }
}
