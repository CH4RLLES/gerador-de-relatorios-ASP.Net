using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblCobrancaInfracaoDevedorSituacaoCadastral
    {
        public TblCobrancaInfracaoDevedorSituacaoCadastral()
        {
            TblCobrancaInfracao = new HashSet<TblCobrancaInfracao>();
        }

        public int CodigoCobrancaInfracaoDevedorSituacaoCadastral { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracao { get; set; }
    }
}
