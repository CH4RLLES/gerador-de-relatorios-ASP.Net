using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoSolicitacaoCancelamentoArquivo
    {
        public int CodigoInfracaoSolicitacaoCancelamentoArquivo { get; set; }
        public int CodigoInfracaoSolicitacaoCancelamento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? Tamanho { get; set; }
        public string ArquivoNomeFisico { get; set; }

        public virtual TblInfracaoSolicitacaoCancelamento CodigoInfracaoSolicitacaoCancelamentoNavigation { get; set; }
    }
}
