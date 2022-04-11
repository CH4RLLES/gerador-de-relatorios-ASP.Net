using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoSolicitacaoCancelamentoSituacao
    {
        public TblInfracaoSolicitacaoCancelamentoSituacao()
        {
            TblInfracaoSolicitacaoCancelamento = new HashSet<TblInfracaoSolicitacaoCancelamento>();
            TblInfracaoSolicitacaoCancelamentoEvento = new HashSet<TblInfracaoSolicitacaoCancelamentoEvento>();
        }

        public int CodigoInfracaoSolicitacaoCancelamentoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoSolicitacaoCancelamento> TblInfracaoSolicitacaoCancelamento { get; set; }
        public virtual ICollection<TblInfracaoSolicitacaoCancelamentoEvento> TblInfracaoSolicitacaoCancelamentoEvento { get; set; }
    }
}
