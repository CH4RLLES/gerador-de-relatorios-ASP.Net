using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBaseSelic
    {
        public int CodigoBaseSelic { get; set; }
        public int MesReferencia { get; set; }
        public int AnoReferencia { get; set; }
        public decimal Taxa { get; set; }
    }
}
