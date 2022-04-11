using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBaseDocumentoUfscdnittipo
    {
        public TblBaseDocumentoUfscdnittipo()
        {
            TblBaseDocumentoUfscdnit = new HashSet<TblBaseDocumentoUfscdnit>();
        }

        public int CodigoBaseDocumentoUfscdnittipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblBaseDocumentoUfscdnit> TblBaseDocumentoUfscdnit { get; set; }
    }
}
