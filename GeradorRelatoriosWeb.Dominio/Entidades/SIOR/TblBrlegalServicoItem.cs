using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBrlegalServicoItem
    {
        public TblBrlegalServicoItem()
        {
            TblBrlegalAnteprojeto = new HashSet<TblBrlegalAnteprojeto>();
            TblBrlegalImplantacaoProjetoCronograma = new HashSet<TblBrlegalImplantacaoProjetoCronograma>();
            TblBrlegalImplantacaoTrechoQuantitativo = new HashSet<TblBrlegalImplantacaoTrechoQuantitativo>();
        }

        public int CodigoBrlegalServicoItem { get; set; }
        public int CodigoBrlegalServicoFamilia { get; set; }
        public int CodigoBrlegalServicoUnidadeMedida { get; set; }
        public string Descricao { get; set; }
        public int? CodigoDnit { get; set; }
        public bool ItemPadrao { get; set; }

        public virtual TblBrlegalServicoFamilia CodigoBrlegalServicoFamiliaNavigation { get; set; }
        public virtual TblBrlegalServicoUnidadeMedida CodigoBrlegalServicoUnidadeMedidaNavigation { get; set; }
        public virtual ICollection<TblBrlegalAnteprojeto> TblBrlegalAnteprojeto { get; set; }
        public virtual ICollection<TblBrlegalImplantacaoProjetoCronograma> TblBrlegalImplantacaoProjetoCronograma { get; set; }
        public virtual ICollection<TblBrlegalImplantacaoTrechoQuantitativo> TblBrlegalImplantacaoTrechoQuantitativo { get; set; }
    }
}
