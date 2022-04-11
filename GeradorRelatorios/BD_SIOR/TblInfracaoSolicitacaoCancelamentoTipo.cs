using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoSolicitacaoCancelamentoTipo
    {
        public TblInfracaoSolicitacaoCancelamentoTipo()
        {
            TblInfracaoSolicitacaoCancelamento = new HashSet<TblInfracaoSolicitacaoCancelamento>();
        }

        public int CodigoInfracaoSolicitacaoCancelamentoTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoSolicitacaoCancelamento> TblInfracaoSolicitacaoCancelamento { get; set; }
    }
}
