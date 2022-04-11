using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNumeroAuto
    {
        public long CodigoInfracaoNumeroAuto { get; set; }
        public string NumeroAuto { get; set; }
        public string Prefixo { get; set; }
        public decimal NumeroSequencial { get; set; }
    }
}
