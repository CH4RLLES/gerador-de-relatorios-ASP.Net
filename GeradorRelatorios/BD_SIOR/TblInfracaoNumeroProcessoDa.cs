using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoNumeroProcessoDa
    {
        public long CodigoInfracaoNumeroProcessoDa { get; set; }
        public string NumeroAutoInfracao { get; set; }
        public DateTime DataProtocolo { get; set; }
        public byte Ocorrencia { get; set; }
        public string NumeroProcesso { get; set; }
    }
}
