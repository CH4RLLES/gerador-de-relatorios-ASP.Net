using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvequipamentoIndicadorTecnologia
    {
        public TblPncvequipamentoIndicadorTecnologia()
        {
            TblPncvestudoTecnicoInstalacaoEquipamento = new HashSet<TblPncvestudoTecnicoInstalacaoEquipamento>();
        }

        public int CodigoPncvequipamentoIndicadorTecnologia { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoTecnicoInstalacaoEquipamento> TblPncvestudoTecnicoInstalacaoEquipamento { get; set; }
    }
}
