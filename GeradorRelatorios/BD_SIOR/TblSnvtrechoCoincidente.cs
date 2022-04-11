using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSnvtrechoCoincidente
    {
        public int CodigoSnvtrechoCoincidente { get; set; }
        public int CodigoSnvtrechoHistorico { get; set; }
        public int CodigoSnvtrechoHistoricoCoincidente { get; set; }

        public virtual TblSnvtrechoHistorico CodigoSnvtrechoHistoricoCoincidenteNavigation { get; set; }
        public virtual TblSnvtrechoHistorico CodigoSnvtrechoHistoricoNavigation { get; set; }
    }
}
