using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaArea
    {
        public TblSistemaArea()
        {
            TblSistemaControle = new HashSet<TblSistemaControle>();
        }

        public int CodigoSistemaArea { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblSistemaControle> TblSistemaControle { get; set; }
    }
}
