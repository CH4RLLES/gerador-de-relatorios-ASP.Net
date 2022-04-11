using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSnvtrechoOcupacao
    {
        public TblSnvtrechoOcupacao()
        {
            TblSnvtrechoHistorico = new HashSet<TblSnvtrechoHistorico>();
        }

        public int CodigoSnvtrechoOcupacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblSnvtrechoHistorico> TblSnvtrechoHistorico { get; set; }
    }
}
