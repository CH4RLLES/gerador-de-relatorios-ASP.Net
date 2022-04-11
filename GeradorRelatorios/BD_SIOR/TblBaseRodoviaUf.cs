using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBaseRodoviaUf
    {
        public int CodigoBaseRodoviaUf { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public int CodigoBaseUf { get; set; }

        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
    }
}
