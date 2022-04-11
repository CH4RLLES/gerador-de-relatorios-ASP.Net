using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvequipamentoIndicadorComunicacao
    {
        public TblPncvequipamentoIndicadorComunicacao()
        {
            TblPncvequipamentoEstudoTecnico = new HashSet<TblPncvequipamentoEstudoTecnico>();
            TblPncvestudoTecnicoInstalacaoEquipamento = new HashSet<TblPncvestudoTecnicoInstalacaoEquipamento>();
            TblPncvestudoTecnicoMonitoramento = new HashSet<TblPncvestudoTecnicoMonitoramento>();
        }

        public int CodigoPncvequipamentoIndicadorComunicacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvequipamentoEstudoTecnico> TblPncvequipamentoEstudoTecnico { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoEquipamento> TblPncvestudoTecnicoInstalacaoEquipamento { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramento> TblPncvestudoTecnicoMonitoramento { get; set; }
    }
}
