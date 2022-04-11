using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvsolicitacaoTransferenciaContratoEquipamento
    {
        public int CodigoPncvsolicitacaoTransferenciaContratoEquipamento { get; set; }
        public int CodigoPncvsolicitacaoTransferenciaContrato { get; set; }
        public int? CodigoPncvequipamento { get; set; }

        public virtual TblPncvequipamento CodigoPncvequipamentoNavigation { get; set; }
        public virtual TblPncvsolicitacaoTransferenciaContrato CodigoPncvsolicitacaoTransferenciaContratoNavigation { get; set; }
    }
}
