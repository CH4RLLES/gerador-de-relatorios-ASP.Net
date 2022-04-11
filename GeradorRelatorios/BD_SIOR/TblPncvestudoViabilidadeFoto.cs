using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvestudoViabilidadeFoto
    {
        public int CodigoPncvestudoViabilidadeFoto { get; set; }
        public int CodigoPncvestudoViabilidade { get; set; }
        public string Descricao { get; set; }
        public string ArquivoNome { get; set; }
        public string ArquivoNomeFisico { get; set; }
        public int ArquivoTamanho { get; set; }

        public virtual TblPncvestudoViabilidade CodigoPncvestudoViabilidadeNavigation { get; set; }
    }
}
