using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvestudoTecnicoInstalacaoAcidente
    {
        public int CodigoPncvestudoTecnicoInstalacaoAcidente { get; set; }
        public int CodigoPncvestudoTecnicoInstalacao { get; set; }
        public int Ano { get; set; }
        public int QuantidadeAcidenteSemVitima { get; set; }
        public int QuantidadeAcidenteComFeridoNaoAtropelado { get; set; }
        public int QuantidadeAcidenteComFeridoAtropelado { get; set; }
        public int QuantidadeAcidenteComMorto { get; set; }
        public int Ups { get; set; }

        public virtual TblPncvestudoTecnicoInstalacao CodigoPncvestudoTecnicoInstalacaoNavigation { get; set; }
    }
}
