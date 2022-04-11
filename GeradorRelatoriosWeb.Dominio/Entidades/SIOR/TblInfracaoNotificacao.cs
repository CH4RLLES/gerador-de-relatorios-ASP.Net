using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacao
    {
        public TblInfracaoNotificacao()
        {
            TblCobrancaInfracaoCodigoInfracaoNotificacaoAutuacaoNavigation = new HashSet<TblCobrancaInfracao>();
            TblCobrancaInfracaoCodigoInfracaoNotificacaoPenalidadeNavigation = new HashSet<TblCobrancaInfracao>();
            TblCobrancaInfracaoCodigoInfracaoNotificacaoRecursoPrimeiraInstanciaNavigation = new HashSet<TblCobrancaInfracao>();
            TblCobrancaInfracaoCodigoInfracaoNotificacaoRecursoSegundaInstanciaNavigation = new HashSet<TblCobrancaInfracao>();
            TblInfracaoNotificacaoEditalNotificacao = new HashSet<TblInfracaoNotificacaoEditalNotificacao>();
        }

        public long CodigoInfracaoNotificacao { get; set; }
        public long CodigoInfracao { get; set; }
        public int CodigoInfracaoNotificacaoSituacao { get; set; }
        public int CodigoInfracaoNotificacaoTipo { get; set; }
        public long? CodigoInfracaoNotificacaoExpedicao { get; set; }
        public int? CodigoInfracaoNotificacaoExpedicaoServico { get; set; }
        public int? CodigoInfracaoNotificacaoArquivoBaixa { get; set; }
        public int? CodigoInfracaoNotificacaoMidiaAr { get; set; }
        public long? CodigoInfracaoFinanceiroGru { get; set; }
        public int? CodigoBaseCorreiosCodigoBaixa { get; set; }
        public int? CodigoBaseCorreiosMotivoDevolucao { get; set; }
        public int? CodigoUf { get; set; }
        public int? CodigoRenavammunicipio { get; set; }
        public int? CodigoRenavamindicadorAdesaoSne { get; set; }
        public string NumeroNotificacaoRenainf { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime? DataPostagem { get; set; }
        public DateTime? DataPublicacaoEdital { get; set; }
        public DateTime? DataVencimentoAtual { get; set; }
        public DateTime? DataVencimentoExpedicao { get; set; }
        public DateTime? DataPrePostagem { get; set; }
        public DateTime? DataVencimentoEdital { get; set; }
        public DateTime? DataVencimentoPreExpedicao { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public DateTime? DataAdesaoSne { get; set; }
        public string Destinatario { get; set; }
        public string EnderecoLogradouro { get; set; }
        public string EnderecoNumero { get; set; }
        public string EnderecoComplemento { get; set; }
        public string EnderecoBairro { get; set; }
        public string EnderecoCep { get; set; }
        public bool? IndicadorNaoAcolhimentoDa { get; set; }
        public bool? IndicadorNaoAcolhimentoPenalidadeAdvertencia { get; set; }
        public string NumeroObjeto { get; set; }
        public string NumeroAr { get; set; }
        public DateTime? BaixaDataEntregaAr { get; set; }
        public DateTime? ArdigitalDataBaixaObjeto { get; set; }
        public string ArdigitalNumeroLoteBaixa { get; set; }
        public string ArdigitalArquivoNome { get; set; }
        public string ArdigitalArquivoNomeFisico { get; set; }
        public int? ArdigitalArquivoTamanho { get; set; }
        public string SegundaViaArquivoNome { get; set; }
        public string SegundaViaArquivoNomeFisico { get; set; }
        public int? SegundaViaArquivoTamanho { get; set; }
        public DateTime? DataNotificacao { get; set; }
        public bool? IndicadorRegistroRenainf { get; set; }
        public int? CodigoInfracaoNotificacaoEdital { get; set; }
        public DateTime? DataRegistroRenainf { get; set; }
        public bool? IndicadorPostagemIntempestiva { get; set; }
        public int? CodigoInfracaoNotificacaoModeloImpressao { get; set; }
        public string CedocodigoDevolucaoEletronica { get; set; }
        public string CedocodigoBarras { get; set; }
        public DateTime? RecursoJulgamentoData { get; set; }
        public string RecursoJulgamentoResultado { get; set; }
        public string RecursoRecorrenteNome { get; set; }

        public virtual TblBaseCorreiosCodigoBaixa CodigoBaseCorreiosCodigoBaixaNavigation { get; set; }
        public virtual TblBaseCorreiosMotivoDevolucao CodigoBaseCorreiosMotivoDevolucaoNavigation { get; set; }
        public virtual TblInfracaoFinanceiroGru CodigoInfracaoFinanceiroGruNavigation { get; set; }
        public virtual TblInfracao CodigoInfracaoNavigation { get; set; }
        public virtual TblInfracaoNotificacaoArquivoBaixa CodigoInfracaoNotificacaoArquivoBaixaNavigation { get; set; }
        public virtual TblInfracaoNotificacaoExpedicao CodigoInfracaoNotificacaoExpedicaoNavigation { get; set; }
        public virtual TblInfracaoNotificacaoExpedicaoServico CodigoInfracaoNotificacaoExpedicaoServicoNavigation { get; set; }
        public virtual TblInfracaoNotificacaoMidiaAr CodigoInfracaoNotificacaoMidiaArNavigation { get; set; }
        public virtual TblInfracaoNotificacaoSituacao CodigoInfracaoNotificacaoSituacaoNavigation { get; set; }
        public virtual TblInfracaoNotificacaoTipo CodigoInfracaoNotificacaoTipoNavigation { get; set; }
        public virtual TblBaseUf CodigoUfNavigation { get; set; }
        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracaoCodigoInfracaoNotificacaoAutuacaoNavigation { get; set; }
        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracaoCodigoInfracaoNotificacaoPenalidadeNavigation { get; set; }
        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracaoCodigoInfracaoNotificacaoRecursoPrimeiraInstanciaNavigation { get; set; }
        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracaoCodigoInfracaoNotificacaoRecursoSegundaInstanciaNavigation { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoEditalNotificacao> TblInfracaoNotificacaoEditalNotificacao { get; set; }
    }
}
