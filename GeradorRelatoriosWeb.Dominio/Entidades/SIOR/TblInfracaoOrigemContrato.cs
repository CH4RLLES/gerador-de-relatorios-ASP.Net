using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoOrigemContrato
    {
        public long CodigoInfracaoOrigemContrato { get; set; }
        public long CodigoInfracaoOrigemContratacao { get; set; }
        public int CodigoInfracaoOrigem { get; set; }
        public int? NumeroLote { get; set; }
        public string Nome { get; set; }
    }
}
