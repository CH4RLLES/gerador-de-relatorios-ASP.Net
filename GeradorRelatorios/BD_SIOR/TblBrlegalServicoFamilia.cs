using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBrlegalServicoFamilia
    {
        public TblBrlegalServicoFamilia()
        {
            TblBrlegalImplantacaoProjetoCronograma = new HashSet<TblBrlegalImplantacaoProjetoCronograma>();
            TblBrlegalImplantacaoTrechoCronograma = new HashSet<TblBrlegalImplantacaoTrechoCronograma>();
            TblBrlegalServicoItem = new HashSet<TblBrlegalServicoItem>();
        }

        public int CodigoBrlegalServicoFamilia { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public int CodigoDnit { get; set; }

        public virtual ICollection<TblBrlegalImplantacaoProjetoCronograma> TblBrlegalImplantacaoProjetoCronograma { get; set; }
        public virtual ICollection<TblBrlegalImplantacaoTrechoCronograma> TblBrlegalImplantacaoTrechoCronograma { get; set; }
        public virtual ICollection<TblBrlegalServicoItem> TblBrlegalServicoItem { get; set; }
    }
}
