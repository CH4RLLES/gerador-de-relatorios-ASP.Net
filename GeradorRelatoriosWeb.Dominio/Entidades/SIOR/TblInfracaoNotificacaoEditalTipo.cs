using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoEditalTipo
    {
        public TblInfracaoNotificacaoEditalTipo()
        {
            TblInfracaoNotificacaoEdital = new HashSet<TblInfracaoNotificacaoEdital>();
        }

        public int CodigoInfracaoNotificacaoEditalTipo { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<TblInfracaoNotificacaoEdital> TblInfracaoNotificacaoEdital { get; set; }
    }
}
