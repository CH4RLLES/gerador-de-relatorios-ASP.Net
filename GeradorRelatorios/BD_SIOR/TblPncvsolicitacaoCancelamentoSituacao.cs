using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvsolicitacaoCancelamentoSituacao
    {
        public TblPncvsolicitacaoCancelamentoSituacao()
        {
            TblPncvsolicitacaoCancelamento = new HashSet<TblPncvsolicitacaoCancelamento>();
            TblPncvsolicitacaoCancelamentoEvento = new HashSet<TblPncvsolicitacaoCancelamentoEvento>();
        }

        public int CodigoPncvsolicitacaoCancelamentoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvsolicitacaoCancelamento> TblPncvsolicitacaoCancelamento { get; set; }
        public virtual ICollection<TblPncvsolicitacaoCancelamentoEvento> TblPncvsolicitacaoCancelamentoEvento { get; set; }
    }
}
