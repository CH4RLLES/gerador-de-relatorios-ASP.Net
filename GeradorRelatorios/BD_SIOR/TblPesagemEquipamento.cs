using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPesagemEquipamento
    {
        public TblPesagemEquipamento()
        {
            TblPesagemPostoEquipamento = new HashSet<TblPesagemPostoEquipamento>();
        }

        public int CodigoPesagemEquipamento { get; set; }
        public int CodigoPesagemEquipamentoBalancaTipo { get; set; }
        public string CodigoEquipamentoDnit { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public virtual TblPesagemEquipamentoBalancaTipo CodigoPesagemEquipamentoBalancaTipoNavigation { get; set; }
        public virtual ICollection<TblPesagemPostoEquipamento> TblPesagemPostoEquipamento { get; set; }
    }
}
