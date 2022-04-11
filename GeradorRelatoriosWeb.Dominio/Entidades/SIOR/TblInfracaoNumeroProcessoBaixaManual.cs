using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNumeroProcessoBaixaManual
    {
        public long CodigoInfracaoNumeroProcessoBaixaManual { get; set; }
        public string NumeroAutoInfracao { get; set; }
        public DateTime DataProtocolo { get; set; }
        public byte Ocorrencia { get; set; }
        public string NumeroProcesso { get; set; }
    }
}
