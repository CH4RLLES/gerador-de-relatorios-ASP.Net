using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSistemaEventoTipo
    {
        public TblSistemaEventoTipo()
        {
            TblSistemaEvento = new HashSet<TblSistemaEvento>();
        }

        public int CodigoSistemaEventoTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblSistemaEvento> TblSistemaEvento { get; set; }
    }
}
