using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoEditalEvento
    {
        public long CodigoInfracaoNotificacaoEditalEvento { get; set; }
        public int CodigoInfracaoNotificacaoEdital { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblInfracaoNotificacaoEdital CodigoInfracaoNotificacaoEditalNavigation { get; set; }
    }
}
