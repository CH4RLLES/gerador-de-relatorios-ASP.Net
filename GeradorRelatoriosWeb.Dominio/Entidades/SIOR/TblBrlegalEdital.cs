using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBrlegalEdital
    {
        public TblBrlegalEdital()
        {
            TblBrlegalContrato = new HashSet<TblBrlegalContrato>();
        }

        public int CodigoBrlegalEdital { get; set; }
        public string NumeroEdital { get; set; }
        public short Ano { get; set; }
        public int NumeroEtapa { get; set; }
        public string ArquivoNome { get; set; }
        public string ArquivoNomeFisico { get; set; }
        public int? ArquivoTamanho { get; set; }

        public virtual ICollection<TblBrlegalContrato> TblBrlegalContrato { get; set; }
    }
}
