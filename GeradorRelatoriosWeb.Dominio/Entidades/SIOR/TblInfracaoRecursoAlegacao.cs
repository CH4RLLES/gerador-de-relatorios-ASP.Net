using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoRecursoAlegacao
    {
        public TblInfracaoRecursoAlegacao()
        {
            TblInfracaoRecursoAlegacaoEnquadramento = new HashSet<TblInfracaoRecursoAlegacaoEnquadramento>();
        }

        public int CodigoInfracaoRecursoAlegacao { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }

        public virtual ICollection<TblInfracaoRecursoAlegacaoEnquadramento> TblInfracaoRecursoAlegacaoEnquadramento { get; set; }
    }
}
