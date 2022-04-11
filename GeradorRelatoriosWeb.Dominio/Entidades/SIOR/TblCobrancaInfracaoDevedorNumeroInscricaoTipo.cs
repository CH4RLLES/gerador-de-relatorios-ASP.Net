using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblCobrancaInfracaoDevedorNumeroInscricaoTipo
    {
        public TblCobrancaInfracaoDevedorNumeroInscricaoTipo()
        {
            TblCobrancaInfracao = new HashSet<TblCobrancaInfracao>();
        }

        public int CodigoCobrancaInfracaoDevedorNumeroInscricaoTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracao { get; set; }
    }
}
