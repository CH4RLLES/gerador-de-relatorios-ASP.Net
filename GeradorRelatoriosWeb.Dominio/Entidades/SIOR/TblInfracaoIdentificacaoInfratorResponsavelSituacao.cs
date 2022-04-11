using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoIdentificacaoInfratorResponsavelSituacao
    {
        public TblInfracaoIdentificacaoInfratorResponsavelSituacao()
        {
            TblInfracaoIdentificacaoInfratorResponsavel = new HashSet<TblInfracaoIdentificacaoInfratorResponsavel>();
            TblInfracaoIdentificacaoInfratorResponsavelEvento = new HashSet<TblInfracaoIdentificacaoInfratorResponsavelEvento>();
        }

        public int CodigoInfracaoIdentificacaoInfratorResponsavelSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoIdentificacaoInfratorResponsavel> TblInfracaoIdentificacaoInfratorResponsavel { get; set; }
        public virtual ICollection<TblInfracaoIdentificacaoInfratorResponsavelEvento> TblInfracaoIdentificacaoInfratorResponsavelEvento { get; set; }
    }
}
