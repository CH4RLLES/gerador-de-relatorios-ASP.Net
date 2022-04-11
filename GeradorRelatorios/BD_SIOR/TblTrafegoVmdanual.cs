using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblTrafegoVmdanual
    {
        public int CodigoTrafegoVmdanual { get; set; }
        public int CodigoTrafegoVmdfonteDados { get; set; }
        public int VolumeAnual { get; set; }
        public decimal? Quilometro { get; set; }
        public int CodigoBaseUf { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public int AnoReferencia { get; set; }
        public string CodigoSnv { get; set; }

        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual TblTrafegoVmdfonteDados CodigoTrafegoVmdfonteDadosNavigation { get; set; }
    }
}
