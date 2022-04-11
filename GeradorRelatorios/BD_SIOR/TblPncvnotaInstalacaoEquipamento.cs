using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvnotaInstalacaoEquipamento
    {
        public int CodigoPncvnotaInstalacaoEquipamento { get; set; }
        public int CodigoPncvequipamento { get; set; }
        public int CodigoPncvnotaInstalacao { get; set; }

        public virtual TblPncvequipamento CodigoPncvequipamentoNavigation { get; set; }
        public virtual TblPncvnotaInstalacao CodigoPncvnotaInstalacaoNavigation { get; set; }
    }
}
