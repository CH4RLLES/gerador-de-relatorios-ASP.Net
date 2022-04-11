using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroPagamentoBaixaManual
    {
        public TblInfracaoFinanceiroPagamentoBaixaManual()
        {
            TblInfracaoFinanceiroPagamentoBaixaManualArquivo = new HashSet<TblInfracaoFinanceiroPagamentoBaixaManualArquivo>();
            TblInfracaoFinanceiroPagamentoBaixaManualEvento = new HashSet<TblInfracaoFinanceiroPagamentoBaixaManualEvento>();
        }

        public long CodigoInfracaoFinanceiroPagamentoBaixaManual { get; set; }
        public int CodigoInfracaoFinanceiroPagamentoBaixaManualSituacao { get; set; }
        public string NumeroProcesso { get; set; }
        public string NumeroDocumentoArrecadacao { get; set; }
        public DateTime DataProtocolo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public bool RenainfIndicadorPago { get; set; }
        public decimal? RenainfValorPago { get; set; }
        public string Observacao { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual TblInfracaoFinanceiroPagamento CodigoInfracaoFinanceiroPagamentoBaixaManualNavigation { get; set; }
        public virtual TblInfracaoFinanceiroPagamentoBaixaManualSituacao CodigoInfracaoFinanceiroPagamentoBaixaManualSituacaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroPagamentoBaixaManualArquivo> TblInfracaoFinanceiroPagamentoBaixaManualArquivo { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroPagamentoBaixaManualEvento> TblInfracaoFinanceiroPagamentoBaixaManualEvento { get; set; }
    }
}
