using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBaseGruComRegistroNossoNumero
    {
        public long CodigoBaseGruComRegistroNossoNumero { get; set; }
        public string NossoNumero { get; set; }
        public string NumeroConvenio { get; set; }
        public decimal NumeroSequencial { get; set; }
    }
}
