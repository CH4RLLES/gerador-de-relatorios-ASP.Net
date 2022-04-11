using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSistemaControle
    {
        public TblSistemaControle()
        {
            TblSistemaAcao = new HashSet<TblSistemaAcao>();
            TblSistemaMenu = new HashSet<TblSistemaMenu>();
        }

        public int CodigoSistemaControle { get; set; }
        public int CodigoSistemaArea { get; set; }
        public string Nome { get; set; }

        public virtual TblSistemaArea CodigoSistemaAreaNavigation { get; set; }
        public virtual ICollection<TblSistemaAcao> TblSistemaAcao { get; set; }
        public virtual ICollection<TblSistemaMenu> TblSistemaMenu { get; set; }
    }
}
