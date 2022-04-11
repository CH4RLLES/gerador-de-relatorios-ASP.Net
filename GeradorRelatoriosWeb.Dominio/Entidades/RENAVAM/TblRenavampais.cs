using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.RENAVAM
{
    public partial class TblRenavampais
    {
        public int CodigoRenavampais { get; set; }
        public string CodigoRenavam { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
    }
}
