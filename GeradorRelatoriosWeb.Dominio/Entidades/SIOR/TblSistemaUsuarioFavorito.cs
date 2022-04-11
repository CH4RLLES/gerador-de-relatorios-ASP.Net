using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaUsuarioFavorito
    {
        public TblSistemaUsuarioFavorito()
        {
            InverseCodigoSistemaUsuarioFavoritoPaiNavigation = new HashSet<TblSistemaUsuarioFavorito>();
        }

        public long CodigoSistemaUsuarioFavorito { get; set; }
        public int CodigoSistemaUsuario { get; set; }
        public int CodigoSistemaUsuarioFavoritoTipo { get; set; }
        public int? CodigoSistemaMenu { get; set; }
        public long? CodigoSistemaUsuarioFavoritoPai { get; set; }
        public string Nome { get; set; }
        public int Ordem { get; set; }

        public virtual TblSistemaMenu CodigoSistemaMenuNavigation { get; set; }
        public virtual TblSistemaUsuarioFavorito CodigoSistemaUsuarioFavoritoPaiNavigation { get; set; }
        public virtual TblSistemaUsuarioFavoritoTipo CodigoSistemaUsuarioFavoritoTipoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioNavigation { get; set; }
        public virtual ICollection<TblSistemaUsuarioFavorito> InverseCodigoSistemaUsuarioFavoritoPaiNavigation { get; set; }
    }
}
