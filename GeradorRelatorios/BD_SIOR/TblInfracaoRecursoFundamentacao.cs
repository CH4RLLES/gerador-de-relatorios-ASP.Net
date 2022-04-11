using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoRecursoFundamentacao
    {
        public TblInfracaoRecursoFundamentacao()
        {
            TblInfracaoRecursoFundamentacaoEnquadramento = new HashSet<TblInfracaoRecursoFundamentacaoEnquadramento>();
        }

        public int CodigoInfracaoRecursoFundamentacao { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }

        public virtual ICollection<TblInfracaoRecursoFundamentacaoEnquadramento> TblInfracaoRecursoFundamentacaoEnquadramento { get; set; }
    }
}
