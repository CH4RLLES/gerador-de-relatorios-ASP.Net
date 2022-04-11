using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoEnquadramentoValor
    {
        public int CodigoInfracaoEnquadramentoValor { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public int CodigoInfracaoGravidade { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal ValorOriginal80Porcento { get; set; }
        public decimal ValorOriginal60Porcento { get; set; }

        public virtual TblInfracaoEnquadramento CodigoInfracaoEnquadramentoNavigation { get; set; }
        public virtual TblInfracaoGravidade CodigoInfracaoGravidadeNavigation { get; set; }
    }
}
