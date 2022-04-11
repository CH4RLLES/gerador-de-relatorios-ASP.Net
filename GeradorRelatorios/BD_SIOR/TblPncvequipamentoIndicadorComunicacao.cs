using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvequipamentoIndicadorComunicacao
    {
        public TblPncvequipamentoIndicadorComunicacao()
        {
            TblPncvequipamentoEstudoTecnico = new HashSet<TblPncvequipamentoEstudoTecnico>();
            TblPncvestudoTecnicoInstalacaoEquipamento = new HashSet<TblPncvestudoTecnicoInstalacaoEquipamento>();
        }

        public int CodigoPncvequipamentoIndicadorComunicacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvequipamentoEstudoTecnico> TblPncvequipamentoEstudoTecnico { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoEquipamento> TblPncvestudoTecnicoInstalacaoEquipamento { get; set; }
    }
}
