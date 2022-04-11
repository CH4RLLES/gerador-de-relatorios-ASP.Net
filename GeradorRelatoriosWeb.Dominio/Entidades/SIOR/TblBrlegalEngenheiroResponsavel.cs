using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBrlegalEngenheiroResponsavel
    {
        public TblBrlegalEngenheiroResponsavel()
        {
            TblBrlegalContrato = new HashSet<TblBrlegalContrato>();
        }

        public int CodigoBrlegalEngenheiroResponsavel { get; set; }
        public string Nome { get; set; }
        public string Informacao { get; set; }

        public virtual ICollection<TblBrlegalContrato> TblBrlegalContrato { get; set; }
    }
}
