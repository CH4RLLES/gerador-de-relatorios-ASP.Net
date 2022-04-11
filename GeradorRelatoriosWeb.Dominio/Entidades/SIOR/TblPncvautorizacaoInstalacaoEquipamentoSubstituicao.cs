using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvautorizacaoInstalacaoEquipamentoSubstituicao
    {
        public int CodigoPncvautorizacaoInstalacaoEquipamentoSubstituicao { get; set; }
        public int CodigoPncvautorizacaoInstalacaoEquipamento { get; set; }
        public int CodigoPncvequipamento { get; set; }

        public virtual TblPncvautorizacaoInstalacaoEquipamento CodigoPncvautorizacaoInstalacaoEquipamentoNavigation { get; set; }
        public virtual TblPncvequipamento CodigoPncvequipamentoNavigation { get; set; }
    }
}
