using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvmodeloEquipamento
    {
        public TblPncvmodeloEquipamento()
        {
            TblPncvequipamento = new HashSet<TblPncvequipamento>();
            TblPncvestudoTecnicoInstalacaoEquipamento = new HashSet<TblPncvestudoTecnicoInstalacaoEquipamento>();
            TblPncvestudoTecnicoMonitoramento = new HashSet<TblPncvestudoTecnicoMonitoramento>();
            TblPncvmodeloEquipamentoRegistroSanmft = new HashSet<TblPncvmodeloEquipamentoRegistroSanmft>();
        }

        public short CodigoPncvmodeloEquipamento { get; set; }
        public short CodigoPncvmarcaEquipamento { get; set; }
        public string Nome { get; set; }

        public virtual TblPncvmarcaEquipamento CodigoPncvmarcaEquipamentoNavigation { get; set; }
        public virtual ICollection<TblPncvequipamento> TblPncvequipamento { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoEquipamento> TblPncvestudoTecnicoInstalacaoEquipamento { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramento> TblPncvestudoTecnicoMonitoramento { get; set; }
        public virtual ICollection<TblPncvmodeloEquipamentoRegistroSanmft> TblPncvmodeloEquipamentoRegistroSanmft { get; set; }
    }
}
