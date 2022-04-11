using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroRepasseDetranevento
    {
        public long CodigoInfracaoFinanceiroRepasseDetranevento { get; set; }
        public int CodigoInfracaoFinanceiroRepasseDetran { get; set; }
        public int CodigoInfracaoFinanceiroRepasseDetransituacao { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblInfracaoFinanceiroRepasseDetran CodigoInfracaoFinanceiroRepasseDetranNavigation { get; set; }
        public virtual TblInfracaoFinanceiroRepasseDetransituacao CodigoInfracaoFinanceiroRepasseDetransituacaoNavigation { get; set; }
    }
}
