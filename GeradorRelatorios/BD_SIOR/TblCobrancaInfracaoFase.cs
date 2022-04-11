using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblCobrancaInfracaoFase
    {
        public TblCobrancaInfracaoFase()
        {
            TblCobrancaInfracao = new HashSet<TblCobrancaInfracao>();
            TblCobrancaInfracaoEvento = new HashSet<TblCobrancaInfracaoEvento>();
        }

        public int CodigoCobrancaInfracaoFase { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracao { get; set; }
        public virtual ICollection<TblCobrancaInfracaoEvento> TblCobrancaInfracaoEvento { get; set; }
    }
}
