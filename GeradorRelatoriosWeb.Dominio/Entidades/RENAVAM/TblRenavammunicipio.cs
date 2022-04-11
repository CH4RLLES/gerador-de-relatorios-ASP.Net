using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.RENAVAM
{
    public partial class TblRenavammunicipio
    {
        public int CodigoRenavammunicipio { get; set; }
        public short? CodigoBaseUf { get; set; }
        public string CodigoRenavam { get; set; }
        public string DigitoMunicipio { get; set; }
        public string Nome { get; set; }
        public string CodigoRenavam5d { get; set; }
    }
}
