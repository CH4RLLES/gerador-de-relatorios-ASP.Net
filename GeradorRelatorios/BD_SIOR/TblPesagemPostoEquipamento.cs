using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPesagemPostoEquipamento
    {
        public int CodigoPesagemPostoEquipamento { get; set; }
        public int CodigoPesagemPosto { get; set; }
        public int CodigoPesagemEquipamento { get; set; }

        public virtual TblPesagemEquipamento CodigoPesagemEquipamentoNavigation { get; set; }
        public virtual TblPesagemPosto CodigoPesagemPostoNavigation { get; set; }
    }
}
