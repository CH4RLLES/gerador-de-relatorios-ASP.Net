using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaUsuarioPncvindicadorVinculo
    {
        public TblSistemaUsuarioPncvindicadorVinculo()
        {
            TblSistemaUsuario = new HashSet<TblSistemaUsuario>();
        }

        public int CodigoSistemaUsuarioPncvindicadorVinculo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblSistemaUsuario> TblSistemaUsuario { get; set; }
    }
}
