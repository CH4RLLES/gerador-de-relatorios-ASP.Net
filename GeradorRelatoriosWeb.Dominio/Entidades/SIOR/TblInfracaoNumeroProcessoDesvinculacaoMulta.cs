using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNumeroProcessoDesvinculacaoMulta
    {
        public long CodigoInfracaoNumeroProcessoDesvinculacaoMulta { get; set; }
        public string NumeroAutoInfracao { get; set; }
        public DateTime DataProtocolo { get; set; }
        public byte Ocorrencia { get; set; }
        public string NumeroProcesso { get; set; }
    }
}
