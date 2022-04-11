using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvequipamentoIndicadorInstalacao
    {
        public TblPncvequipamentoIndicadorInstalacao()
        {
            TblPncvautorizacaoInstalacaoEquipamento = new HashSet<TblPncvautorizacaoInstalacaoEquipamento>();
            TblPncvestudoTecnicoInstalacaoEquipamento = new HashSet<TblPncvestudoTecnicoInstalacaoEquipamento>();
        }

        public int CodigoPncvequipamentoIndicadorInstalacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvautorizacaoInstalacaoEquipamento> TblPncvautorizacaoInstalacaoEquipamento { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoEquipamento> TblPncvestudoTecnicoInstalacaoEquipamento { get; set; }
    }
}
