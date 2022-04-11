using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBaseDocumentoUfscdnit
    {
        public TblBaseDocumentoUfscdnit()
        {
            InverseCodigoBaseDocumentoUfscdnitpaiNavigation = new HashSet<TblBaseDocumentoUfscdnit>();
        }

        public int CodigoBaseDocumentoUfscdnit { get; set; }
        public int CodigoBaseDocumentoUfscdnittipo { get; set; }
        public int? CodigoBaseDocumentoUfscdnitpai { get; set; }
        public string Nome { get; set; }
        public DateTime DataModificacao { get; set; }
        public DateTime? DocumentoDataReferencia { get; set; }
        public int? DocumentoTamanho { get; set; }
        public string DocumentoNomeFisico { get; set; }

        public virtual TblBaseDocumentoUfscdnit CodigoBaseDocumentoUfscdnitpaiNavigation { get; set; }
        public virtual TblBaseDocumentoUfscdnittipo CodigoBaseDocumentoUfscdnittipoNavigation { get; set; }
        public virtual ICollection<TblBaseDocumentoUfscdnit> InverseCodigoBaseDocumentoUfscdnitpaiNavigation { get; set; }
    }
}
