using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoFinanceiroDebitoEvento
    {
        public long CodigoInfracaoFinanceiroDebitoEvento { get; set; }
        public long CodigoInfracaoFinanceiroDebito { get; set; }
        public int CodigoInfracaoFinanceiroDebitoSituacao { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblInfracaoFinanceiroDebito CodigoInfracaoFinanceiroDebitoNavigation { get; set; }
        public virtual TblInfracaoFinanceiroDebitoSituacao CodigoInfracaoFinanceiroDebitoSituacaoNavigation { get; set; }
    }
}
