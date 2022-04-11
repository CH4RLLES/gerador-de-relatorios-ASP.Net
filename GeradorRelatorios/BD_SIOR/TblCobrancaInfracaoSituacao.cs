using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblCobrancaInfracaoSituacao
    {
        public TblCobrancaInfracaoSituacao()
        {
            TblCobrancaInfracao = new HashSet<TblCobrancaInfracao>();
            TblCobrancaInfracaoEvento = new HashSet<TblCobrancaInfracaoEvento>();
        }

        public int CodigoCobrancaInfracaoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracao { get; set; }
        public virtual ICollection<TblCobrancaInfracaoEvento> TblCobrancaInfracaoEvento { get; set; }
    }
}
