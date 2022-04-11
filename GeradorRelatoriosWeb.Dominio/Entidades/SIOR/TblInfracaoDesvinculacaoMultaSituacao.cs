using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoDesvinculacaoMultaSituacao
    {
        public TblInfracaoDesvinculacaoMultaSituacao()
        {
            TblInfracaoDesvinculacaoMulta = new HashSet<TblInfracaoDesvinculacaoMulta>();
            TblInfracaoDesvinculacaoMultaEvento = new HashSet<TblInfracaoDesvinculacaoMultaEvento>();
        }

        public int CodigoInfracaoDesvinculacaoMultaSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoDesvinculacaoMulta> TblInfracaoDesvinculacaoMulta { get; set; }
        public virtual ICollection<TblInfracaoDesvinculacaoMultaEvento> TblInfracaoDesvinculacaoMultaEvento { get; set; }
    }
}
