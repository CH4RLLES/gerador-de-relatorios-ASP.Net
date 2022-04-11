using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBrlegalImplantacaoProjetoCronograma
    {
        public int CodigoBrlegalImplantacaoProjetoCronograma { get; set; }
        public int CodigoBrlegalImplantacaoPlanejamento { get; set; }
        public int CodigoBrlegalServicoFamilia { get; set; }
        public int CodigoBrlegalServicoItem { get; set; }
        public DateTime Periodo { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Extensao { get; set; }

        public virtual TblBrlegalImplantacaoPlanejamento CodigoBrlegalImplantacaoPlanejamentoNavigation { get; set; }
        public virtual TblBrlegalServicoFamilia CodigoBrlegalServicoFamiliaNavigation { get; set; }
        public virtual TblBrlegalServicoItem CodigoBrlegalServicoItemNavigation { get; set; }
    }
}
