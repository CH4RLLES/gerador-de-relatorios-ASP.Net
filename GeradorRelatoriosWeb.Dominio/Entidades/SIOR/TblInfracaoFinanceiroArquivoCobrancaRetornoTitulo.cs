using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo
    {
        public TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo()
        {
            TblInfracaoFinanceiroPagamentoGru = new HashSet<TblInfracaoFinanceiroPagamentoGru>();
        }

        public long CodigoInfracaoFinanceiroArquivoCobrancaRetornoTitulo { get; set; }
        public int CodigoInfracaoFinanceiroArquivoCobrancaRetornoTituloSituacao { get; set; }
        public long? CodigoInfracaoFinanceiroArquivoCobrancaRetorno { get; set; }
        public int? CodigoBaseFebrabanMovimentoRetorno { get; set; }
        public long? CodigoInfracaoFinanceiroGru { get; set; }
        public long? CodigoInfracao { get; set; }
        public int NumeroLinhaRegistroDetalhe { get; set; }
        public string NossoNumero { get; set; }
        public DateTime? DataOcorrencia { get; set; }
        public DateTime? DataCredito { get; set; }
        public string CodigoBancoPagamento { get; set; }
        public string CodigoAgenciaPagamento { get; set; }
        public string DigitoVerificadorAgenciaPagamento { get; set; }
        public string NumeroDocumentoCobranca { get; set; }
        public string IdentificacaoTituloEmpresa { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorAcrescimo { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorAbatimento { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal ValorOutrasDespesas { get; set; }
        public decimal ValorOutrosCreditos { get; set; }
        public string Observacao { get; set; }
        public string MotivoOcorrencia { get; set; }

        public virtual TblBaseFebrabanMovimentoRetorno CodigoBaseFebrabanMovimentoRetornoNavigation { get; set; }
        public virtual TblInfracaoFinanceiroArquivoCobrancaRetorno CodigoInfracaoFinanceiroArquivoCobrancaRetornoNavigation { get; set; }
        public virtual TblInfracaoFinanceiroArquivoCobrancaRetornoTituloSituacao CodigoInfracaoFinanceiroArquivoCobrancaRetornoTituloSituacaoNavigation { get; set; }
        public virtual TblInfracaoFinanceiroGru CodigoInfracaoFinanceiroGruNavigation { get; set; }
        public virtual TblInfracao CodigoInfracaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroPagamentoGru> TblInfracaoFinanceiroPagamentoGru { get; set; }
    }
}
