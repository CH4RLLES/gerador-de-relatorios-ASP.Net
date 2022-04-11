using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoEnquadramentoVelocidade
    {
        public int CodigoInfracaoEnquadramentoVelocidade { get; set; }
        public int? CodigoInfracaoEnquadramento { get; set; }
        public int LimiteRegulamentado { get; set; }
        public int VelocidadeMinima { get; set; }
        public int? VelocidadeMaxima { get; set; }

        public virtual TblInfracaoEnquadramento CodigoInfracaoEnquadramentoNavigation { get; set; }
    }
}
