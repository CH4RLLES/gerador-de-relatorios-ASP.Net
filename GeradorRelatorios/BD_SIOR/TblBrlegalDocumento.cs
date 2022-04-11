using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBrlegalDocumento
    {
        public int CodigoBrlegalDocumento { get; set; }
        public int CodigoBrlegalContrato { get; set; }
        public int? CodigoBaseRodovia { get; set; }
        public int CodigoBrlegalDocumentoTipo { get; set; }
        public int CodigoBrlegalServicoTipo { get; set; }
        public string DocumentoNome { get; set; }
        public DateTime? DocumentoData { get; set; }
        public string ArquivoNome { get; set; }
        public string ArquivoNomeFisico { get; set; }
        public int? ArquivoTamanho { get; set; }

        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBrlegalContrato CodigoBrlegalContratoNavigation { get; set; }
        public virtual TblBrlegalDocumentoTipo CodigoBrlegalDocumentoTipoNavigation { get; set; }
        public virtual TblBrlegalServicoTipo CodigoBrlegalServicoTipoNavigation { get; set; }
    }
}
