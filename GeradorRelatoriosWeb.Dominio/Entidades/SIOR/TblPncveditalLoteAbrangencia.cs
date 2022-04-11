﻿using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncveditalLoteAbrangencia
    {
        public int CodigoPncveditalLoteAbrangencia { get; set; }
        public int CodigoPncveditalLote { get; set; }
        public int CodigoBaseUf { get; set; }

        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual TblPncveditalLote CodigoPncveditalLoteNavigation { get; set; }
    }
}
