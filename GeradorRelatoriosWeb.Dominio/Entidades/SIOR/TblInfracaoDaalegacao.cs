using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoDaalegacao
    {
        public TblInfracaoDaalegacao()
        {
            TblInfracaoDaalegacaoEnquadramento = new HashSet<TblInfracaoDaalegacaoEnquadramento>();
        }

        public int CodigoInfracaoDaalegacao { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }

        public virtual ICollection<TblInfracaoDaalegacaoEnquadramento> TblInfracaoDaalegacaoEnquadramento { get; set; }
    }
}
