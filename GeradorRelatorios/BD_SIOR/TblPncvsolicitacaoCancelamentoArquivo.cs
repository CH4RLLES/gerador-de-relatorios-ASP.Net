using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvsolicitacaoCancelamentoArquivo
    {
        public int CodigoPncvsolicitacaoCancelamentoArquivo { get; set; }
        public int CodigoPncvsolicitacaoCancelamento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? Tamanho { get; set; }
        public string ArquivoNomeFisico { get; set; }

        public virtual TblPncvsolicitacaoCancelamento CodigoPncvsolicitacaoCancelamentoNavigation { get; set; }
    }
}
