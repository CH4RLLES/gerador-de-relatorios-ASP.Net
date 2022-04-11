using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBaseArquivoTipo
    {
        public int CodigoBaseArquivoTipo { get; set; }
        public string MimeType { get; set; }
        public string Extensao { get; set; }
    }
}
