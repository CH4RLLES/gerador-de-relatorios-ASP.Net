using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblCobrancaInfracaoIndicadorResultadoAnalise
    {
        public TblCobrancaInfracaoIndicadorResultadoAnalise()
        {
            TblCobrancaInfracao = new HashSet<TblCobrancaInfracao>();
        }

        public int CodigoCobrancaInfracaoIndicadorResultadoAnalise { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracao { get; set; }
    }
}
