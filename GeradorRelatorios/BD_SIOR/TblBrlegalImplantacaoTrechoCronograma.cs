using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBrlegalImplantacaoTrechoCronograma
    {
        public TblBrlegalImplantacaoTrechoCronograma()
        {
            TblBrlegalImplantacaoTrechoQuantitativo = new HashSet<TblBrlegalImplantacaoTrechoQuantitativo>();
        }

        public int CodigoBrlegalImplantacaoTrechoCronograma { get; set; }
        public int CodigoBrlegalImplantacaoPlanejamento { get; set; }
        public int CodigoBrlegalContratoTrecho { get; set; }
        public int CodigoBrlegalServicoFamilia { get; set; }
        public DateTime Periodo { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Extensao { get; set; }

        public virtual TblBrlegalContratoTrecho CodigoBrlegalContratoTrechoNavigation { get; set; }
        public virtual TblBrlegalImplantacaoPlanejamento CodigoBrlegalImplantacaoPlanejamentoNavigation { get; set; }
        public virtual TblBrlegalServicoFamilia CodigoBrlegalServicoFamiliaNavigation { get; set; }
        public virtual ICollection<TblBrlegalImplantacaoTrechoQuantitativo> TblBrlegalImplantacaoTrechoQuantitativo { get; set; }
    }
}
