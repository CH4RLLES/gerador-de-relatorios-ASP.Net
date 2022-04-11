using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroPagamentoBaixaManualEvento
    {
        public long CodigoInfracaoFinanceiroPagamentoBaixaManualEvento { get; set; }
        public long CodigoInfracaoFinanceiroPagamentoBaixaManual { get; set; }
        public int CodigoInfracaoFinanceiroPagamentoBaixaManualSituacao { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblInfracaoFinanceiroPagamentoBaixaManual CodigoInfracaoFinanceiroPagamentoBaixaManualNavigation { get; set; }
        public virtual TblInfracaoFinanceiroPagamentoBaixaManualSituacao CodigoInfracaoFinanceiroPagamentoBaixaManualSituacaoNavigation { get; set; }
    }
}
