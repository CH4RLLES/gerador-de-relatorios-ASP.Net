using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblCobrancaInfracaoIndicadorResultadoConsistencia
    {
        public TblCobrancaInfracaoIndicadorResultadoConsistencia()
        {
            TblCobrancaInfracaoCodigoCobrancaInfracaoIndicadorResultadoAndamentoProcessualNavigation = new HashSet<TblCobrancaInfracao>();
            TblCobrancaInfracaoCodigoCobrancaInfracaoIndicadorResultadoExpedicaoNaNavigation = new HashSet<TblCobrancaInfracao>();
            TblCobrancaInfracaoCodigoCobrancaInfracaoIndicadorResultadoRevisaoProcessualNavigation = new HashSet<TblCobrancaInfracao>();
            TblCobrancaInfracaoCodigoCobrancaInfracaoIndicadorResultadoTramitacaoPfeNavigation = new HashSet<TblCobrancaInfracao>();
        }

        public int CodigoCobrancaInfracaoIndicadorResultadoConsistencia { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracaoCodigoCobrancaInfracaoIndicadorResultadoAndamentoProcessualNavigation { get; set; }
        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracaoCodigoCobrancaInfracaoIndicadorResultadoExpedicaoNaNavigation { get; set; }
        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracaoCodigoCobrancaInfracaoIndicadorResultadoRevisaoProcessualNavigation { get; set; }
        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracaoCodigoCobrancaInfracaoIndicadorResultadoTramitacaoPfeNavigation { get; set; }
    }
}
