using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroArquivoMcpagamento
    {
        public long CodigoInfracaoFinanceiroArquivoMcpagamento { get; set; }
        public int CodigoInfracaoFinanceiroArquivoMcpagamentoSituacao { get; set; }
        public int CodigoInfracaoFinanceiroArquivoMc { get; set; }
        public string RegistroMensagem { get; set; }
        public string RegistroDetran { get; set; }
        public string RegistroNumeroAuto { get; set; }
        public string RegistroEnquadramento { get; set; }
        public DateTime? RegistroDataRegistroRenainf { get; set; }
        public DateTime? RegistroDataPagamento { get; set; }
        public decimal? RegistroValorPago { get; set; }
        public int? RegistroNumeroPagamento { get; set; }
        public long? CodigoInfracao { get; set; }
        public int? CodigoInfracaoFinanceiroDetran { get; set; }
        public int ProcessamentoTentativa { get; set; }
        public DateTime? ProcessamentoData { get; set; }
        public string ProcessamentoObservacao { get; set; }

        public virtual TblInfracaoFinanceiroArquivoMc CodigoInfracaoFinanceiroArquivoMcNavigation { get; set; }
        public virtual TblInfracaoFinanceiroArquivoMcpagamentoSituacao CodigoInfracaoFinanceiroArquivoMcpagamentoSituacaoNavigation { get; set; }
    }
}
