using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoIdentificacaoInfratorResponsavelMotivoInvalidacao
    {
        public TblInfracaoIdentificacaoInfratorResponsavelMotivoInvalidacao()
        {
            TblInfracaoIdentificacaoInfratorResponsavel = new HashSet<TblInfracaoIdentificacaoInfratorResponsavel>();
        }

        public int CodigoInfracaoIdentificacaoInfratorResponsavelMotivoInvalidacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoIdentificacaoInfratorResponsavel> TblInfracaoIdentificacaoInfratorResponsavel { get; set; }
    }
}
