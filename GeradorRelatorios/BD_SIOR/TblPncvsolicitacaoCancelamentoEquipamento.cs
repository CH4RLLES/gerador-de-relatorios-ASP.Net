using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvsolicitacaoCancelamentoEquipamento
    {
        public int CodigoPncvsolicitacaoCancelamentoEquipamento { get; set; }
        public int CodigoPncvsolicitacaoCancelamento { get; set; }
        public int? CodigoPncvequipamento { get; set; }

        public virtual TblPncvequipamento CodigoPncvequipamentoNavigation { get; set; }
        public virtual TblPncvsolicitacaoCancelamento CodigoPncvsolicitacaoCancelamentoNavigation { get; set; }
    }
}
