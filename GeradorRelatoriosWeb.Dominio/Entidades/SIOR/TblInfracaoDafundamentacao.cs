using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoDafundamentacao
    {
        public TblInfracaoDafundamentacao()
        {
            TblInfracaoDafundamentacaoEnquadramento = new HashSet<TblInfracaoDafundamentacaoEnquadramento>();
        }

        public int CodigoInfracaoDafundamentacao { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }

        public virtual ICollection<TblInfracaoDafundamentacaoEnquadramento> TblInfracaoDafundamentacaoEnquadramento { get; set; }
    }
}
