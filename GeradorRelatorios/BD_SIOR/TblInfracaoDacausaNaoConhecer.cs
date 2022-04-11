using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoDacausaNaoConhecer
    {
        public TblInfracaoDacausaNaoConhecer()
        {
            TblInfracaoDanaoConhecer = new HashSet<TblInfracaoDanaoConhecer>();
        }

        public int CodigoInfracaoDacausaNaoConhecer { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TblInfracaoDanaoConhecer> TblInfracaoDanaoConhecer { get; set; }
    }
}
