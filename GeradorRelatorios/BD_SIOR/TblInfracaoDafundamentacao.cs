using System;
using System.Collections.Generic;

namespace GeradorRelatorios
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
