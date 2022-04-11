using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblCobrancaInfracao
    {
        public TblCobrancaInfracao()
        {
            TblCobrancaInfracaoArquivo = new HashSet<TblCobrancaInfracaoArquivo>();
            TblCobrancaInfracaoEvento = new HashSet<TblCobrancaInfracaoEvento>();
        }

        public long CodigoCobrancaInfracao { get; set; }
        public byte[] RowVersion { get; set; }
        public int CodigoCobrancaInfracaoSituacao { get; set; }
        public int CodigoCobrancaInfracaoFase { get; set; }
        public int CodigoCobrancaInfracaoDevedorSituacaoCadastral { get; set; }
        public string Observacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataEncerramento { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public int CodigoCobrancaInfracaoDevedorNumeroInscricaoTipo { get; set; }
        public int CodigoCobrancaInfracaoDevedorCondicao { get; set; }
        public string InfracaoDevedorNome { get; set; }
        public string InfracaoDevedorNumeroInscricao { get; set; }
        public string InfracaoDevedorNumeroInscricaoFormatado { get; set; }
        public int CodigoInfracaoOrigem { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public string InfracaoNumeroAuto { get; set; }
        public string InfracaoNupformatado { get; set; }
        public DateTime InfracaoData { get; set; }
        public string InfracaoVeiculoPlaca { get; set; }
        public string InfracaoVeiculoUf { get; set; }
        public decimal InfracaoValorOriginal { get; set; }
        public bool InfracaoIndicadorRegistroRenainf { get; set; }
        public DateTime InfracaoNotificacaoPenalidadeDataVencimento { get; set; }
        public long CodigoInfracaoNotificacaoAutuacao { get; set; }
        public long CodigoInfracaoNotificacaoPenalidade { get; set; }
        public long? CodigoInfracaoNotificacaoRecursoPrimeiraInstancia { get; set; }
        public long? CodigoInfracaoNotificacaoRecursoSegundaInstancia { get; set; }
        public long? CodigoInfracaoDa { get; set; }
        public long? CodigoInfracaoRecursoPrimeiraInstancia { get; set; }
        public long? CodigoInfracaoRecursoSegundaInstancia { get; set; }
        public string Sapiensnupformatado { get; set; }
        public DateTime? SapiensdataCadastro { get; set; }
        public bool DauindicadorInscricao { get; set; }
        public DateTime? DaudataInscricao { get; set; }
        public bool DauindicadorDebitoPago { get; set; }
        public DateTime? DaudataPagamento { get; set; }
        public decimal? DauvalorPago { get; set; }
        public string Tdanumero { get; set; }
        public string TdaarquivoNome { get; set; }
        public string TdaarquivoNomeFisico { get; set; }
        public int? TdaarquivoTamanho { get; set; }
        public string Cdanumero { get; set; }
        public string CdaarquivoNome { get; set; }
        public string CdaarquivoNomeFisico { get; set; }
        public int? CdaarquivoTamanho { get; set; }
        public int? CodigoUsuarioCadastroSapiens { get; set; }
        public DateTime? CadastroSapiensdata { get; set; }
        public string CadastroSapiensusuarioNome { get; set; }
        public int CodigoCobrancaInfracaoIndicadorResultadoAnaliseProcessual { get; set; }
        public int? CodigoUsuarioAnaliseProcessual { get; set; }
        public int CodigoCobrancaInfracaoIndicadorResultadoAndamentoProcessual { get; set; }
        public int CodigoCobrancaInfracaoIndicadorResultadoTramitacaoPfe { get; set; }
        public int CodigoCobrancaInfracaoIndicadorResultadoExpedicaoNa { get; set; }
        public int CodigoCobrancaInfracaoIndicadorResultadoRevisaoProcessual { get; set; }
        public DateTime? AnaliseProcessualData { get; set; }
        public string AnaliseProcessualUsuarioNome { get; set; }
        public DateTime? AnaliseDataVencimentoUltimaGru { get; set; }
        public DateTime? AnaliseDataConstituicaoDefinitiva { get; set; }
        public DateTime? AnaliseDataPrescricaoExecutoria { get; set; }
        public DateTime? AnaliseDataInicioSelic { get; set; }
        public DateTime? AnaliseDataInicioMultaMora { get; set; }
        public DateTime? AnaliseNadataPostagem { get; set; }
        public DateTime? AnaliseNadataPublicacaoDou { get; set; }
        public DateTime? AnaliseNpdataPostagem { get; set; }
        public DateTime? AnaliseNpdataPublicacaoDou { get; set; }
        public DateTime? AnaliseNpdataVencimentoGru { get; set; }
        public DateTime? AnaliseDadataProtocolo { get; set; }
        public DateTime? AnaliseDadataJulgamento { get; set; }
        public string AnaliseDaautoridadeTransito { get; set; }
        public DateTime? AnaliseRecursoPrimeiraInstacaoDataProtocolo { get; set; }
        public DateTime? AnaliseRecursoPrimeiraInstacaoDataJulgamento { get; set; }
        public string AnaliseRecursoPrimeiraInstacaoOrgaoJulgador { get; set; }
        public DateTime? AnaliseRecursoPrimeiraInstacaoNotificacaoDataPostagem { get; set; }
        public DateTime? AnaliseRecursoPrimeiraInstacaoNotificacaoDataPublicacaoDou { get; set; }
        public DateTime? AnaliseRecursoSegundaInstacaoDataProtocolo { get; set; }
        public DateTime? AnaliseRecursoSegundaInstacaoDataJulgamento { get; set; }
        public string AnaliseRecursoSegundaInstacaoOrgaoJulgador { get; set; }
        public DateTime? AnaliseRecursoSegundaInstacaoNotificacaoDataPostagem { get; set; }
        public DateTime? AnaliseRecursoSegundaInstacaoNotificacaoDataPublicacaoDou { get; set; }
        public int? CodigoUsuarioRevisaoProcessual { get; set; }
        public DateTime? RevisaoProcessualData { get; set; }
        public string RevisaoProcessualUsuarioNome { get; set; }
        public string PagamentoArquivoNome { get; set; }
        public string PagamentoArquivoNomeFisico { get; set; }
        public int? PagamentoArquivoTamanho { get; set; }
        public bool IndicadorCadastradoSapiens { get; set; }
        public bool IndicadorRevisaoProcessual { get; set; }
        public string DevedorNome { get; set; }
        public string DevedorNumeroInscricao { get; set; }
        public string DevedorNumeroInscricaoFormatado { get; set; }
        public string RelatorioArquivoNome { get; set; }
        public string RelatorioArquivoNomeFisico { get; set; }
        public int? RelatorioArquivoTamanho { get; set; }
        public string InfracaoDarecorrenteNome { get; set; }

        public virtual TblCobrancaInfracaoDevedorCondicao CodigoCobrancaInfracaoDevedorCondicaoNavigation { get; set; }
        public virtual TblCobrancaInfracaoDevedorNumeroInscricaoTipo CodigoCobrancaInfracaoDevedorNumeroInscricaoTipoNavigation { get; set; }
        public virtual TblCobrancaInfracaoDevedorSituacaoCadastral CodigoCobrancaInfracaoDevedorSituacaoCadastralNavigation { get; set; }
        public virtual TblCobrancaInfracaoFase CodigoCobrancaInfracaoFaseNavigation { get; set; }
        public virtual TblCobrancaInfracaoIndicadorResultadoAnalise CodigoCobrancaInfracaoIndicadorResultadoAnaliseProcessualNavigation { get; set; }
        public virtual TblCobrancaInfracaoIndicadorResultadoConsistencia CodigoCobrancaInfracaoIndicadorResultadoAndamentoProcessualNavigation { get; set; }
        public virtual TblCobrancaInfracaoIndicadorResultadoConsistencia CodigoCobrancaInfracaoIndicadorResultadoExpedicaoNaNavigation { get; set; }
        public virtual TblCobrancaInfracaoIndicadorResultadoConsistencia CodigoCobrancaInfracaoIndicadorResultadoRevisaoProcessualNavigation { get; set; }
        public virtual TblCobrancaInfracaoIndicadorResultadoConsistencia CodigoCobrancaInfracaoIndicadorResultadoTramitacaoPfeNavigation { get; set; }
        public virtual TblInfracao CodigoCobrancaInfracaoNavigation { get; set; }
        public virtual TblCobrancaInfracaoSituacao CodigoCobrancaInfracaoSituacaoNavigation { get; set; }
        public virtual TblInfracaoDa CodigoInfracaoDaNavigation { get; set; }
        public virtual TblInfracaoEnquadramento CodigoInfracaoEnquadramentoNavigation { get; set; }
        public virtual TblInfracaoNotificacao CodigoInfracaoNotificacaoAutuacaoNavigation { get; set; }
        public virtual TblInfracaoNotificacao CodigoInfracaoNotificacaoPenalidadeNavigation { get; set; }
        public virtual TblInfracaoNotificacao CodigoInfracaoNotificacaoRecursoPrimeiraInstanciaNavigation { get; set; }
        public virtual TblInfracaoNotificacao CodigoInfracaoNotificacaoRecursoSegundaInstanciaNavigation { get; set; }
        public virtual TblInfracaoOrigem CodigoInfracaoOrigemNavigation { get; set; }
        public virtual TblInfracaoRecurso CodigoInfracaoRecursoPrimeiraInstanciaNavigation { get; set; }
        public virtual TblInfracaoRecurso CodigoInfracaoRecursoSegundaInstanciaNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoUsuarioAnaliseProcessualNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoUsuarioCadastroSapiensNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoUsuarioRevisaoProcessualNavigation { get; set; }
        public virtual ICollection<TblCobrancaInfracaoArquivo> TblCobrancaInfracaoArquivo { get; set; }
        public virtual ICollection<TblCobrancaInfracaoEvento> TblCobrancaInfracaoEvento { get; set; }
    }
}
