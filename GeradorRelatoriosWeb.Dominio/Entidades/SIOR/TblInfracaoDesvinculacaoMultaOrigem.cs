using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoDesvinculacaoMultaOrigem
    {
        public TblInfracaoDesvinculacaoMultaOrigem()
        {
            TblInfracaoDesvinculacaoMulta = new HashSet<TblInfracaoDesvinculacaoMulta>();
        }

        public int CodigoInfracaoDesvinculacaoMultaOrigem { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<TblInfracaoDesvinculacaoMulta> TblInfracaoDesvinculacaoMulta { get; set; }
    }
}
