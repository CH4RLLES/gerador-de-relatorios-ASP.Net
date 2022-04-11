using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaAcao
    {
        public TblSistemaAcao()
        {
            TblSistemaMenu = new HashSet<TblSistemaMenu>();
            TblSistemaPerfilAcao = new HashSet<TblSistemaPerfilAcao>();
            TblSistemaUsuarioAcao = new HashSet<TblSistemaUsuarioAcao>();
        }

        public int CodigoSistemaAcao { get; set; }
        public int CodigoSistemaControle { get; set; }
        public string Nome { get; set; }
        public string NomeApresentacao { get; set; }

        public virtual TblSistemaControle CodigoSistemaControleNavigation { get; set; }
        public virtual ICollection<TblSistemaMenu> TblSistemaMenu { get; set; }
        public virtual ICollection<TblSistemaPerfilAcao> TblSistemaPerfilAcao { get; set; }
        public virtual ICollection<TblSistemaUsuarioAcao> TblSistemaUsuarioAcao { get; set; }
    }
}
