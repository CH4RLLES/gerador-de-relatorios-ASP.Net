using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaSsrsrelatorio
    {
        public int CodigoSistemaSsrsrelatorio { get; set; }
        public int CodigoSistemaSsrs { get; set; }
        public string RelatorioCaminhoPasta { get; set; }
        public string RelatorioNome { get; set; }

        public virtual TblSistemaSsrs CodigoSistemaSsrsNavigation { get; set; }
    }
}
