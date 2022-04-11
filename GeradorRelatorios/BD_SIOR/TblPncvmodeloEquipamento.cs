using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvmodeloEquipamento
    {
        public TblPncvmodeloEquipamento()
        {
            TblPncvequipamento = new HashSet<TblPncvequipamento>();
            TblPncvestudoTecnicoInstalacaoEquipamento = new HashSet<TblPncvestudoTecnicoInstalacaoEquipamento>();
            TblPncvmodeloEquipamentoRegistroSanmft = new HashSet<TblPncvmodeloEquipamentoRegistroSanmft>();
        }

        public short CodigoPncvmodeloEquipamento { get; set; }
        public short CodigoPncvmarcaEquipamento { get; set; }
        public string Nome { get; set; }

        public virtual TblPncvmarcaEquipamento CodigoPncvmarcaEquipamentoNavigation { get; set; }
        public virtual ICollection<TblPncvequipamento> TblPncvequipamento { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoEquipamento> TblPncvestudoTecnicoInstalacaoEquipamento { get; set; }
        public virtual ICollection<TblPncvmodeloEquipamentoRegistroSanmft> TblPncvmodeloEquipamentoRegistroSanmft { get; set; }
    }
}
