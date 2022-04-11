using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvautorizacaoInstalacaoEquipamentoRemanejamento
    {
        public int CodigoPncvautorizacaoInstalacaoEquipamentoRemanejamento { get; set; }
        public int CodigoPncvautorizacaoInstalacaoEquipamento { get; set; }
        public int CodigoPncvequipamento { get; set; }

        public virtual TblPncvautorizacaoInstalacaoEquipamento CodigoPncvautorizacaoInstalacaoEquipamentoNavigation { get; set; }
        public virtual TblPncvequipamento CodigoPncvequipamentoNavigation { get; set; }
    }
}
