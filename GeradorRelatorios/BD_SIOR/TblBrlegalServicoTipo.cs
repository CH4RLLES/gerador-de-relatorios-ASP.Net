using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBrlegalServicoTipo
    {
        public TblBrlegalServicoTipo()
        {
            TblBrlegalDocumento = new HashSet<TblBrlegalDocumento>();
        }

        public int CodigoBrlegalServicoTipo { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TblBrlegalDocumento> TblBrlegalDocumento { get; set; }
    }
}
