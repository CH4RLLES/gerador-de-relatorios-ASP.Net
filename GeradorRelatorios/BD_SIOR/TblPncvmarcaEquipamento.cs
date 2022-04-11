using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvmarcaEquipamento
    {
        public TblPncvmarcaEquipamento()
        {
            TblPncvmodeloEquipamento = new HashSet<TblPncvmodeloEquipamento>();
        }

        public short CodigoPncvmarcaEquipamento { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvmodeloEquipamento> TblPncvmodeloEquipamento { get; set; }
    }
}
