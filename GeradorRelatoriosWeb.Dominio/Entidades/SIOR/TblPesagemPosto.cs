using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPesagemPosto
    {
        public TblPesagemPosto()
        {
            TblPesagemPostoEquipamento = new HashSet<TblPesagemPostoEquipamento>();
        }

        public int CodigoPesagemPosto { get; set; }
        public int? CodigoPesagemEquipamentoBalancaTipo { get; set; }
        public int CodigoBaseUf { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public int CodigoRenavammunicipio { get; set; }
        public string CodigoIdentificacaoPosto { get; set; }
        public decimal Quilometro { get; set; }
        public string Sentido { get; set; }

        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual TblPesagemEquipamentoBalancaTipo CodigoPesagemEquipamentoBalancaTipoNavigation { get; set; }
        public virtual ICollection<TblPesagemPostoEquipamento> TblPesagemPostoEquipamento { get; set; }
    }
}
