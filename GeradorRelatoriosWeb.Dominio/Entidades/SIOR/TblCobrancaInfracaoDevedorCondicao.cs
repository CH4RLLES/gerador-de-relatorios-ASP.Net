using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblCobrancaInfracaoDevedorCondicao
    {
        public TblCobrancaInfracaoDevedorCondicao()
        {
            TblCobrancaInfracao = new HashSet<TblCobrancaInfracao>();
        }

        public int CodigoCobrancaInfracaoDevedorCondicao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracao { get; set; }
    }
}
