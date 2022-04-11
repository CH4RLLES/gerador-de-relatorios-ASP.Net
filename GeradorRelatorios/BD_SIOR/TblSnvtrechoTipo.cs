using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSnvtrechoTipo
    {
        public TblSnvtrechoTipo()
        {
            TblSnvtrechoHistorico = new HashSet<TblSnvtrechoHistorico>();
        }

        public int CodigoSnvtrechoTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblSnvtrechoHistorico> TblSnvtrechoHistorico { get; set; }
    }
}
