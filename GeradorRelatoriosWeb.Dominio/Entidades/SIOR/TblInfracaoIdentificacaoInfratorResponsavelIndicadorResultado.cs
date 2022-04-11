using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoIdentificacaoInfratorResponsavelIndicadorResultado
    {
        public TblInfracaoIdentificacaoInfratorResponsavelIndicadorResultado()
        {
            TblInfracaoIdentificacaoInfratorResponsavel = new HashSet<TblInfracaoIdentificacaoInfratorResponsavel>();
        }

        public int CodigoInfracaoIdentificacaoInfratorResponsavelIndicadorResultado { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoIdentificacaoInfratorResponsavel> TblInfracaoIdentificacaoInfratorResponsavel { get; set; }
    }
}
