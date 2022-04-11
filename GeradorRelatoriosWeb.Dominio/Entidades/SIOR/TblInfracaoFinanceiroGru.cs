using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroGru
    {
        public TblInfracaoFinanceiroGru()
        {
            TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo = new HashSet<TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo>();
            TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo = new HashSet<TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo>();
            TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGruNavigation = new HashSet<TblInfracaoFinanceiroDebito>();
            TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrundr1Navigation = new HashSet<TblInfracaoFinanceiroDebito>();
            TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrundr2Navigation = new HashSet<TblInfracaoFinanceiroDebito>();
            TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrunpNavigation = new HashSet<TblInfracaoFinanceiroDebito>();
            TblInfracaoFinanceiroPagamentoGru = new HashSet<TblInfracaoFinanceiroPagamentoGru>();
            TblInfracaoNotificacao = new HashSet<TblInfracaoNotificacao>();
        }

        public long CodigoInfracaoFinanceiroGru { get; set; }
        public int CodigoInfracaoFinanceiroGrusituacao { get; set; }
        public int CodigoInfracaoFinanceiroGrutipoValor { get; set; }
        public long CodigoInfracao { get; set; }
        public int CodigoInfracaoFinanceiroGrucadastroTituloBanco { get; set; }
        public long? CodigoInfracaoFinanceiroArquivoCobrancaRemessa { get; set; }
        public long? CodigoInfracaoFinanceiroArquivoCobrancaRetorno { get; set; }
        public int? CodigoBaseFebrabanMovimentoRemessa { get; set; }
        public int? CodigoBaseFebrabanMovimentoRetorno { get; set; }
        public string CodigoBanco { get; set; }
        public string LinhaDigitavel { get; set; }
        public DateTime? DataDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string EspecieDocumento { get; set; }
        public DateTime? DataProcessamento { get; set; }
        public DateTime? DataVencimento { get; set; }
        public string NumeroConvenio { get; set; }
        public string Carteira { get; set; }
        public string AgenciaBanco { get; set; }
        public string NumeroConta { get; set; }
        public string NossoNumero { get; set; }
        public decimal ValorDocumento { get; set; }
        public string Instrucao { get; set; }
        public string CodigoBarras { get; set; }
        public string PagadorNome { get; set; }
        public int? PagadorTipoInscricao { get; set; }
        public string PagadorNumeroInscricao { get; set; }
        public string PagadorEndereco { get; set; }
        public string PagadorBairro { get; set; }
        public string PagadorCep { get; set; }
        public string PagadorCidade { get; set; }
        public string PagadorUf { get; set; }
        public string NumeroComercioEletronico { get; set; }
        public string MotivoOcorrencia { get; set; }

        public virtual TblBaseFebrabanMovimentoRemessa CodigoBaseFebrabanMovimentoRemessaNavigation { get; set; }
        public virtual TblBaseFebrabanMovimentoRetorno CodigoBaseFebrabanMovimentoRetornoNavigation { get; set; }
        public virtual TblInfracaoFinanceiroArquivoCobrancaRemessa CodigoInfracaoFinanceiroArquivoCobrancaRemessaNavigation { get; set; }
        public virtual TblInfracaoFinanceiroArquivoCobrancaRetorno CodigoInfracaoFinanceiroArquivoCobrancaRetornoNavigation { get; set; }
        public virtual TblInfracaoFinanceiroGrucadastroTituloBanco CodigoInfracaoFinanceiroGrucadastroTituloBancoNavigation { get; set; }
        public virtual TblInfracaoFinanceiroGrusituacao CodigoInfracaoFinanceiroGrusituacaoNavigation { get; set; }
        public virtual TblInfracaoFinanceiroGrutipoValor CodigoInfracaoFinanceiroGrutipoValorNavigation { get; set; }
        public virtual TblInfracao CodigoInfracaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo> TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo> TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroDebito> TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGruNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroDebito> TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrundr1Navigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroDebito> TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrundr2Navigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroDebito> TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrunpNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroPagamentoGru> TblInfracaoFinanceiroPagamentoGru { get; set; }
        public virtual ICollection<TblInfracaoNotificacao> TblInfracaoNotificacao { get; set; }
    }
}
