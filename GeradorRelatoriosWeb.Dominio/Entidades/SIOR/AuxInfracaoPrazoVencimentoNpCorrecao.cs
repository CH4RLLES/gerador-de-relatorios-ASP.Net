using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class AuxInfracaoPrazoVencimentoNpCorrecao
    {
        public long InfracaoCodigoProcesso { get; set; }
        public bool? ProcessamentoPrazoExpedicaoNpIndicadorAtualizado { get; set; }
    }
}
