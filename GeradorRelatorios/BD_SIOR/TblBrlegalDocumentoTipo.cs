using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBrlegalDocumentoTipo
    {
        public TblBrlegalDocumentoTipo()
        {
            TblBrlegalDocumento = new HashSet<TblBrlegalDocumento>();
        }

        public int CodigoBrlegalDocumentoTipo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TblBrlegalDocumento> TblBrlegalDocumento { get; set; }
    }
}
