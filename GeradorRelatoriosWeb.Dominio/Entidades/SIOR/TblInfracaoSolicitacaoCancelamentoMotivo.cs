using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoSolicitacaoCancelamentoMotivo
    {
        public TblInfracaoSolicitacaoCancelamentoMotivo()
        {
            TblInfracaoSolicitacaoCancelamento = new HashSet<TblInfracaoSolicitacaoCancelamento>();
        }

        public int CodigoInfracaoSolicitacaoCancelamentoMotivo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoSolicitacaoCancelamento> TblInfracaoSolicitacaoCancelamento { get; set; }
    }
}
