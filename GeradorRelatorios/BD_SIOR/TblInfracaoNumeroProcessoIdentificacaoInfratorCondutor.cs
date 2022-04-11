using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoNumeroProcessoIdentificacaoInfratorCondutor
    {
        public long CodigoInfracaoNumeroProcessoIdentificacaoInfratorCondutor { get; set; }
        public string NumeroAutoInfracao { get; set; }
        public DateTime DataProtocolo { get; set; }
        public byte Ocorrencia { get; set; }
        public string NumeroProcesso { get; set; }
    }
}
