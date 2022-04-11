using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class AuxEditalNpCorrecaoInfracaoOrigemSagi
    {
        public long CodigoInfracaoNotificacao { get; set; }
        public long CodigoInfracao { get; set; }
        public string NumeroAuto { get; set; }
        public string Acao { get; set; }
        public bool IndicadorProcessado { get; set; }
    }
}
