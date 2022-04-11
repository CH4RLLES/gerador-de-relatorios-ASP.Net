using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoIndicadorResponsavel
    {
        public TblInfracaoIndicadorResponsavel()
        {
            TblInfracao = new HashSet<TblInfracao>();
            TblInfracaoEnquadramento = new HashSet<TblInfracaoEnquadramento>();
            TblInfracaoIdentificacaoInfratorResponsavel = new HashSet<TblInfracaoIdentificacaoInfratorResponsavel>();
            TblInfracaoPreAutuacao = new HashSet<TblInfracaoPreAutuacao>();
        }

        public int CodigoInfracaoIndicadorResponsavel { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
        public virtual ICollection<TblInfracaoEnquadramento> TblInfracaoEnquadramento { get; set; }
        public virtual ICollection<TblInfracaoIdentificacaoInfratorResponsavel> TblInfracaoIdentificacaoInfratorResponsavel { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacao { get; set; }
    }
}
