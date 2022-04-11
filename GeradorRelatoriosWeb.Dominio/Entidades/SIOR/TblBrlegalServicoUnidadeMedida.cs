using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBrlegalServicoUnidadeMedida
    {
        public TblBrlegalServicoUnidadeMedida()
        {
            TblBrlegalServicoItem = new HashSet<TblBrlegalServicoItem>();
        }

        public int CodigoBrlegalServicoUnidadeMedida { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<TblBrlegalServicoItem> TblBrlegalServicoItem { get; set; }
    }
}
