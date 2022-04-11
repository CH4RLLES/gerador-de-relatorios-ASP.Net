using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo
    {
        public long CodigoInfracaoFinanceiroArquivoCobrancaRemessaTitulo { get; set; }
        public int CodigoInfracaoFinanceiroArquivoCobrancaRemessaTituloSituacao { get; set; }
        public long? CodigoInfracaoFinanceiroArquivoCobrancaRemessa { get; set; }
        public int CodigoBaseFebrabanMovimentoRemessa { get; set; }
        public long? CodigoInfracaoFinanceiroGru { get; set; }
        public long? CodigoInfracaoNotificacaoExpedicao { get; set; }
        public long? CodigoInfracao { get; set; }
        public string NumeroAuto { get; set; }
        public string NossoNumero { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public string BancoAgenciaMantenedora { get; set; }
        public string BancoAgenciaDigitoVerificador { get; set; }
        public string BancoContaCorrenteNumero { get; set; }
        public string BancoContaCorrenteDigitoVerificador { get; set; }
        public string CodigoRecolhimentoTes { get; set; }
        public string DescricaoCodigoRecolhimentoTes { get; set; }
        public string NumeroConvenio { get; set; }
        public string NumeroContrato { get; set; }
        public string NumeroCarteira { get; set; }
        public string NumeroCarteiraVariacao { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorAbatimento { get; set; }
        public decimal ValorNominalTitulo { get; set; }
        public int PagadorTipoInscricao { get; set; }
        public string PagadorNumeroInscricao { get; set; }
        public string PagadorNome { get; set; }
        public string PagadorEndereco { get; set; }
        public string PagadorBairro { get; set; }
        public string PagadorCep { get; set; }
        public string PagadorCidade { get; set; }
        public string PagadorUf { get; set; }
        public string Observacao { get; set; }

        public virtual TblBaseFebrabanMovimentoRemessa CodigoBaseFebrabanMovimentoRemessaNavigation { get; set; }
        public virtual TblInfracaoFinanceiroArquivoCobrancaRemessa CodigoInfracaoFinanceiroArquivoCobrancaRemessaNavigation { get; set; }
        public virtual TblInfracaoFinanceiroArquivoCobrancaRemessaTituloSituacao CodigoInfracaoFinanceiroArquivoCobrancaRemessaTituloSituacaoNavigation { get; set; }
        public virtual TblInfracaoFinanceiroGru CodigoInfracaoFinanceiroGruNavigation { get; set; }
        public virtual TblInfracao CodigoInfracaoNavigation { get; set; }
        public virtual TblInfracaoNotificacaoExpedicao CodigoInfracaoNotificacaoExpedicaoNavigation { get; set; }
    }
}
