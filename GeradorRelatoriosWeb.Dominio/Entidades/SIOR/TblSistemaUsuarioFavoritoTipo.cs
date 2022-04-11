using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaUsuarioFavoritoTipo
    {
        public TblSistemaUsuarioFavoritoTipo()
        {
            TblSistemaUsuarioFavorito = new HashSet<TblSistemaUsuarioFavorito>();
        }

        public int CodigoSistemaUsuarioFavoritoTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblSistemaUsuarioFavorito> TblSistemaUsuarioFavorito { get; set; }
    }
}
