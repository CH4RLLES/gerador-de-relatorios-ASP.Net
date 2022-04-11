using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBrlegalAnteprojeto
    {
        public int CodigoBrlegalAnteprojeto { get; set; }
        public int CodigoBrlegalContrato { get; set; }
        public int CodigoBrlegalServicoItem { get; set; }
        public decimal? Quantidade { get; set; }
        public decimal? ValorUnitario { get; set; }
        public decimal? ValorTotal { get; set; }

        public virtual TblBrlegalContrato CodigoBrlegalContratoNavigation { get; set; }
        public virtual TblBrlegalServicoItem CodigoBrlegalServicoItemNavigation { get; set; }
    }
}
