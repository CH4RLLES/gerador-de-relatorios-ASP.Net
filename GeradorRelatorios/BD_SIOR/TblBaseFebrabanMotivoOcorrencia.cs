using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBaseFebrabanMotivoOcorrencia
    {
        public int CodigoBaseFebrabanMotivoOcorrencia { get; set; }
        public int CodigoBaseFebrabanMotivoOcorrenciaDominio { get; set; }
        public string CodigoMovimentoOcorrencia { get; set; }
        public string Nome { get; set; }

        public virtual TblBaseFebrabanMotivoOcorrenciaDominio CodigoBaseFebrabanMotivoOcorrenciaDominioNavigation { get; set; }
    }
}
