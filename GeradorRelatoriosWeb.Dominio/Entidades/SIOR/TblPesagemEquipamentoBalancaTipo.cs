using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPesagemEquipamentoBalancaTipo
    {
        public TblPesagemEquipamentoBalancaTipo()
        {
            TblPesagemEquipamento = new HashSet<TblPesagemEquipamento>();
            TblPesagemPosto = new HashSet<TblPesagemPosto>();
        }

        public int CodigoPesagemEquipamentoBalancaTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPesagemEquipamento> TblPesagemEquipamento { get; set; }
        public virtual ICollection<TblPesagemPosto> TblPesagemPosto { get; set; }
    }
}
