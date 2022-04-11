using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class AuxFiciCorrecaoDataConferencia
    {
        public string NumeroAuto { get; set; }
        public long? CodigoInfracao { get; set; }
        public long? CodigoInfracaoIdentificacaoInfratorCondutor { get; set; }
        public DateTime? ConferenciaPrimeira { get; set; }
        public DateTime? ConferenciaAtual { get; set; }
        public string Resultado { get; set; }
    }
}
