using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvsolicitacaoTransferenciaContratoSituacao
    {
        public TblPncvsolicitacaoTransferenciaContratoSituacao()
        {
            TblPncvsolicitacaoTransferenciaContrato = new HashSet<TblPncvsolicitacaoTransferenciaContrato>();
            TblPncvsolicitacaoTransferenciaContratoEvento = new HashSet<TblPncvsolicitacaoTransferenciaContratoEvento>();
        }

        public int CodigoPncvsolicitacaoTransferenciaContratoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvsolicitacaoTransferenciaContrato> TblPncvsolicitacaoTransferenciaContrato { get; set; }
        public virtual ICollection<TblPncvsolicitacaoTransferenciaContratoEvento> TblPncvsolicitacaoTransferenciaContratoEvento { get; set; }
    }
}
