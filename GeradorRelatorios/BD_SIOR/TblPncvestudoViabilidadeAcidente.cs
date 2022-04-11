using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvestudoViabilidadeAcidente
    {
        public int CodigoPncvestudoViabilidadeAcidente { get; set; }
        public int CodigoPncvestudoViabilidade { get; set; }
        public int Ano { get; set; }
        public int QuantidadeAcidenteSemVitima { get; set; }
        public int QuantidadeAcidenteComFeridoNaoAtropelado { get; set; }
        public int QuantidadeAcidenteComFeridoAtropelado { get; set; }
        public int QuantidadeAcidenteComMorto { get; set; }
        public int Ups { get; set; }

        public virtual TblPncvestudoViabilidade CodigoPncvestudoViabilidadeNavigation { get; set; }
    }
}
