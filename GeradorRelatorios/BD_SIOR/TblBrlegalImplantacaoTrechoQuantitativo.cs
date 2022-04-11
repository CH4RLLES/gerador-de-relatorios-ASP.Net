using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBrlegalImplantacaoTrechoQuantitativo
    {
        public int CodigoBrlegalImplantacaoTrechoQuantitativo { get; set; }
        public int CodigoBrlegalImplantacaoTrechoCronograma { get; set; }
        public int CodigoBrlegalServicoItem { get; set; }
        public decimal Quantidade { get; set; }

        public virtual TblBrlegalImplantacaoTrechoCronograma CodigoBrlegalImplantacaoTrechoCronogramaNavigation { get; set; }
        public virtual TblBrlegalServicoItem CodigoBrlegalServicoItemNavigation { get; set; }
    }
}
