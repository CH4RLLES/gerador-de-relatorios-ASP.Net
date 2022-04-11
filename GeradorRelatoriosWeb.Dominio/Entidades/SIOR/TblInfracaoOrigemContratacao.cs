using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoOrigemContratacao
    {
        public long CodigoInfracaoOrigemContratacao { get; set; }
        public int CodigoInfracaoOrigem { get; set; }
        public string Nome { get; set; }
    }
}
