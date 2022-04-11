using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class AuxEditalNaCorrecaoInfracaoOrigemSagi
    {
        public string NumeroAuto { get; set; }
        public string Acao { get; set; }
        public long? CodigoInfracao { get; set; }
        public bool? IndicadorProcessado { get; set; }
    }
}
