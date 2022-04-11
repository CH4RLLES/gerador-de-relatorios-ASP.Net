using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoNotificacaoEditalNotificacao
    {
        public int CodigoInfracaoNotificacaoEditalNotificacao { get; set; }
        public int CodigoInfracaoNotificacaoEdital { get; set; }
        public long CodigoInfracaoNotificacao { get; set; }
        public int CodigoInfracaoNotificacaoTipo { get; set; }
        public string PlacaUf { get; set; }
        public string NumeroAit { get; set; }
        public DateTime DataInfracao { get; set; }
        public string CodigoEnquadramentoTexto { get; set; }
        public decimal? ValorOriginal { get; set; }

        public virtual TblInfracaoNotificacaoEdital CodigoInfracaoNotificacaoEditalNavigation { get; set; }
        public virtual TblInfracaoNotificacao CodigoInfracaoNotificacaoNavigation { get; set; }
        public virtual TblInfracaoNotificacaoTipo CodigoInfracaoNotificacaoTipoNavigation { get; set; }
    }
}
