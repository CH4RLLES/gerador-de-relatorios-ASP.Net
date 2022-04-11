using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoNumeroProcessoEfeitoSuspensivo
    {
        public long CodigoInfracaoNumeroProcessoEfeitoSuspensivo { get; set; }
        public string NumeroAutoInfracao { get; set; }
        public DateTime DataProtocolo { get; set; }
        public byte Ocorrencia { get; set; }
        public string NumeroProcesso { get; set; }
    }
}
