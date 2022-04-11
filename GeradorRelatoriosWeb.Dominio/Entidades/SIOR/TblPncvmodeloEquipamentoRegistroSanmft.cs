using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvmodeloEquipamentoRegistroSanmft
    {
        public int CodigoPncvmodeloEquipamentoRegistroSanmft { get; set; }
        public short CodigoPncvmodeloEquipamento { get; set; }
        public string NumeroRegistro { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime DataValidade { get; set; }
        public string ArquivoReferenciaNome { get; set; }
        public string ArquivoReferenciaNomeFisico { get; set; }
        public int? ArquivoReferenciaTamanho { get; set; }

        public virtual TblPncvmodeloEquipamento CodigoPncvmodeloEquipamentoNavigation { get; set; }
    }
}
