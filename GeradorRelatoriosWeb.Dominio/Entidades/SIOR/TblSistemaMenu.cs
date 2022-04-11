using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaMenu
    {
        public TblSistemaMenu()
        {
            InverseCodigoSistemaMenuPaiNavigation = new HashSet<TblSistemaMenu>();
            TblSistemaPerfilAcao = new HashSet<TblSistemaPerfilAcao>();
            TblSistemaPerfilMenu = new HashSet<TblSistemaPerfilMenu>();
            TblSistemaUsuarioAcao = new HashSet<TblSistemaUsuarioAcao>();
            TblSistemaUsuarioFavorito = new HashSet<TblSistemaUsuarioFavorito>();
            TblSistemaUsuarioMenu = new HashSet<TblSistemaUsuarioMenu>();
        }

        public int CodigoSistemaMenu { get; set; }
        public int? CodigoSistemaMenuPai { get; set; }
        public string Nome { get; set; }
        public short Ordem { get; set; }
        public int? CodigoSistemaControle { get; set; }
        public int? CodigoSistemaAcaoRota { get; set; }
        public string ParametroFiltro { get; set; }
        public bool IndicadorControleAcaoLimitado { get; set; }

        public virtual TblSistemaAcao CodigoSistemaAcaoRotaNavigation { get; set; }
        public virtual TblSistemaControle CodigoSistemaControleNavigation { get; set; }
        public virtual TblSistemaMenu CodigoSistemaMenuPaiNavigation { get; set; }
        public virtual ICollection<TblSistemaMenu> InverseCodigoSistemaMenuPaiNavigation { get; set; }
        public virtual ICollection<TblSistemaPerfilAcao> TblSistemaPerfilAcao { get; set; }
        public virtual ICollection<TblSistemaPerfilMenu> TblSistemaPerfilMenu { get; set; }
        public virtual ICollection<TblSistemaUsuarioAcao> TblSistemaUsuarioAcao { get; set; }
        public virtual ICollection<TblSistemaUsuarioFavorito> TblSistemaUsuarioFavorito { get; set; }
        public virtual ICollection<TblSistemaUsuarioMenu> TblSistemaUsuarioMenu { get; set; }
    }
}
