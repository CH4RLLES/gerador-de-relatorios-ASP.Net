using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoViabilidadeDocumento
    {
        public int CodigoPncvestudoViabilidadeDocumento { get; set; }
        public int CodigoPncvestudoViabilidade { get; set; }
        public string Descricao { get; set; }
        public string ArquivoNome { get; set; }
        public string ArquivoNomeFisico { get; set; }
        public int? ArquivoTamanho { get; set; }

        public virtual TblPncvestudoViabilidade CodigoPncvestudoViabilidadeNavigation { get; set; }
    }
}
