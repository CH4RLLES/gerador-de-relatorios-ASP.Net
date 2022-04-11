using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvsolicitacaoCancelamentoEvento
    {
        public int CodigoPncvsolicitacaoCancelamentoEvento { get; set; }
        public int CodigoPncvsolicitacaoCancelamentoSituacao { get; set; }
        public int CodigoPncvsolicitacaoCancelamento { get; set; }
        public string NomeSistemaUsuario { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }

        public virtual TblPncvsolicitacaoCancelamento CodigoPncvsolicitacaoCancelamentoNavigation { get; set; }
        public virtual TblPncvsolicitacaoCancelamentoSituacao CodigoPncvsolicitacaoCancelamentoSituacaoNavigation { get; set; }
    }
}
