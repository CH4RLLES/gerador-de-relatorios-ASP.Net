using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvsolicitacaoTransferenciaContratoArquivo
    {
        public int CodigoPncvsolicitacaoTransferenciaContratoArquivo { get; set; }
        public int CodigoPncvsolicitacaoTransferenciaContrato { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? Tamanho { get; set; }
        public string ArquivoNomeFisico { get; set; }

        public virtual TblPncvsolicitacaoTransferenciaContrato CodigoPncvsolicitacaoTransferenciaContratoNavigation { get; set; }
    }
}
