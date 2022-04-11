using System;
using System.Data.Entity.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GeradorRelatorios
{
    public partial class BD_SIORContext : DbContext
    {
        public BD_SIORContext()
        {
        }

        public BD_SIORContext(DbContextOptions<BD_SIORContext> options)
            : base(options)
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 180;
        }

        public virtual DbSet<AuxCorrecaoSituacaoDebitoNpreplublicada> AuxCorrecaoSituacaoDebitoNpreplublicada { get; set; }
        public virtual DbSet<AuxEditalNaCorrecaoInfracaoOrigemSagi> AuxEditalNaCorrecaoInfracaoOrigemSagi { get; set; }
        public virtual DbSet<AuxEditalNpCorrecaoInfracaoOrigemSagi> AuxEditalNpCorrecaoInfracaoOrigemSagi { get; set; }
        public virtual DbSet<AuxExpedicaoCorrecaoDataVencimentoControle1> AuxExpedicaoCorrecaoDataVencimentoControle1 { get; set; }
        public virtual DbSet<AuxExpedicaoCorrecaoDataVencimentoControle2DataAtualDebito> AuxExpedicaoCorrecaoDataVencimentoControle2DataAtualDebito { get; set; }
        public virtual DbSet<AuxFiciCorrecaoDataConferencia> AuxFiciCorrecaoDataConferencia { get; set; }
        public virtual DbSet<AuxInfracaoPrazoVencimentoNpCorrecao> AuxInfracaoPrazoVencimentoNpCorrecao { get; set; }
        public virtual DbSet<AuxInfracaoPreAutuacaoUpdateRegistroInfracao> AuxInfracaoPreAutuacaoUpdateRegistroInfracao { get; set; }
        public virtual DbSet<AuxMigracaoFinanceiro> AuxMigracaoFinanceiro { get; set; }
        public virtual DbSet<AuxProprietarioCorrecaoCnpj> AuxProprietarioCorrecaoCnpj { get; set; }
        public virtual DbSet<AuxProprietarioCorrecaoCpfcnpj> AuxProprietarioCorrecaoCpfcnpj { get; set; }
        public virtual DbSet<AuxSinpevMigracaoDocumentoDigitalizado> AuxSinpevMigracaoDocumentoDigitalizado { get; set; }
        public virtual DbSet<AuxUpdatePreAutuacaoRegistroInfracao> AuxUpdatePreAutuacaoRegistroInfracao { get; set; }
        public virtual DbSet<SIOR.DatabaseLog> DatabaseLog { get; set; }
        public virtual DbSet<ElmahError> ElmahError { get; set; }
        public virtual DbSet<TblBaseArquivoTipo> TblBaseArquivoTipo { get; set; }
        public virtual DbSet<TblBaseCalendario> TblBaseCalendario { get; set; }
        public virtual DbSet<TblBaseCorreiosCartaoPostagem> TblBaseCorreiosCartaoPostagem { get; set; }
        public virtual DbSet<TblBaseCorreiosCodigoBaixa> TblBaseCorreiosCodigoBaixa { get; set; }
        public virtual DbSet<TblBaseCorreiosMotivoDevolucao> TblBaseCorreiosMotivoDevolucao { get; set; }
        public virtual DbSet<TblBaseCorreiosPlanoTriagem> TblBaseCorreiosPlanoTriagem { get; set; }
        public virtual DbSet<TblBaseCorreiosPlanoTriagemFaixaCep> TblBaseCorreiosPlanoTriagemFaixaCep { get; set; }
        public virtual DbSet<TblBaseDiaSemana> TblBaseDiaSemana { get; set; }
        public virtual DbSet<TblBaseDocumentoUfscdnit> TblBaseDocumentoUfscdnit { get; set; }
        public virtual DbSet<TblBaseDocumentoUfscdnittipo> TblBaseDocumentoUfscdnittipo { get; set; }
        public virtual DbSet<TblBaseFebrabanMotivoOcorrencia> TblBaseFebrabanMotivoOcorrencia { get; set; }
        public virtual DbSet<TblBaseFebrabanMotivoOcorrenciaDominio> TblBaseFebrabanMotivoOcorrenciaDominio { get; set; }
        public virtual DbSet<TblBaseFebrabanMovimentoRemessa> TblBaseFebrabanMovimentoRemessa { get; set; }
        public virtual DbSet<TblBaseFebrabanMovimentoRetorno> TblBaseFebrabanMovimentoRetorno { get; set; }
        public virtual DbSet<TblBaseGruCodigoRecolhimentoTes> TblBaseGruCodigoRecolhimentoTes { get; set; }
        public virtual DbSet<TblBaseGruComRegistroNossoNumero> TblBaseGruComRegistroNossoNumero { get; set; }
        public virtual DbSet<TblBaseHora> TblBaseHora { get; set; }
        public virtual DbSet<TblBaseHoraFracao> TblBaseHoraFracao { get; set; }
        public virtual DbSet<TblBaseMes> TblBaseMes { get; set; }
        public virtual DbSet<TblBaseMunicipio> TblBaseMunicipio { get; set; }
        public virtual DbSet<TblBaseNup> TblBaseNup { get; set; }
        public virtual DbSet<TblBasePais> TblBasePais { get; set; }
        public virtual DbSet<TblBaseRodovia> TblBaseRodovia { get; set; }
        public virtual DbSet<TblBaseRodoviaUf> TblBaseRodoviaUf { get; set; }
        public virtual DbSet<TblBaseSelic> TblBaseSelic { get; set; }
        public virtual DbSet<TblBaseUf> TblBaseUf { get; set; }
        public virtual DbSet<TblBrlegalAnteprojeto> TblBrlegalAnteprojeto { get; set; }
        public virtual DbSet<TblBrlegalContrato> TblBrlegalContrato { get; set; }
        public virtual DbSet<TblBrlegalContratoTrecho> TblBrlegalContratoTrecho { get; set; }
        public virtual DbSet<TblBrlegalContratoTrechoContratado> TblBrlegalContratoTrechoContratado { get; set; }
        public virtual DbSet<TblBrlegalContratoTrechoRemovido> TblBrlegalContratoTrechoRemovido { get; set; }
        public virtual DbSet<TblBrlegalContratoTrechoRemovidoMotivo> TblBrlegalContratoTrechoRemovidoMotivo { get; set; }
        public virtual DbSet<TblBrlegalContratoTrechoSuspenso> TblBrlegalContratoTrechoSuspenso { get; set; }
        public virtual DbSet<TblBrlegalContratoTrechoSuspensoMotivo> TblBrlegalContratoTrechoSuspensoMotivo { get; set; }
        public virtual DbSet<TblBrlegalDocumento> TblBrlegalDocumento { get; set; }
        public virtual DbSet<TblBrlegalDocumentoTipo> TblBrlegalDocumentoTipo { get; set; }
        public virtual DbSet<TblBrlegalEdital> TblBrlegalEdital { get; set; }
        public virtual DbSet<TblBrlegalEmpresa> TblBrlegalEmpresa { get; set; }
        public virtual DbSet<TblBrlegalEngenheiroResponsavel> TblBrlegalEngenheiroResponsavel { get; set; }
        public virtual DbSet<TblBrlegalImplantacaoPlanejamento> TblBrlegalImplantacaoPlanejamento { get; set; }
        public virtual DbSet<TblBrlegalImplantacaoPlanejamentoEvento> TblBrlegalImplantacaoPlanejamentoEvento { get; set; }
        public virtual DbSet<TblBrlegalImplantacaoPlanejamentoSituacao> TblBrlegalImplantacaoPlanejamentoSituacao { get; set; }
        public virtual DbSet<TblBrlegalImplantacaoProjetoCronograma> TblBrlegalImplantacaoProjetoCronograma { get; set; }
        public virtual DbSet<TblBrlegalImplantacaoTrechoCronograma> TblBrlegalImplantacaoTrechoCronograma { get; set; }
        public virtual DbSet<TblBrlegalImplantacaoTrechoQuantitativo> TblBrlegalImplantacaoTrechoQuantitativo { get; set; }
        public virtual DbSet<TblBrlegalParametroPrazo> TblBrlegalParametroPrazo { get; set; }
        public virtual DbSet<TblBrlegalProjetoBasicoEntrega> TblBrlegalProjetoBasicoEntrega { get; set; }
        public virtual DbSet<TblBrlegalProjetoBasicoEntregaTrecho> TblBrlegalProjetoBasicoEntregaTrecho { get; set; }
        public virtual DbSet<TblBrlegalProjetoBasicoEntregaTrechoNaoAceite> TblBrlegalProjetoBasicoEntregaTrechoNaoAceite { get; set; }
        public virtual DbSet<TblBrlegalProjetoEntregaTrechoSituacao> TblBrlegalProjetoEntregaTrechoSituacao { get; set; }
        public virtual DbSet<TblBrlegalProjetoExecutivoEntrega> TblBrlegalProjetoExecutivoEntrega { get; set; }
        public virtual DbSet<TblBrlegalProjetoExecutivoEntregaTrecho> TblBrlegalProjetoExecutivoEntregaTrecho { get; set; }
        public virtual DbSet<TblBrlegalProjetoExecutivoEntregaTrechoNaoAceite> TblBrlegalProjetoExecutivoEntregaTrechoNaoAceite { get; set; }
        public virtual DbSet<TblBrlegalServicoFamilia> TblBrlegalServicoFamilia { get; set; }
        public virtual DbSet<TblBrlegalServicoItem> TblBrlegalServicoItem { get; set; }
        public virtual DbSet<TblBrlegalServicoTipo> TblBrlegalServicoTipo { get; set; }
        public virtual DbSet<TblBrlegalServicoUnidadeMedida> TblBrlegalServicoUnidadeMedida { get; set; }
        public virtual DbSet<TblCobrancaInfracao> TblCobrancaInfracao { get; set; }
        public virtual DbSet<TblCobrancaInfracaoArquivo> TblCobrancaInfracaoArquivo { get; set; }
        public virtual DbSet<TblCobrancaInfracaoDevedorCondicao> TblCobrancaInfracaoDevedorCondicao { get; set; }
        public virtual DbSet<TblCobrancaInfracaoDevedorNumeroInscricaoTipo> TblCobrancaInfracaoDevedorNumeroInscricaoTipo { get; set; }
        public virtual DbSet<TblCobrancaInfracaoDevedorSituacaoCadastral> TblCobrancaInfracaoDevedorSituacaoCadastral { get; set; }
        public virtual DbSet<TblCobrancaInfracaoEvento> TblCobrancaInfracaoEvento { get; set; }
        public virtual DbSet<TblCobrancaInfracaoFase> TblCobrancaInfracaoFase { get; set; }
        public virtual DbSet<TblCobrancaInfracaoIndicadorResultadoAnalise> TblCobrancaInfracaoIndicadorResultadoAnalise { get; set; }
        public virtual DbSet<TblCobrancaInfracaoIndicadorResultadoConsistencia> TblCobrancaInfracaoIndicadorResultadoConsistencia { get; set; }
        public virtual DbSet<TblCobrancaInfracaoSituacao> TblCobrancaInfracaoSituacao { get; set; }
        public virtual DbSet<TblInfracao> TblInfracao { get; set; }
        public virtual DbSet<TblInfracaoArquivoAnexo> TblInfracaoArquivoAnexo { get; set; }
        public virtual DbSet<TblInfracaoCausaCancelamento> TblInfracaoCausaCancelamento { get; set; }
        public virtual DbSet<TblInfracaoCondutor> TblInfracaoCondutor { get; set; }
        public virtual DbSet<TblInfracaoDa> TblInfracaoDa { get; set; }
        public virtual DbSet<TblInfracaoDaalegacao> TblInfracaoDaalegacao { get; set; }
        public virtual DbSet<TblInfracaoDaalegacaoEnquadramento> TblInfracaoDaalegacaoEnquadramento { get; set; }
        public virtual DbSet<TblInfracaoDaarquivo> TblInfracaoDaarquivo { get; set; }
        public virtual DbSet<TblInfracaoDacausaNaoConhecer> TblInfracaoDacausaNaoConhecer { get; set; }
        public virtual DbSet<TblInfracaoDaevento> TblInfracaoDaevento { get; set; }
        public virtual DbSet<TblInfracaoDafase> TblInfracaoDafase { get; set; }
        public virtual DbSet<TblInfracaoDafundamentacao> TblInfracaoDafundamentacao { get; set; }
        public virtual DbSet<TblInfracaoDafundamentacaoEnquadramento> TblInfracaoDafundamentacaoEnquadramento { get; set; }
        public virtual DbSet<TblInfracaoDaindicadorAdmissibilidade> TblInfracaoDaindicadorAdmissibilidade { get; set; }
        public virtual DbSet<TblInfracaoDaindicadorMerito> TblInfracaoDaindicadorMerito { get; set; }
        public virtual DbSet<TblInfracaoDaindicadorRecorrente> TblInfracaoDaindicadorRecorrente { get; set; }
        public virtual DbSet<TblInfracaoDaindicadorResultado> TblInfracaoDaindicadorResultado { get; set; }
        public virtual DbSet<TblInfracaoDanaoConhecer> TblInfracaoDanaoConhecer { get; set; }
        public virtual DbSet<TblInfracaoDaorigem> TblInfracaoDaorigem { get; set; }
        public virtual DbSet<TblInfracaoDasituacao> TblInfracaoDasituacao { get; set; }
        public virtual DbSet<TblInfracaoDesvinculacaoMulta> TblInfracaoDesvinculacaoMulta { get; set; }
        public virtual DbSet<TblInfracaoDesvinculacaoMultaArquivo> TblInfracaoDesvinculacaoMultaArquivo { get; set; }
        public virtual DbSet<TblInfracaoDesvinculacaoMultaEvento> TblInfracaoDesvinculacaoMultaEvento { get; set; }
        public virtual DbSet<TblInfracaoDesvinculacaoMultaOrigem> TblInfracaoDesvinculacaoMultaOrigem { get; set; }
        public virtual DbSet<TblInfracaoDesvinculacaoMultaSituacao> TblInfracaoDesvinculacaoMultaSituacao { get; set; }
        public virtual DbSet<TblInfracaoEfeitoSuspensivo> TblInfracaoEfeitoSuspensivo { get; set; }
        public virtual DbSet<TblInfracaoEfeitoSuspensivoArquivo> TblInfracaoEfeitoSuspensivoArquivo { get; set; }
        public virtual DbSet<TblInfracaoEfeitoSuspensivoEvento> TblInfracaoEfeitoSuspensivoEvento { get; set; }
        public virtual DbSet<TblInfracaoEfeitoSuspensivoFase> TblInfracaoEfeitoSuspensivoFase { get; set; }
        public virtual DbSet<TblInfracaoEfeitoSuspensivoSituacao> TblInfracaoEfeitoSuspensivoSituacao { get; set; }
        public virtual DbSet<TblInfracaoEfeitoSuspensivoTipo> TblInfracaoEfeitoSuspensivoTipo { get; set; }
        public virtual DbSet<TblInfracaoEmbarcador> TblInfracaoEmbarcador { get; set; }
        public virtual DbSet<TblInfracaoEnquadramento> TblInfracaoEnquadramento { get; set; }
        public virtual DbSet<TblInfracaoEnquadramentoCalculoTipo> TblInfracaoEnquadramentoCalculoTipo { get; set; }
        public virtual DbSet<TblInfracaoEnquadramentoEvento> TblInfracaoEnquadramentoEvento { get; set; }
        public virtual DbSet<TblInfracaoEnquadramentoTipoInfracional> TblInfracaoEnquadramentoTipoInfracional { get; set; }
        public virtual DbSet<TblInfracaoEnquadramentoValor> TblInfracaoEnquadramentoValor { get; set; }
        public virtual DbSet<TblInfracaoEnquadramentoVelocidade> TblInfracaoEnquadramentoVelocidade { get; set; }
        public virtual DbSet<TblInfracaoEquipamentoAfericaoTipo> TblInfracaoEquipamentoAfericaoTipo { get; set; }
        public virtual DbSet<TblInfracaoEvento> TblInfracaoEvento { get; set; }
        public virtual DbSet<TblInfracaoFase> TblInfracaoFase { get; set; }
        public virtual DbSet<TblInfracaoFaseGrupo> TblInfracaoFaseGrupo { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroArquivoCobrancaRemessa> TblInfracaoFinanceiroArquivoCobrancaRemessa { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroArquivoCobrancaRemessaSituacao> TblInfracaoFinanceiroArquivoCobrancaRemessaSituacao { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroArquivoCobrancaRemessaTipoEnvio> TblInfracaoFinanceiroArquivoCobrancaRemessaTipoEnvio { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo> TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroArquivoCobrancaRemessaTituloSituacao> TblInfracaoFinanceiroArquivoCobrancaRemessaTituloSituacao { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroArquivoCobrancaRetorno> TblInfracaoFinanceiroArquivoCobrancaRetorno { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroArquivoCobrancaRetornoSituacao> TblInfracaoFinanceiroArquivoCobrancaRetornoSituacao { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo> TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroArquivoCobrancaRetornoTituloSituacao> TblInfracaoFinanceiroArquivoCobrancaRetornoTituloSituacao { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroDebito> TblInfracaoFinanceiroDebito { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroDebitoEvento> TblInfracaoFinanceiroDebitoEvento { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroDebitoSituacao> TblInfracaoFinanceiroDebitoSituacao { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroDetran> TblInfracaoFinanceiroDetran { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroGru> TblInfracaoFinanceiroGru { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroGrucadastroTituloBanco> TblInfracaoFinanceiroGrucadastroTituloBanco { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroGrusituacao> TblInfracaoFinanceiroGrusituacao { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroGrutipoRegistro> TblInfracaoFinanceiroGrutipoRegistro { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroGrutipoValor> TblInfracaoFinanceiroGrutipoValor { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroPagamento> TblInfracaoFinanceiroPagamento { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroPagamentoBaixaManual> TblInfracaoFinanceiroPagamentoBaixaManual { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroPagamentoBaixaManualArquivo> TblInfracaoFinanceiroPagamentoBaixaManualArquivo { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroPagamentoBaixaManualEvento> TblInfracaoFinanceiroPagamentoBaixaManualEvento { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroPagamentoBaixaManualSituacao> TblInfracaoFinanceiroPagamentoBaixaManualSituacao { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroPagamentoDetran> TblInfracaoFinanceiroPagamentoDetran { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroPagamentoGru> TblInfracaoFinanceiroPagamentoGru { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroPagamentoTipo> TblInfracaoFinanceiroPagamentoTipo { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroRepasseDetran> TblInfracaoFinanceiroRepasseDetran { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroRepasseDetranevento> TblInfracaoFinanceiroRepasseDetranevento { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroRepasseDetranretornoExecucaoErro> TblInfracaoFinanceiroRepasseDetranretornoExecucaoErro { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroRepasseDetransituacao> TblInfracaoFinanceiroRepasseDetransituacao { get; set; }
        public virtual DbSet<TblInfracaoFinanceiroRepasseDetransituacaoArquivo> TblInfracaoFinanceiroRepasseDetransituacaoArquivo { get; set; }
        public virtual DbSet<TblInfracaoGravidade> TblInfracaoGravidade { get; set; }
        public virtual DbSet<TblInfracaoIdentificacaoInfratorCondutor> TblInfracaoIdentificacaoInfratorCondutor { get; set; }
        public virtual DbSet<TblInfracaoIdentificacaoInfratorCondutorArquivo> TblInfracaoIdentificacaoInfratorCondutorArquivo { get; set; }
        public virtual DbSet<TblInfracaoIdentificacaoInfratorCondutorConferenciaEspecial> TblInfracaoIdentificacaoInfratorCondutorConferenciaEspecial { get; set; }
        public virtual DbSet<TblInfracaoIdentificacaoInfratorCondutorEvento> TblInfracaoIdentificacaoInfratorCondutorEvento { get; set; }
        public virtual DbSet<TblInfracaoIdentificacaoInfratorCondutorFase> TblInfracaoIdentificacaoInfratorCondutorFase { get; set; }
        public virtual DbSet<TblInfracaoIdentificacaoInfratorCondutorIndicadorResultado> TblInfracaoIdentificacaoInfratorCondutorIndicadorResultado { get; set; }
        public virtual DbSet<TblInfracaoIdentificacaoInfratorCondutorMotivoInvalidacao> TblInfracaoIdentificacaoInfratorCondutorMotivoInvalidacao { get; set; }
        public virtual DbSet<TblInfracaoIdentificacaoInfratorCondutorOrigem> TblInfracaoIdentificacaoInfratorCondutorOrigem { get; set; }
        public virtual DbSet<TblInfracaoIdentificacaoInfratorCondutorSituacao> TblInfracaoIdentificacaoInfratorCondutorSituacao { get; set; }
        public virtual DbSet<TblInfracaoImagem> TblInfracaoImagem { get; set; }
        public virtual DbSet<TblInfracaoImagemTipo> TblInfracaoImagemTipo { get; set; }
        public virtual DbSet<TblInfracaoIndicadorResponsavel> TblInfracaoIndicadorResponsavel { get; set; }
        public virtual DbSet<TblInfracaoInfrator> TblInfracaoInfrator { get; set; }
        public virtual DbSet<TblInfracaoNotificacao> TblInfracaoNotificacao { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoArquivoBaixa> TblInfracaoNotificacaoArquivoBaixa { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoArquivoBaixaSituacao> TblInfracaoNotificacaoArquivoBaixaSituacao { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoEdital> TblInfracaoNotificacaoEdital { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoEditalArquivo> TblInfracaoNotificacaoEditalArquivo { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoEditalEvento> TblInfracaoNotificacaoEditalEvento { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoEditalNotificacao> TblInfracaoNotificacaoEditalNotificacao { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoEditalNotificacaoExcecao> TblInfracaoNotificacaoEditalNotificacaoExcecao { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoEditalSituacaoArquivo> TblInfracaoNotificacaoEditalSituacaoArquivo { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoEditalTipo> TblInfracaoNotificacaoEditalTipo { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoExpedicao> TblInfracaoNotificacaoExpedicao { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoExpedicaoEvento> TblInfracaoNotificacaoExpedicaoEvento { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoExpedicaoFalha> TblInfracaoNotificacaoExpedicaoFalha { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoExpedicaoFase> TblInfracaoNotificacaoExpedicaoFase { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoExpedicaoServico> TblInfracaoNotificacaoExpedicaoServico { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoExpedicaoSituacao> TblInfracaoNotificacaoExpedicaoSituacao { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoExpedicaoTipo> TblInfracaoNotificacaoExpedicaoTipo { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoMidiaAr> TblInfracaoNotificacaoMidiaAr { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoRestricao> TblInfracaoNotificacaoRestricao { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoRestricaoArquivo> TblInfracaoNotificacaoRestricaoArquivo { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoRestricaoEvento> TblInfracaoNotificacaoRestricaoEvento { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoRestricaoPncvequipamento> TblInfracaoNotificacaoRestricaoPncvequipamento { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoSituacao> TblInfracaoNotificacaoSituacao { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoTipo> TblInfracaoNotificacaoTipo { get; set; }
        public virtual DbSet<TblInfracaoNotificacaoTipoGrupo> TblInfracaoNotificacaoTipoGrupo { get; set; }
        public virtual DbSet<TblInfracaoNumeroAuto> TblInfracaoNumeroAuto { get; set; }
        public virtual DbSet<TblInfracaoNumeroAutoPrefixo> TblInfracaoNumeroAutoPrefixo { get; set; }
        public virtual DbSet<TblInfracaoNumeroNotificacaoPenalidade> TblInfracaoNumeroNotificacaoPenalidade { get; set; }
        public virtual DbSet<TblInfracaoNumeroProcessoBaixaManual> TblInfracaoNumeroProcessoBaixaManual { get; set; }
        public virtual DbSet<TblInfracaoNumeroProcessoDa> TblInfracaoNumeroProcessoDa { get; set; }
        public virtual DbSet<TblInfracaoNumeroProcessoDesvinculacaoMulta> TblInfracaoNumeroProcessoDesvinculacaoMulta { get; set; }
        public virtual DbSet<TblInfracaoNumeroProcessoEfeitoSuspensivo> TblInfracaoNumeroProcessoEfeitoSuspensivo { get; set; }
        public virtual DbSet<TblInfracaoNumeroProcessoIdentificacaoInfratorCondutor> TblInfracaoNumeroProcessoIdentificacaoInfratorCondutor { get; set; }
        public virtual DbSet<TblInfracaoNumeroProcessoRecurso> TblInfracaoNumeroProcessoRecurso { get; set; }
        public virtual DbSet<TblInfracaoNumeroProcessoSolicitacaoAdvertencia> TblInfracaoNumeroProcessoSolicitacaoAdvertencia { get; set; }
        public virtual DbSet<TblInfracaoOrigem> TblInfracaoOrigem { get; set; }
        public virtual DbSet<TblInfracaoOrigemContratacao> TblInfracaoOrigemContratacao { get; set; }
        public virtual DbSet<TblInfracaoOrigemContrato> TblInfracaoOrigemContrato { get; set; }
        public virtual DbSet<TblInfracaoParametros> TblInfracaoParametros { get; set; }
        public virtual DbSet<TblInfracaoPesagem> TblInfracaoPesagem { get; set; }
        public virtual DbSet<TblInfracaoPreAutuacao> TblInfracaoPreAutuacao { get; set; }
        public virtual DbSet<TblInfracaoPreAutuacaoAnalise> TblInfracaoPreAutuacaoAnalise { get; set; }
        public virtual DbSet<TblInfracaoPreAutuacaoArbitragemResultado> TblInfracaoPreAutuacaoArbitragemResultado { get; set; }
        public virtual DbSet<TblInfracaoPreAutuacaoClasseVeiculo> TblInfracaoPreAutuacaoClasseVeiculo { get; set; }
        public virtual DbSet<TblInfracaoPreAutuacaoConferenciaDupla> TblInfracaoPreAutuacaoConferenciaDupla { get; set; }
        public virtual DbSet<TblInfracaoPreAutuacaoConferenciaSimplesPncv> TblInfracaoPreAutuacaoConferenciaSimplesPncv { get; set; }
        public virtual DbSet<TblInfracaoPreAutuacaoConferenciaTipo> TblInfracaoPreAutuacaoConferenciaTipo { get; set; }
        public virtual DbSet<TblInfracaoPreAutuacaoFase> TblInfracaoPreAutuacaoFase { get; set; }
        public virtual DbSet<TblInfracaoPreAutuacaoImagem> TblInfracaoPreAutuacaoImagem { get; set; }
        public virtual DbSet<TblInfracaoPreAutuacaoLavratura> TblInfracaoPreAutuacaoLavratura { get; set; }
        public virtual DbSet<TblInfracaoPreAutuacaoMotivoInvalidacao> TblInfracaoPreAutuacaoMotivoInvalidacao { get; set; }
        public virtual DbSet<TblInfracaoPreAutuacaoMotivoInvalidacaoGrupo> TblInfracaoPreAutuacaoMotivoInvalidacaoGrupo { get; set; }
        public virtual DbSet<TblInfracaoPreAutuacaoPreparacaoImagem> TblInfracaoPreAutuacaoPreparacaoImagem { get; set; }
        public virtual DbSet<TblInfracaoPreAutuacaoSituacao> TblInfracaoPreAutuacaoSituacao { get; set; }
        public virtual DbSet<TblInfracaoProprietario> TblInfracaoProprietario { get; set; }
        public virtual DbSet<TblInfracaoProprietarioEndereco> TblInfracaoProprietarioEndereco { get; set; }
        public virtual DbSet<TblInfracaoProtocoloAutomatico> TblInfracaoProtocoloAutomatico { get; set; }
        public virtual DbSet<TblInfracaoRecurso> TblInfracaoRecurso { get; set; }
        public virtual DbSet<TblInfracaoRecursoAlegacao> TblInfracaoRecursoAlegacao { get; set; }
        public virtual DbSet<TblInfracaoRecursoAlegacaoEnquadramento> TblInfracaoRecursoAlegacaoEnquadramento { get; set; }
        public virtual DbSet<TblInfracaoRecursoAnaliseJulgamentoJari> TblInfracaoRecursoAnaliseJulgamentoJari { get; set; }
        public virtual DbSet<TblInfracaoRecursoAnaliseJulgamentoJarievento> TblInfracaoRecursoAnaliseJulgamentoJarievento { get; set; }
        public virtual DbSet<TblInfracaoRecursoAnaliseJulgamentoJarisituacao> TblInfracaoRecursoAnaliseJulgamentoJarisituacao { get; set; }
        public virtual DbSet<TblInfracaoRecursoArquivo> TblInfracaoRecursoArquivo { get; set; }
        public virtual DbSet<TblInfracaoRecursoCausaNaoConhecer> TblInfracaoRecursoCausaNaoConhecer { get; set; }
        public virtual DbSet<TblInfracaoRecursoEvento> TblInfracaoRecursoEvento { get; set; }
        public virtual DbSet<TblInfracaoRecursoFase> TblInfracaoRecursoFase { get; set; }
        public virtual DbSet<TblInfracaoRecursoFundamentacao> TblInfracaoRecursoFundamentacao { get; set; }
        public virtual DbSet<TblInfracaoRecursoFundamentacaoEnquadramento> TblInfracaoRecursoFundamentacaoEnquadramento { get; set; }
        public virtual DbSet<TblInfracaoRecursoIndicadorAdmissibilidade> TblInfracaoRecursoIndicadorAdmissibilidade { get; set; }
        public virtual DbSet<TblInfracaoRecursoIndicadorMerito> TblInfracaoRecursoIndicadorMerito { get; set; }
        public virtual DbSet<TblInfracaoRecursoIndicadorRecorrente> TblInfracaoRecursoIndicadorRecorrente { get; set; }
        public virtual DbSet<TblInfracaoRecursoIndicadorResultado> TblInfracaoRecursoIndicadorResultado { get; set; }
        public virtual DbSet<TblInfracaoRecursoInstrucaoNaoConhecer> TblInfracaoRecursoInstrucaoNaoConhecer { get; set; }
        public virtual DbSet<TblInfracaoRecursoOrigem> TblInfracaoRecursoOrigem { get; set; }
        public virtual DbSet<TblInfracaoRecursoRelatoNaoConhecer> TblInfracaoRecursoRelatoNaoConhecer { get; set; }
        public virtual DbSet<TblInfracaoRecursoSituacao> TblInfracaoRecursoSituacao { get; set; }
        public virtual DbSet<TblInfracaoRecursoTipo> TblInfracaoRecursoTipo { get; set; }
        public virtual DbSet<TblInfracaoSituacao> TblInfracaoSituacao { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoAdvertencia> TblInfracaoSolicitacaoAdvertencia { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoAdvertenciaArquivo> TblInfracaoSolicitacaoAdvertenciaArquivo { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoAdvertenciaCausaNaoConhecer> TblInfracaoSolicitacaoAdvertenciaCausaNaoConhecer { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoAdvertenciaEvento> TblInfracaoSolicitacaoAdvertenciaEvento { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoAdvertenciaFase> TblInfracaoSolicitacaoAdvertenciaFase { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoAdvertenciaFundamentacao> TblInfracaoSolicitacaoAdvertenciaFundamentacao { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidade> TblInfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidade { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoAdvertenciaIndicadorMerito> TblInfracaoSolicitacaoAdvertenciaIndicadorMerito { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoAdvertenciaIndicadorRecorrente> TblInfracaoSolicitacaoAdvertenciaIndicadorRecorrente { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoAdvertenciaIndicadorResultado> TblInfracaoSolicitacaoAdvertenciaIndicadorResultado { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoAdvertenciaNaoConhecer> TblInfracaoSolicitacaoAdvertenciaNaoConhecer { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoAdvertenciaOrigem> TblInfracaoSolicitacaoAdvertenciaOrigem { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoAdvertenciaSituacao> TblInfracaoSolicitacaoAdvertenciaSituacao { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoCancelamento> TblInfracaoSolicitacaoCancelamento { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoCancelamentoArquivo> TblInfracaoSolicitacaoCancelamentoArquivo { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoCancelamentoEvento> TblInfracaoSolicitacaoCancelamentoEvento { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoCancelamentoInfracao> TblInfracaoSolicitacaoCancelamentoInfracao { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoCancelamentoMotivo> TblInfracaoSolicitacaoCancelamentoMotivo { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoCancelamentoSituacao> TblInfracaoSolicitacaoCancelamentoSituacao { get; set; }
        public virtual DbSet<TblInfracaoSolicitacaoCancelamentoTipo> TblInfracaoSolicitacaoCancelamentoTipo { get; set; }
        public virtual DbSet<TblInfracaoTransportador> TblInfracaoTransportador { get; set; }
        public virtual DbSet<TblInfracaoVeiculo> TblInfracaoVeiculo { get; set; }
        public virtual DbSet<TblInfracaoVeiculoTipo> TblInfracaoVeiculoTipo { get; set; }
        public virtual DbSet<TblInfracaoVelocidadeValorConsiderado> TblInfracaoVelocidadeValorConsiderado { get; set; }
        public virtual DbSet<TblJari> TblJari { get; set; }
        public virtual DbSet<TblJariarquivo> TblJariarquivo { get; set; }
        public virtual DbSet<TblJariintegrante> TblJariintegrante { get; set; }
        public virtual DbSet<TblJariintegranteTipo> TblJariintegranteTipo { get; set; }
        public virtual DbSet<TblJariintegranteVinculo> TblJariintegranteVinculo { get; set; }
        public virtual DbSet<TblJarisessaoJulgamento> TblJarisessaoJulgamento { get; set; }
        public virtual DbSet<TblJarisessaoJulgamentoArquivo> TblJarisessaoJulgamentoArquivo { get; set; }
        public virtual DbSet<TblJarisessaoJulgamentoColegiado> TblJarisessaoJulgamentoColegiado { get; set; }
        public virtual DbSet<TblJarisessaoJulgamentoEvento> TblJarisessaoJulgamentoEvento { get; set; }
        public virtual DbSet<TblJarisessaoJulgamentoPauta> TblJarisessaoJulgamentoPauta { get; set; }
        public virtual DbSet<TblJarisessaoJulgamentoSituacao> TblJarisessaoJulgamentoSituacao { get; set; }
        public virtual DbSet<TblJarisessaoJulgamentoVoto> TblJarisessaoJulgamentoVoto { get; set; }
        public virtual DbSet<TblPesagemEquipamento> TblPesagemEquipamento { get; set; }
        public virtual DbSet<TblPesagemEquipamentoBalancaTipo> TblPesagemEquipamentoBalancaTipo { get; set; }
        public virtual DbSet<TblPesagemPosto> TblPesagemPosto { get; set; }
        public virtual DbSet<TblPesagemPostoEquipamento> TblPesagemPostoEquipamento { get; set; }
        public virtual DbSet<TblPncvagenteTransitoAtividadeDesempenhada> TblPncvagenteTransitoAtividadeDesempenhada { get; set; }
        public virtual DbSet<TblPncvagenteTransitoCredenciamento> TblPncvagenteTransitoCredenciamento { get; set; }
        public virtual DbSet<TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada> TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada { get; set; }
        public virtual DbSet<TblPncvagenteTransitoCredenciamentoEvento> TblPncvagenteTransitoCredenciamentoEvento { get; set; }
        public virtual DbSet<TblPncvagenteTransitoCredenciamentoSituacao> TblPncvagenteTransitoCredenciamentoSituacao { get; set; }
        public virtual DbSet<TblPncvagenteTransitoIndicadorResultadoVerificacao> TblPncvagenteTransitoIndicadorResultadoVerificacao { get; set; }
        public virtual DbSet<TblPncvagenteTransitoIndicadorTipoSanguineo> TblPncvagenteTransitoIndicadorTipoSanguineo { get; set; }
        public virtual DbSet<TblPncvagenteTransitoSolicitacaoCredenciamento> TblPncvagenteTransitoSolicitacaoCredenciamento { get; set; }
        public virtual DbSet<TblPncvagenteTransitoSolicitacaoCredenciamentoArquivo> TblPncvagenteTransitoSolicitacaoCredenciamentoArquivo { get; set; }
        public virtual DbSet<TblPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada> TblPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada { get; set; }
        public virtual DbSet<TblPncvagenteTransitoSolicitacaoCredenciamentoEvento> TblPncvagenteTransitoSolicitacaoCredenciamentoEvento { get; set; }
        public virtual DbSet<TblPncvagenteTransitoSolicitacaoCredenciamentoSituacao> TblPncvagenteTransitoSolicitacaoCredenciamentoSituacao { get; set; }
        public virtual DbSet<TblPncvagenteTransitoSolicitacaoDescredenciamento> TblPncvagenteTransitoSolicitacaoDescredenciamento { get; set; }
        public virtual DbSet<TblPncvagenteTransitoSolicitacaoDescredenciamentoArquivo> TblPncvagenteTransitoSolicitacaoDescredenciamentoArquivo { get; set; }
        public virtual DbSet<TblPncvagenteTransitoSolicitacaoDescredenciamentoEvento> TblPncvagenteTransitoSolicitacaoDescredenciamentoEvento { get; set; }
        public virtual DbSet<TblPncvagenteTransitoSolicitacaoDescredenciamentoSituacao> TblPncvagenteTransitoSolicitacaoDescredenciamentoSituacao { get; set; }
        public virtual DbSet<TblPncvautorizacaoInstalacaoEquipamento> TblPncvautorizacaoInstalacaoEquipamento { get; set; }
        public virtual DbSet<TblPncvautorizacaoInstalacaoEquipamentoEvento> TblPncvautorizacaoInstalacaoEquipamentoEvento { get; set; }
        public virtual DbSet<TblPncvautorizacaoInstalacaoEquipamentoRemanejamento> TblPncvautorizacaoInstalacaoEquipamentoRemanejamento { get; set; }
        public virtual DbSet<TblPncvautorizacaoInstalacaoEquipamentoSituacao> TblPncvautorizacaoInstalacaoEquipamentoSituacao { get; set; }
        public virtual DbSet<TblPncvautorizacaoInstalacaoEquipamentoSubstituicao> TblPncvautorizacaoInstalacaoEquipamentoSubstituicao { get; set; }
        public virtual DbSet<TblPncvedital> TblPncvedital { get; set; }
        public virtual DbSet<TblPncveditalLote> TblPncveditalLote { get; set; }
        public virtual DbSet<TblPncveditalLoteAbrangencia> TblPncveditalLoteAbrangencia { get; set; }
        public virtual DbSet<TblPncveditalObjeto> TblPncveditalObjeto { get; set; }
        public virtual DbSet<TblPncvequipamento> TblPncvequipamento { get; set; }
        public virtual DbSet<TblPncvequipamentoCodigo> TblPncvequipamentoCodigo { get; set; }
        public virtual DbSet<TblPncvequipamentoEstudoTecnico> TblPncvequipamentoEstudoTecnico { get; set; }
        public virtual DbSet<TblPncvequipamentoEstudoTecnicoArquivo> TblPncvequipamentoEstudoTecnicoArquivo { get; set; }
        public virtual DbSet<TblPncvequipamentoEstudoTecnicoFaixa> TblPncvequipamentoEstudoTecnicoFaixa { get; set; }
        public virtual DbSet<TblPncvequipamentoEvento> TblPncvequipamentoEvento { get; set; }
        public virtual DbSet<TblPncvequipamentoFaixa> TblPncvequipamentoFaixa { get; set; }
        public virtual DbSet<TblPncvequipamentoFaixaParalisacao> TblPncvequipamentoFaixaParalisacao { get; set; }
        public virtual DbSet<TblPncvequipamentoFaixaParalisacaoEvento> TblPncvequipamentoFaixaParalisacaoEvento { get; set; }
        public virtual DbSet<TblPncvequipamentoFaixaParalisacaoMotivo> TblPncvequipamentoFaixaParalisacaoMotivo { get; set; }
        public virtual DbSet<TblPncvequipamentoFaixaParalisacaoSituacao> TblPncvequipamentoFaixaParalisacaoSituacao { get; set; }
        public virtual DbSet<TblPncvequipamentoFaixaSituacao> TblPncvequipamentoFaixaSituacao { get; set; }
        public virtual DbSet<TblPncvequipamentoFaixaVerificacao> TblPncvequipamentoFaixaVerificacao { get; set; }
        public virtual DbSet<TblPncvequipamentoFaixaVerificacaoEvento> TblPncvequipamentoFaixaVerificacaoEvento { get; set; }
        public virtual DbSet<TblPncvequipamentoFaixaVerificacaoPlaca> TblPncvequipamentoFaixaVerificacaoPlaca { get; set; }
        public virtual DbSet<TblPncvequipamentoFaixaVerificacaoSituacao> TblPncvequipamentoFaixaVerificacaoSituacao { get; set; }
        public virtual DbSet<TblPncvequipamentoIndicadorCapturaImagem> TblPncvequipamentoIndicadorCapturaImagem { get; set; }
        public virtual DbSet<TblPncvequipamentoIndicadorComunicacao> TblPncvequipamentoIndicadorComunicacao { get; set; }
        public virtual DbSet<TblPncvequipamentoIndicadorInstalacao> TblPncvequipamentoIndicadorInstalacao { get; set; }
        public virtual DbSet<TblPncvequipamentoIndicadorTecnologia> TblPncvequipamentoIndicadorTecnologia { get; set; }
        public virtual DbSet<TblPncvequipamentoTipo> TblPncvequipamentoTipo { get; set; }
        public virtual DbSet<TblPncvestudoIndicadorClasseRodovia> TblPncvestudoIndicadorClasseRodovia { get; set; }
        public virtual DbSet<TblPncvestudoIndicadorComparacaoVelocidade> TblPncvestudoIndicadorComparacaoVelocidade { get; set; }
        public virtual DbSet<TblPncvestudoIndicadorCondicaoPavimento> TblPncvestudoIndicadorCondicaoPavimento { get; set; }
        public virtual DbSet<TblPncvestudoIndicadorDefensaMetalicaTerminal> TblPncvestudoIndicadorDefensaMetalicaTerminal { get; set; }
        public virtual DbSet<TblPncvestudoIndicadorDispositivoSeguranca> TblPncvestudoIndicadorDispositivoSeguranca { get; set; }
        public virtual DbSet<TblPncvestudoIndicadorGeometriaVia> TblPncvestudoIndicadorGeometriaVia { get; set; }
        public virtual DbSet<TblPncvestudoIndicadorNivelRisco> TblPncvestudoIndicadorNivelRisco { get; set; }
        public virtual DbSet<TblPncvestudoIndicadorRelevo> TblPncvestudoIndicadorRelevo { get; set; }
        public virtual DbSet<TblPncvestudoIndicadorSinalizacaoLadoRodovia> TblPncvestudoIndicadorSinalizacaoLadoRodovia { get; set; }
        public virtual DbSet<TblPncvestudoIndicadorTracadoVia> TblPncvestudoIndicadorTracadoVia { get; set; }
        public virtual DbSet<TblPncvestudoIndicadorTransito> TblPncvestudoIndicadorTransito { get; set; }
        public virtual DbSet<TblPncvestudoTecnicoInstalacao> TblPncvestudoTecnicoInstalacao { get; set; }
        public virtual DbSet<TblPncvestudoTecnicoInstalacaoAcidente> TblPncvestudoTecnicoInstalacaoAcidente { get; set; }
        public virtual DbSet<TblPncvestudoTecnicoInstalacaoCodigo> TblPncvestudoTecnicoInstalacaoCodigo { get; set; }
        public virtual DbSet<TblPncvestudoTecnicoInstalacaoEquipamento> TblPncvestudoTecnicoInstalacaoEquipamento { get; set; }
        public virtual DbSet<TblPncvestudoTecnicoInstalacaoEvento> TblPncvestudoTecnicoInstalacaoEvento { get; set; }
        public virtual DbSet<TblPncvestudoTecnicoInstalacaoFaixa> TblPncvestudoTecnicoInstalacaoFaixa { get; set; }
        public virtual DbSet<TblPncvestudoTecnicoInstalacaoFoto> TblPncvestudoTecnicoInstalacaoFoto { get; set; }
        public virtual DbSet<TblPncvestudoTecnicoInstalacaoSinalizacaoVertical> TblPncvestudoTecnicoInstalacaoSinalizacaoVertical { get; set; }
        public virtual DbSet<TblPncvestudoTecnicoInstalacaoSituacao> TblPncvestudoTecnicoInstalacaoSituacao { get; set; }
        public virtual DbSet<TblPncvestudoViabilidade> TblPncvestudoViabilidade { get; set; }
        public virtual DbSet<TblPncvestudoViabilidadeAcidente> TblPncvestudoViabilidadeAcidente { get; set; }
        public virtual DbSet<TblPncvestudoViabilidadeCodigo> TblPncvestudoViabilidadeCodigo { get; set; }
        public virtual DbSet<TblPncvestudoViabilidadeDocumento> TblPncvestudoViabilidadeDocumento { get; set; }
        public virtual DbSet<TblPncvestudoViabilidadeEvento> TblPncvestudoViabilidadeEvento { get; set; }
        public virtual DbSet<TblPncvestudoViabilidadeFaixa> TblPncvestudoViabilidadeFaixa { get; set; }
        public virtual DbSet<TblPncvestudoViabilidadeFoto> TblPncvestudoViabilidadeFoto { get; set; }
        public virtual DbSet<TblPncvestudoViabilidadeMotivacao> TblPncvestudoViabilidadeMotivacao { get; set; }
        public virtual DbSet<TblPncvestudoViabilidadeOrigem> TblPncvestudoViabilidadeOrigem { get; set; }
        public virtual DbSet<TblPncvestudoViabilidadeResultado> TblPncvestudoViabilidadeResultado { get; set; }
        public virtual DbSet<TblPncvestudoViabilidadeSituacao> TblPncvestudoViabilidadeSituacao { get; set; }
        public virtual DbSet<TblPncvmarcaEquipamento> TblPncvmarcaEquipamento { get; set; }
        public virtual DbSet<TblPncvmodeloEquipamento> TblPncvmodeloEquipamento { get; set; }
        public virtual DbSet<TblPncvmodeloEquipamentoRegistroSanmft> TblPncvmodeloEquipamentoRegistroSanmft { get; set; }
        public virtual DbSet<TblPncvnotaInstalacao> TblPncvnotaInstalacao { get; set; }
        public virtual DbSet<TblPncvnotaInstalacaoEquipamento> TblPncvnotaInstalacaoEquipamento { get; set; }
        public virtual DbSet<TblPncvoperadora> TblPncvoperadora { get; set; }
        public virtual DbSet<TblPncvparametros> TblPncvparametros { get; set; }
        public virtual DbSet<TblPncvparametrosEditalLote> TblPncvparametrosEditalLote { get; set; }
        public virtual DbSet<TblPncvsentidoRodovia> TblPncvsentidoRodovia { get; set; }
        public virtual DbSet<TblPncvsolicitacaoCancelamento> TblPncvsolicitacaoCancelamento { get; set; }
        public virtual DbSet<TblPncvsolicitacaoCancelamentoArquivo> TblPncvsolicitacaoCancelamentoArquivo { get; set; }
        public virtual DbSet<TblPncvsolicitacaoCancelamentoEquipamento> TblPncvsolicitacaoCancelamentoEquipamento { get; set; }
        public virtual DbSet<TblPncvsolicitacaoCancelamentoEvento> TblPncvsolicitacaoCancelamentoEvento { get; set; }
        public virtual DbSet<TblPncvsolicitacaoCancelamentoSituacao> TblPncvsolicitacaoCancelamentoSituacao { get; set; }
        public virtual DbSet<TblPncvsolicitacaoTransferenciaContrato> TblPncvsolicitacaoTransferenciaContrato { get; set; }
        public virtual DbSet<TblPncvsolicitacaoTransferenciaContratoArquivo> TblPncvsolicitacaoTransferenciaContratoArquivo { get; set; }
        public virtual DbSet<TblPncvsolicitacaoTransferenciaContratoEquipamento> TblPncvsolicitacaoTransferenciaContratoEquipamento { get; set; }
        public virtual DbSet<TblPncvsolicitacaoTransferenciaContratoEvento> TblPncvsolicitacaoTransferenciaContratoEvento { get; set; }
        public virtual DbSet<TblPncvsolicitacaoTransferenciaContratoSituacao> TblPncvsolicitacaoTransferenciaContratoSituacao { get; set; }
        public virtual DbSet<TblPncvtipoPlacaSinalizacao> TblPncvtipoPlacaSinalizacao { get; set; }
        public virtual DbSet<TblPncvtipoVia> TblPncvtipoVia { get; set; }
        public virtual DbSet<TblSegurancaAcidenteTransito> TblSegurancaAcidenteTransito { get; set; }
        public virtual DbSet<TblSegurancaAcidenteTransitoCausa> TblSegurancaAcidenteTransitoCausa { get; set; }
        public virtual DbSet<TblSegurancaAcidenteTransitoFonteDados> TblSegurancaAcidenteTransitoFonteDados { get; set; }
        public virtual DbSet<TblSegurancaAcidenteTransitoGravidade> TblSegurancaAcidenteTransitoGravidade { get; set; }
        public virtual DbSet<TblSegurancaAcidenteTransitoSentido> TblSegurancaAcidenteTransitoSentido { get; set; }
        public virtual DbSet<TblSegurancaAcidenteTransitoTipo> TblSegurancaAcidenteTransitoTipo { get; set; }
        public virtual DbSet<TblSegurancaAcidenteTransitoUsoSolo> TblSegurancaAcidenteTransitoUsoSolo { get; set; }
        public virtual DbSet<TblSegurancaClasseSegmentoRodovia> TblSegurancaClasseSegmentoRodovia { get; set; }
        public virtual DbSet<TblSegurancaSegmentoCritico> TblSegurancaSegmentoCritico { get; set; }
        public virtual DbSet<TblSegurancaSegmentoHomogeneo> TblSegurancaSegmentoHomogeneo { get; set; }
        public virtual DbSet<TblSistemaAcao> TblSistemaAcao { get; set; }
        public virtual DbSet<TblSistemaArea> TblSistemaArea { get; set; }
        public virtual DbSet<TblSistemaCatalogoConexao> TblSistemaCatalogoConexao { get; set; }
        public virtual DbSet<TblSistemaCatalogoConexaoServico> TblSistemaCatalogoConexaoServico { get; set; }
        public virtual DbSet<TblSistemaConfiguracao> TblSistemaConfiguracao { get; set; }
        public virtual DbSet<TblSistemaConfiguracaoPropriedadeTipo> TblSistemaConfiguracaoPropriedadeTipo { get; set; }
        public virtual DbSet<TblSistemaControle> TblSistemaControle { get; set; }
        public virtual DbSet<TblSistemaEvento> TblSistemaEvento { get; set; }
        public virtual DbSet<TblSistemaEventoTipo> TblSistemaEventoTipo { get; set; }
        public virtual DbSet<TblSistemaInstituicao> TblSistemaInstituicao { get; set; }
        public virtual DbSet<TblSistemaInstituicaoTipo> TblSistemaInstituicaoTipo { get; set; }
        public virtual DbSet<TblSistemaMenu> TblSistemaMenu { get; set; }
        public virtual DbSet<TblSistemaPerfil> TblSistemaPerfil { get; set; }
        public virtual DbSet<TblSistemaPerfilAcao> TblSistemaPerfilAcao { get; set; }
        public virtual DbSet<TblSistemaPerfilMenu> TblSistemaPerfilMenu { get; set; }
        public virtual DbSet<TblSistemaPerfilPerfil> TblSistemaPerfilPerfil { get; set; }
        public virtual DbSet<TblSistemaSolicitacaoAcesso> TblSistemaSolicitacaoAcesso { get; set; }
        public virtual DbSet<TblSistemaSolicitacaoAcessoSituacao> TblSistemaSolicitacaoAcessoSituacao { get; set; }
        public virtual DbSet<TblSistemaSsrs> TblSistemaSsrs { get; set; }
        public virtual DbSet<TblSistemaSsrsrelatorio> TblSistemaSsrsrelatorio { get; set; }
        public virtual DbSet<TblSistemaUsuario> TblSistemaUsuario { get; set; }
        public virtual DbSet<TblSistemaUsuarioAcao> TblSistemaUsuarioAcao { get; set; }
        public virtual DbSet<TblSistemaUsuarioBrlegalContrato> TblSistemaUsuarioBrlegalContrato { get; set; }
        public virtual DbSet<TblSistemaUsuarioEvento> TblSistemaUsuarioEvento { get; set; }
        public virtual DbSet<TblSistemaUsuarioMenu> TblSistemaUsuarioMenu { get; set; }
        public virtual DbSet<TblSistemaUsuarioPerfil> TblSistemaUsuarioPerfil { get; set; }
        public virtual DbSet<TblSistemaUsuarioPncvabrangencia> TblSistemaUsuarioPncvabrangencia { get; set; }
        public virtual DbSet<TblSistemaUsuarioPncveditalLote> TblSistemaUsuarioPncveditalLote { get; set; }
        public virtual DbSet<TblSistemaUsuarioPncvindicadorVinculo> TblSistemaUsuarioPncvindicadorVinculo { get; set; }
        public virtual DbSet<TblSnvtrecho> TblSnvtrecho { get; set; }
        public virtual DbSet<TblSnvtrechoCoincidente> TblSnvtrechoCoincidente { get; set; }
        public virtual DbSet<TblSnvtrechoFonteDados> TblSnvtrechoFonteDados { get; set; }
        public virtual DbSet<TblSnvtrechoHistorico> TblSnvtrechoHistorico { get; set; }
        public virtual DbSet<TblSnvtrechoOcupacao> TblSnvtrechoOcupacao { get; set; }
        public virtual DbSet<TblSnvtrechoSuperficie> TblSnvtrechoSuperficie { get; set; }
        public virtual DbSet<TblSnvtrechoTipo> TblSnvtrechoTipo { get; set; }
        public virtual DbSet<TblTrafegoVelocidadeMediaHorario> TblTrafegoVelocidadeMediaHorario { get; set; }
        public virtual DbSet<TblTrafegoVelocidadeMediaSemanal> TblTrafegoVelocidadeMediaSemanal { get; set; }
        public virtual DbSet<TblTrafegoVmdanual> TblTrafegoVmdanual { get; set; }
        public virtual DbSet<TblTrafegoVmdanualClassificado> TblTrafegoVmdanualClassificado { get; set; }
        public virtual DbSet<TblTrafegoVmdanualClassificadoClasseVeiculo> TblTrafegoVmdanualClassificadoClasseVeiculo { get; set; }
        public virtual DbSet<TblTrafegoVmdclasseVeiculo> TblTrafegoVmdclasseVeiculo { get; set; }
        public virtual DbSet<TblTrafegoVmdfonteDados> TblTrafegoVmdfonteDados { get; set; }
        public virtual DbSet<TblTrafegoVmdhorario> TblTrafegoVmdhorario { get; set; }
        public virtual DbSet<TblTrafegoVmdhorarioClassificado> TblTrafegoVmdhorarioClassificado { get; set; }
        public virtual DbSet<TblTrafegoVmdhorarioClassificadoClasseVeiculo> TblTrafegoVmdhorarioClassificadoClasseVeiculo { get; set; }
        public virtual DbSet<TblTrafegoVmdmensal> TblTrafegoVmdmensal { get; set; }
        public virtual DbSet<TblTrafegoVmdmensalClassificado> TblTrafegoVmdmensalClassificado { get; set; }
        public virtual DbSet<TblTrafegoVmdmensalClassificadoClasseVeiculo> TblTrafegoVmdmensalClassificadoClasseVeiculo { get; set; }
        public virtual DbSet<TblTrafegoVmdsemanal> TblTrafegoVmdsemanal { get; set; }
        public virtual DbSet<TblTrafegoVmdsemanalClassificado> TblTrafegoVmdsemanalClassificado { get; set; }
        public virtual DbSet<TblTrafegoVmdsemanalClassificadoClasseVeiculo> TblTrafegoVmdsemanalClassificadoClasseVeiculo { get; set; }

        // Unable to generate entity type for table 'dbo.AUX_RepasseDETRAN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Aux_ArquivoMC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUX_FICI_Arquivo_CorrecaoNome'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FICIS_01032018'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUX_Veiculo_CorrecaoMarcaModelo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblICOMTesteRecebimento'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=10.100.10.144\\SIOR;Initial Catalog=BD_SIOR;Persist Security Info=True;User ID=nestor.santos;Password=​Ns92878@;MultipleActiveResultSets=True;Connection Timeout=180",
                    x => x.UseNetTopologySuite());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<AuxCorrecaoSituacaoDebitoNpreplublicada>(entity =>
            {
                entity.HasKey(e => e.InfracaoCodigoProcesso)
                    .HasName("prkAUX_CorrecaoSituacaoDebitoNPReplublicada");

                entity.ToTable("AUX_CorrecaoSituacaoDebitoNPReplublicada");

                entity.Property(e => e.InfracaoCodigoProcesso)
                    .HasColumnName("Infracao_CodigoProcesso")
                    .ValueGeneratedNever();

                entity.Property(e => e.DebitoCodigoSituacaoAtual).HasColumnName("Debito_CodigoSituacao_Atual");

                entity.Property(e => e.DebitoValorOriginal)
                    .HasColumnName("Debito_ValorOriginal")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.DebitoValorOriginal60Porcento)
                    .HasColumnName("Debito_ValorOriginal60Porcento")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.DebitoValorOriginal80Porcento)
                    .HasColumnName("Debito_ValorOriginal80Porcento")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.DebitoValorPagoAteVencimentoNp)
                    .HasColumnName("Debito_ValorPago_AteVencimentoNP")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.DebitoValorPagoTotal)
                    .HasColumnName("Debito_ValorPago_Total")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.InfracaoCodigoSituacao).HasColumnName("Infracao_CodigoSituacao");

                entity.Property(e => e.InfracaoIndicadorReconhecidoCometimento).HasColumnName("Infracao_IndicadorReconhecidoCometimento");

                entity.Property(e => e.ProcessamentoDebitoSituacaoIndicadorAtualizado).HasColumnName("Processamento_Debito_Situacao_IndicadorAtualizado");

                entity.Property(e => e.ProcessamentoDebitoSituacaoIndicadorQuitacao).HasColumnName("Processamento_Debito_Situacao_IndicadorQuitacao");
            });

            modelBuilder.Entity<AuxEditalNaCorrecaoInfracaoOrigemSagi>(entity =>
            {
                entity.HasKey(e => e.NumeroAuto)
                    .HasName("PK_AUX_EditalNA_CorrecaoAutosOrigemSAGI");

                entity.ToTable("AUX_EditalNA_CorrecaoInfracaoOrigemSAGI");

                entity.HasIndex(e => new { e.Acao, e.IndicadorProcessado, e.CodigoInfracao })
                    .HasName("idxAUX_EditalNA_CorrecaoInfracaoOrigemSAGI");

                entity.Property(e => e.NumeroAuto)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Acao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuxEditalNpCorrecaoInfracaoOrigemSagi>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacao)
                    .HasName("prkAUX_EditalNP_CorrecaoAutosOrigemSAGI");

                entity.ToTable("AUX_EditalNP_CorrecaoInfracaoOrigemSAGI");

                entity.HasIndex(e => new { e.Acao, e.CodigoInfracaoNotificacao })
                    .HasName("idxAUX_EditalNP_CorrecaoInfracaoOrigemSAGI");

                entity.Property(e => e.CodigoInfracaoNotificacao).ValueGeneratedNever();

                entity.Property(e => e.Acao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAuto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuxExpedicaoCorrecaoDataVencimentoControle1>(entity =>
            {
                entity.HasKey(e => e.ExpedicaoNumeroRemessa)
                    .HasName("prkAUX_Expedicao_CorrecaoDataVencimento_Controle1");

                entity.ToTable("AUX_Expedicao_CorrecaoDataVencimento_Controle1");

                entity.Property(e => e.ExpedicaoNumeroRemessa)
                    .HasColumnName("Expedicao_NumeroRemessa")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ExpedicaoCodigoProcesso).HasColumnName("Expedicao_CodigoProcesso");

                entity.Property(e => e.ExpedicaoDataVencimentoAtual)
                    .HasColumnName("Expedicao_DataVencimento_Atual")
                    .HasColumnType("date");

                entity.Property(e => e.ExpedicaoDataVencimentoConsiderada)
                    .HasColumnName("Expedicao_DataVencimento_Considerada")
                    .HasColumnType("date");

                entity.Property(e => e.ExpedicaoNotificacaoCodigoTipo).HasColumnName("Expedicao_Notificacao_CodigoTipo");

                entity.Property(e => e.ProcessamentoControle2IndicadorInsercao).HasColumnName("Processamento_Controle2_IndicadorInsercao");

                entity.Property(e => e.ProcessamentoExpedicaoIndicadorAtualizado).HasColumnName("Processamento_Expedicao_IndicadorAtualizado");

                entity.Property(e => e.ProcessamentoExpedicaoIndicadorCorrecao).HasColumnName("Processamento_Expedicao_IndicadorCorrecao");

                entity.Property(e => e.ProcessamentoNotificacaoIndicadorAtualizado).HasColumnName("Processamento_Notificacao_IndicadorAtualizado");
            });

            modelBuilder.Entity<AuxExpedicaoCorrecaoDataVencimentoControle2DataAtualDebito>(entity =>
            {
                entity.HasKey(e => e.NotificacaoCodigoProcesso)
                    .HasName("PK_AUX_CorrecaoDataVencimentoExpedicao");

                entity.ToTable("AUX_Expedicao_CorrecaoDataVencimento_Controle2_DataAtual_Debito");

                entity.Property(e => e.NotificacaoCodigoProcesso)
                    .HasColumnName("Notificacao_CodigoProcesso")
                    .ValueGeneratedNever();

                entity.Property(e => e.DebitoCodigoSituacaoAtual).HasColumnName("Debito_CodigoSituacao_Atual");

                entity.Property(e => e.DebitoValorOriginal)
                    .HasColumnName("Debito_ValorOriginal")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.DebitoValorOriginal60Porcento)
                    .HasColumnName("Debito_ValorOriginal60Porcento")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.DebitoValorOriginal80Porcento)
                    .HasColumnName("Debito_ValorOriginal80Porcento")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.DebitoValorPagoAteVencimentoNp)
                    .HasColumnName("Debito_ValorPago_AteVencimentoNP")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.DebitoValorPagoTotal)
                    .HasColumnName("Debito_ValorPago_Total")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.InfracaoCodigoProcesso).HasColumnName("Infracao_CodigoProcesso");

                entity.Property(e => e.InfracaoCodigoSituacao).HasColumnName("Infracao_CodigoSituacao");

                entity.Property(e => e.InfracaoIndicadorReconhecidoCometimento).HasColumnName("Infracao_IndicadorReconhecidoCometimento");

                entity.Property(e => e.NotificacaoCodigoExpedicao).HasColumnName("Notificacao_CodigoExpedicao");

                entity.Property(e => e.NotificacaoCodigoTipo).HasColumnName("Notificacao_CodigoTipo");

                entity.Property(e => e.NotificacaoDataVencimentoAtualAtual)
                    .HasColumnName("Notificacao_DataVencimentoAtual_Atual")
                    .HasColumnType("date");

                entity.Property(e => e.NotificacaoDataVencimentoAtualRecalculado)
                    .HasColumnName("Notificacao_DataVencimentoAtual_Recalculado")
                    .HasColumnType("date");

                entity.Property(e => e.NotificacaoDataVencimentoEdital)
                    .HasColumnName("Notificacao_DataVencimentoEdital")
                    .HasColumnType("date");

                entity.Property(e => e.NotificacaoDataVencimentoExpedicaoCorrigido)
                    .HasColumnName("Notificacao_DataVencimentoExpedicao_Corrigido")
                    .HasColumnType("date");

                entity.Property(e => e.ProcessamentoDataVencimentoAtualIndicadorAtualizado).HasColumnName("Processamento_DataVencimentoAtual_IndicadorAtualizado");

                entity.Property(e => e.ProcessamentoDataVencimentoAtualIndicadorCorrecao).HasColumnName("Processamento_DataVencimentoAtual_IndicadorCorrecao");

                entity.Property(e => e.ProcessamentoDataVencimentoAtualIndicadorInconsistencia).HasColumnName("Processamento_DataVencimentoAtual_IndicadorInconsistencia");

                entity.Property(e => e.ProcessamentoDebitoDataVencimentoNpIndicadorAtualizado).HasColumnName("Processamento_Debito_DataVencimentoNP_IndicadorAtualizado");

                entity.Property(e => e.ProcessamentoDebitoSituacaoIndicadorAnalise).HasColumnName("Processamento_Debito_Situacao_IndicadorAnalise");

                entity.Property(e => e.ProcessamentoDebitoSituacaoIndicadorAtualizado).HasColumnName("Processamento_Debito_Situacao_IndicadorAtualizado");

                entity.Property(e => e.ProcessamentoDebitoSituacaoIndicadorQuitacao).HasColumnName("Processamento_Debito_Situacao_IndicadorQuitacao");
            });

            modelBuilder.Entity<AuxFiciCorrecaoDataConferencia>(entity =>
            {
                entity.HasKey(e => e.NumeroAuto)
                    .HasName("prkAUX_FICI_CorrecaoDataConferencia");

                entity.ToTable("AUX_FICI_CorrecaoDataConferencia");

                entity.Property(e => e.NumeroAuto)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ConferenciaAtual).HasColumnType("date");

                entity.Property(e => e.ConferenciaPrimeira).HasColumnType("date");

                entity.Property(e => e.Resultado)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuxInfracaoPrazoVencimentoNpCorrecao>(entity =>
            {
                entity.HasKey(e => e.InfracaoCodigoProcesso)
                    .HasName("prkAUX_Infracao_PrazoVencimentoNP_Correcao");

                entity.ToTable("AUX_Infracao_PrazoVencimentoNP_Correcao");

                entity.HasIndex(e => new { e.InfracaoCodigoProcesso, e.ProcessamentoPrazoExpedicaoNpIndicadorAtualizado })
                    .HasName("NonClusteredIndex-20180224-121646");

                entity.Property(e => e.InfracaoCodigoProcesso)
                    .HasColumnName("Infracao_CodigoProcesso")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProcessamentoPrazoExpedicaoNpIndicadorAtualizado).HasColumnName("Processamento_PrazoExpedicaoNP_IndicadorAtualizado");
            });

            modelBuilder.Entity<AuxInfracaoPreAutuacaoUpdateRegistroInfracao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPreAutuacao)
                    .HasName("prkAUX_InfracaoPreAutuacao_UpdateRegistroInfracao");

                entity.ToTable("AUX_InfracaoPreAutuacao_UpdateRegistroInfracao");

                entity.Property(e => e.CodigoInfracaoPreAutuacao).ValueGeneratedNever();

                entity.Property(e => e.CodigoRenavamunidadeMedida).HasColumnName("CodigoRENAVAMUnidadeMedida");

                entity.Property(e => e.DataHoraInfracao).HasColumnType("datetime");

                entity.Property(e => e.ImagemPrincipalArquivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LimiteRegulamentado).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorConsiderado).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorOriginal).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal60Porcento).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal80Porcento).HasColumnType("decimal(7, 2)");
            });

            modelBuilder.Entity<AuxMigracaoFinanceiro>(entity =>
            {
                entity.HasKey(e => e.CodigoProcesso)
                    .HasName("prkAUX_ArquivoProcessado");

                entity.ToTable("AUX_MigracaoFinanceiro");

                entity.HasIndex(e => e.IndicadorProcessado)
                    .HasName("idxAUX_ArquivoProcessamento");

                entity.Property(e => e.CodigoProcesso).ValueGeneratedNever();

                entity.Property(e => e.DataVencimentoNp)
                    .HasColumnName("DataVencimentoNP")
                    .HasColumnType("date");

                entity.Property(e => e.IndicadorReprocessar)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ValorPago).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorPagoAteVencimentoNp)
                    .HasColumnName("ValorPagoAteVencimentoNP")
                    .HasColumnType("decimal(7, 2)");
            });

            modelBuilder.Entity<AuxProprietarioCorrecaoCnpj>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracao)
                    .HasName("prkAUX_Proprietario_CorrecaoCNPJ");

                entity.ToTable("AUX_Proprietario_CorrecaoCNPJ");

                entity.Property(e => e.CodigoInfracao).ValueGeneratedNever();

                entity.Property(e => e.Analise2IndicadorProcessado).HasColumnName("Analise2_IndicadorProcessado");

                entity.Property(e => e.Analise2IndicadorValidade).HasColumnName("Analise2_IndicadorValidade");

                entity.Property(e => e.Analise2NumeroCnpj)
                    .HasColumnName("Analise2_NumeroCNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Analise2NumeroCnpjformatado)
                    .HasColumnName("Analise2_NumeroCNPJFormatado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AnaliseIndicadorProcessado).HasColumnName("Analise_IndicadorProcessado");

                entity.Property(e => e.AnaliseIndicadorValidade).HasColumnName("Analise_IndicadorValidade");

                entity.Property(e => e.AnaliseNumeroCnpj)
                    .HasColumnName("Analise_NumeroCNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.AnaliseNumeroCnpjformatado)
                    .HasColumnName("Analise_NumeroCNPJFormatado")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRenavampossuidorTipoDocumento).HasColumnName("CodigoRENAVAMPossuidorTipoDocumento");

                entity.Property(e => e.DataInfracao).HasColumnType("date");

                entity.Property(e => e.Nome)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAuto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCpfcnpj)
                    .HasColumnName("NumeroCPFCNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCpfcnpjformatado)
                    .HasColumnName("NumeroCPFCNPJFormatado")
                    .HasMaxLength(18)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuxProprietarioCorrecaoCpfcnpj>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracao)
                    .HasName("prkAUX_Proprietario_CorrecaoCPFCNPJ");

                entity.ToTable("AUX_Proprietario_CorrecaoCPFCNPJ");

                entity.Property(e => e.CodigoInfracao).ValueGeneratedNever();

                entity.Property(e => e.Analise1IndicadorProcessado).HasColumnName("Analise1_IndicadorProcessado");

                entity.Property(e => e.Analise1IndicadorValidade).HasColumnName("Analise1_IndicadorValidade");

                entity.Property(e => e.Analise1NumeroCpf)
                    .HasColumnName("Analise1_NumeroCPF")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Analise1NumeroCpfformatado)
                    .HasColumnName("Analise1_NumeroCPFFormatado")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Analise2CodigoRenavampossuidorTipoDocumento).HasColumnName("Analise2_CodigoRENAVAMPossuidorTipoDocumento");

                entity.Property(e => e.Analise2IndicadorProcessado).HasColumnName("Analise2_IndicadorProcessado");

                entity.Property(e => e.Analise2NumeroCpfcnpj)
                    .HasColumnName("Analise2_NumeroCPFCNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Analise2NumeroCpfcnpjformatado)
                    .HasColumnName("Analise2_NumeroCPFCNPJFormatado")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Analise3IndicadorProcessado).HasColumnName("Analise3_IndicadorProcessado");

                entity.Property(e => e.Analise3IndicadorValidade).HasColumnName("Analise3_IndicadorValidade");

                entity.Property(e => e.Analise3NumeroCnpj)
                    .HasColumnName("Analise3_NumeroCNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Analise3NumeroCnpjformatado)
                    .HasColumnName("Analise3_NumeroCNPJFormatado")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRenavampossuidorTipoDocumento).HasColumnName("CodigoRENAVAMPossuidorTipoDocumento");

                entity.Property(e => e.DataInfracao).HasColumnType("date");

                entity.Property(e => e.Nome)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAuto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCpfcnpj)
                    .HasColumnName("NumeroCPFCNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCpfcnpjformatado)
                    .HasColumnName("NumeroCPFCNPJFormatado")
                    .HasMaxLength(18)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuxSinpevMigracaoDocumentoDigitalizado>(entity =>
            {
                entity.HasKey(e => e.NupDocumento)
                    .HasName("PK_tblAUX_SINPEVMigracao_DocumentoDigitalizado");

                entity.ToTable("AUX_SINPEV_Migracao_DocumentoDigitalizado");

                entity.Property(e => e.NupDocumento).ValueGeneratedNever();

                entity.Property(e => e.NumeroAuto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao).IsUnicode(false);

                entity.Property(e => e.TipoProcesso)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuxUpdatePreAutuacaoRegistroInfracao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPreAutuacao)
                    .HasName("prkAUX_UPDATE_PreAutuacao_RegistroInfracao");

                entity.ToTable("AUX_UPDATE_PreAutuacao_RegistroInfracao");

                entity.Property(e => e.CodigoInfracaoPreAutuacao).ValueGeneratedNever();

                entity.Property(e => e.CodigoPncveditalLote).HasColumnName("CodigoPNCVEditalLote");

                entity.Property(e => e.CodigoRenavamunidadeMedida).HasColumnName("CodigoRENAVAMUnidadeMedida");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataHoraInfracao).HasColumnType("datetime");

                entity.Property(e => e.EquipamentoAfericaoCodigoDnit)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ImagemPrincipalArquivoNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImagemPrincipalArquivoNomeCalculado)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LimiteRegulamentado).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.LocalInfracaoRodoviaFaixa)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MedicaoRealizada).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RemessaDataProcessamento).HasColumnType("datetime");

                entity.Property(e => e.ValorConsiderado).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorOriginal).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal60Porcento).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal80Porcento).HasColumnType("decimal(7, 2)");
            });

            modelBuilder.Entity<ElmahError>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .HasName("prkELMAH_Error")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ELMAH_Error");

                entity.HasIndex(e => new { e.Application, e.TimeUtc, e.Sequence })
                    .HasName("idxELMAH_Error_App_Time_Seq");

                entity.Property(e => e.ErrorId).ValueGeneratedNever();

                entity.Property(e => e.AllXml)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.Application)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TimeUtc).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblBaseArquivoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseArquivoTipo)
                    .HasName("prkBaseArquivoTipo");

                entity.ToTable("tblBaseArquivoTipo");

                entity.Property(e => e.CodigoBaseArquivoTipo).ValueGeneratedNever();

                entity.Property(e => e.Extensao)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaseCalendario>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseCalendario)
                    .HasName("prkBaseCalendario");

                entity.ToTable("tblBaseCalendario");

                entity.HasIndex(e => e.Data)
                    .HasName("idxBaseCalendario_Data");

                entity.HasIndex(e => new { e.Dia, e.Ano, e.Mes, e.Data })
                    .HasName("idxBaseCalendario_AnoMesData");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.NomeDiaSemana)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NomeMes)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiglaDiaSemana)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SiglaMes)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaseCorreiosCartaoPostagem>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseCorreiosCartaoPostagem)
                    .HasName("prkBaseCorreiosCartaoPostagem");

                entity.ToTable("tblBaseCorreiosCartaoPostagem");

                entity.Property(e => e.CodigoBaseCorreiosCartaoPostagem).ValueGeneratedNever();

                entity.Property(e => e.CodigoAdministrativo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCartaoPostagem)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroContrato)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaseCorreiosCodigoBaixa>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseCorreiosCodigoBaixa)
                    .HasName("prkBaseCorreiosCodigoBaixa");

                entity.ToTable("tblBaseCorreiosCodigoBaixa");

                entity.Property(e => e.CodigoBaseCorreiosCodigoBaixa).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaseCorreiosMotivoDevolucao>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseCorreiosMotivoDevolucao)
                    .HasName("prkBaseCorreiosMotivoDevolucao");

                entity.ToTable("tblBaseCorreiosMotivoDevolucao");

                entity.Property(e => e.CodigoBaseCorreiosMotivoDevolucao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaseCorreiosPlanoTriagem>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseCorreiosPlanoTriagem)
                    .HasName("prkBaseCorreiosPlanoTriagem");

                entity.ToTable("tblBaseCorreiosPlanoTriagem");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuantidadeFaixaCep).HasColumnName("QuantidadeFaixaCEP");

                entity.Property(e => e.Versao)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VigenciaDataInicio).HasColumnType("date");

                entity.Property(e => e.VigenciaDataTermino).HasColumnType("date");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoExpedicaoServicoNavigation)
                    .WithMany(p => p.TblBaseCorreiosPlanoTriagem)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoExpedicaoServico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBaseCorreiosPlanoTriagem_InfracaoNotificacaoExpedicaoServico");
            });

            modelBuilder.Entity<TblBaseCorreiosPlanoTriagemFaixaCep>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseCorreiosPlanoTriagemFaixaCep)
                    .HasName("prkBaseCorreiosPlanoTriagemFaixaCEP");

                entity.ToTable("tblBaseCorreiosPlanoTriagemFaixaCEP");

                entity.Property(e => e.CodigoBaseCorreiosPlanoTriagemFaixaCep).HasColumnName("CodigoBaseCorreiosPlanoTriagemFaixaCEP");

                entity.Property(e => e.Centralizador)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CepFinal)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CepInicial)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Dr)
                    .IsRequired()
                    .HasColumnName("DR")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadeDistribuicao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBaseCorreiosPlanoTriagemNavigation)
                    .WithMany(p => p.TblBaseCorreiosPlanoTriagemFaixaCep)
                    .HasForeignKey(d => d.CodigoBaseCorreiosPlanoTriagem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBaseCorreiosPlanoTriagemFaixaCEP_BaseCorreiosPlanoTriagem");
            });

            modelBuilder.Entity<TblBaseDiaSemana>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseDiaSemana)
                    .HasName("prkBaseDiaSemana");

                entity.ToTable("tblBaseDiaSemana");

                entity.Property(e => e.CodigoBaseDiaSemana).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeExtenso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaseDocumentoUfscdnit>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseDocumentoUfscdnit)
                    .HasName("prkBaseDocumentoUFSCDNIT");

                entity.ToTable("tblBaseDocumentoUFSCDNIT");

                entity.Property(e => e.CodigoBaseDocumentoUfscdnit).HasColumnName("CodigoBaseDocumentoUFSCDNIT");

                entity.Property(e => e.CodigoBaseDocumentoUfscdnitpai).HasColumnName("CodigoBaseDocumentoUFSCDNITPai");

                entity.Property(e => e.CodigoBaseDocumentoUfscdnittipo).HasColumnName("CodigoBaseDocumentoUFSCDNITTipo");

                entity.Property(e => e.DataModificacao).HasColumnType("datetime");

                entity.Property(e => e.DocumentoDataReferencia).HasColumnType("date");

                entity.Property(e => e.DocumentoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBaseDocumentoUfscdnitpaiNavigation)
                    .WithMany(p => p.InverseCodigoBaseDocumentoUfscdnitpaiNavigation)
                    .HasForeignKey(d => d.CodigoBaseDocumentoUfscdnitpai)
                    .HasConstraintName("frkBaseDocumentoUFSCDNIT_BaseDocumentoUFSCDNITPai");

                entity.HasOne(d => d.CodigoBaseDocumentoUfscdnittipoNavigation)
                    .WithMany(p => p.TblBaseDocumentoUfscdnit)
                    .HasForeignKey(d => d.CodigoBaseDocumentoUfscdnittipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBaseDocumentoUFSCDNIT_BaseDocumentoUFSCDNITTipo");
            });

            modelBuilder.Entity<TblBaseDocumentoUfscdnittipo>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseDocumentoUfscdnittipo)
                    .HasName("prkBaseDocumentoUFSCDNITTipo");

                entity.ToTable("tblBaseDocumentoUFSCDNITTipo");

                entity.Property(e => e.CodigoBaseDocumentoUfscdnittipo)
                    .HasColumnName("CodigoBaseDocumentoUFSCDNITTipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaseFebrabanMotivoOcorrencia>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseFebrabanMotivoOcorrencia)
                    .HasName("prkBaseFebrabanMotivoOcorrencia");

                entity.ToTable("tblBaseFebrabanMotivoOcorrencia");

                entity.Property(e => e.CodigoBaseFebrabanMotivoOcorrencia).ValueGeneratedNever();

                entity.Property(e => e.CodigoMovimentoOcorrencia)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBaseFebrabanMotivoOcorrenciaDominioNavigation)
                    .WithMany(p => p.TblBaseFebrabanMotivoOcorrencia)
                    .HasForeignKey(d => d.CodigoBaseFebrabanMotivoOcorrenciaDominio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBaseFebrabanMotivoOcorrencia_BaseFebrabanMotivoOcorrenciaDominio");
            });

            modelBuilder.Entity<TblBaseFebrabanMotivoOcorrenciaDominio>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseFebrabanMotivoOcorrenciaDominio)
                    .HasName("prkBaseFebrabanMotivoOcorrenciaDominio");

                entity.ToTable("tblBaseFebrabanMotivoOcorrenciaDominio");

                entity.Property(e => e.CodigoBaseFebrabanMotivoOcorrenciaDominio).ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaseFebrabanMovimentoRemessa>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseFebrabanMovimentoRemessa)
                    .HasName("prkBaseFebrabanMovimentoRemessa");

                entity.ToTable("tblBaseFebrabanMovimentoRemessa");

                entity.Property(e => e.CodigoBaseFebrabanMovimentoRemessa).ValueGeneratedNever();

                entity.Property(e => e.CodigoMovimentoRemessa)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaseFebrabanMovimentoRetorno>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseFebrabanMovimentoRetorno)
                    .HasName("prkBaseFebrabanMovimentoRetorno");

                entity.ToTable("tblBaseFebrabanMovimentoRetorno");

                entity.Property(e => e.CodigoBaseFebrabanMovimentoRetorno).ValueGeneratedNever();

                entity.Property(e => e.CodigoMovimentoRetorno)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaseGruCodigoRecolhimentoTes>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseGrucodigoRecolhimentoTes)
                    .HasName("prkBaseGRUCodigoRecolhimentoTES");

                entity.ToTable("tblBaseGruCodigoRecolhimentoTES");

                entity.Property(e => e.CodigoBaseGrucodigoRecolhimentoTes)
                    .HasColumnName("CodigoBaseGRUCodigoRecolhimentoTES")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodigoBanco3D)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRecolhimento5D)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRecolhimentoDv)
                    .HasColumnName("CodigoRecolhimentoDV")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoUnidadeGestora11D)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAgencia5D)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAgenciaDv)
                    .HasColumnName("NumeroAgenciaDV")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCarteiraGruComRegistro2D)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCarteiraGruComercioEletronico2D)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCarteiraGruSemRegistro2D)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroComercioEletronico6D)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroConta12D)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroContaDv)
                    .HasColumnName("NumeroContaDV")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroContratoGruComRegistro)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroContratoGruComercioEletronicoRegistro)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroContratoGruSemRegistro)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroConvenioGruComRegistro7D)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroConvenioGruComercioEletronicoRegistro7D)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroConvenioGruSemRegistro6D)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroVariacaoCarteiraGruComRegistro3D)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroVariacaoCarteiraGruComercioEletronicoRegistro3D)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroVariacaoCarteiraGruSemRegistro3D)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaseGruComRegistroNossoNumero>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseGruComRegistroNossoNumero)
                    .HasName("prkBaseGruComRegistroNossoNumero");

                entity.ToTable("tblBaseGruComRegistroNossoNumero");

                entity.HasIndex(e => new { e.NumeroConvenio, e.NumeroSequencial })
                    .HasName("idxBaseGruComRegistroNossoNumero");

                entity.Property(e => e.NossoNumero)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroConvenio)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSequencial).HasColumnType("decimal(10, 0)");
            });

            modelBuilder.Entity<TblBaseHora>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseHora)
                    .HasName("prkBaseHora");

                entity.ToTable("tblBaseHora");

                entity.Property(e => e.CodigoBaseHora).ValueGeneratedNever();

                entity.Property(e => e.FaixaHoraria)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaseHoraFracao>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseHoraFracao)
                    .HasName("prkBaseHoraFracao");

                entity.ToTable("tblBaseHoraFracao");

                entity.Property(e => e.CodigoBaseHoraFracao).ValueGeneratedNever();

                entity.Property(e => e.FaixaHoraFracao)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaseMes>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseMes)
                    .HasName("prkBaseMes");

                entity.ToTable("tblBaseMes");

                entity.Property(e => e.CodigoBaseMes).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaseMunicipio>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseMunicipio)
                    .HasName("prkBaseMunicipio");

                entity.ToTable("tblBaseMunicipio");

                entity.Property(e => e.CodigoBaseMunicipio).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblBaseMunicipio)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBaseMunicipio_BaseUf");
            });

            modelBuilder.Entity<TblBaseNup>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseNup)
                    .HasName("prkBaseNUP");

                entity.ToTable("tblBaseNUP");

                entity.HasIndex(e => new { e.Nupformatado, e.IdentificacaoDocumentoOriginal })
                    .HasName("idxBaseNUP_AUX_CargaInicial");

                entity.HasIndex(e => new { e.AnoFormacao4D, e.UnidadeProtocolizadora5D, e.SequencialProcesso6D })
                    .HasName("idxBaseNUP_ValorUnico")
                    .IsUnique();

                entity.HasIndex(e => new { e.NupvalorNumerico, e.AnoFormacao4D, e.IndicadorFaixaFinalAno })
                    .HasName("idxBaseNUP_AnoFormacao4D_IndicadorFaixaFinal");

                entity.HasIndex(e => new { e.CodigoBaseNup, e.AnoFormacao4D, e.UnidadeProtocolizadora5D, e.IndicadorFaixaFinalAno })
                    .HasName("idxBaseNUP_AnoFormacao_Unidade_IndicadorFaixaFinal");

                entity.Property(e => e.CodigoBaseNup)
                    .HasColumnName("CodigoBaseNUP")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnoFormacao4D).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.DataCadastro).HasColumnType("date");

                entity.Property(e => e.DigitoVerificador2D).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.IdentificacaoDocumentoOriginal)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nup)
                    .IsRequired()
                    .HasColumnName("NUP")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Nupformatado)
                    .IsRequired()
                    .HasColumnName("NUPFormatado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NupvalorNumerico)
                    .HasColumnName("NUPValorNumerico")
                    .HasColumnType("decimal(17, 0)");

                entity.Property(e => e.SequencialProcesso6D).HasColumnType("decimal(6, 0)");

                entity.Property(e => e.UnidadeProtocolizadora5D).HasColumnType("decimal(5, 0)");
            });

            modelBuilder.Entity<TblBasePais>(entity =>
            {
                entity.HasKey(e => e.CodigoBasePais)
                    .HasName("prkBasePais");

                entity.ToTable("tblBasePais");

                entity.Property(e => e.CodigoBasePais).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaseRodovia>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseRodovia)
                    .HasName("prkBaseRodovia");

                entity.ToTable("tblBaseRodovia");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaseRodoviaUf>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseRodoviaUf)
                    .HasName("prkBaseRodoviaUF");

                entity.ToTable("tblBaseRodoviaUF");

                entity.Property(e => e.CodigoBaseRodoviaUf).HasColumnName("CodigoBaseRodoviaUF");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblBaseRodoviaUf)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBaseRodoviaUF_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblBaseRodoviaUf)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBaseRodoviaUF_BaseUF");
            });

            modelBuilder.Entity<TblBaseSelic>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseSelic)
                    .HasName("prkBaseSELIC");

                entity.ToTable("tblBaseSELIC");

                entity.Property(e => e.CodigoBaseSelic).HasColumnName("CodigoBaseSELIC");

                entity.Property(e => e.Taxa).HasColumnType("decimal(4, 2)");
            });

            modelBuilder.Entity<TblBaseUf>(entity =>
            {
                entity.HasKey(e => e.CodigoBaseUf)
                    .HasName("prkBaseUF");

                entity.ToTable("tblBaseUF");

                entity.Property(e => e.CodigoBaseUf)
                    .HasColumnName("CodigoBaseUF")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBrlegalAnteprojeto>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalAnteprojeto)
                    .HasName("prkBRLegalAnteprojeto");

                entity.ToTable("tblBRLegalAnteprojeto");

                entity.Property(e => e.CodigoBrlegalAnteprojeto).HasColumnName("CodigoBRLegalAnteprojeto");

                entity.Property(e => e.CodigoBrlegalContrato).HasColumnName("CodigoBRLegalContrato");

                entity.Property(e => e.CodigoBrlegalServicoItem).HasColumnName("CodigoBRLegalServicoItem");

                entity.Property(e => e.Quantidade).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValorTotal).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ValorUnitario).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.CodigoBrlegalContratoNavigation)
                    .WithMany(p => p.TblBrlegalAnteprojeto)
                    .HasForeignKey(d => d.CodigoBrlegalContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalAnteprojeto_BRLegalContrato");

                entity.HasOne(d => d.CodigoBrlegalServicoItemNavigation)
                    .WithMany(p => p.TblBrlegalAnteprojeto)
                    .HasForeignKey(d => d.CodigoBrlegalServicoItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalAnteprojeto_BRLegalServicoItem");
            });

            modelBuilder.Entity<TblBrlegalContrato>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalContrato)
                    .HasName("prkBRLegalContrato");

                entity.ToTable("tblBRLegalContrato");

                entity.Property(e => e.CodigoBrlegalContrato).HasColumnName("CodigoBRLegalContrato");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoBrlegalEdital).HasColumnName("CodigoBRLegalEdital");

                entity.Property(e => e.CodigoBrlegalEmpresa).HasColumnName("CodigoBRLegalEmpresa");

                entity.Property(e => e.CodigoBrlegalEngenheiroResponsavel).HasColumnName("CodigoBRLegalEngenheiroResponsavel");

                entity.Property(e => e.DataBaseCalculo).HasColumnType("datetime");

                entity.Property(e => e.DataLimiteEntregaProjetoBasico).HasColumnType("datetime");

                entity.Property(e => e.DataLimiteEntregaProjetoExecutivo).HasColumnType("datetime");

                entity.Property(e => e.DataOrdemInicioServicos).HasColumnType("datetime");

                entity.Property(e => e.Desconto).HasColumnType("decimal(7, 5)");

                entity.Property(e => e.ExtensaoMalhaContratada).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.NovaDataEntregaProjetoBasico).HasColumnType("datetime");

                entity.Property(e => e.NovaDataEntregaProjetoExecutivo).HasColumnType("datetime");

                entity.Property(e => e.NumeroContrato)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OficioProjetoBasicoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OficioProjetoBasicoNomeFisico)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OficioProjetoExecutivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OficioProjetoExecutivoNomeFisico)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ValorInicial).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ValorInicialAditivo).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ValorInicialAditivoReajuste).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblBrlegalContrato)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalContrato_BaseUF");

                entity.HasOne(d => d.CodigoBrlegalEditalNavigation)
                    .WithMany(p => p.TblBrlegalContrato)
                    .HasForeignKey(d => d.CodigoBrlegalEdital)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalContrato_BRLegalEdital");

                entity.HasOne(d => d.CodigoBrlegalEmpresaNavigation)
                    .WithMany(p => p.TblBrlegalContrato)
                    .HasForeignKey(d => d.CodigoBrlegalEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalContrato_BRLegalEmpresa");

                entity.HasOne(d => d.CodigoBrlegalEngenheiroResponsavelNavigation)
                    .WithMany(p => p.TblBrlegalContrato)
                    .HasForeignKey(d => d.CodigoBrlegalEngenheiroResponsavel)
                    .HasConstraintName("frkBRLegalContrato_BRLegalEngenheiroResponsavel");
            });

            modelBuilder.Entity<TblBrlegalContratoTrecho>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalContratoTrecho)
                    .HasName("prkBRLegalContratoTrecho");

                entity.ToTable("tblBRLegalContratoTrecho");

                entity.Property(e => e.CodigoBrlegalContratoTrecho).HasColumnName("CodigoBRLegalContratoTrecho");

                entity.Property(e => e.AnoSnv).HasColumnName("AnoSNV");

                entity.Property(e => e.CodigoBrlegalContrato).HasColumnName("CodigoBRLegalContrato");

                entity.Property(e => e.CodigoSnvtrecho).HasColumnName("CodigoSNVTrecho");

                entity.Property(e => e.Extensao).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.KmFinal).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.KmInicial).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Mp082).HasColumnName("MP_082");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBrlegalContratoNavigation)
                    .WithMany(p => p.TblBrlegalContratoTrecho)
                    .HasForeignKey(d => d.CodigoBrlegalContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalContratoTrecho_BRLegalContrato");

                entity.HasOne(d => d.CodigoSnvtrechoNavigation)
                    .WithMany(p => p.TblBrlegalContratoTrecho)
                    .HasForeignKey(d => d.CodigoSnvtrecho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalContratoTrecho_SNVTrecho");
            });

            modelBuilder.Entity<TblBrlegalContratoTrechoContratado>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalContratoTrechoContratado)
                    .HasName("prkBRLegalContratoTrechoContratado");

                entity.ToTable("tblBRLegalContratoTrechoContratado");

                entity.Property(e => e.CodigoBrlegalContratoTrechoContratado).HasColumnName("CodigoBRLegalContratoTrechoContratado");

                entity.Property(e => e.AnoSnv).HasColumnName("AnoSNV");

                entity.Property(e => e.CodigoBrlegalContrato).HasColumnName("CodigoBRLegalContrato");

                entity.Property(e => e.CodigoSnvtrecho).HasColumnName("CodigoSNVTrecho");

                entity.Property(e => e.Extensao).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.KmFinal).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.KmInicial).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Mp082).HasColumnName("MP_082");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBrlegalContratoNavigation)
                    .WithMany(p => p.TblBrlegalContratoTrechoContratado)
                    .HasForeignKey(d => d.CodigoBrlegalContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalContratoTrechoContratado_BRLegalContrato");

                entity.HasOne(d => d.CodigoSnvtrechoNavigation)
                    .WithMany(p => p.TblBrlegalContratoTrechoContratado)
                    .HasForeignKey(d => d.CodigoSnvtrecho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalContratoTrechoContratado_SNVTrecho");
            });

            modelBuilder.Entity<TblBrlegalContratoTrechoRemovido>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalContratoTrechoRemovido)
                    .HasName("prkBRLegalContratoTrechoRemovido");

                entity.ToTable("tblBRLegalContratoTrechoRemovido");

                entity.Property(e => e.CodigoBrlegalContratoTrechoRemovido).HasColumnName("CodigoBRLegalContratoTrechoRemovido");

                entity.Property(e => e.CodigoBrlegalContratoTrecho).HasColumnName("CodigoBRLegalContratoTrecho");

                entity.Property(e => e.CodigoBrlegalContratoTrechoRemovidoMotivo).HasColumnName("CodigoBRLegalContratoTrechoRemovidoMotivo");

                entity.Property(e => e.DataOcorrencia).HasColumnType("datetime");

                entity.Property(e => e.Extensao).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.KmFinal).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.KmInicial).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBrlegalContratoTrechoNavigation)
                    .WithMany(p => p.TblBrlegalContratoTrechoRemovido)
                    .HasForeignKey(d => d.CodigoBrlegalContratoTrecho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalContratoTrechoRemovido_BRLegalContratoTrecho");

                entity.HasOne(d => d.CodigoBrlegalContratoTrechoRemovidoMotivoNavigation)
                    .WithMany(p => p.TblBrlegalContratoTrechoRemovido)
                    .HasForeignKey(d => d.CodigoBrlegalContratoTrechoRemovidoMotivo)
                    .HasConstraintName("frkBRLegalContratoTrechoRemovido_BRLegalContratoTrechoRemovidoMotivo");
            });

            modelBuilder.Entity<TblBrlegalContratoTrechoRemovidoMotivo>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalContratoTrechoRemovidoMotivo)
                    .HasName("prkBRLegalMotivoRemocao");

                entity.ToTable("tblBRLegalContratoTrechoRemovidoMotivo");

                entity.Property(e => e.CodigoBrlegalContratoTrechoRemovidoMotivo).HasColumnName("CodigoBRLegalContratoTrechoRemovidoMotivo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBrlegalContratoTrechoSuspenso>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalContratoTrechoSuspenso)
                    .HasName("prkBRLegalContratoTrechoSuspenso");

                entity.ToTable("tblBRLegalContratoTrechoSuspenso");

                entity.Property(e => e.CodigoBrlegalContratoTrechoSuspenso).HasColumnName("CodigoBRLegalContratoTrechoSuspenso");

                entity.Property(e => e.CodigoBrlegalContratoTrecho).HasColumnName("CodigoBRLegalContratoTrecho");

                entity.Property(e => e.CodigoBrlegalContratoTrechoSuspensoMotivo).HasColumnName("CodigoBRLegalContratoTrechoSuspensoMotivo");

                entity.Property(e => e.DataLiberacao).HasColumnType("datetime");

                entity.Property(e => e.DataOcorrencia).HasColumnType("datetime");

                entity.Property(e => e.Extensao).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.KmFinal).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.KmInicial).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.NovaDataLimiteEntrega).HasColumnType("datetime");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBrlegalContratoTrechoNavigation)
                    .WithMany(p => p.TblBrlegalContratoTrechoSuspenso)
                    .HasForeignKey(d => d.CodigoBrlegalContratoTrecho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalContratoTrechoSuspenso_BRLegalContratoTrecho");

                entity.HasOne(d => d.CodigoBrlegalContratoTrechoSuspensoMotivoNavigation)
                    .WithMany(p => p.TblBrlegalContratoTrechoSuspenso)
                    .HasForeignKey(d => d.CodigoBrlegalContratoTrechoSuspensoMotivo)
                    .HasConstraintName("frkBRLegalContratoTrechoSuspenso_BRLegalContratoTrechoSuspensoMotivo");
            });

            modelBuilder.Entity<TblBrlegalContratoTrechoSuspensoMotivo>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalContratoTrechoSuspensoMotivo)
                    .HasName("prkBRLegalMotivoSuspensao");

                entity.ToTable("tblBRLegalContratoTrechoSuspensoMotivo");

                entity.Property(e => e.CodigoBrlegalContratoTrechoSuspensoMotivo).HasColumnName("CodigoBRLegalContratoTrechoSuspensoMotivo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBrlegalDocumento>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalDocumento)
                    .HasName("prkBRLegalDocumento");

                entity.ToTable("tblBRLegalDocumento");

                entity.Property(e => e.CodigoBrlegalDocumento).HasColumnName("CodigoBRLegalDocumento");

                entity.Property(e => e.ArquivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoNomeFisico)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBrlegalContrato).HasColumnName("CodigoBRLegalContrato");

                entity.Property(e => e.CodigoBrlegalDocumentoTipo).HasColumnName("CodigoBRLegalDocumentoTipo");

                entity.Property(e => e.CodigoBrlegalServicoTipo).HasColumnName("CodigoBRLegalServicoTipo");

                entity.Property(e => e.DocumentoData).HasColumnType("datetime");

                entity.Property(e => e.DocumentoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblBrlegalDocumento)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .HasConstraintName("frkBRLegalDocumento_BaseRodovia");

                entity.HasOne(d => d.CodigoBrlegalContratoNavigation)
                    .WithMany(p => p.TblBrlegalDocumento)
                    .HasForeignKey(d => d.CodigoBrlegalContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalDocumento_BRLegalContrato");

                entity.HasOne(d => d.CodigoBrlegalDocumentoTipoNavigation)
                    .WithMany(p => p.TblBrlegalDocumento)
                    .HasForeignKey(d => d.CodigoBrlegalDocumentoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalDocumento_BRLegalDocumentoTipo");

                entity.HasOne(d => d.CodigoBrlegalServicoTipoNavigation)
                    .WithMany(p => p.TblBrlegalDocumento)
                    .HasForeignKey(d => d.CodigoBrlegalServicoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalDocumento_BRLegalServicoTipo");
            });

            modelBuilder.Entity<TblBrlegalDocumentoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalDocumentoTipo)
                    .HasName("prkBRLegalDocumentoTipo");

                entity.ToTable("tblBRLegalDocumentoTipo");

                entity.Property(e => e.CodigoBrlegalDocumentoTipo).HasColumnName("CodigoBRLegalDocumentoTipo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBrlegalEdital>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalEdital)
                    .HasName("prkBRLegalEdital");

                entity.ToTable("tblBRLegalEdital");

                entity.Property(e => e.CodigoBrlegalEdital).HasColumnName("CodigoBRLegalEdital");

                entity.Property(e => e.ArquivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoNomeFisico)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroEdital)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBrlegalEmpresa>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalEmpresa)
                    .HasName("prkBRLegalEmpresa");

                entity.ToTable("tblBRLegalEmpresa");

                entity.Property(e => e.CodigoBrlegalEmpresa).HasColumnName("CodigoBRLegalEmpresa");

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cnpj)
                    .HasColumnName("CNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Informacao)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NomeEmpresa)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Representante)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBaseMunicipioNavigation)
                    .WithMany(p => p.TblBrlegalEmpresa)
                    .HasForeignKey(d => d.CodigoBaseMunicipio)
                    .HasConstraintName("frkBRLegalEmpresa_BaseMunicipio");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblBrlegalEmpresa)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .HasConstraintName("frkBRLegalEmpresa_BaseUF");
            });

            modelBuilder.Entity<TblBrlegalEngenheiroResponsavel>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalEngenheiroResponsavel)
                    .HasName("prkBRLegalEngenheiroResponsavel");

                entity.ToTable("tblBRLegalEngenheiroResponsavel");

                entity.Property(e => e.CodigoBrlegalEngenheiroResponsavel).HasColumnName("CodigoBRLegalEngenheiroResponsavel");

                entity.Property(e => e.Informacao)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBrlegalImplantacaoPlanejamento>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalImplantacaoPlanejamento)
                    .HasName("prkBRLegalImplantacaoPlanejamento");

                entity.ToTable("tblBRLegalImplantacaoPlanejamento");

                entity.Property(e => e.CodigoBrlegalImplantacaoPlanejamento).HasColumnName("CodigoBRLegalImplantacaoPlanejamento");

                entity.Property(e => e.CodigoBrlegalContrato).HasColumnName("CodigoBRLegalContrato");

                entity.Property(e => e.CodigoBrlegalImplantacaoPlanejamentoSituacao).HasColumnName("CodigoBRLegalImplantacaoPlanejamentoSituacao");

                entity.Property(e => e.Versao).HasColumnType("date");

                entity.HasOne(d => d.CodigoBrlegalContratoNavigation)
                    .WithMany(p => p.TblBrlegalImplantacaoPlanejamento)
                    .HasForeignKey(d => d.CodigoBrlegalContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalImplantacaoPlanejamento_BRLegalContrato");

                entity.HasOne(d => d.CodigoBrlegalImplantacaoPlanejamentoSituacaoNavigation)
                    .WithMany(p => p.TblBrlegalImplantacaoPlanejamento)
                    .HasForeignKey(d => d.CodigoBrlegalImplantacaoPlanejamentoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalImplantacaoPlanejamento_BRLegalImplantacaoPlanejamentoSituacao");
            });

            modelBuilder.Entity<TblBrlegalImplantacaoPlanejamentoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalImplantacaoPlanejamentoEvento)
                    .HasName("prkBRLegalImplantacaoPlanejamentoEvento");

                entity.ToTable("tblBRLegalImplantacaoPlanejamentoEvento");

                entity.Property(e => e.CodigoBrlegalImplantacaoPlanejamentoEvento).HasColumnName("CodigoBRLegalImplantacaoPlanejamentoEvento");

                entity.Property(e => e.CodigoBrlegalImplantacaoPlanejamento).HasColumnName("CodigoBRLegalImplantacaoPlanejamento");

                entity.Property(e => e.CodigoBrlegalImplantacaoPlanejamentoSituacao).HasColumnName("CodigoBRLegalImplantacaoPlanejamentoSituacao");

                entity.Property(e => e.DataEvento).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBrlegalImplantacaoPlanejamentoNavigation)
                    .WithMany(p => p.TblBrlegalImplantacaoPlanejamentoEvento)
                    .HasForeignKey(d => d.CodigoBrlegalImplantacaoPlanejamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalImplantacaoPlanejamentoEvento_BRLegalImplantacaoPlanejamento");

                entity.HasOne(d => d.CodigoBrlegalImplantacaoPlanejamentoSituacaoNavigation)
                    .WithMany(p => p.TblBrlegalImplantacaoPlanejamentoEvento)
                    .HasForeignKey(d => d.CodigoBrlegalImplantacaoPlanejamentoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalImplantacaoPlanejamentoEvento_BRLegalImplantacaoPlanejamentoSituacao");
            });

            modelBuilder.Entity<TblBrlegalImplantacaoPlanejamentoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalImplantacaoPlanejamentoSituacao)
                    .HasName("prkBRLegalImplantacaoPlanejamentoSituacao");

                entity.ToTable("tblBRLegalImplantacaoPlanejamentoSituacao");

                entity.Property(e => e.CodigoBrlegalImplantacaoPlanejamentoSituacao).HasColumnName("CodigoBRLegalImplantacaoPlanejamentoSituacao");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBrlegalImplantacaoProjetoCronograma>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalImplantacaoProjetoCronograma)
                    .HasName("prkBRLegalImplantacaoProjetoCronograma");

                entity.ToTable("tblBRLegalImplantacaoProjetoCronograma");

                entity.HasIndex(e => new { e.Periodo, e.CodigoBrlegalImplantacaoPlanejamento })
                    .HasName("idx_BRLegalImplantacaoProjetoCronograma");

                entity.Property(e => e.CodigoBrlegalImplantacaoProjetoCronograma).HasColumnName("CodigoBRLegalImplantacaoProjetoCronograma");

                entity.Property(e => e.CodigoBrlegalImplantacaoPlanejamento).HasColumnName("CodigoBRLegalImplantacaoPlanejamento");

                entity.Property(e => e.CodigoBrlegalServicoFamilia).HasColumnName("CodigoBRLegalServicoFamilia");

                entity.Property(e => e.CodigoBrlegalServicoItem).HasColumnName("CodigoBRLegalServicoItem");

                entity.Property(e => e.Extensao).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Periodo).HasColumnType("date");

                entity.Property(e => e.Valor).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.CodigoBrlegalImplantacaoPlanejamentoNavigation)
                    .WithMany(p => p.TblBrlegalImplantacaoProjetoCronograma)
                    .HasForeignKey(d => d.CodigoBrlegalImplantacaoPlanejamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalImplantacaoProjetoCronograma_BRLegalImplantacaoPlanejamento");

                entity.HasOne(d => d.CodigoBrlegalServicoFamiliaNavigation)
                    .WithMany(p => p.TblBrlegalImplantacaoProjetoCronograma)
                    .HasForeignKey(d => d.CodigoBrlegalServicoFamilia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalImplantacaoProjetoCronograma_BRLegalServicoFamilia");

                entity.HasOne(d => d.CodigoBrlegalServicoItemNavigation)
                    .WithMany(p => p.TblBrlegalImplantacaoProjetoCronograma)
                    .HasForeignKey(d => d.CodigoBrlegalServicoItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalImplantacaoProjetoCronograma_BRLegalServicoItem");
            });

            modelBuilder.Entity<TblBrlegalImplantacaoTrechoCronograma>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalImplantacaoTrechoCronograma)
                    .HasName("prkBRLegalImplantacaoTrechoCronograma");

                entity.ToTable("tblBRLegalImplantacaoTrechoCronograma");

                entity.HasIndex(e => new { e.CodigoBrlegalImplantacaoTrechoCronograma, e.CodigoBrlegalContratoTrecho, e.CodigoBrlegalImplantacaoPlanejamento })
                    .HasName("idxImplantacaoTrechoCronograma");

                entity.Property(e => e.CodigoBrlegalImplantacaoTrechoCronograma).HasColumnName("CodigoBRLegalImplantacaoTrechoCronograma");

                entity.Property(e => e.CodigoBrlegalContratoTrecho).HasColumnName("CodigoBRLegalContratoTrecho");

                entity.Property(e => e.CodigoBrlegalImplantacaoPlanejamento).HasColumnName("CodigoBRLegalImplantacaoPlanejamento");

                entity.Property(e => e.CodigoBrlegalServicoFamilia).HasColumnName("CodigoBRLegalServicoFamilia");

                entity.Property(e => e.Extensao).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Periodo).HasColumnType("date");

                entity.Property(e => e.Valor).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.CodigoBrlegalContratoTrechoNavigation)
                    .WithMany(p => p.TblBrlegalImplantacaoTrechoCronograma)
                    .HasForeignKey(d => d.CodigoBrlegalContratoTrecho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalImplantacaoTrechoCronograma_BRLegalContratoTrecho");

                entity.HasOne(d => d.CodigoBrlegalImplantacaoPlanejamentoNavigation)
                    .WithMany(p => p.TblBrlegalImplantacaoTrechoCronograma)
                    .HasForeignKey(d => d.CodigoBrlegalImplantacaoPlanejamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalImplantacaoTrechoCronograma_BRLegalImplantacaoPlanejamento");

                entity.HasOne(d => d.CodigoBrlegalServicoFamiliaNavigation)
                    .WithMany(p => p.TblBrlegalImplantacaoTrechoCronograma)
                    .HasForeignKey(d => d.CodigoBrlegalServicoFamilia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalImplantacaoTrechoCronograma_BRLegalServicoFamilia");
            });

            modelBuilder.Entity<TblBrlegalImplantacaoTrechoQuantitativo>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalImplantacaoTrechoQuantitativo)
                    .HasName("prkBRLegalImplantacaoTrechoQuantitativo");

                entity.ToTable("tblBRLegalImplantacaoTrechoQuantitativo");

                entity.HasIndex(e => e.CodigoBrlegalImplantacaoTrechoCronograma)
                    .HasName("idxImplantacaoTrechoQuantitativo");

                entity.Property(e => e.CodigoBrlegalImplantacaoTrechoQuantitativo).HasColumnName("CodigoBRLegalImplantacaoTrechoQuantitativo");

                entity.Property(e => e.CodigoBrlegalImplantacaoTrechoCronograma).HasColumnName("CodigoBRLegalImplantacaoTrechoCronograma");

                entity.Property(e => e.CodigoBrlegalServicoItem).HasColumnName("CodigoBRLegalServicoItem");

                entity.Property(e => e.Quantidade).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.CodigoBrlegalImplantacaoTrechoCronogramaNavigation)
                    .WithMany(p => p.TblBrlegalImplantacaoTrechoQuantitativo)
                    .HasForeignKey(d => d.CodigoBrlegalImplantacaoTrechoCronograma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalImplantacaoTrechoQuantitativo_BRLegalImplantacaoTrechoCronograma");

                entity.HasOne(d => d.CodigoBrlegalServicoItemNavigation)
                    .WithMany(p => p.TblBrlegalImplantacaoTrechoQuantitativo)
                    .HasForeignKey(d => d.CodigoBrlegalServicoItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalImplantacaoTrechoQuantitativo_BRLegalServicoItem");
            });

            modelBuilder.Entity<TblBrlegalParametroPrazo>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalParametroPrazo)
                    .HasName("prkBRLegalParametroPrazo");

                entity.ToTable("tblBRLegalParametroPrazo");

                entity.Property(e => e.CodigoBrlegalParametroPrazo).HasColumnName("CodigoBRLegalParametroPrazo");
            });

            modelBuilder.Entity<TblBrlegalProjetoBasicoEntrega>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalProjetoBasicoEntrega)
                    .HasName("prkBRLegalProjetoBasicoEntrega");

                entity.ToTable("tblBRLegalProjetoBasicoEntrega");

                entity.Property(e => e.CodigoBrlegalProjetoBasicoEntrega).HasColumnName("CodigoBRLegalProjetoBasicoEntrega");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoBrlegalContrato).HasColumnName("CodigoBRLegalContrato");

                entity.Property(e => e.DataEntregaProjetoSede).HasColumnType("datetime");

                entity.Property(e => e.DataLimiteAnalise).HasColumnType("datetime");

                entity.Property(e => e.Extensao).HasColumnType("numeric(6, 2)");

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblBrlegalProjetoBasicoEntrega)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalProjetoBasicoEntrega_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblBrlegalProjetoBasicoEntrega)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalProjetoBasicoEntrega_BaseUF");

                entity.HasOne(d => d.CodigoBrlegalContratoNavigation)
                    .WithMany(p => p.TblBrlegalProjetoBasicoEntrega)
                    .HasForeignKey(d => d.CodigoBrlegalContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalProjetoBasicoEntrega_BRLegalContrato");
            });

            modelBuilder.Entity<TblBrlegalProjetoBasicoEntregaTrecho>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalProjetoBasicoEntregaTrecho)
                    .HasName("prkBRLegalProjetoBasicoEntregaTrecho");

                entity.ToTable("tblBRLegalProjetoBasicoEntregaTrecho");

                entity.Property(e => e.CodigoBrlegalProjetoBasicoEntregaTrecho).HasColumnName("CodigoBRLegalProjetoBasicoEntregaTrecho");

                entity.Property(e => e.CodigoBrlegalProjetoBasicoEntrega).HasColumnName("CodigoBRLegalProjetoBasicoEntrega");

                entity.Property(e => e.CodigoBrlegalProjetoEntregaTrechoSituacao).HasColumnName("CodigoBRLegalProjetoEntregaTrechoSituacao");

                entity.Property(e => e.CodigoSnvtrecho).HasColumnName("CodigoSNVTrecho");

                entity.Property(e => e.DataAceite).HasColumnType("datetime");

                entity.Property(e => e.EngenheirosFiscais)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Extensao).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.KmFinal).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.KmInicial).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBrlegalProjetoBasicoEntregaNavigation)
                    .WithMany(p => p.TblBrlegalProjetoBasicoEntregaTrecho)
                    .HasForeignKey(d => d.CodigoBrlegalProjetoBasicoEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalProjetoBasicoEntregaTrecho_BRLegalProjetoBasicoEntrega");

                entity.HasOne(d => d.CodigoBrlegalProjetoEntregaTrechoSituacaoNavigation)
                    .WithMany(p => p.TblBrlegalProjetoBasicoEntregaTrecho)
                    .HasForeignKey(d => d.CodigoBrlegalProjetoEntregaTrechoSituacao)
                    .HasConstraintName("frkBRLegalProjetoBasicoEntregaTrecho_BRLegalProjetoEntregaTrechoSituacao");

                entity.HasOne(d => d.CodigoSnvtrechoNavigation)
                    .WithMany(p => p.TblBrlegalProjetoBasicoEntregaTrecho)
                    .HasForeignKey(d => d.CodigoSnvtrecho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalProjetoBasicoEntregaTrecho_SNVTrecho");
            });

            modelBuilder.Entity<TblBrlegalProjetoBasicoEntregaTrechoNaoAceite>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalProjetoBasicoEntregaTrechoNaoAceite)
                    .HasName("prkBRLegalProjetoBasicoEntregaTrechoNaoAceite");

                entity.ToTable("tblBRLegalProjetoBasicoEntregaTrechoNaoAceite");

                entity.Property(e => e.CodigoBrlegalProjetoBasicoEntregaTrechoNaoAceite).HasColumnName("CodigoBRLegalProjetoBasicoEntregaTrechoNaoAceite");

                entity.Property(e => e.CodigoBrlegalProjetoBasicoEntrega).HasColumnName("CodigoBRLegalProjetoBasicoEntrega");

                entity.Property(e => e.CodigoSnvtrecho).HasColumnName("CodigoSNVTrecho");

                entity.Property(e => e.DataCorrecaoEntrega).HasColumnType("datetime");

                entity.Property(e => e.DataNaoAceite).HasColumnType("datetime");

                entity.Property(e => e.DataNovaEntrega).HasColumnType("datetime");

                entity.Property(e => e.EngenheirosFiscais)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Extensao).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.KmFinal).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.KmInicial).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.NovaDataLimiteAnalise).HasColumnType("datetime");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBrlegalProjetoBasicoEntregaNavigation)
                    .WithMany(p => p.TblBrlegalProjetoBasicoEntregaTrechoNaoAceite)
                    .HasForeignKey(d => d.CodigoBrlegalProjetoBasicoEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalProjetoBasicoEntregaTrechoNaoAceite_BRLegalProjetoBasicoEntrega");

                entity.HasOne(d => d.CodigoSnvtrechoNavigation)
                    .WithMany(p => p.TblBrlegalProjetoBasicoEntregaTrechoNaoAceite)
                    .HasForeignKey(d => d.CodigoSnvtrecho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalProjetoBasicoEntregaTrechoNaoAceite_SNVTrecho");
            });

            modelBuilder.Entity<TblBrlegalProjetoEntregaTrechoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalProjetoEntregaTrechoSituacao)
                    .HasName("prkBRLegalProjetoEntregaTrechoSituacao");

                entity.ToTable("tblBRLegalProjetoEntregaTrechoSituacao");

                entity.Property(e => e.CodigoBrlegalProjetoEntregaTrechoSituacao).HasColumnName("CodigoBRLegalProjetoEntregaTrechoSituacao");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBrlegalProjetoExecutivoEntrega>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalProjetoExecutivoEntrega)
                    .HasName("prkBRLegalProjetoExecutivoEntrega");

                entity.ToTable("tblBRLegalProjetoExecutivoEntrega");

                entity.Property(e => e.CodigoBrlegalProjetoExecutivoEntrega).HasColumnName("CodigoBRLegalProjetoExecutivoEntrega");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoBrlegalContrato).HasColumnName("CodigoBRLegalContrato");

                entity.Property(e => e.DataEntregaProjetoSede).HasColumnType("datetime");

                entity.Property(e => e.DataLimiteAnalise).HasColumnType("datetime");

                entity.Property(e => e.Extensao).HasColumnType("numeric(6, 2)");

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblBrlegalProjetoExecutivoEntrega)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalProjetoExecutivoEntrega_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblBrlegalProjetoExecutivoEntrega)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalProjetoExecutivoEntrega_BaseUF");

                entity.HasOne(d => d.CodigoBrlegalContratoNavigation)
                    .WithMany(p => p.TblBrlegalProjetoExecutivoEntrega)
                    .HasForeignKey(d => d.CodigoBrlegalContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalProjetoExecutivoEntrega_BRLegalContrato");
            });

            modelBuilder.Entity<TblBrlegalProjetoExecutivoEntregaTrecho>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalProjetoExecutivoEntregaTrecho)
                    .HasName("prkBRLegalProjetoExecutivoEntregaTrecho");

                entity.ToTable("tblBRLegalProjetoExecutivoEntregaTrecho");

                entity.Property(e => e.CodigoBrlegalProjetoExecutivoEntregaTrecho).HasColumnName("CodigoBRLegalProjetoExecutivoEntregaTrecho");

                entity.Property(e => e.CodigoBrlegalProjetoEntregaTrechoSituacao).HasColumnName("CodigoBRLegalProjetoEntregaTrechoSituacao");

                entity.Property(e => e.CodigoBrlegalProjetoExecutivoEntrega).HasColumnName("CodigoBRLegalProjetoExecutivoEntrega");

                entity.Property(e => e.CodigoSnvtrecho).HasColumnName("CodigoSNVTrecho");

                entity.Property(e => e.DataAceite).HasColumnType("datetime");

                entity.Property(e => e.EngenheirosFiscais)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Extensao).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.KmFinal).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.KmInicial).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBrlegalProjetoEntregaTrechoSituacaoNavigation)
                    .WithMany(p => p.TblBrlegalProjetoExecutivoEntregaTrecho)
                    .HasForeignKey(d => d.CodigoBrlegalProjetoEntregaTrechoSituacao)
                    .HasConstraintName("frkBRLegalProjetoExecutivoEntregaTrecho_BRLegalProjetoEntregaTrechoSituacao");

                entity.HasOne(d => d.CodigoBrlegalProjetoExecutivoEntregaNavigation)
                    .WithMany(p => p.TblBrlegalProjetoExecutivoEntregaTrecho)
                    .HasForeignKey(d => d.CodigoBrlegalProjetoExecutivoEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalProjetoExecutivoEntregaTrecho_BRLegalProjetoExecutivoEntrega");

                entity.HasOne(d => d.CodigoSnvtrechoNavigation)
                    .WithMany(p => p.TblBrlegalProjetoExecutivoEntregaTrecho)
                    .HasForeignKey(d => d.CodigoSnvtrecho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalProjetoExecutivoEntregaTrecho_SNVTrecho");
            });

            modelBuilder.Entity<TblBrlegalProjetoExecutivoEntregaTrechoNaoAceite>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalProjetoExecutivoEntregaTrechoNaoAceite)
                    .HasName("prkBRLegalProjetoExecutivoEntregaNaoAceiteSNV");

                entity.ToTable("tblBRLegalProjetoExecutivoEntregaTrechoNaoAceite");

                entity.Property(e => e.CodigoBrlegalProjetoExecutivoEntregaTrechoNaoAceite).HasColumnName("CodigoBRLegalProjetoExecutivoEntregaTrechoNaoAceite");

                entity.Property(e => e.CodigoBrlegalProjetoExecutivoEntrega).HasColumnName("CodigoBRLegalProjetoExecutivoEntrega");

                entity.Property(e => e.CodigoSnvtrecho).HasColumnName("CodigoSNVTrecho");

                entity.Property(e => e.DataCorrecaoEntrega).HasColumnType("datetime");

                entity.Property(e => e.DataNaoAceite).HasColumnType("datetime");

                entity.Property(e => e.DataNovaEntrega).HasColumnType("datetime");

                entity.Property(e => e.EngenheirosFiscais)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Extensao).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.KmFinal).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.KmInicial).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.NovaDataLimiteAnalise).HasColumnType("datetime");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBrlegalProjetoExecutivoEntregaNavigation)
                    .WithMany(p => p.TblBrlegalProjetoExecutivoEntregaTrechoNaoAceite)
                    .HasForeignKey(d => d.CodigoBrlegalProjetoExecutivoEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalProjetoExecutivoEntregaTrechoNaoAceite_BRLegalProjetoExecutivoEntrega");

                entity.HasOne(d => d.CodigoSnvtrechoNavigation)
                    .WithMany(p => p.TblBrlegalProjetoExecutivoEntregaTrechoNaoAceite)
                    .HasForeignKey(d => d.CodigoSnvtrecho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalProjetoExecutivoEntregaTrechoNaoAceite_SNVTrecho");
            });

            modelBuilder.Entity<TblBrlegalServicoFamilia>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalServicoFamilia)
                    .HasName("prkBRLegalServicoFamilia");

                entity.ToTable("tblBRLegalServicoFamilia");

                entity.Property(e => e.CodigoBrlegalServicoFamilia).HasColumnName("CodigoBRLegalServicoFamilia");

                entity.Property(e => e.CodigoDnit).HasColumnName("CodigoDNIT");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBrlegalServicoItem>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalServicoItem)
                    .HasName("prkBRLegalServicoItem");

                entity.ToTable("tblBRLegalServicoItem");

                entity.Property(e => e.CodigoBrlegalServicoItem).HasColumnName("CodigoBRLegalServicoItem");

                entity.Property(e => e.CodigoBrlegalServicoFamilia).HasColumnName("CodigoBRLegalServicoFamilia");

                entity.Property(e => e.CodigoBrlegalServicoUnidadeMedida).HasColumnName("CodigoBRLegalServicoUnidadeMedida");

                entity.Property(e => e.CodigoDnit).HasColumnName("CodigoDNIT");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBrlegalServicoFamiliaNavigation)
                    .WithMany(p => p.TblBrlegalServicoItem)
                    .HasForeignKey(d => d.CodigoBrlegalServicoFamilia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalServicoItem_BRLegalServicoFamilia");

                entity.HasOne(d => d.CodigoBrlegalServicoUnidadeMedidaNavigation)
                    .WithMany(p => p.TblBrlegalServicoItem)
                    .HasForeignKey(d => d.CodigoBrlegalServicoUnidadeMedida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkBRLegalServicoItem_BRLegalServicoUnidadeMedida");
            });

            modelBuilder.Entity<TblBrlegalServicoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalServicoTipo)
                    .HasName("prkBRLegalServicoTipo");

                entity.ToTable("tblBRLegalServicoTipo");

                entity.Property(e => e.CodigoBrlegalServicoTipo).HasColumnName("CodigoBRLegalServicoTipo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBrlegalServicoUnidadeMedida>(entity =>
            {
                entity.HasKey(e => e.CodigoBrlegalServicoUnidadeMedida)
                    .HasName("prkBRLegalServicoUnidadeMedida");

                entity.ToTable("tblBRLegalServicoUnidadeMedida");

                entity.Property(e => e.CodigoBrlegalServicoUnidadeMedida).HasColumnName("CodigoBRLegalServicoUnidadeMedida");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCobrancaInfracao>(entity =>
            {
                entity.HasKey(e => e.CodigoCobrancaInfracao)
                    .HasName("prkCobrancaInfracao");

                entity.ToTable("tblCobrancaInfracao");

                entity.HasIndex(e => new { e.InfracaoValorOriginal, e.DevedorNome, e.DevedorNumeroInscricao, e.DevedorNumeroInscricaoFormatado, e.CodigoCobrancaInfracaoSituacao, e.CodigoCobrancaInfracaoFase })
                    .HasName("idxCobrancaInfracao_AutorizacaoAnalise_Pesquisa");

                entity.HasIndex(e => new { e.CodigoCobrancaInfracao, e.CodigoCobrancaInfracaoDevedorCondicao, e.CodigoInfracaoEnquadramento, e.CodigoInfracaoOrigem, e.InfracaoNotificacaoPenalidadeDataVencimento, e.CodigoCobrancaInfracaoSituacao, e.CodigoCobrancaInfracaoFase })
                    .HasName("idxCobrancaInfracao_SituacaoFase");

                entity.Property(e => e.CodigoCobrancaInfracao).ValueGeneratedNever();

                entity.Property(e => e.AnaliseDaautoridadeTransito)
                    .HasColumnName("AnaliseDAAutoridadeTransito")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AnaliseDadataJulgamento)
                    .HasColumnName("AnaliseDADataJulgamento")
                    .HasColumnType("date");

                entity.Property(e => e.AnaliseDadataProtocolo)
                    .HasColumnName("AnaliseDADataProtocolo")
                    .HasColumnType("date");

                entity.Property(e => e.AnaliseDataConstituicaoDefinitiva).HasColumnType("date");

                entity.Property(e => e.AnaliseDataInicioMultaMora).HasColumnType("date");

                entity.Property(e => e.AnaliseDataInicioSelic).HasColumnType("date");

                entity.Property(e => e.AnaliseDataPrescricaoExecutoria).HasColumnType("date");

                entity.Property(e => e.AnaliseDataVencimentoUltimaGru)
                    .HasColumnName("AnaliseDataVencimentoUltimaGRU")
                    .HasColumnType("date");

                entity.Property(e => e.AnaliseNadataPostagem)
                    .HasColumnName("AnaliseNADataPostagem")
                    .HasColumnType("date");

                entity.Property(e => e.AnaliseNadataPublicacaoDou)
                    .HasColumnName("AnaliseNADataPublicacaoDOU")
                    .HasColumnType("date");

                entity.Property(e => e.AnaliseNpdataPostagem)
                    .HasColumnName("AnaliseNPDataPostagem")
                    .HasColumnType("date");

                entity.Property(e => e.AnaliseNpdataPublicacaoDou)
                    .HasColumnName("AnaliseNPDataPublicacaoDOU")
                    .HasColumnType("date");

                entity.Property(e => e.AnaliseNpdataVencimentoGru)
                    .HasColumnName("AnaliseNPDataVencimentoGRU")
                    .HasColumnType("date");

                entity.Property(e => e.AnaliseProcessualData).HasColumnType("datetime");

                entity.Property(e => e.AnaliseProcessualUsuarioNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AnaliseRecursoPrimeiraInstacaoDataJulgamento).HasColumnType("date");

                entity.Property(e => e.AnaliseRecursoPrimeiraInstacaoDataProtocolo).HasColumnType("date");

                entity.Property(e => e.AnaliseRecursoPrimeiraInstacaoNotificacaoDataPostagem).HasColumnType("date");

                entity.Property(e => e.AnaliseRecursoPrimeiraInstacaoNotificacaoDataPublicacaoDou)
                    .HasColumnName("AnaliseRecursoPrimeiraInstacaoNotificacaoDataPublicacaoDOU")
                    .HasColumnType("date");

                entity.Property(e => e.AnaliseRecursoPrimeiraInstacaoOrgaoJulgador)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AnaliseRecursoSegundaInstacaoDataJulgamento).HasColumnType("date");

                entity.Property(e => e.AnaliseRecursoSegundaInstacaoDataProtocolo).HasColumnType("date");

                entity.Property(e => e.AnaliseRecursoSegundaInstacaoNotificacaoDataPostagem).HasColumnType("date");

                entity.Property(e => e.AnaliseRecursoSegundaInstacaoNotificacaoDataPublicacaoDou)
                    .HasColumnName("AnaliseRecursoSegundaInstacaoNotificacaoDataPublicacaoDOU")
                    .HasColumnType("date");

                entity.Property(e => e.AnaliseRecursoSegundaInstacaoOrgaoJulgador)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CadastroSapiensdata)
                    .HasColumnName("CadastroSAPIENSData")
                    .HasColumnType("datetime");

                entity.Property(e => e.CadastroSapiensusuarioNome)
                    .HasColumnName("CadastroSAPIENSUsuarioNome")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CdaarquivoNome)
                    .HasColumnName("CDAArquivoNome")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CdaarquivoNomeFisico)
                    .HasColumnName("CDAArquivoNomeFisico")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CdaarquivoTamanho).HasColumnName("CDAArquivoTamanho");

                entity.Property(e => e.Cdanumero)
                    .HasColumnName("CDANumero")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCobrancaInfracaoIndicadorResultadoExpedicaoNa).HasColumnName("CodigoCobrancaInfracaoIndicadorResultadoExpedicaoNA");

                entity.Property(e => e.CodigoCobrancaInfracaoIndicadorResultadoTramitacaoPfe).HasColumnName("CodigoCobrancaInfracaoIndicadorResultadoTramitacaoPFE");

                entity.Property(e => e.CodigoInfracaoDa).HasColumnName("CodigoInfracaoDA");

                entity.Property(e => e.CodigoUsuarioCadastroSapiens).HasColumnName("CodigoUsuarioCadastroSAPIENS");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataCancelamento).HasColumnType("datetime");

                entity.Property(e => e.DataEncerramento).HasColumnType("datetime");

                entity.Property(e => e.DaudataInscricao)
                    .HasColumnName("DAUDataInscricao")
                    .HasColumnType("date");

                entity.Property(e => e.DaudataPagamento)
                    .HasColumnName("DAUDataPagamento")
                    .HasColumnType("date");

                entity.Property(e => e.DauindicadorDebitoPago).HasColumnName("DAUIndicadorDebitoPago");

                entity.Property(e => e.DauindicadorInscricao).HasColumnName("DAUIndicadorInscricao");

                entity.Property(e => e.DauvalorPago)
                    .HasColumnName("DAUValorPago")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.DevedorNome)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DevedorNumeroInscricao)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.DevedorNumeroInscricaoFormatado)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.IndicadorCadastradoSapiens).HasColumnName("IndicadorCadastradoSAPIENS");

                entity.Property(e => e.InfracaoDarecorrenteNome)
                    .HasColumnName("InfracaoDARecorrenteNome")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InfracaoData).HasColumnType("date");

                entity.Property(e => e.InfracaoDevedorNome)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InfracaoDevedorNumeroInscricao)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.InfracaoDevedorNumeroInscricaoFormatado)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.InfracaoIndicadorRegistroRenainf).HasColumnName("InfracaoIndicadorRegistroRENAINF");

                entity.Property(e => e.InfracaoNotificacaoPenalidadeDataVencimento).HasColumnType("date");

                entity.Property(e => e.InfracaoNumeroAuto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InfracaoNupformatado)
                    .IsRequired()
                    .HasColumnName("InfracaoNUPFormatado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InfracaoValorOriginal).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.InfracaoVeiculoPlaca)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.InfracaoVeiculoUf)
                    .IsRequired()
                    .HasColumnName("InfracaoVeiculoUF")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PagamentoArquivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PagamentoArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RelatorioArquivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RelatorioArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RevisaoProcessualData).HasColumnType("datetime");

                entity.Property(e => e.RevisaoProcessualUsuarioNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.SapiensdataCadastro)
                    .HasColumnName("SAPIENSDataCadastro")
                    .HasColumnType("date");

                entity.Property(e => e.Sapiensnupformatado)
                    .HasColumnName("SAPIENSNUPFormatado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TdaarquivoNome)
                    .HasColumnName("TDAArquivoNome")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TdaarquivoNomeFisico)
                    .HasColumnName("TDAArquivoNomeFisico")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TdaarquivoTamanho).HasColumnName("TDAArquivoTamanho");

                entity.Property(e => e.Tdanumero)
                    .HasColumnName("TDANumero")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoCobrancaInfracaoNavigation)
                    .WithOne(p => p.TblCobrancaInfracao)
                    .HasForeignKey<TblCobrancaInfracao>(d => d.CodigoCobrancaInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracao_Infracao");

                entity.HasOne(d => d.CodigoCobrancaInfracaoDevedorCondicaoNavigation)
                    .WithMany(p => p.TblCobrancaInfracao)
                    .HasForeignKey(d => d.CodigoCobrancaInfracaoDevedorCondicao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracao_CobrancaInfracaoDevedorCondicao");

                entity.HasOne(d => d.CodigoCobrancaInfracaoDevedorNumeroInscricaoTipoNavigation)
                    .WithMany(p => p.TblCobrancaInfracao)
                    .HasForeignKey(d => d.CodigoCobrancaInfracaoDevedorNumeroInscricaoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracao_CobrancaInfracaoDevedorNumeroInscricaoTipo");

                entity.HasOne(d => d.CodigoCobrancaInfracaoDevedorSituacaoCadastralNavigation)
                    .WithMany(p => p.TblCobrancaInfracao)
                    .HasForeignKey(d => d.CodigoCobrancaInfracaoDevedorSituacaoCadastral)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracao_CobrancaInfracaoDevedorSituacaoCadastral");

                entity.HasOne(d => d.CodigoCobrancaInfracaoFaseNavigation)
                    .WithMany(p => p.TblCobrancaInfracao)
                    .HasForeignKey(d => d.CodigoCobrancaInfracaoFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracao_CobrancaInfracaoFase");

                entity.HasOne(d => d.CodigoCobrancaInfracaoIndicadorResultadoAnaliseProcessualNavigation)
                    .WithMany(p => p.TblCobrancaInfracao)
                    .HasForeignKey(d => d.CodigoCobrancaInfracaoIndicadorResultadoAnaliseProcessual)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracao_CobrancaInfracaoIndicadorResultado_AnaliseProcessual");

                entity.HasOne(d => d.CodigoCobrancaInfracaoIndicadorResultadoAndamentoProcessualNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoCodigoCobrancaInfracaoIndicadorResultadoAndamentoProcessualNavigation)
                    .HasForeignKey(d => d.CodigoCobrancaInfracaoIndicadorResultadoAndamentoProcessual)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracao_CobrancaInfracaoIndicadorResultado_AndamentoProcessual");

                entity.HasOne(d => d.CodigoCobrancaInfracaoIndicadorResultadoExpedicaoNaNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoCodigoCobrancaInfracaoIndicadorResultadoExpedicaoNaNavigation)
                    .HasForeignKey(d => d.CodigoCobrancaInfracaoIndicadorResultadoExpedicaoNa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracao_CobrancaInfracaoIndicadorResultado_ExpedicaoNA");

                entity.HasOne(d => d.CodigoCobrancaInfracaoIndicadorResultadoRevisaoProcessualNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoCodigoCobrancaInfracaoIndicadorResultadoRevisaoProcessualNavigation)
                    .HasForeignKey(d => d.CodigoCobrancaInfracaoIndicadorResultadoRevisaoProcessual)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracao_CobrancaInfracaoIndicadorResultadoRevisaoProcessual");

                entity.HasOne(d => d.CodigoCobrancaInfracaoIndicadorResultadoTramitacaoPfeNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoCodigoCobrancaInfracaoIndicadorResultadoTramitacaoPfeNavigation)
                    .HasForeignKey(d => d.CodigoCobrancaInfracaoIndicadorResultadoTramitacaoPfe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracao_CobrancaInfracaoIndicadorResultado_TramitacaoPFE");

                entity.HasOne(d => d.CodigoCobrancaInfracaoSituacaoNavigation)
                    .WithMany(p => p.TblCobrancaInfracao)
                    .HasForeignKey(d => d.CodigoCobrancaInfracaoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracao_CobrancaInfracaoSituacao");

                entity.HasOne(d => d.CodigoInfracaoDaNavigation)
                    .WithMany(p => p.TblCobrancaInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoDa)
                    .HasConstraintName("frkCobrancaInfracao_InfracaoDA");

                entity.HasOne(d => d.CodigoInfracaoEnquadramentoNavigation)
                    .WithMany(p => p.TblCobrancaInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoEnquadramento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracao_InfracaoEnquadramento");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoAutuacaoNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoCodigoInfracaoNotificacaoAutuacaoNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoAutuacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracao_InfracaoNotificacao_Autuacao");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoPenalidadeNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoCodigoInfracaoNotificacaoPenalidadeNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoPenalidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracao_InfracaoNotificacao_Penalidade");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoRecursoPrimeiraInstanciaNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoCodigoInfracaoNotificacaoRecursoPrimeiraInstanciaNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoRecursoPrimeiraInstancia)
                    .HasConstraintName("frkCobrancaInfracao_InfracaoNotificacaoRecurso_PrimeiraInstacia");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoRecursoSegundaInstanciaNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoCodigoInfracaoNotificacaoRecursoSegundaInstanciaNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoRecursoSegundaInstancia)
                    .HasConstraintName("frkCobrancaInfracao_InfracaoNotificacaoRecurso_SegundaInstacia");

                entity.HasOne(d => d.CodigoInfracaoOrigemNavigation)
                    .WithMany(p => p.TblCobrancaInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoOrigem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracao_InfracaoOrigem");

                entity.HasOne(d => d.CodigoInfracaoRecursoPrimeiraInstanciaNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoCodigoInfracaoRecursoPrimeiraInstanciaNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoPrimeiraInstancia)
                    .HasConstraintName("frkCobrancaInfracao_InfracaoRecurso_PrimeiraInstacia");

                entity.HasOne(d => d.CodigoInfracaoRecursoSegundaInstanciaNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoCodigoInfracaoRecursoSegundaInstanciaNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoSegundaInstancia)
                    .HasConstraintName("frkCobrancaInfracao_InfracaoRecurso_SegundaInstacia");

                entity.HasOne(d => d.CodigoUsuarioAnaliseProcessualNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoCodigoUsuarioAnaliseProcessualNavigation)
                    .HasForeignKey(d => d.CodigoUsuarioAnaliseProcessual)
                    .HasConstraintName("frkCobrancaInfracao_SistemaUsuario_AnaliseProcessual");

                entity.HasOne(d => d.CodigoUsuarioCadastroSapiensNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoCodigoUsuarioCadastroSapiensNavigation)
                    .HasForeignKey(d => d.CodigoUsuarioCadastroSapiens)
                    .HasConstraintName("frkCobrancaInfracao_SistemaUsuario_VerificacaoDocumental");

                entity.HasOne(d => d.CodigoUsuarioRevisaoProcessualNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoCodigoUsuarioRevisaoProcessualNavigation)
                    .HasForeignKey(d => d.CodigoUsuarioRevisaoProcessual)
                    .HasConstraintName("frkCobrancaInfracao_SistemaUsuario");
            });

            modelBuilder.Entity<TblCobrancaInfracaoArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoCobrancaInfracaoArquivo)
                    .HasName("prkCobrancaInfracaoArquivo");

                entity.ToTable("tblCobrancaInfracaoArquivo");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacaoCaixa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoCobrancaInfracaoNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoArquivo)
                    .HasForeignKey(d => d.CodigoCobrancaInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracaoArquivo_CobrancaInfracao");
            });

            modelBuilder.Entity<TblCobrancaInfracaoDevedorCondicao>(entity =>
            {
                entity.HasKey(e => e.CodigoCobrancaInfracaoDevedorCondicao)
                    .HasName("prkCobrancaInfracaoDevedorCondicao");

                entity.ToTable("tblCobrancaInfracaoDevedorCondicao");

                entity.Property(e => e.CodigoCobrancaInfracaoDevedorCondicao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCobrancaInfracaoDevedorNumeroInscricaoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoCobrancaInfracaoDevedorNumeroInscricaoTipo)
                    .HasName("prkCobrancaInfracaoDevedorNumeroInscricaoTipo");

                entity.ToTable("tblCobrancaInfracaoDevedorNumeroInscricaoTipo");

                entity.Property(e => e.CodigoCobrancaInfracaoDevedorNumeroInscricaoTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCobrancaInfracaoDevedorSituacaoCadastral>(entity =>
            {
                entity.HasKey(e => e.CodigoCobrancaInfracaoDevedorSituacaoCadastral)
                    .HasName("prkCobrancaInfracaoDevedorSituacaoCadastral");

                entity.ToTable("tblCobrancaInfracaoDevedorSituacaoCadastral");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCobrancaInfracaoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoCobrancaInfracaoEvento)
                    .HasName("prkCobrancaInfracaoEvento");

                entity.ToTable("tblCobrancaInfracaoEvento");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoCobrancaInfracaoNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoEvento)
                    .HasForeignKey(d => d.CodigoCobrancaInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracaoEvento_CobrancaInfracao");

                entity.HasOne(d => d.CodigoCobrancaInfracaoFaseNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoEvento)
                    .HasForeignKey(d => d.CodigoCobrancaInfracaoFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracaoEvento_CobrancaInfracaoFase");

                entity.HasOne(d => d.CodigoCobrancaInfracaoSituacaoNavigation)
                    .WithMany(p => p.TblCobrancaInfracaoEvento)
                    .HasForeignKey(d => d.CodigoCobrancaInfracaoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkCobrancaInfracaoEvento_CobrancaInfracaoSituacao");
            });

            modelBuilder.Entity<TblCobrancaInfracaoFase>(entity =>
            {
                entity.HasKey(e => e.CodigoCobrancaInfracaoFase)
                    .HasName("prkCobrancaInfracaoFase");

                entity.ToTable("tblCobrancaInfracaoFase");

                entity.Property(e => e.CodigoCobrancaInfracaoFase).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCobrancaInfracaoIndicadorResultadoAnalise>(entity =>
            {
                entity.HasKey(e => e.CodigoCobrancaInfracaoIndicadorResultadoAnalise)
                    .HasName("prkCobrancaInfracaoIndicadorResultadoAnalise");

                entity.ToTable("tblCobrancaInfracaoIndicadorResultadoAnalise");

                entity.Property(e => e.CodigoCobrancaInfracaoIndicadorResultadoAnalise).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCobrancaInfracaoIndicadorResultadoConsistencia>(entity =>
            {
                entity.HasKey(e => e.CodigoCobrancaInfracaoIndicadorResultadoConsistencia)
                    .HasName("prkCobrancaInfracaoIndicadorResultadoConsistencia");

                entity.ToTable("tblCobrancaInfracaoIndicadorResultadoConsistencia");

                entity.Property(e => e.CodigoCobrancaInfracaoIndicadorResultadoConsistencia).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCobrancaInfracaoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoCobrancaInfracaoSituacao)
                    .HasName("prkCobrancaInfracaoSituacao");

                entity.ToTable("tblCobrancaInfracaoSituacao");

                entity.Property(e => e.CodigoCobrancaInfracaoSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracao)
                    .HasName("prkInfracao");

                entity.ToTable("tblInfracao");

                entity.HasIndex(e => e.CodigoInfracaoVeiculo)
                    .HasName("idxInfracao_Veiculo");

                entity.HasIndex(e => e.CodigoRenavammunicipioLocalInfracao)
                    .HasName("idxInfracao_CodigoRENAVAMMunicipioLocalInfracao");

                entity.HasIndex(e => e.DataHoraInfracao)
                    .HasName("idxInfracao_DataHora");

                entity.HasIndex(e => e.IndicadorRegistroRenainf)
                    .HasName("idxInfracao_IndicadorRegistroRENAINF");

                entity.HasIndex(e => e.NumeroAit)
                    .HasName("idxInfracao_NumeroAuto")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodigoInfracao, e.CodigoInfracaoPesagem })
                    .HasName("idxInfracao_Pesagem");

                entity.HasIndex(e => new { e.CodigoInfracaoFase, e.DataInfracao, e.CodigoInfracaoSituacao })
                    .HasName("idxInfracao_Situacao");

                entity.HasIndex(e => new { e.CodigoInfracaoVeiculo, e.CodigoInfracaoProprietario, e.CodigoInfracao })
                    .HasName("idxInfracao_NotificacaoExpedicaoArquivoXmlPNCV");

                entity.HasIndex(e => new { e.CodigoInfracao, e.CodigoInfracaoVeiculo, e.CodigoInfracaoProprietario, e.DataInfracao })
                    .HasName("idxInfracao_Data");

                entity.HasIndex(e => new { e.CodigoInfracao, e.DataInfracao, e.DataHoraInfracao, e.CodigoEquipamentoDnit, e.PrazoExpedicaoNp, e.CodigoInfracaoSituacao, e.CodigoInfracaoFase })
                    .HasName("idxInfracao_SituacaoFase");

                entity.HasIndex(e => new { e.CodigoInfracao, e.DataInfracao, e.CodigoEquipamentoDnit, e.CodigoInfracaoEnquadramento, e.CodigoRenainf, e.NumeroAit, e.IndicadorRegistroRenainf, e.CodigoInfracaoSituacao, e.CodigoInfracaoFase, e.CodigoInfracaoOrigem, e.PrazoExpedicaoNp })
                    .HasName("idxInfracao_Notificacao_Penalidade_AutorizarExpedicao");

                entity.HasIndex(e => new { e.CodigoInfracao, e.CodigoInfracaoEnquadramento, e.CodigoInfracaoGravidade, e.CodigoInfracaoIndicadorResponsavel, e.CodigoUflocalInfracao, e.CodigoInfracaoVeiculo, e.CodigoInfracaoCausaCancelamento, e.CodigoRenavammunicipioLocalInfracao, e.NumeroAit, e.IndicadorAutuacaoEmFlagrante, e.LocalInfracao, e.DataHoraInfracao, e.ValorOriginal, e.CodigoInfracaoProprietario, e.CodigoInfracaoSituacao, e.CodigoInfracaoFase })
                    .HasName("idxInfracao_PortalMultas");

                entity.Property(e => e.CodigoEquipamentoDnit)
                    .HasColumnName("CodigoEquipamentoDNIT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncveditalLote).HasColumnName("CodigoPNCVEditalLote");

                entity.Property(e => e.CodigoRenainf)
                    .HasColumnName("CodigoRENAINF")
                    .HasColumnType("decimal(11, 0)");

                entity.Property(e => e.CodigoRenavamindicadorAdesaoSne).HasColumnName("CodigoRENAVAMIndicadorAdesaoSne");

                entity.Property(e => e.CodigoRenavamindicadorAssinaturaAuto).HasColumnName("CodigoRENAVAMIndicadorAssinaturaAuto");

                entity.Property(e => e.CodigoRenavammunicipioLocalInfracao).HasColumnName("CodigoRENAVAMMunicipioLocalInfracao");

                entity.Property(e => e.CodigoRenavamorgaoAutuador).HasColumnName("CodigoRENAVAMOrgaoAutuador");

                entity.Property(e => e.CodigoRenavamtipoAutoInfracao).HasColumnName("CodigoRENAVAMTipoAutoInfracao");

                entity.Property(e => e.CodigoRenavamunidadeMedida).HasColumnName("CodigoRENAVAMUnidadeMedida");

                entity.Property(e => e.CodigoUflocalInfracao).HasColumnName("CodigoUFLocalInfracao");

                entity.Property(e => e.DataAdesaoSne).HasColumnType("datetime");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataCancelamento).HasColumnType("date");

                entity.Property(e => e.DataDesvinculacaoMulta).HasColumnType("date");

                entity.Property(e => e.DataHoraInfracao).HasColumnType("datetime");

                entity.Property(e => e.DataInfracao).HasColumnType("date");

                entity.Property(e => e.DataReconhecidoCometimentoInfracao).HasColumnType("date");

                entity.Property(e => e.DataVerificacaoInmetro).HasColumnType("date");

                entity.Property(e => e.FaixaRodoviaLocalInfracao)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ImagemPrincipalArquivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImagemPrincipalArquivoNomeFisico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IndicadorRegistroRenainf).HasColumnName("IndicadorRegistroRENAINF");

                entity.Property(e => e.LimiteRegulamentado).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.LocalInfracao)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.MarcaEquipamento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicaoRealizada).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ModeloEquipamento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeRodoviaLocalInfracao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAgenteTransito)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAit)
                    .IsRequired()
                    .HasColumnName("NumeroAIT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroKmLocalInfracao).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.NumeroVerificacaoInmetro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NupdataCadastro)
                    .HasColumnName("NUPDataCadastro")
                    .HasColumnType("date");

                entity.Property(e => e.Nupformatado)
                    .IsRequired()
                    .HasColumnName("NUPFormatado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PontosCnh).HasColumnName("PontosCNH");

                entity.Property(e => e.PrazoExpedicaoNp)
                    .HasColumnName("PrazoExpedicaoNP")
                    .HasColumnType("date");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.ValorConsiderado).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorOriginal).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal60Porcento).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal80Porcento).HasColumnType("decimal(7, 2)");

                entity.HasOne(d => d.CodigoInfracaoCausaCancelamentoNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoCausaCancelamento)
                    .HasConstraintName("frkInfracao_InfracaoCausaCancelamento");

                entity.HasOne(d => d.CodigoInfracaoCondutorNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoCondutor)
                    .HasConstraintName("frkInfracao_InfracaoCondutor");

                entity.HasOne(d => d.CodigoInfracaoEmbarcadorNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoEmbarcador)
                    .HasConstraintName("frkInfracao_InfracaoEmbarcador");

                entity.HasOne(d => d.CodigoInfracaoEnquadramentoNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoEnquadramento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracao_InfracaoEnquadramentoCTB");

                entity.HasOne(d => d.CodigoInfracaoEquipamentoAfericaoTipoNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoEquipamentoAfericaoTipo)
                    .HasConstraintName("frkInfracao_InfracaoEquipamentoAfericaoTipo");

                entity.HasOne(d => d.CodigoInfracaoFaseNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracao_InfracaoFase");

                entity.HasOne(d => d.CodigoInfracaoGravidadeNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoGravidade)
                    .HasConstraintName("frkInfracao_InfracaoGravidade");

                entity.HasOne(d => d.CodigoInfracaoIndicadorResponsavelNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoIndicadorResponsavel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracao_InfracaoIndicadorResponsavel");

                entity.HasOne(d => d.CodigoInfracaoInfratorNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoInfrator)
                    .HasConstraintName("frkInfracao_InfracaoInfrator");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoExpedicaoTipoNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoExpedicaoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracao_InfracaoNotificacaoExpedicaoTipo");

                entity.HasOne(d => d.CodigoInfracaoOrigemNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoOrigem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracao_InfracaoOrigem");

                entity.HasOne(d => d.CodigoInfracaoPesagemNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoPesagem)
                    .HasConstraintName("frkInfracao_InfracaoPesagem");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacao)
                    .HasConstraintName("frkInfracao_InfracaoPreAutuacao");

                entity.HasOne(d => d.CodigoInfracaoProprietarioNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoProprietario)
                    .HasConstraintName("frkInfracao_InfracaoProprietario");

                entity.HasOne(d => d.CodigoInfracaoSituacaoNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracao_InfracaoSituacao");

                entity.HasOne(d => d.CodigoInfracaoTransportadorNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoTransportador)
                    .HasConstraintName("frkInfracao_InfracaoTransportador");

                entity.HasOne(d => d.CodigoInfracaoVeiculoNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoVeiculo)
                    .HasConstraintName("frkInfracao_InfracaoVeiculo");

                entity.HasOne(d => d.CodigoRodoviaLocalInfracaoNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoRodoviaLocalInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracao_BaseRodovia_LocalInfracao");

                entity.HasOne(d => d.CodigoUflocalInfracaoNavigation)
                    .WithMany(p => p.TblInfracao)
                    .HasForeignKey(d => d.CodigoUflocalInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracao_BaseUF_LocalInfracao");
            });

            modelBuilder.Entity<TblInfracaoArquivoAnexo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoArquivoAnexo)
                    .HasName("prkInfracaoArquivoAnexo");

                entity.ToTable("tblInfracaoArquivoAnexo");

                entity.HasIndex(e => e.CodigoInfracao)
                    .HasName("idxInfracaoArquivoAnexo_Infracao");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacaoCaixa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoArquivoAnexo)
                    .HasForeignKey(d => d.CodigoInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoArquivoAnexo_Infracao");
            });

            modelBuilder.Entity<TblInfracaoCausaCancelamento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoCausaCancelamento)
                    .HasName("prkInfracaoCausaCancelamento");

                entity.ToTable("tblInfracaoCausaCancelamento");

                entity.Property(e => e.CodigoInfracaoCausaCancelamento).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoCondutor>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoCondutor)
                    .HasName("prkInfracaoCondutor");

                entity.ToTable("tblInfracaoCondutor");

                entity.Property(e => e.CodigoRenavammodeloCh).HasColumnName("CodigoRENAVAMModeloCH");

                entity.Property(e => e.CodigoRenavampaisExpedicaoChestrangeira).HasColumnName("CodigoRENAVAMPaisExpedicaoCHEstrangeira");

                entity.Property(e => e.CodigoRenavamtipoDocumentoCondutorNaoHabilitado).HasColumnName("CodigoRENAVAMTipoDocumentoCondutorNaoHabilitado");

                entity.Property(e => e.CodigoUfexpedicaoCnh).HasColumnName("CodigoUFExpedicaoCNH");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCpf)
                    .HasColumnName("NumeroCPF")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCpfformatado)
                    .HasColumnName("NumeroCPFFormatado")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumentoIdentificacao)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroRegistroCh)
                    .HasColumnName("NumeroRegistroCH")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoUfexpedicaoCnhNavigation)
                    .WithMany(p => p.TblInfracaoCondutor)
                    .HasForeignKey(d => d.CodigoUfexpedicaoCnh)
                    .HasConstraintName("frkInfracaoCondutor_BaseUF");
            });

            modelBuilder.Entity<TblInfracaoDa>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDa)
                    .HasName("prkInfracaoDA");

                entity.ToTable("tblInfracaoDA");

                entity.HasIndex(e => new { e.CodigoInfracao, e.NumeroProcesso })
                    .HasName("idxInfracaoDA_InfracaoProcesso")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodigoInfracaoDa, e.CodigoInfracao, e.CodigoInfracaoDasituacao, e.CodigoInfracaoDafase })
                    .HasName("idxInfracaoDA_SituacaoFase");

                entity.HasIndex(e => new { e.CodigoInfracaoDasituacao, e.CodigoInfracaoDafase, e.CodigoInfracaoDaindicadorResultadoJulgamento, e.CodigoInfracao })
                    .HasName("idxInfracaoDA_Infracao");

                entity.HasIndex(e => new { e.CodigoInfracaoDa, e.CodigoInfracao, e.CodigoInfracaoDaindicadorAdmissibilidade, e.CodigoInfracaoDaindicadorMerito, e.DataProtocolo, e.DataInstrucao, e.NumeroAuto, e.DataInfracao, e.CodigoSistemaUsuarioInstrucao, e.CodigoInfracaoDasituacao, e.CodigoInfracaoDafase })
                    .HasName("idxInfracaoDA_InstrucaoDistribuicao");

                entity.Property(e => e.CodigoInfracaoDa).HasColumnName("CodigoInfracaoDA");

                entity.Property(e => e.CodigoInfracaoDafase).HasColumnName("CodigoInfracaoDAFase");

                entity.Property(e => e.CodigoInfracaoDaindicadorAdmissibilidade).HasColumnName("CodigoInfracaoDAIndicadorAdmissibilidade");

                entity.Property(e => e.CodigoInfracaoDaindicadorMerito).HasColumnName("CodigoInfracaoDAIndicadorMerito");

                entity.Property(e => e.CodigoInfracaoDaindicadorRecorrente).HasColumnName("CodigoInfracaoDAIndicadorRecorrente");

                entity.Property(e => e.CodigoInfracaoDaindicadorResultadoJulgamento).HasColumnName("CodigoInfracaoDAIndicadorResultadoJulgamento");

                entity.Property(e => e.CodigoInfracaoDaorigem).HasColumnName("CodigoInfracaoDAOrigem");

                entity.Property(e => e.CodigoInfracaoDasituacao).HasColumnName("CodigoInfracaoDASituacao");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataCadastroDetran)
                    .HasColumnName("DataCadastroDETRAN")
                    .HasColumnType("date");

                entity.Property(e => e.DataCadastroDnit)
                    .HasColumnName("DataCadastroDNIT")
                    .HasColumnType("date");

                entity.Property(e => e.DataCancelamento).HasColumnType("date");

                entity.Property(e => e.DataInfracao).HasColumnType("date");

                entity.Property(e => e.DataInstrucao).HasColumnType("date");

                entity.Property(e => e.DataJulgamento).HasColumnType("date");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.IndicadorRegistroRenainf).HasColumnName("IndicadorRegistroRENAINF");

                entity.Property(e => e.InstrucaoAlegacao).IsUnicode(false);

                entity.Property(e => e.InstrucaoFundamentacao).IsUnicode(false);

                entity.Property(e => e.NumeroAuto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroProcesso)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrazoJulgamento).HasColumnType("date");

                entity.Property(e => e.RecorrenteNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecorrenteNumeroCpfcnpj)
                    .HasColumnName("RecorrenteNumeroCPFCNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.RecorrenteNumeroCpfcnpjformatado)
                    .HasColumnName("RecorrenteNumeroCPFCNPJFormatado")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.VeiculoPlaca)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.VeiculoPlacaUf)
                    .IsRequired()
                    .HasColumnName("VeiculoPlacaUF")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoDa)
                    .HasForeignKey(d => d.CodigoInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDA_Infracao");

                entity.HasOne(d => d.CodigoInfracaoDafaseNavigation)
                    .WithMany(p => p.TblInfracaoDa)
                    .HasForeignKey(d => d.CodigoInfracaoDafase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDA_InfracaoDAFase");

                entity.HasOne(d => d.CodigoInfracaoDaindicadorAdmissibilidadeNavigation)
                    .WithMany(p => p.TblInfracaoDa)
                    .HasForeignKey(d => d.CodigoInfracaoDaindicadorAdmissibilidade)
                    .HasConstraintName("frkInfracaoDA_InfracaoDAIndicadorAdmissibilidade");

                entity.HasOne(d => d.CodigoInfracaoDaindicadorMeritoNavigation)
                    .WithMany(p => p.TblInfracaoDa)
                    .HasForeignKey(d => d.CodigoInfracaoDaindicadorMerito)
                    .HasConstraintName("frkInfracaoDA_InfracaoDAIndicadorMerito");

                entity.HasOne(d => d.CodigoInfracaoDaindicadorRecorrenteNavigation)
                    .WithMany(p => p.TblInfracaoDa)
                    .HasForeignKey(d => d.CodigoInfracaoDaindicadorRecorrente)
                    .HasConstraintName("frkInfracaoDA_InfracaoDAIndicadorRecorrente");

                entity.HasOne(d => d.CodigoInfracaoDaindicadorResultadoJulgamentoNavigation)
                    .WithMany(p => p.TblInfracaoDa)
                    .HasForeignKey(d => d.CodigoInfracaoDaindicadorResultadoJulgamento)
                    .HasConstraintName("frkInfracaoDA_InfracaoDAIndicadorResultado");

                entity.HasOne(d => d.CodigoInfracaoDaorigemNavigation)
                    .WithMany(p => p.TblInfracaoDa)
                    .HasForeignKey(d => d.CodigoInfracaoDaorigem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDA_InfracaoDAOrigem");

                entity.HasOne(d => d.CodigoInfracaoDasituacaoNavigation)
                    .WithMany(p => p.TblInfracaoDa)
                    .HasForeignKey(d => d.CodigoInfracaoDasituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDA_InfracaoDASituacao");

                entity.HasOne(d => d.CodigoSistemaUsuarioEmInstrucaoNavigation)
                    .WithMany(p => p.TblInfracaoDa)
                    .HasForeignKey(d => d.CodigoSistemaUsuarioInstrucao)
                    .HasConstraintName("frkInfracaoDA_SistemaUsuarioEmInstrucao");
            });

            modelBuilder.Entity<TblInfracaoDaalegacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDaalegacao)
                    .HasName("prkInfracaoDAAlegacao");

                entity.ToTable("tblInfracaoDAAlegacao");

                entity.Property(e => e.CodigoInfracaoDaalegacao).HasColumnName("CodigoInfracaoDAAlegacao");

                entity.Property(e => e.Conteudo)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoDaalegacaoEnquadramento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDaalegacaoEnquadramento)
                    .HasName("prkInfracaoDAAlegacaoEnquadramento");

                entity.ToTable("tblInfracaoDAAlegacaoEnquadramento");

                entity.Property(e => e.CodigoInfracaoDaalegacaoEnquadramento).HasColumnName("CodigoInfracaoDAAlegacaoEnquadramento");

                entity.Property(e => e.CodigoInfracaoDaalegacao).HasColumnName("CodigoInfracaoDAAlegacao");

                entity.HasOne(d => d.CodigoInfracaoDaalegacaoNavigation)
                    .WithMany(p => p.TblInfracaoDaalegacaoEnquadramento)
                    .HasForeignKey(d => d.CodigoInfracaoDaalegacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDAAlegacaoEnquadramento_InfracaoDAAlegacao");

                entity.HasOne(d => d.CodigoInfracaoEnquadramentoNavigation)
                    .WithMany(p => p.TblInfracaoDaalegacaoEnquadramento)
                    .HasForeignKey(d => d.CodigoInfracaoEnquadramento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDAAlegacaoEnquadramento_InfracaoEnquadramento");
            });

            modelBuilder.Entity<TblInfracaoDaarquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDaarquivo)
                    .HasName("prkInfracaoDAArquivo");

                entity.ToTable("tblInfracaoDAArquivo");

                entity.HasIndex(e => e.CodigoInfracaoDa)
                    .HasName("idxInfracaoDAArquivo_DA");

                entity.Property(e => e.CodigoInfracaoDaarquivo).HasColumnName("CodigoInfracaoDAArquivo");

                entity.Property(e => e.CodigoInfracaoDa).HasColumnName("CodigoInfracaoDA");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacaoCaixa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoDaNavigation)
                    .WithMany(p => p.TblInfracaoDaarquivo)
                    .HasForeignKey(d => d.CodigoInfracaoDa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDAArquivo_InfracaoDA");
            });

            modelBuilder.Entity<TblInfracaoDacausaNaoConhecer>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDacausaNaoConhecer)
                    .HasName("prkInfracaoDACausaNaoConhecer");

                entity.ToTable("tblInfracaoDACausaNaoConhecer");

                entity.Property(e => e.CodigoInfracaoDacausaNaoConhecer)
                    .HasColumnName("CodigoInfracaoDACausaNaoConhecer")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SIOR.DatabaseLog>(entity =>
            {
                entity.HasKey(e => e.DatabaseLogId)
                    .HasName("prk_DatabaseLog_DatabaseLogID")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.DatabaseLogId).HasColumnName("DatabaseLogID");

                entity.Property(e => e.DatabaseUser)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Object).HasMaxLength(128);

                entity.Property(e => e.PostTime).HasColumnType("datetime");

                entity.Property(e => e.Schema).HasMaxLength(128);

                entity.Property(e => e.Tsql)
                    .IsRequired()
                    .HasColumnName("TSQL");

                entity.Property(e => e.XmlEvent)
                    .IsRequired()
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<TblInfracaoDaevento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDaevento)
                    .HasName("prkInfracaoDAEvento");

                entity.ToTable("tblInfracaoDAEvento");

                entity.HasIndex(e => new { e.CodigoInfracaoDa, e.Data })
                    .HasName("idxInfracaoDAEvento");

                entity.Property(e => e.CodigoInfracaoDaevento).HasColumnName("CodigoInfracaoDAEvento");

                entity.Property(e => e.CodigoInfracaoDa).HasColumnName("CodigoInfracaoDA");

                entity.Property(e => e.CodigoInfracaoDafase).HasColumnName("CodigoInfracaoDAFase");

                entity.Property(e => e.CodigoInfracaoDasituacao).HasColumnName("CodigoInfracaoDASituacao");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoDaNavigation)
                    .WithMany(p => p.TblInfracaoDaevento)
                    .HasForeignKey(d => d.CodigoInfracaoDa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDAEvento_InfracaoDA");

                entity.HasOne(d => d.CodigoInfracaoDafaseNavigation)
                    .WithMany(p => p.TblInfracaoDaevento)
                    .HasForeignKey(d => d.CodigoInfracaoDafase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDAEvento_InfracaoDAFase");

                entity.HasOne(d => d.CodigoInfracaoDasituacaoNavigation)
                    .WithMany(p => p.TblInfracaoDaevento)
                    .HasForeignKey(d => d.CodigoInfracaoDasituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDAEvento_InfracaoDASituacao");
            });

            modelBuilder.Entity<TblInfracaoDafase>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDafase)
                    .HasName("prkInfracaoDAFase");

                entity.ToTable("tblInfracaoDAFase");

                entity.Property(e => e.CodigoInfracaoDafase)
                    .HasColumnName("CodigoInfracaoDAFase")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoDafundamentacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDafundamentacao)
                    .HasName("prkInfracaoDAFundamentacao");

                entity.ToTable("tblInfracaoDAFundamentacao");

                entity.Property(e => e.CodigoInfracaoDafundamentacao).HasColumnName("CodigoInfracaoDAFundamentacao");

                entity.Property(e => e.Conteudo)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoDafundamentacaoEnquadramento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDafundamentacaoEnquadramento)
                    .HasName("prkInfracaoDAFundamentacaoEnquadramento");

                entity.ToTable("tblInfracaoDAFundamentacaoEnquadramento");

                entity.Property(e => e.CodigoInfracaoDafundamentacaoEnquadramento).HasColumnName("CodigoInfracaoDAFundamentacaoEnquadramento");

                entity.Property(e => e.CodigoInfracaoDafundamentacao).HasColumnName("CodigoInfracaoDAFundamentacao");

                entity.HasOne(d => d.CodigoInfracaoDafundamentacaoNavigation)
                    .WithMany(p => p.TblInfracaoDafundamentacaoEnquadramento)
                    .HasForeignKey(d => d.CodigoInfracaoDafundamentacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDAFundamentacaoEnquadramento_InfracaoDAFundamentacao");

                entity.HasOne(d => d.CodigoInfracaoEnquadramentoNavigation)
                    .WithMany(p => p.TblInfracaoDafundamentacaoEnquadramento)
                    .HasForeignKey(d => d.CodigoInfracaoEnquadramento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDAFundamentacaoEnquadramento_InfracaoEnquadramento");
            });

            modelBuilder.Entity<TblInfracaoDaindicadorAdmissibilidade>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDaindicadorAdmissibilidade)
                    .HasName("prkInfracaoDAIndicadorAdmissibilidade");

                entity.ToTable("tblInfracaoDAIndicadorAdmissibilidade");

                entity.Property(e => e.CodigoInfracaoDaindicadorAdmissibilidade)
                    .HasColumnName("CodigoInfracaoDAIndicadorAdmissibilidade")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoDaindicadorMerito>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDaindicadorMerito)
                    .HasName("prkInfracaoDAIndicadorMerito");

                entity.ToTable("tblInfracaoDAIndicadorMerito");

                entity.Property(e => e.CodigoInfracaoDaindicadorMerito)
                    .HasColumnName("CodigoInfracaoDAIndicadorMerito")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoDaindicadorRecorrente>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDaindicadorRecorrente)
                    .HasName("prkInfracaoDAIndicadorRecorrente");

                entity.ToTable("tblInfracaoDAIndicadorRecorrente");

                entity.Property(e => e.CodigoInfracaoDaindicadorRecorrente)
                    .HasColumnName("CodigoInfracaoDAIndicadorRecorrente")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoDaindicadorResultado>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDaindicadorResultado)
                    .HasName("prkInfracaoDAIndicadorResultado");

                entity.ToTable("tblInfracaoDAIndicadorResultado");

                entity.Property(e => e.CodigoInfracaoDaindicadorResultado)
                    .HasColumnName("CodigoInfracaoDAIndicadorResultado")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoDanaoConhecer>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDanaoConhecer)
                    .HasName("prkInfracaoDANaoConhecer");

                entity.ToTable("tblInfracaoDANaoConhecer");

                entity.Property(e => e.CodigoInfracaoDanaoConhecer).HasColumnName("CodigoInfracaoDANaoConhecer");

                entity.Property(e => e.CodigoInfracaoDa).HasColumnName("CodigoInfracaoDA");

                entity.Property(e => e.CodigoInfracaoDacausaNaoConhecer).HasColumnName("CodigoInfracaoDACausaNaoConhecer");

                entity.HasOne(d => d.CodigoInfracaoDaNavigation)
                    .WithMany(p => p.TblInfracaoDanaoConhecer)
                    .HasForeignKey(d => d.CodigoInfracaoDa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDANaoConhecer_InfracaoDA");

                entity.HasOne(d => d.CodigoInfracaoDacausaNaoConhecerNavigation)
                    .WithMany(p => p.TblInfracaoDanaoConhecer)
                    .HasForeignKey(d => d.CodigoInfracaoDacausaNaoConhecer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDANaoConhecer_InfracaoDACausaNaoConhecer");
            });

            modelBuilder.Entity<TblInfracaoDaorigem>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDaorigem)
                    .HasName("prkInfracaoDAOrigem");

                entity.ToTable("tblInfracaoDAOrigem");

                entity.Property(e => e.CodigoInfracaoDaorigem)
                    .HasColumnName("CodigoInfracaoDAOrigem")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoDasituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDasituacao);

                entity.ToTable("tblInfracaoDASituacao");

                entity.Property(e => e.CodigoInfracaoDasituacao)
                    .HasColumnName("CodigoInfracaoDASituacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoDesvinculacaoMulta>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDesvinculacaoMulta)
                    .HasName("prkInfracaoDesvinculacaoMulta");

                entity.ToTable("tblInfracaoDesvinculacaoMulta");

                entity.HasIndex(e => new { e.CodigoInfracaoDesvinculacaoMultaOrigem, e.NumeroProcesso, e.CodigoInfracao })
                    .HasName("idxInfracaoDesvinculacaoMulta_CodigoInfracao");

                entity.Property(e => e.CodigoRenavammotivoDesvinculacao).HasColumnName("CodigoRENAVAMMotivoDesvinculacao");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataCadastro).HasColumnType("date");

                entity.Property(e => e.DataCancelamento).HasColumnType("date");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.IndicadorRegistroRenainf).HasColumnName("IndicadorRegistroRENAINF");

                entity.Property(e => e.NumeroProcesso)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoDesvinculacaoMulta)
                    .HasForeignKey(d => d.CodigoInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDesvinculacaoMulta_Infracao");

                entity.HasOne(d => d.CodigoInfracaoDesvinculacaoMultaOrigemNavigation)
                    .WithMany(p => p.TblInfracaoDesvinculacaoMulta)
                    .HasForeignKey(d => d.CodigoInfracaoDesvinculacaoMultaOrigem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDesvinculacaoMulta_InfracaoDesvinculacaoMultaOrigem");

                entity.HasOne(d => d.CodigoInfracaoDesvinculacaoMultaSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoDesvinculacaoMulta)
                    .HasForeignKey(d => d.CodigoInfracaoDesvinculacaoMultaSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDesvinculacaoMulta_InfracaoDesvinculacaoMultaSituacao");
            });

            modelBuilder.Entity<TblInfracaoDesvinculacaoMultaArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDesvinculacaoMultaArquivo)
                    .HasName("prkInfracaoDesvinculacaoMultaArquivo");

                entity.ToTable("tblInfracaoDesvinculacaoMultaArquivo");

                entity.HasIndex(e => e.CodigoInfracaoDesvinculacaoMulta)
                    .HasName("idxInfracaoDesvinculacaoMultaArquivo_DesvinculacaoMulta");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacaoCaixa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoDesvinculacaoMultaNavigation)
                    .WithMany(p => p.TblInfracaoDesvinculacaoMultaArquivo)
                    .HasForeignKey(d => d.CodigoInfracaoDesvinculacaoMulta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDesvinculacaoMultaArquivo_InfracaoDesvinculacaoMulta");
            });

            modelBuilder.Entity<TblInfracaoDesvinculacaoMultaEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDesvinculacaoMultaEvento)
                    .HasName("prkInfracaoDesvinculacaoMultaEvento");

                entity.ToTable("tblInfracaoDesvinculacaoMultaEvento");

                entity.HasIndex(e => new { e.CodigoInfracaoDesvinculacaoMulta, e.Data })
                    .HasName("idxInfracaoDesvinculacaoMultaEvento");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoDesvinculacaoMultaNavigation)
                    .WithMany(p => p.TblInfracaoDesvinculacaoMultaEvento)
                    .HasForeignKey(d => d.CodigoInfracaoDesvinculacaoMulta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDesvinculacaoMultaEvento_InfracaoDesvinculacaoMulta");

                entity.HasOne(d => d.CodigoInfracaoDesvinculacaoMultaSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoDesvinculacaoMultaEvento)
                    .HasForeignKey(d => d.CodigoInfracaoDesvinculacaoMultaSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoDesvinculacaoMultaEvento_InfracaoDesvinculacaoMultaSituacao");
            });

            modelBuilder.Entity<TblInfracaoDesvinculacaoMultaOrigem>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDesvinculacaoMultaOrigem);

                entity.ToTable("tblInfracaoDesvinculacaoMultaOrigem");

                entity.Property(e => e.CodigoInfracaoDesvinculacaoMultaOrigem).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoDesvinculacaoMultaSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoDesvinculacaoMultaSituacao)
                    .HasName("prkInfracaoDesvinculacaoMultaSituacao");

                entity.ToTable("tblInfracaoDesvinculacaoMultaSituacao");

                entity.Property(e => e.CodigoInfracaoDesvinculacaoMultaSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoEfeitoSuspensivo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoEfeitoSuspensivo)
                    .HasName("prkInfracaoEfeitoSuspensivo");

                entity.ToTable("tblInfracaoEfeitoSuspensivo");

                entity.HasIndex(e => new { e.CodigoInfracaoEfeitoSuspensivoSituacao, e.CodigoInfracaoEfeitoSuspensivoFase, e.CodigoInfracaoEfeitoSuspensivoTipo, e.NumeroProcesso, e.DataProtocolo, e.DataAnulacao, e.CodigoInfracao })
                    .HasName("idxInfracaoEfeitoSuspensivo_Infracao");

                entity.Property(e => e.DataAnulacao).HasColumnType("date");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataCadastro).HasColumnType("date");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.IndicadorRegistroRenainf).HasColumnName("IndicadorRegistroRENAINF");

                entity.Property(e => e.NumeroProcesso)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoEfeitoSuspensivo)
                    .HasForeignKey(d => d.CodigoInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEfeitoSuspensivo_Infracao");

                entity.HasOne(d => d.CodigoInfracaoEfeitoSuspensivoFaseNavigation)
                    .WithMany(p => p.TblInfracaoEfeitoSuspensivo)
                    .HasForeignKey(d => d.CodigoInfracaoEfeitoSuspensivoFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEfeitoSuspensivo_InfracaoEfeitoSuspensivoFase");

                entity.HasOne(d => d.CodigoInfracaoEfeitoSuspensivoSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoEfeitoSuspensivo)
                    .HasForeignKey(d => d.CodigoInfracaoEfeitoSuspensivoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEfeitoSuspensivo_InfracaoEfeitoSuspensivoSituacao");

                entity.HasOne(d => d.CodigoInfracaoEfeitoSuspensivoTipoNavigation)
                    .WithMany(p => p.TblInfracaoEfeitoSuspensivo)
                    .HasForeignKey(d => d.CodigoInfracaoEfeitoSuspensivoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEfeitoSuspensivo_InfracaoEfeitoSuspensivoTipo");
            });

            modelBuilder.Entity<TblInfracaoEfeitoSuspensivoArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoEfeitoSuspensivoArquivo)
                    .HasName("prkInfracaoEfeitoSuspensivoArquivo");

                entity.ToTable("tblInfracaoEfeitoSuspensivoArquivo");

                entity.HasIndex(e => e.CodigoInfracaoEfeitoSuspensivo)
                    .HasName("idxInfracaoEfeitoSuspensivoArquivo");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacaoCaixa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoEfeitoSuspensivoNavigation)
                    .WithMany(p => p.TblInfracaoEfeitoSuspensivoArquivo)
                    .HasForeignKey(d => d.CodigoInfracaoEfeitoSuspensivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEfeitoSuspensivoArquivo_InfracaoEfeitoSuspensivo");
            });

            modelBuilder.Entity<TblInfracaoEfeitoSuspensivoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoEfeitoSuspensivoEvento)
                    .HasName("prkInfracaoEfeitoSuspensivoEvento");

                entity.ToTable("tblInfracaoEfeitoSuspensivoEvento");

                entity.HasIndex(e => new { e.CodigoInfracaoEfeitoSuspensivo, e.Data })
                    .HasName("idxInfracaoEfeitoSuspensivoEvento");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoEfeitoSuspensivoNavigation)
                    .WithMany(p => p.TblInfracaoEfeitoSuspensivoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoEfeitoSuspensivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEfeitoSuspensivoEvento_InfracaoEfeitoSuspensivo");

                entity.HasOne(d => d.CodigoInfracaoEfeitoSuspensivoFaseNavigation)
                    .WithMany(p => p.TblInfracaoEfeitoSuspensivoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoEfeitoSuspensivoFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEfeitoSuspensivoEvento_InfracaoEfeitoSuspensivoFase");

                entity.HasOne(d => d.CodigoInfracaoEfeitoSuspensivoSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoEfeitoSuspensivoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoEfeitoSuspensivoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEfeitoSuspensivoEvento_InfracaoEfeitoSuspensivoSituacao");
            });

            modelBuilder.Entity<TblInfracaoEfeitoSuspensivoFase>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoEfeitoSuspensivoFase);

                entity.ToTable("tblInfracaoEfeitoSuspensivoFase");

                entity.Property(e => e.CodigoInfracaoEfeitoSuspensivoFase).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoEfeitoSuspensivoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoEfeitoSuspensivoSituacao);

                entity.ToTable("tblInfracaoEfeitoSuspensivoSituacao");

                entity.Property(e => e.CodigoInfracaoEfeitoSuspensivoSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoEfeitoSuspensivoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoEfeitoSuspensivoTipo)
                    .HasName("prkInfracaoEfeitoSuspensivoTipo");

                entity.ToTable("tblInfracaoEfeitoSuspensivoTipo");

                entity.Property(e => e.CodigoInfracaoEfeitoSuspensivoTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoEmbarcador>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoEmbarcador)
                    .HasName("prkInfracaoEmbarcador");

                entity.ToTable("tblInfracaoEmbarcador");

                entity.Property(e => e.CodigoRenavamtipoDocumentoEmbarcadorTransportador).HasColumnName("CodigoRENAVAMTipoDocumentoEmbarcadorTransportador");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCpfcnpj)
                    .IsRequired()
                    .HasColumnName("NumeroCPFCNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCpfcnpjformatado)
                    .IsRequired()
                    .HasColumnName("NumeroCPFCNPJFormatado")
                    .HasMaxLength(18)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoEnquadramento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoEnquadramento)
                    .HasName("prkInfracaoEnquadramento");

                entity.ToTable("tblInfracaoEnquadramento");

                entity.HasIndex(e => new { e.CodigoEnquadramentoTexto, e.DescricaoInfracao, e.CodigoInfracaoEnquadramento })
                    .HasName("idxInfracaoEnquadramento");

                entity.Property(e => e.CodigoInfracaoEnquadramento).ValueGeneratedNever();

                entity.Property(e => e.AmparoLegal)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBaseGrucodigoRecolhimentoTes).HasColumnName("CodigoBaseGRUCodigoRecolhimentoTES");

                entity.Property(e => e.CodigoEnquadramentoTexto)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoInfracaoCtb).HasColumnName("CodigoInfracaoCTB");

                entity.Property(e => e.CodigoInfracaoTextoCtb)
                    .IsRequired()
                    .HasColumnName("CodigoInfracaoTextoCTB")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRenavamunidadeMedida).HasColumnName("CodigoRENAVAMUnidadeMedida");

                entity.Property(e => e.DescricaoInfracao)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DescricaoInfracaoResumo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBaseGrucodigoRecolhimentoTesNavigation)
                    .WithMany(p => p.TblInfracaoEnquadramento)
                    .HasForeignKey(d => d.CodigoBaseGrucodigoRecolhimentoTes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEnquadramento_BaseGRUCodigoRecolhimentoTES");

                entity.HasOne(d => d.CodigoInfracaoEnquadramentoTipoInfracionalNavigation)
                    .WithMany(p => p.TblInfracaoEnquadramento)
                    .HasForeignKey(d => d.CodigoInfracaoEnquadramentoTipoInfracional)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEnquadramento_InfracaoEnquadramentoTipoInfracional");

                entity.HasOne(d => d.CodigoInfracaoIndicadorResponsavelNavigation)
                    .WithMany(p => p.TblInfracaoEnquadramento)
                    .HasForeignKey(d => d.CodigoInfracaoIndicadorResponsavel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEnquadramento_InfracaoIndicadorResponsavel");

                entity.HasOne(d => d.CodigoInfracaoNumeroAutoPrefixoNavigation)
                    .WithMany(p => p.TblInfracaoEnquadramento)
                    .HasForeignKey(d => d.CodigoInfracaoNumeroAutoPrefixo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEnquadramento_InfracaoNumeroAutoPrefixo");
            });

            modelBuilder.Entity<TblInfracaoEnquadramentoCalculoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoEnquadramentoCalculoTipo)
                    .HasName("prkInfracaoEnquadramentoCalculoTipo");

                entity.ToTable("tblInfracaoEnquadramentoCalculoTipo");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeProcedimento)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoEnquadramentoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoEnquadramentoEvento)
                    .HasName("prkInfracaoEnquadramentoEvento");

                entity.ToTable("tblInfracaoEnquadramentoEvento");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Identificacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoEnquadramentoNavigation)
                    .WithMany(p => p.TblInfracaoEnquadramentoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoEnquadramento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEnquadramentoEvento_InfracaoEnquadramento");
            });

            modelBuilder.Entity<TblInfracaoEnquadramentoTipoInfracional>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoEnquadramentoTipoInfracional)
                    .HasName("prkInfracaoEnquadramentoTipoInfracional");

                entity.ToTable("tblInfracaoEnquadramentoTipoInfracional");

                entity.Property(e => e.CodigoInfracaoEnquadramentoTipoInfracional).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoEnquadramentoValor>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoEnquadramentoValor)
                    .HasName("prkInfracaoEnquadramentoValor");

                entity.ToTable("tblInfracaoEnquadramentoValor");

                entity.Property(e => e.DataFim).HasColumnType("date");

                entity.Property(e => e.DataInicio).HasColumnType("date");

                entity.Property(e => e.ValorOriginal).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal60Porcento).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal80Porcento).HasColumnType("decimal(7, 2)");

                entity.HasOne(d => d.CodigoInfracaoEnquadramentoNavigation)
                    .WithMany(p => p.TblInfracaoEnquadramentoValor)
                    .HasForeignKey(d => d.CodigoInfracaoEnquadramento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEnquadramentoValor_InfracaoEnquadramento");

                entity.HasOne(d => d.CodigoInfracaoGravidadeNavigation)
                    .WithMany(p => p.TblInfracaoEnquadramentoValor)
                    .HasForeignKey(d => d.CodigoInfracaoGravidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEnquadramentoValor_InfracaoGravidade");
            });

            modelBuilder.Entity<TblInfracaoEnquadramentoVelocidade>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoEnquadramentoVelocidade)
                    .HasName("prkInfracaoEnquadramentoVelocidade");

                entity.ToTable("tblInfracaoEnquadramentoVelocidade");

                entity.Property(e => e.CodigoInfracaoEnquadramentoVelocidade).ValueGeneratedNever();

                entity.HasOne(d => d.CodigoInfracaoEnquadramentoNavigation)
                    .WithMany(p => p.TblInfracaoEnquadramentoVelocidade)
                    .HasForeignKey(d => d.CodigoInfracaoEnquadramento)
                    .HasConstraintName("frkInfracaoEnquadramentoVelocidade_InfracaoEnquadramento");
            });

            modelBuilder.Entity<TblInfracaoEquipamentoAfericaoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoEquipamentoAfericaoTipo)
                    .HasName("prkInfracaoEquipamentoAfericaoTipo");

                entity.ToTable("tblInfracaoEquipamentoAfericaoTipo");

                entity.Property(e => e.CodigoInfracaoEquipamentoAfericaoTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoEvento)
                    .HasName("prkInfracaoEvento");

                entity.ToTable("tblInfracaoEvento");

                entity.HasIndex(e => new { e.CodigoInfracao, e.Data })
                    .HasName("idxInfracaoEvento_CodigoInfracao");

                entity.Property(e => e.CodigoIcompoolEnvioTransacao).HasColumnName("CodigoICOMPoolEnvioTransacao");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoEvento)
                    .HasForeignKey(d => d.CodigoInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEvento_Infracao");

                entity.HasOne(d => d.CodigoInfracaoFaseNavigation)
                    .WithMany(p => p.TblInfracaoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEvento_InfracaoFase");

                entity.HasOne(d => d.CodigoInfracaoSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEvento_InfracaoSituacao");
            });

            modelBuilder.Entity<TblInfracaoFase>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFase)
                    .HasName("prkInfracaoFase");

                entity.ToTable("tblInfracaoFase");

                entity.Property(e => e.CodigoInfracaoFase).ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoFaseGrupoNavigation)
                    .WithMany(p => p.TblInfracaoFase)
                    .HasForeignKey(d => d.CodigoInfracaoFaseGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFase_InfracaoFaseGrupo");
            });

            modelBuilder.Entity<TblInfracaoFaseGrupo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFaseGrupo)
                    .HasName("prkInfracaoFaseGrupo");

                entity.ToTable("tblInfracaoFaseGrupo");

                entity.Property(e => e.CodigoInfracaoFaseGrupo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoFinanceiroArquivoCobrancaRemessa>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroArquivoCobrancaRemessa)
                    .HasName("prkInfracaoFinanceiroArquivoCobrancaRemessa");

                entity.ToTable("tblInfracaoFinanceiroArquivoCobrancaRemessa");

                entity.Property(e => e.ArquivoNome)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoNomeFisico)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BancoAgenciaDigitoVerificador)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BancoAgenciaMantenedora)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BancoContaCorrenteDigitoVerificador)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BancoContaCorrenteNumero)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRecolhimentoTes)
                    .IsRequired()
                    .HasColumnName("CodigoRecolhimentoTES")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataEnvio).HasColumnType("date");

                entity.Property(e => e.DescricaoCodigoRecolhimentoTes)
                    .HasColumnName("DescricaoCodigoRecolhimentoTES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCarteira)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCarteiraVariacao)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroContrato)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroConvenio)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao).IsUnicode(false);

                entity.Property(e => e.UsuarioEnvio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRemessaSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroArquivoCobrancaRemessa)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRemessaSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroArquivoCobrancaRemessa_InfracaoFinanceiroArquivoCobrancaRemessaSituacao");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRemessaTipoEnvioNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroArquivoCobrancaRemessa)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRemessaTipoEnvio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroArquivoCobrancaRemessa_InfracaoFinanceiroArquivoCobrancaRemessaTipoEnvio");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroArquivoCobrancaRemessaSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroArquivoCobrancaRemessaSituacao)
                    .HasName("prkInfracaoFinanceiroArquivoCobrancaRemessaSituacao");

                entity.ToTable("tblInfracaoFinanceiroArquivoCobrancaRemessaSituacao");

                entity.Property(e => e.CodigoInfracaoFinanceiroArquivoCobrancaRemessaSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoFinanceiroArquivoCobrancaRemessaTipoEnvio>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroArquivoCobrancaRemessaTipoEnvio)
                    .HasName("prkInfracaoFinanceiroArquivoCobrancaRemessaTipoEnvio");

                entity.ToTable("tblInfracaoFinanceiroArquivoCobrancaRemessaTipoEnvio");

                entity.Property(e => e.CodigoInfracaoFinanceiroArquivoCobrancaRemessaTipoEnvio).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroArquivoCobrancaRemessaTitulo)
                    .HasName("prkInfracaoFinanceiroArquivoCobrancaRemessaTitulo");

                entity.ToTable("tblInfracaoFinanceiroArquivoCobrancaRemessaTitulo");

                entity.HasIndex(e => e.CodigoInfracaoFinanceiroArquivoCobrancaRemessa)
                    .HasName("idxInfracaoFinanceiroArquivoCobrancaRemessaTitulo_Remessa");

                entity.HasIndex(e => new { e.CodigoInfracaoFinanceiroArquivoCobrancaRemessaTitulo, e.CodigoBaseFebrabanMovimentoRemessa, e.CodigoInfracaoFinanceiroGru, e.CodigoRecolhimentoTes, e.CodigoInfracaoFinanceiroArquivoCobrancaRemessaTituloSituacao, e.CodigoInfracaoFinanceiroArquivoCobrancaRemessa })
                    .HasName("idxInfracaoFinanceiroArquivoCobrancaRemessaTitulo_RemessaGerar");

                entity.Property(e => e.BancoAgenciaDigitoVerificador)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BancoAgenciaMantenedora)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BancoContaCorrenteDigitoVerificador)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BancoContaCorrenteNumero)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoInfracaoFinanceiroGru).HasColumnName("CodigoInfracaoFinanceiroGRU");

                entity.Property(e => e.CodigoRecolhimentoTes)
                    .IsRequired()
                    .HasColumnName("CodigoRecolhimentoTES")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataEmissao).HasColumnType("date");

                entity.Property(e => e.DataVencimento).HasColumnType("date");

                entity.Property(e => e.DescricaoCodigoRecolhimentoTes)
                    .HasColumnName("DescricaoCodigoRecolhimentoTES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NossoNumero)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAuto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCarteira)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCarteiraVariacao)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroContrato)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroConvenio)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao).IsUnicode(false);

                entity.Property(e => e.PagadorBairro)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorCep)
                    .IsRequired()
                    .HasColumnName("PagadorCEP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorCidade)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEndereco)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorNome)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorNumeroInscricao)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorUf)
                    .HasColumnName("PagadorUF")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ValorAbatimento).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ValorDesconto).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ValorNominalTitulo).HasColumnType("decimal(15, 2)");

                entity.HasOne(d => d.CodigoBaseFebrabanMovimentoRemessaNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo)
                    .HasForeignKey(d => d.CodigoBaseFebrabanMovimentoRemessa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroArquivoCobrancaRemessaTitulo_BaseFebrabanMovimentoRemessa");

                entity.HasOne(d => d.CodigoInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo)
                    .HasForeignKey(d => d.CodigoInfracao)
                    .HasConstraintName("frkInfracaoFinanceiroArquivoCobrancaRemessaTitulo_Infracao");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRemessaNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRemessa)
                    .HasConstraintName("frkInfracaoFinanceiroArquivoCobrancaRemessaTitulo_InfracaoFinanceiroArquivoCobrancaRemessa");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRemessaTituloSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRemessaTituloSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroArquivoCobrancaRemessaTitulo_InfracaoFinanceiroArquivoCobrancaRemessaTituloSituacao");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroGruNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroGru)
                    .HasConstraintName("frkInfracaoFinanceiroArquivoCobrancaRemessaTitulo_InfracaoFinanceiroGRU");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoExpedicaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoExpedicao)
                    .HasConstraintName("frkInfracaoFinanceiroArquivoCobrancaRemessaTitulo_InfracaoNotificacaoExpedicao");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroArquivoCobrancaRemessaTituloSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroArquivoCobrancaRemessaTituloSituacao)
                    .HasName("prkInfracaoFinanceiroArquivoCobrancaRemessaTituloSituacao");

                entity.ToTable("tblInfracaoFinanceiroArquivoCobrancaRemessaTituloSituacao");

                entity.Property(e => e.CodigoInfracaoFinanceiroArquivoCobrancaRemessaTituloSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoFinanceiroArquivoCobrancaRetorno>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroArquivoCobrancaRetorno)
                    .HasName("prkInfracaoFinanceiroArquivoCobrancaRetorno");

                entity.ToTable("tblInfracaoFinanceiroArquivoCobrancaRetorno");

                entity.HasIndex(e => new { e.CodigoInfracaoFinanceiroArquivoCobrancaRetorno, e.CodigoInfracaoFinanceiroArquivoCobrancaRetornoSituacao })
                    .HasName("idxInfracaoFinanceiroArquivoCobrancaRetorno_Processamento");

                entity.Property(e => e.ArquivoNome)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoNomeFisico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRecolhimentoTes)
                    .HasColumnName("CodigoRecolhimentoTES")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataAnalise).HasColumnType("datetime");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataHoraGeracao).HasColumnType("datetime");

                entity.Property(e => e.DataProcessamento).HasColumnType("datetime");

                entity.Property(e => e.HeaderNumeroSequencial)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroContrato)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroConvenio)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao).IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRetornoSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroArquivoCobrancaRetorno)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRetornoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroArquivoCobrancaRetorno_InfracaoFinanceiroArquivoCobrancaRetornoSituacao");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroArquivoCobrancaRetornoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroArquivoCobrancaRetornoSituacao)
                    .HasName("prkInfracaoFinanceiroArquivoCobrancaRetornoSituacao");

                entity.ToTable("tblInfracaoFinanceiroArquivoCobrancaRetornoSituacao");

                entity.Property(e => e.CodigoInfracaoFinanceiroArquivoCobrancaRetornoSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroArquivoCobrancaRetornoTitulo)
                    .HasName("prkInfracaoFinanceiroArquivoCobrancaRetornoTitulo");

                entity.ToTable("tblInfracaoFinanceiroArquivoCobrancaRetornoTitulo");

                entity.HasIndex(e => new { e.CodigoInfracaoFinanceiroArquivoCobrancaRetorno, e.NumeroLinhaRegistroDetalhe })
                    .HasName("idxInfracaoFinanceiroArquivoCobrancaRetornoTitulo_Identificacao");

                entity.HasIndex(e => new { e.CodigoInfracaoFinanceiroArquivoCobrancaRetorno, e.NumeroLinhaRegistroDetalhe, e.CodigoInfracaoFinanceiroGru })
                    .HasName("idxInfracaoFinanceiroArquivoCobrancaRetornoTitulo_ConsultaDetalhe");

                entity.Property(e => e.CodigoAgenciaPagamento)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBancoPagamento)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoInfracaoFinanceiroGru).HasColumnName("CodigoInfracaoFinanceiroGRU");

                entity.Property(e => e.DataCredito).HasColumnType("date");

                entity.Property(e => e.DataOcorrencia).HasColumnType("date");

                entity.Property(e => e.DigitoVerificadorAgenciaPagamento)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificacaoTituloEmpresa)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoOcorrencia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NossoNumero)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumentoCobranca)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao).IsUnicode(false);

                entity.Property(e => e.ValorAbatimento).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ValorAcrescimo).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ValorDesconto).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ValorLiquido).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ValorOutrasDespesas).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ValorOutrosCreditos).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ValorPago).HasColumnType("decimal(15, 2)");

                entity.HasOne(d => d.CodigoBaseFebrabanMovimentoRetornoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo)
                    .HasForeignKey(d => d.CodigoBaseFebrabanMovimentoRetorno)
                    .HasConstraintName("frkInfracaoFinanceiroArquivoCobrancaRetornoTitulo_BaseFebrabanMovimentoRetorno");

                entity.HasOne(d => d.CodigoInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo)
                    .HasForeignKey(d => d.CodigoInfracao)
                    .HasConstraintName("frkInfracaoFinanceiroArquivoCobrancaRetornoTitulo_Infracao");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRetornoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRetorno)
                    .HasConstraintName("frkInfracaoFinanceiroArquivoCobrancaRetornoTitulo_InfracaoFinanceiroArquivoCobrancaRetorno");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRetornoTituloSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRetornoTituloSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroArquivoCobrancaRetornoTitulo_InfracaoFinanceiroArquivoCobrancaRetornoTituloSituacao");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroGruNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroGru)
                    .HasConstraintName("frkInfracaoFinanceiroArquivoCobrancaRetornoTitulo_InfracaoFinanceiroGRU");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroArquivoCobrancaRetornoTituloSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroArquivoCobrancaRetornoTituloSituacao)
                    .HasName("prkInfracaoFinanceiroArquivoCobrancaRetornoTituloSituacao");

                entity.ToTable("tblInfracaoFinanceiroArquivoCobrancaRetornoTituloSituacao");

                entity.Property(e => e.CodigoInfracaoFinanceiroArquivoCobrancaRetornoTituloSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoFinanceiroDebito>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroDebito)
                    .HasName("prkInfracaoFinanceiroDebito");

                entity.ToTable("tblInfracaoFinanceiroDebito");

                entity.HasIndex(e => e.NumeroAit)
                    .HasName("idxInfracaoFinanceiroDebito_NumeroAIT")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodigoInfracaoFinanceiroDebito, e.CodigoInfracaoFinanceiroDebitoSituacao })
                    .HasName("idxInfracaoFinanceiroDebito_Situacao");

                entity.Property(e => e.CodigoInfracaoFinanceiroDebito).ValueGeneratedNever();

                entity.Property(e => e.CodigoInfracaoCtb)
                    .IsRequired()
                    .HasColumnName("CodigoInfracaoCTB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoInfracaoFinanceiroGru).HasColumnName("CodigoInfracaoFinanceiroGRU");

                entity.Property(e => e.CodigoInfracaoFinanceiroGrunp).HasColumnName("CodigoInfracaoFinanceiroGRUNP");

                entity.Property(e => e.CodigoInfracaoFinanceiroGrunptipoValor).HasColumnName("CodigoInfracaoFinanceiroGRUNPTipoValor");

                entity.Property(e => e.CodigoInfracaoFinanceiroGrutipoValor).HasColumnName("CodigoInfracaoFinanceiroGRUTipoValor");

                entity.Property(e => e.CorrecaoMultaDataInicioControle).HasColumnType("date");

                entity.Property(e => e.CorrecaoMultaFatorMultiplicador).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CorrecaoMultaPeriodoReferencia).HasColumnType("date");

                entity.Property(e => e.CorrecaoMultaValorCorrigido).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CorrecaoMultaVigenciaDataInicio).HasColumnType("date");

                entity.Property(e => e.CorrecaoMultaVigenciaDataTermino).HasColumnType("date");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataConstituicaoDefinitivaCredito).HasColumnType("date");

                entity.Property(e => e.DataInfracao).HasColumnType("date");

                entity.Property(e => e.DataVencimentoNp)
                    .HasColumnName("DataVencimentoNP")
                    .HasColumnType("date");

                entity.Property(e => e.DevedorBairro)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DevedorCep)
                    .HasColumnName("DevedorCEP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DevedorCidade)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DevedorComplemento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DevedorLogradouro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DevedorNome)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DevedorNumeroImovel)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DevedorNumeroInscricao)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.DevedorUf)
                    .HasColumnName("DevedorUF")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAit)
                    .IsRequired()
                    .HasColumnName("NumeroAIT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SequencialGru).HasColumnName("SequencialGRU");

                entity.Property(e => e.ValorOriginal).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal60Porcento).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal80Porcento).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorPago).HasColumnType("decimal(15, 2)");

                entity.HasOne(d => d.CodigoInfracaoEnquadramentoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroDebito)
                    .HasForeignKey(d => d.CodigoInfracaoEnquadramento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroDebito_InfracaoEnquadramento");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroDebitoNavigation)
                    .WithOne(p => p.TblInfracaoFinanceiroDebito)
                    .HasForeignKey<TblInfracaoFinanceiroDebito>(d => d.CodigoInfracaoFinanceiroDebito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroDebito_Infracao");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroDebitoSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroDebito)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroDebitoSituacao)
                    .HasConstraintName("frkInfracaoFinanceiroDebito_InfracaoFinanceiroDebitoSituacao");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroGruNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGruNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroGru)
                    .HasConstraintName("frkInfracaoFinanceiroDebito_InfracaoFinanceiroGRU");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroGrunpNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrunpNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroGrunp)
                    .HasConstraintName("frkInfracaoFinanceiroDebito_InfracaoFinanceiroGRUNP");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroGrunptipoValorNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrunptipoValorNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroGrunptipoValor)
                    .HasConstraintName("frkInfracaoFinanceiroDebito_InfracaoFinanceiroGRUNPTipoValor");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroGrutipoValorNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroDebitoCodigoInfracaoFinanceiroGrutipoValorNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroGrutipoValor)
                    .HasConstraintName("frkInfracaoFinanceiroDebito_InfracaoFinanceiroGRUTipoValor");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroDebitoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroDebitoEvento)
                    .HasName("prkInfracaoFinanceiroDebitoEvento");

                entity.ToTable("tblInfracaoFinanceiroDebitoEvento");

                entity.HasIndex(e => new { e.CodigoInfracaoFinanceiroDebito, e.Data })
                    .HasName("idxInfracaoFinanceiroDebitoEvento");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoFinanceiroDebitoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroDebitoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroDebito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroDebitoEvento_InfracaoFinanceiroDebito");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroDebitoSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroDebitoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroDebitoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroDebitoEvento_InfracaoFinanceiroDebitoSituacao");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroDebitoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroDebitoSituacao)
                    .HasName("prkFinanceiroDebitoControleSituacao");

                entity.ToTable("tblInfracaoFinanceiroDebitoSituacao");

                entity.Property(e => e.CodigoInfracaoFinanceiroDebitoSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoFinanceiroDetran>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroDetran)
                    .HasName("prkInfracaoFinanceiroDETRAN");

                entity.ToTable("tblInfracaoFinanceiroDETRAN");

                entity.Property(e => e.CodigoInfracaoFinanceiroDetran)
                    .HasColumnName("CodigoInfracaoFinanceiroDETRAN")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodigoBaseGrucodigoRecolhimentoTes).HasColumnName("CodigoBaseGRUCodigoRecolhimentoTES");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCnpj)
                    .IsRequired()
                    .HasColumnName("NumeroCNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.SiglaUf)
                    .IsRequired()
                    .HasColumnName("SiglaUF")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBaseGrucodigoRecolhimentoTesNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroDetran)
                    .HasForeignKey(d => d.CodigoBaseGrucodigoRecolhimentoTes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroDETRAN_BaseGRUCodigoRecolhimentoTES");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroGru>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroGru)
                    .HasName("prkInfracaoFinanceiroGRU");

                entity.ToTable("tblInfracaoFinanceiroGRU");

                entity.HasIndex(e => e.CodigoInfracao)
                    .HasName("idxlInfracaoFinanceiroGRU_Infracao");

                entity.HasIndex(e => e.NossoNumero)
                    .HasName("idxInfracaoFinanceiroGRU_NossoNumero")
                    .IsUnique();

                entity.Property(e => e.CodigoInfracaoFinanceiroGru).HasColumnName("CodigoInfracaoFinanceiroGRU");

                entity.Property(e => e.AgenciaBanco)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Carteira)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBanco)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBarras)
                    .HasMaxLength(44)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoInfracaoFinanceiroGrucadastroTituloBanco).HasColumnName("CodigoInfracaoFinanceiroGRUCadastroTituloBanco");

                entity.Property(e => e.CodigoInfracaoFinanceiroGrusituacao).HasColumnName("CodigoInfracaoFinanceiroGRUSituacao");

                entity.Property(e => e.CodigoInfracaoFinanceiroGrutipoValor).HasColumnName("CodigoInfracaoFinanceiroGRUTipoValor");

                entity.Property(e => e.DataDocumento).HasColumnType("date");

                entity.Property(e => e.DataProcessamento).HasColumnType("date");

                entity.Property(e => e.DataVencimento).HasColumnType("date");

                entity.Property(e => e.EspecieDocumento)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Instrucao)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LinhaDigitavel)
                    .HasMaxLength(47)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoOcorrencia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NossoNumero)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroComercioEletronico)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroConta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroConvenio)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorBairro)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorCep)
                    .HasColumnName("PagadorCEP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorCidade)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEndereco)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorNome)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorNumeroInscricao)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorUf)
                    .HasColumnName("PagadorUF")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ValorDocumento).HasColumnType("decimal(7, 2)");

                entity.HasOne(d => d.CodigoBaseFebrabanMovimentoRemessaNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroGru)
                    .HasForeignKey(d => d.CodigoBaseFebrabanMovimentoRemessa)
                    .HasConstraintName("frkInfracaoFinanceiroGRU_BaseFebrabanMovimentoRemessa");

                entity.HasOne(d => d.CodigoBaseFebrabanMovimentoRetornoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroGru)
                    .HasForeignKey(d => d.CodigoBaseFebrabanMovimentoRetorno)
                    .HasConstraintName("frkInfracaoFinanceiroGRU_BaseFebrabanMovimentoRetorno");

                entity.HasOne(d => d.CodigoInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroGru)
                    .HasForeignKey(d => d.CodigoInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroGRU_Infracao");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRemessaNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroGru)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRemessa)
                    .HasConstraintName("frkInfracaoFinanceiroGRU_InfracaoFinanceiroArquivoCobrancaRemessa");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRetornoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroGru)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRetorno)
                    .HasConstraintName("frkInfracaoFinanceiroGRU_InfracaoFinanceiroArquivoCobrancaRetorno");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroGrucadastroTituloBancoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroGru)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroGrucadastroTituloBanco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroGRU_InfracaoFinanceiroGRUCadastroTituloBanco");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroGrusituacaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroGru)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroGrusituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroGRU_InfracaoFinanceiroGRUSituacao");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroGrutipoValorNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroGru)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroGrutipoValor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroGRU_InfracaoFinanceiroGRUTipoValor");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroGrucadastroTituloBanco>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroGrucadastroTituloBanco)
                    .HasName("prkInfracaoFinanceiroGRUCadastroTituloBanco");

                entity.ToTable("tblInfracaoFinanceiroGRUCadastroTituloBanco");

                entity.Property(e => e.CodigoInfracaoFinanceiroGrucadastroTituloBanco)
                    .HasColumnName("CodigoInfracaoFinanceiroGRUCadastroTituloBanco")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoFinanceiroGrusituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroGrusituacao)
                    .HasName("prkInfracaoFinanceiroGRUSituacao");

                entity.ToTable("tblInfracaoFinanceiroGRUSituacao");

                entity.Property(e => e.CodigoInfracaoFinanceiroGrusituacao)
                    .HasColumnName("CodigoInfracaoFinanceiroGRUSituacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoFinanceiroGrutipoRegistro>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroGrutipoRegistro)
                    .HasName("prkInfracaoFinanceiroGRUTipoRegistro");

                entity.ToTable("tblInfracaoFinanceiroGRUTipoRegistro");

                entity.Property(e => e.CodigoInfracaoFinanceiroGrutipoRegistro)
                    .HasColumnName("CodigoInfracaoFinanceiroGRUTipoRegistro")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoFinanceiroGrutipoValor>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroGrutipoValor)
                    .HasName("prkInfracaoFinanceiroGRUTipoValor");

                entity.ToTable("tblInfracaoFinanceiroGRUTipoValor");

                entity.Property(e => e.CodigoInfracaoFinanceiroGrutipoValor)
                    .HasColumnName("CodigoInfracaoFinanceiroGRUTipoValor")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoFinanceiroPagamento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroPagamento)
                    .HasName("prkInfracaoFinanceiroPagamento");

                entity.ToTable("tblInfracaoFinanceiroPagamento");

                entity.HasIndex(e => e.IndicadorRegistroRenainf)
                    .HasName("idxInfracaoFinanceiroPagamento_IndicadorRegistroRENAINF");

                entity.HasIndex(e => new { e.CodigoInfracaoFinanceiroPagamento, e.ValorPago, e.DataPagamento })
                    .HasName("idxInfracaoFinanceiroPagamento_DataPagamento");

                entity.HasIndex(e => new { e.DataPagamento, e.ValorPago, e.CodigoInfracao })
                    .HasName("idxInfracaoFinanceiroPagamento_CodigoInfracao");

                entity.Property(e => e.CodigoAgenciaPagamento)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBancoPagamento)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoInfracaoCtb).HasColumnName("CodigoInfracaoCTB");

                entity.Property(e => e.CodigoRenainf)
                    .HasColumnName("CodigoRENAINF")
                    .HasColumnType("decimal(11, 0)");

                entity.Property(e => e.DataCancelamento).HasColumnType("date");

                entity.Property(e => e.DataPagamento).HasColumnType("date");

                entity.Property(e => e.DataProcessamento).HasColumnType("datetime");

                entity.Property(e => e.DigitoVerificadorAgenciaPagamento)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndicadorRegistroRenainf).HasColumnName("IndicadorRegistroRENAINF");

                entity.Property(e => e.NomeUsuarioCancelamento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAit)
                    .HasColumnName("NumeroAIT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ValorPago).HasColumnType("decimal(15, 2)");

                entity.HasOne(d => d.CodigoInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroPagamento)
                    .HasForeignKey(d => d.CodigoInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroPagamento_Infracao");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroPagamentoTipoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroPagamento)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroPagamentoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroPagamento_InfracaoFinanceiroPagamentoTipo");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroPagamentoBaixaManual>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroPagamentoBaixaManual)
                    .HasName("prkInfracaoFinanceiroPagamentoBaixaManual");

                entity.ToTable("tblInfracaoFinanceiroPagamentoBaixaManual");

                entity.Property(e => e.CodigoInfracaoFinanceiroPagamentoBaixaManual).ValueGeneratedNever();

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataCadastro).HasColumnType("date");

                entity.Property(e => e.DataCancelamento).HasColumnType("date");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.NumeroDocumentoArrecadacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroProcesso)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RenainfValorPago).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoInfracaoFinanceiroPagamentoBaixaManualNavigation)
                    .WithOne(p => p.TblInfracaoFinanceiroPagamentoBaixaManual)
                    .HasForeignKey<TblInfracaoFinanceiroPagamentoBaixaManual>(d => d.CodigoInfracaoFinanceiroPagamentoBaixaManual)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroPagamentoBaixaManual_InfracaoFinanceiroPagamento");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroPagamentoBaixaManualSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroPagamentoBaixaManual)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroPagamentoBaixaManualSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroPagamentoBaixaManual_InfracaoFinanceiroPagamentoBaixaManualSituacao");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroPagamentoBaixaManualArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroPagamentoBaixaManualArquivo)
                    .HasName("prkInfracaoFinanceiroPagamentoBaixaManualArquivo");

                entity.ToTable("tblInfracaoFinanceiroPagamentoBaixaManualArquivo");

                entity.HasIndex(e => e.CodigoInfracaoFinanceiroPagamentoBaixaManual)
                    .HasName("idxInfracaoFinanceiroPagamentoBaixaManualArquivo");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoFinanceiroPagamentoBaixaManualNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroPagamentoBaixaManualArquivo)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroPagamentoBaixaManual)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroPagamentoBaixaManualArquivo_InfracaoFinanceiroPagamentoBaixaManual");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroPagamentoBaixaManualEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroPagamentoBaixaManualEvento)
                    .HasName("prkInfracaoFinanceiroPagamentoBaixaManualEvento");

                entity.ToTable("tblInfracaoFinanceiroPagamentoBaixaManualEvento");

                entity.HasIndex(e => new { e.CodigoInfracaoFinanceiroPagamentoBaixaManual, e.Data })
                    .HasName("idxInfracaoFinanceiroPagamentoBaixaManualEvento");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoFinanceiroPagamentoBaixaManualNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroPagamentoBaixaManualEvento)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroPagamentoBaixaManual)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroPagamentoBaixaManualEvento_InfracaoFinanceiroPagamentoBaixaManual");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroPagamentoBaixaManualSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroPagamentoBaixaManualEvento)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroPagamentoBaixaManualSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroPagamentoBaixaManualEvento_InfracaoFinanceiroPagamentoBaixaManualSituacao");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroPagamentoBaixaManualSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroPagamentoBaixaManualSituacao);

                entity.ToTable("tblInfracaoFinanceiroPagamentoBaixaManualSituacao");

                entity.Property(e => e.CodigoInfracaoFinanceiroPagamentoBaixaManualSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoFinanceiroPagamentoDetran>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroPagamentoDetran)
                    .HasName("prkInfracaoFinanceiroPagamentoDETRAN");

                entity.ToTable("tblInfracaoFinanceiroPagamentoDETRAN");

                entity.HasIndex(e => new { e.CodigoInfracaoFinanceiroPagamentoDetran, e.Ufpagamento, e.ValorFunset, e.ValorDenatran, e.ValorDetran, e.ValorOrgaoAutuador, e.CodigoInfracaoFinanceiroDetran, e.CodigoInfracaoFinanceiroRepasseDetran })
                    .HasName("idxInfracaoFinanceiroPagamentoDETRAN");

                entity.Property(e => e.CodigoInfracaoFinanceiroPagamentoDetran)
                    .HasColumnName("CodigoInfracaoFinanceiroPagamentoDETRAN")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodigoInfracaoFinanceiroDetran).HasColumnName("CodigoInfracaoFinanceiroDETRAN");

                entity.Property(e => e.CodigoInfracaoFinanceiroRepasseDetran).HasColumnName("CodigoInfracaoFinanceiroRepasseDETRAN");

                entity.Property(e => e.DataCreditoOrgaoAutuador).HasColumnType("date");

                entity.Property(e => e.NumeroAutenticacao)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumentoArrecadacao)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroTerminalFinanceiro)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Ufpagamento)
                    .IsRequired()
                    .HasColumnName("UFPagamento")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ValorDenatran)
                    .HasColumnName("ValorDENATRAN")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorDetran)
                    .HasColumnName("ValorDETRAN")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorFunset)
                    .HasColumnName("ValorFUNSET")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOrgaoAutuador).HasColumnType("decimal(7, 2)");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroDetranNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroPagamentoDetran)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroDetran)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroPagamentoDETRAN_InfracaoFinanceiroDETRAN");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroPagamentoDetranNavigation)
                    .WithOne(p => p.TblInfracaoFinanceiroPagamentoDetran)
                    .HasForeignKey<TblInfracaoFinanceiroPagamentoDetran>(d => d.CodigoInfracaoFinanceiroPagamentoDetran)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroPagamentoDETRAN_CodigoInfracaoFinanceiroPagamento");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroRepasseDetranNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroPagamentoDetran)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroRepasseDetran)
                    .HasConstraintName("frkInfracaoFinanceiroPagamentoDETRAN_InfracaoFinanceiroRepasseDETRAN");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroPagamentoGru>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroPagamentoGru)
                    .HasName("prkInfracaoFinanceiroPagamentoGRU");

                entity.ToTable("tblInfracaoFinanceiroPagamentoGRU");

                entity.Property(e => e.CodigoInfracaoFinanceiroPagamentoGru)
                    .HasColumnName("CodigoInfracaoFinanceiroPagamentoGRU")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodigoInfracaoFinanceiroGru).HasColumnName("CodigoInfracaoFinanceiroGRU");

                entity.Property(e => e.DataCredito).HasColumnType("date");

                entity.Property(e => e.RenainfValorPago).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ValorAbatimento).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ValorAcrescimo).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ValorDesconto).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ValorLiquido).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ValorOutrasDespesas).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ValorOutrosCreditos).HasColumnType("decimal(15, 2)");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRetornoTituloNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroPagamentoGru)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroArquivoCobrancaRetornoTitulo)
                    .HasConstraintName("frkInfracaoFinanceiroPagamentoGRU_InfracaoFinanceiroArquivoCobrancaRetornoTitulo");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroGruNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroPagamentoGru)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroGru)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroPagamentoGRU_InfracaoFinanceiroGRU");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroPagamentoGruNavigation)
                    .WithOne(p => p.TblInfracaoFinanceiroPagamentoGru)
                    .HasForeignKey<TblInfracaoFinanceiroPagamentoGru>(d => d.CodigoInfracaoFinanceiroPagamentoGru)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroPagamentoGRU_InfracaoFinanceiroPagamentoGRU");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroPagamentoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroPagamentoTipo)
                    .HasName("prkInfracaoFinanceiroPagamentoTipo");

                entity.ToTable("tblInfracaoFinanceiroPagamentoTipo");

                entity.Property(e => e.CodigoInfracaoFinanceiroPagamentoTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoFinanceiroRepasseDetran>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroRepasseDetran)
                    .HasName("prkInfracaoFinanceiroRepasseDETRAN");

                entity.ToTable("tblInfracaoFinanceiroRepasseDETRAN");

                entity.HasIndex(e => new { e.CodigoInfracaoFinanceiroDetran, e.IdentificacaoRepasse })
                    .HasName("idxInfracaoFinanceiroRepasseDETRAN_DETRAN");

                entity.Property(e => e.CodigoInfracaoFinanceiroRepasseDetran).HasColumnName("CodigoInfracaoFinanceiroRepasseDETRAN");

                entity.Property(e => e.Arquivo1CancelamentoDataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Arquivo1CancelamentoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Arquivo1CancelamentoNomeFisico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Arquivo1DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Arquivo1Nome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Arquivo1NomeFisico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Arquivo2CancelamentoCodigoRetornoExecucaoGru)
                    .HasColumnName("Arquivo2CancelamentoCodigoRetornoExecucaoGRU")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Arquivo2CancelamentoCodigoRetornoExecucaoHeader)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Arquivo2CancelamentoCodigoRetornoExecucaoTrailer)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Arquivo2CancelamentoDataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Arquivo2CancelamentoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Arquivo2CancelamentoNomeFisico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Arquivo2CodigoRetornoExecucaoGru)
                    .HasColumnName("Arquivo2CodigoRetornoExecucaoGRU")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Arquivo2CodigoRetornoExecucaoHeader)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Arquivo2CodigoRetornoExecucaoTrailer)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Arquivo2DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Arquivo2Nome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Arquivo2NomeFisico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoConfirmacaoSiafinome)
                    .HasColumnName("ArquivoConfirmacaoSIAFINome")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoConfirmacaoSiafinomeFisico)
                    .HasColumnName("ArquivoConfirmacaoSIAFINomeFisico")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoConfirmacaoSiafitamanho).HasColumnName("ArquivoConfirmacaoSIAFITamanho");

                entity.Property(e => e.CodigoInfracaoFinanceiroDetran).HasColumnName("CodigoInfracaoFinanceiroDETRAN");

                entity.Property(e => e.CodigoInfracaoFinanceiroRepasseDetransituacao).HasColumnName("CodigoInfracaoFinanceiroRepasseDETRANSituacao");

                entity.Property(e => e.CodigoInfracaoFinanceiroRepasseDetransituacaoArquivoExclusao).HasColumnName("CodigoInfracaoFinanceiroRepasseDETRANSituacaoArquivoExclusao");

                entity.Property(e => e.CodigoInfracaoFinanceiroRepasseDetransituacaoArquivoInclusao).HasColumnName("CodigoInfracaoFinanceiroRepasseDETRANSituacaoArquivoInclusao");

                entity.Property(e => e.CodigoRenavamorgaoAutuador).HasColumnName("CodigoRENAVAMOrgaoAutuador");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.GruanoCompetencia).HasColumnName("GRUAnoCompetencia");

                entity.Property(e => e.GrucodigoRecolhimento)
                    .HasColumnName("GRUCodigoRecolhimento")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.GrucodigoRecolhimentoDv)
                    .HasColumnName("GRUCodigoRecolhimentoDV")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GrudataVencimento)
                    .HasColumnName("GRUDataVencimento")
                    .HasColumnType("date");

                entity.Property(e => e.GrumesCompetencia).HasColumnName("GRUMesCompetencia");

                entity.Property(e => e.GrunumeroReferencia)
                    .HasColumnName("GRUNumeroReferencia")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Gruobservacoes)
                    .HasColumnName("GRUObservacoes")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Gruuggestao)
                    .HasColumnName("GRUUGGestao")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.GruvalorDescontosAbatimento)
                    .HasColumnName("GRUValorDescontosAbatimento")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GruvalorOutrasDeducoes)
                    .HasColumnName("GRUValorOutrasDeducoes")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GruvalorPrincipal)
                    .HasColumnName("GRUValorPrincipal")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GruvalorRepasse)
                    .HasColumnName("GRUValorRepasse")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IdentificacaoArquivo)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificacaoRepasse)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RespostaDetrandataRepasse)
                    .HasColumnName("RespostaDETRANDataRepasse")
                    .HasColumnType("date");

                entity.Property(e => e.RespostaDetranvalorRepassado)
                    .HasColumnName("RespostaDETRANValorRepassado")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TotalRegistrosTipo2Gru).HasColumnName("TotalRegistrosTipo2GRU");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroDetranNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroRepasseDetran)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroDetran)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroRepasseDETRAN_InfracaoFinanceiroDETRAN");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroRepasseDetransituacaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroRepasseDetran)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroRepasseDetransituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroRepasseDETRAN_InfracaoFinanceiroRepasseDETRANSituacao");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroRepasseDetransituacaoArquivoExclusaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroRepasseDetranCodigoInfracaoFinanceiroRepasseDetransituacaoArquivoExclusaoNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroRepasseDetransituacaoArquivoExclusao)
                    .HasConstraintName("frkInfracaoFinanceiroRepasseDETRAN_InfracaoFinanceiroRepasseDETRANSituacaoArquivo_Exclusao");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroRepasseDetransituacaoArquivoInclusaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroRepasseDetranCodigoInfracaoFinanceiroRepasseDetransituacaoArquivoInclusaoNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroRepasseDetransituacaoArquivoInclusao)
                    .HasConstraintName("frkInfracaoFinanceiroRepasseDETRAN_InfracaoFinanceiroRepasseDETRANSituacaoArquivo_Inclusao");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroRepasseDetranevento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroRepasseDetranevento)
                    .HasName("prkInfracaoFinanceiroRepasseDETRANEvento");

                entity.ToTable("tblInfracaoFinanceiroRepasseDETRANEvento");

                entity.HasIndex(e => new { e.CodigoInfracaoFinanceiroRepasseDetran, e.Data })
                    .HasName("idxInfracaoFinanceiroRepasseDETRANEvento");

                entity.Property(e => e.CodigoInfracaoFinanceiroRepasseDetranevento).HasColumnName("CodigoInfracaoFinanceiroRepasseDETRANEvento");

                entity.Property(e => e.CodigoInfracaoFinanceiroRepasseDetran).HasColumnName("CodigoInfracaoFinanceiroRepasseDETRAN");

                entity.Property(e => e.CodigoInfracaoFinanceiroRepasseDetransituacao).HasColumnName("CodigoInfracaoFinanceiroRepasseDETRANSituacao");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoFinanceiroRepasseDetranNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroRepasseDetranevento)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroRepasseDetran)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroRepasseDETRANEvento_InfracaoFinanceiroRepasseDETRAN");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroRepasseDetransituacaoNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroRepasseDetranevento)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroRepasseDetransituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroRepasseDETRANEvento_InfracaoFinanceiroRepasseDETRANSituacao");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroRepasseDetranretornoExecucaoErro>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroRepasseDetranretornoExecucaoErro)
                    .HasName("prkInfracaoFinanceiroRepasseDETRANRetornoExecucaoErro");

                entity.ToTable("tblInfracaoFinanceiroRepasseDETRANRetornoExecucaoErro");

                entity.Property(e => e.CodigoInfracaoFinanceiroRepasseDetranretornoExecucaoErro).HasColumnName("CodigoInfracaoFinanceiroRepasseDETRANRetornoExecucaoErro");

                entity.Property(e => e.CodigoInfracaoFinanceiroRepasseDetran).HasColumnName("CodigoInfracaoFinanceiroRepasseDETRAN");

                entity.Property(e => e.CodigoRetornoExecucao)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAuto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoFinanceiroRepasseDetranNavigation)
                    .WithMany(p => p.TblInfracaoFinanceiroRepasseDetranretornoExecucaoErro)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroRepasseDetran)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoFinanceiroRepasseDETRANRetornoErros_InfracaoFinanceiroRepasseDETRAN");
            });

            modelBuilder.Entity<TblInfracaoFinanceiroRepasseDetransituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroRepasseDetransituacao);

                entity.ToTable("tblInfracaoFinanceiroRepasseDETRANSituacao");

                entity.Property(e => e.CodigoInfracaoFinanceiroRepasseDetransituacao)
                    .HasColumnName("CodigoInfracaoFinanceiroRepasseDETRANSituacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoFinanceiroRepasseDetransituacaoArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoFinanceiroRepasseDetransituacaoArquivo)
                    .HasName("prkInfracaoFinanceiroRepasseDETRANSituacaoArquivo");

                entity.ToTable("tblInfracaoFinanceiroRepasseDETRANSituacaoArquivo");

                entity.Property(e => e.CodigoInfracaoFinanceiroRepasseDetransituacaoArquivo)
                    .HasColumnName("CodigoInfracaoFinanceiroRepasseDETRANSituacaoArquivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoGravidade>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoGravidade)
                    .HasName("prkInfracaoGravidade");

                entity.ToTable("tblInfracaoGravidade");

                entity.Property(e => e.CodigoInfracaoGravidade).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoIdentificacaoInfratorCondutor>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoIdentificacaoInfratorCondutor)
                    .HasName("prkInfracaoIdentificacaoInfratorCondutor");

                entity.ToTable("tblInfracaoIdentificacaoInfratorCondutor");

                entity.HasIndex(e => new { e.CodigoInfracao, e.CodigoInfracaoIdentificacaoInfratorCondutorSituacao })
                    .HasName("idxInfracaoIdentificacaoInfratorCondutor_PesquisaInfracao");

                entity.HasIndex(e => new { e.CodigoInfracaoIdentificacaoInfratorCondutor, e.CodigoInfracaoIdentificacaoInfratorCondutorIndicadorResultadoConferencia, e.CodigoInfracaoIdentificacaoInfratorCondutorMotivoInvalidacao, e.DataProtocolo, e.DataConferencia, e.DataAtualizacao, e.RowVersion, e.NumeroAuto, e.DataInfracao, e.CodigoInfracaoIdentificacaoInfratorCondutorFase, e.CodigoSistemaUsuarioConferencia, e.CodigoInfracaoIdentificacaoInfratorCondutorConferenciaEspecial, e.CodigoInfracaoIdentificacaoInfratorCondutorSituacao })
                    .HasName("idxInfracaoIdentificacaoInfratorCondutor_ConferenciaDistribuicao");

                entity.HasIndex(e => new { e.CodigoInfracaoIdentificacaoInfratorCondutor, e.CodigoInfracao, e.CodigoSistemaUsuarioConferencia, e.NumeroProcesso, e.DataProtocolo, e.PrazoConferencia, e.Nome, e.NumeroCpfformatado, e.RowVersion, e.CodigoInfracaoProprietario, e.NumeroAuto, e.DataInfracao, e.VeiculoPlaca, e.VeiculoPlacaUf, e.CodigoInfracaoIdentificacaoInfratorCondutorSituacao, e.CodigoInfracaoIdentificacaoInfratorCondutorFase, e.CodigoInfracaoIdentificacaoInfratorCondutorConferenciaEspecial })
                    .HasName("idxInfracaoIdentificacaoInfratorCondutor_ConferenciaPesquisa");

                entity.Property(e => e.CodigoRenavammodeloCh).HasColumnName("CodigoRENAVAMModeloCH");

                entity.Property(e => e.CodigoRenavampaisExpedicaoChestrangeira).HasColumnName("CodigoRENAVAMPaisExpedicaoCHEstrangeira");

                entity.Property(e => e.CodigoRenavamtipoDocumentoCondutorNaoHabilitado).HasColumnName("CodigoRENAVAMTipoDocumentoCondutorNaoHabilitado");

                entity.Property(e => e.CodigoUfexpedicaoCnh).HasColumnName("CodigoUFExpedicaoCNH");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataCadastro).HasColumnType("date");

                entity.Property(e => e.DataCancelamento).HasColumnType("date");

                entity.Property(e => e.DataConferencia).HasColumnType("date");

                entity.Property(e => e.DataInfracao).HasColumnType("date");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.IndicadorRegistroRenainf).HasColumnName("IndicadorRegistroRENAINF");

                entity.Property(e => e.Nome)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAuto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCpf)
                    .HasColumnName("NumeroCPF")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCpfformatado)
                    .HasColumnName("NumeroCPFFormatado")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumentoIdentificacao)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroProcesso)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroRegistroCh)
                    .HasColumnName("NumeroRegistroCH")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PrazoConferencia).HasColumnType("date");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.VeiculoPlaca)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.VeiculoPlacaUf)
                    .IsRequired()
                    .HasColumnName("VeiculoPlacaUF")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoIdentificacaoInfratorCondutor)
                    .HasForeignKey(d => d.CodigoInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoIdentificacaoInfratorCondutor_Infracao");

                entity.HasOne(d => d.CodigoInfracaoIdentificacaoInfratorCondutorConferenciaEspecialNavigation)
                    .WithMany(p => p.TblInfracaoIdentificacaoInfratorCondutor)
                    .HasForeignKey(d => d.CodigoInfracaoIdentificacaoInfratorCondutorConferenciaEspecial)
                    .HasConstraintName("frkInfracaoIdentificacaoInfratorCondutor_InfracaoIdentificacaoInfratorCondutorConferenciaEspecial");

                entity.HasOne(d => d.CodigoInfracaoIdentificacaoInfratorCondutorFaseNavigation)
                    .WithMany(p => p.TblInfracaoIdentificacaoInfratorCondutor)
                    .HasForeignKey(d => d.CodigoInfracaoIdentificacaoInfratorCondutorFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoIdentificacaoInfratorCondutor_IdentificacaoInfratorCondutorFase");

                entity.HasOne(d => d.CodigoInfracaoIdentificacaoInfratorCondutorIndicadorResultadoConferenciaNavigation)
                    .WithMany(p => p.TblInfracaoIdentificacaoInfratorCondutor)
                    .HasForeignKey(d => d.CodigoInfracaoIdentificacaoInfratorCondutorIndicadorResultadoConferencia)
                    .HasConstraintName("frkInfracaoIdentificacaoInfratorCondutor_IdentificacaoInfratorCondutorIndicadorResultadoConferencia");

                entity.HasOne(d => d.CodigoInfracaoIdentificacaoInfratorCondutorMotivoInvalidacaoNavigation)
                    .WithMany(p => p.TblInfracaoIdentificacaoInfratorCondutor)
                    .HasForeignKey(d => d.CodigoInfracaoIdentificacaoInfratorCondutorMotivoInvalidacao)
                    .HasConstraintName("frkInfracaoIdentificacaoInfratorCondutor_IdentificacaoInfratorCondutorMotivoInvalidacao");

                entity.HasOne(d => d.CodigoInfracaoIdentificacaoInfratorCondutorOrigemNavigation)
                    .WithMany(p => p.TblInfracaoIdentificacaoInfratorCondutor)
                    .HasForeignKey(d => d.CodigoInfracaoIdentificacaoInfratorCondutorOrigem)
                    .HasConstraintName("frkInfracaoIdentificacaoInfratorCondutor_InfracaoIdentificacaoInfratorCondutorOrigem");

                entity.HasOne(d => d.CodigoInfracaoIdentificacaoInfratorCondutorSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoIdentificacaoInfratorCondutor)
                    .HasForeignKey(d => d.CodigoInfracaoIdentificacaoInfratorCondutorSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoIdentificacaoInfratorCondutor_IdentificacaoInfratorCondutorSituacao");

                entity.HasOne(d => d.CodigoSistemaUsuarioEmConferenciaNavigation)
                    .WithMany(p => p.TblInfracaoIdentificacaoInfratorCondutor)
                    .HasForeignKey(d => d.CodigoSistemaUsuarioConferencia)
                    .HasConstraintName("frkInfracaoIdentificacaoInfratorCondutor_SistemaUsuario_EmConferencia");

                entity.HasOne(d => d.CodigoUfexpedicaoCnhNavigation)
                    .WithMany(p => p.TblInfracaoIdentificacaoInfratorCondutor)
                    .HasForeignKey(d => d.CodigoUfexpedicaoCnh)
                    .HasConstraintName("frkInfracaoIdentificacaoInfratorCondutor_BaseUF_ExpedicaoCNH");
            });

            modelBuilder.Entity<TblInfracaoIdentificacaoInfratorCondutorArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoIdentificacaoInfratorCondutorArquivo)
                    .HasName("prkInfracaoIdentificacaoInfratorCondutorArquivo");

                entity.ToTable("tblInfracaoIdentificacaoInfratorCondutorArquivo");

                entity.HasIndex(e => e.CodigoInfracaoIdentificacaoInfratorCondutor)
                    .HasName("idxInfracaoIdentificacaoInfratorCondutorArquivo");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacaoCaixa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoIdentificacaoInfratorCondutorNavigation)
                    .WithMany(p => p.TblInfracaoIdentificacaoInfratorCondutorArquivo)
                    .HasForeignKey(d => d.CodigoInfracaoIdentificacaoInfratorCondutor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoIdentificacaoInfratorCondutorArquivo_InfracaoIdentificacaoInfratorCondutor");
            });

            modelBuilder.Entity<TblInfracaoIdentificacaoInfratorCondutorConferenciaEspecial>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoIdentificacaoInfratorCondutorConferenciaEspecial)
                    .HasName("prkInfracaoIdentificacaoInfratorCondutorConferenciaEspecial");

                entity.ToTable("tblInfracaoIdentificacaoInfratorCondutorConferenciaEspecial");

                entity.Property(e => e.CodigoInfracaoIdentificacaoInfratorCondutorConferenciaEspecial).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoIdentificacaoInfratorCondutorEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoIdentificacaoInfratorCondutorEvento)
                    .HasName("prkInfracaoIdentificacaoInfratorCondutorEvento");

                entity.ToTable("tblInfracaoIdentificacaoInfratorCondutorEvento");

                entity.HasIndex(e => new { e.CodigoInfracaoIdentificacaoInfratorCondutor, e.Data })
                    .HasName("idxInfracaoIdentificacaoInfratorCondutorEvento");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoIdentificacaoInfratorCondutorNavigation)
                    .WithMany(p => p.TblInfracaoIdentificacaoInfratorCondutorEvento)
                    .HasForeignKey(d => d.CodigoInfracaoIdentificacaoInfratorCondutor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoIdentificacaoInfratorCondutorEvento_InfracaoIdentificacaoInfratorCondutor");

                entity.HasOne(d => d.CodigoInfracaoIdentificacaoInfratorCondutorFaseNavigation)
                    .WithMany(p => p.TblInfracaoIdentificacaoInfratorCondutorEvento)
                    .HasForeignKey(d => d.CodigoInfracaoIdentificacaoInfratorCondutorFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoIdentificacaoInfratorCondutorEvento_InfracaoIdentificacaoInfratorCondutorFase");

                entity.HasOne(d => d.CodigoInfracaoIdentificacaoInfratorCondutorSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoIdentificacaoInfratorCondutorEvento)
                    .HasForeignKey(d => d.CodigoInfracaoIdentificacaoInfratorCondutorSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoIdentificacaoInfratorCondutorEvento_InfracaoIdentificacaoInfratorCondutorSituacao");
            });

            modelBuilder.Entity<TblInfracaoIdentificacaoInfratorCondutorFase>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoIdentificacaoInfratorCondutorFase)
                    .HasName("prkInfracaoIdentificacaoInfratorCondutorFase");

                entity.ToTable("tblInfracaoIdentificacaoInfratorCondutorFase");

                entity.Property(e => e.CodigoInfracaoIdentificacaoInfratorCondutorFase).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoIdentificacaoInfratorCondutorIndicadorResultado>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoIdentificacaoInfratorCondutorIndicadorResultado)
                    .HasName("prkInfracaoIdentificacaoInfratorCondutorIndicadorResultado");

                entity.ToTable("tblInfracaoIdentificacaoInfratorCondutorIndicadorResultado");

                entity.Property(e => e.CodigoInfracaoIdentificacaoInfratorCondutorIndicadorResultado).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoIdentificacaoInfratorCondutorMotivoInvalidacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoIdentificacaoInfratorCondutorMotivoInvalidacao)
                    .HasName("prkInfracaoIdentificacaoInfratorCondutorMotivoInvalidacao");

                entity.ToTable("tblInfracaoIdentificacaoInfratorCondutorMotivoInvalidacao");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoIdentificacaoInfratorCondutorOrigem>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoIdentificacaoInfratorCondutorOrigem)
                    .HasName("prkInfracaoIdentificacaoInfratorCondutorOrigem");

                entity.ToTable("tblInfracaoIdentificacaoInfratorCondutorOrigem");

                entity.Property(e => e.CodigoInfracaoIdentificacaoInfratorCondutorOrigem).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoIdentificacaoInfratorCondutorSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoIdentificacaoInfratorCondutorSituacao)
                    .HasName("prkInfracaoIdentificacaoInfratorCondutorSituacao");

                entity.ToTable("tblInfracaoIdentificacaoInfratorCondutorSituacao");

                entity.Property(e => e.CodigoInfracaoIdentificacaoInfratorCondutorSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoImagem>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoImagem)
                    .HasName("prkInfracaoImagem");

                entity.ToTable("tblInfracaoImagem");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoImagem)
                    .HasForeignKey(d => d.CodigoInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoImagem_Infracao");

                entity.HasOne(d => d.CodigoInfracaoImagemTipoNavigation)
                    .WithMany(p => p.TblInfracaoImagem)
                    .HasForeignKey(d => d.CodigoInfracaoImagemTipo)
                    .HasConstraintName("frkInfracaoImagem_InfracaoImagemTipo");
            });

            modelBuilder.Entity<TblInfracaoImagemTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoImagemTipo)
                    .HasName("prkInfracaoImagemTipo");

                entity.ToTable("tblInfracaoImagemTipo");

                entity.Property(e => e.CodigoInfracaoImagemTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoIndicadorResponsavel>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoIndicadorResponsavel)
                    .HasName("prkInfracaoIndicadorResponsavel");

                entity.ToTable("tblInfracaoIndicadorResponsavel");

                entity.Property(e => e.CodigoInfracaoIndicadorResponsavel).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoInfrator>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoInfrator)
                    .HasName("prkInfracaoInfrator");

                entity.ToTable("tblInfracaoInfrator");

                entity.Property(e => e.CodigoRenavammodeloCh).HasColumnName("CodigoRENAVAMModeloCH");

                entity.Property(e => e.CodigoRenavampaisExpedicaoChestrangeira).HasColumnName("CodigoRENAVAMPaisExpedicaoCHEstrangeira");

                entity.Property(e => e.CodigoRenavamtipoDocumentoCondutorNaoHabilitado).HasColumnName("CodigoRENAVAMTipoDocumentoCondutorNaoHabilitado");

                entity.Property(e => e.CodigoUfexpedicaoCnh).HasColumnName("CodigoUFExpedicaoCNH");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCpfcnpj)
                    .HasColumnName("NumeroCPFCNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCpfcnpjformatado)
                    .HasColumnName("NumeroCPFCNPJFormatado")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumentoIdentificacao)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroRegistroCh)
                    .HasColumnName("NumeroRegistroCH")
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNotificacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacao)
                    .HasName("prkInfracaoNotificacao");

                entity.ToTable("tblInfracaoNotificacao");

                entity.HasIndex(e => e.IndicadorRegistroRenainf)
                    .HasName("idxInfracaoNotificacao_AUX");

                entity.HasIndex(e => e.NumeroNotificacaoRenainf)
                    .HasName("idxInfracaoNotificacao_NumeroNotificacaoRENAINF");

                entity.HasIndex(e => new { e.CodigoInfracao, e.CodigoInfracaoNotificacaoTipo })
                    .HasName("idxInfracaoNotificacao_CodigoInfracao");

                entity.HasIndex(e => new { e.CodigoInfracaoNotificacao, e.CodigoInfracaoNotificacaoEdital })
                    .HasName("idxInfracaoNotificacao_Edital_Publicado_Temp");

                entity.HasIndex(e => new { e.EnderecoCep, e.CodigoInfracaoNotificacaoExpedicao })
                    .HasName("idxInfracaoNotificacao_Expedicao");

                entity.HasIndex(e => new { e.CodigoInfracao, e.CodigoInfracaoNotificacaoExpedicaoServico, e.CodigoInfracaoNotificacao, e.DataPostagem, e.DataVencimentoAtual, e.CodigoInfracaoNotificacaoTipo, e.CodigoInfracaoNotificacaoSituacao })
                    .HasName("idxInfracaoNotificacao_Edital");

                entity.Property(e => e.ArdigitalArquivoNome)
                    .HasColumnName("ARDigitalArquivoNome")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArdigitalArquivoNomeFisico)
                    .HasColumnName("ARDigitalArquivoNomeFisico")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArdigitalArquivoTamanho).HasColumnName("ARDigitalArquivoTamanho");

                entity.Property(e => e.ArdigitalDataBaixaObjeto)
                    .HasColumnName("ARDigitalDataBaixaObjeto")
                    .HasColumnType("date");

                entity.Property(e => e.ArdigitalNumeroLoteBaixa)
                    .HasColumnName("ARDigitalNumeroLoteBaixa")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BaixaDataEntregaAr)
                    .HasColumnName("BaixaDataEntregaAR")
                    .HasColumnType("date");

                entity.Property(e => e.CodigoInfracaoFinanceiroGru).HasColumnName("CodigoInfracaoFinanceiroGRU");

                entity.Property(e => e.CodigoInfracaoNotificacaoMidiaAr).HasColumnName("CodigoInfracaoNotificacaoMidiaAR");

                entity.Property(e => e.CodigoRenavamindicadorAdesaoSne).HasColumnName("CodigoRENAVAMIndicadorAdesaoSne");

                entity.Property(e => e.CodigoRenavammunicipio).HasColumnName("CodigoRENAVAMMunicipio");

                entity.Property(e => e.CodigoUf).HasColumnName("CodigoUF");

                entity.Property(e => e.DataAdesaoSne).HasColumnType("datetime");

                entity.Property(e => e.DataCancelamento).HasColumnType("date");

                entity.Property(e => e.DataEmissao).HasColumnType("date");

                entity.Property(e => e.DataNotificacao).HasColumnType("date");

                entity.Property(e => e.DataPostagem).HasColumnType("date");

                entity.Property(e => e.DataPrePostagem).HasColumnType("date");

                entity.Property(e => e.DataPublicacaoEdital).HasColumnType("date");

                entity.Property(e => e.DataRegistroRenainf)
                    .HasColumnName("DataRegistroRENAINF")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataVencimentoAtual).HasColumnType("date");

                entity.Property(e => e.DataVencimentoEdital).HasColumnType("date");

                entity.Property(e => e.DataVencimentoExpedicao).HasColumnType("date");

                entity.Property(e => e.DataVencimentoPreExpedicao).HasColumnType("date");

                entity.Property(e => e.Destinatario)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoBairro)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoCep)
                    .HasColumnName("EnderecoCEP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoComplemento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoLogradouro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoNumero)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IndicadorNaoAcolhimentoDa).HasColumnName("IndicadorNaoAcolhimentoDA");

                entity.Property(e => e.IndicadorRegistroRenainf).HasColumnName("IndicadorRegistroRENAINF");

                entity.Property(e => e.NumeroAr)
                    .HasColumnName("NumeroAR")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroNotificacaoRenainf)
                    .HasColumnName("NumeroNotificacaoRENAINF")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroObjeto)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SegundaViaArquivoNome)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SegundaViaArquivoNomeFisico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBaseCorreiosCodigoBaixaNavigation)
                    .WithMany(p => p.TblInfracaoNotificacao)
                    .HasForeignKey(d => d.CodigoBaseCorreiosCodigoBaixa)
                    .HasConstraintName("frkInfracaoNotificacao_BaseCorreiosCodigoBaixa");

                entity.HasOne(d => d.CodigoBaseCorreiosMotivoDevolucaoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacao)
                    .HasForeignKey(d => d.CodigoBaseCorreiosMotivoDevolucao)
                    .HasConstraintName("frkInfracaoNotificacao_BaseCorreiosMotivoDevolucao");

                entity.HasOne(d => d.CodigoInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacao)
                    .HasForeignKey(d => d.CodigoInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacao_Infracao");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroGruNavigation)
                    .WithMany(p => p.TblInfracaoNotificacao)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroGru)
                    .HasConstraintName("frkInfracaoNotificacao_InfracaoFinanceiroGRU");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoArquivoBaixaNavigation)
                    .WithMany(p => p.TblInfracaoNotificacao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoArquivoBaixa)
                    .HasConstraintName("frkInfracaoNotificacao_InfracaoNotificacaoArquivoBaixa");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoExpedicaoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoExpedicao)
                    .HasConstraintName("frkInfracaoNotificacao_InfracaoNotificacaoExpedicao");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoExpedicaoServicoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoExpedicaoServico)
                    .HasConstraintName("frkInfracaoNotificacao_InfracaoNotificacaoExpedicaoServico");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoMidiaArNavigation)
                    .WithMany(p => p.TblInfracaoNotificacao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoMidiaAr)
                    .HasConstraintName("frkInfracaoNotificacao_InfracaoNotificacaoMidiaAR");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacao_InfracaoNotificacaoSituacao");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoTipoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacao_InfracaoNotificacaoTipo");

                entity.HasOne(d => d.CodigoUfNavigation)
                    .WithMany(p => p.TblInfracaoNotificacao)
                    .HasForeignKey(d => d.CodigoUf)
                    .HasConstraintName("frkInfracaoNotificacao_UF");
            });

            modelBuilder.Entity<TblInfracaoNotificacaoArquivoBaixa>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoArquivoBaixa)
                    .HasName("prkInfracaoNotificacaoArquivoBaixa");

                entity.ToTable("tblInfracaoNotificacaoArquivoBaixa");

                entity.Property(e => e.ArquivoNome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoNomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataGeracao).HasColumnType("datetime");

                entity.Property(e => e.DataProcessamento).HasColumnType("datetime");

                entity.Property(e => e.Observacao).IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoNotificacaoArquivoBaixaSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoArquivoBaixa)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoArquivoBaixaSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoArquivoBaixa_InfracaoNotificacaoArquivoBaixaSituacao");
            });

            modelBuilder.Entity<TblInfracaoNotificacaoArquivoBaixaSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoArquivoBaixaSituacao);

                entity.ToTable("tblInfracaoNotificacaoArquivoBaixaSituacao");

                entity.Property(e => e.CodigoInfracaoNotificacaoArquivoBaixaSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNotificacaoEdital>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoEdital)
                    .HasName("prkInfracaoNotificacaoEdital");

                entity.ToTable("tblInfracaoNotificacaoEdital");

                entity.HasIndex(e => new { e.CodigoInfracaoNotificacaoEditalTipo, e.DataVencimentoEdital, e.CodigoInfracaoNotificacaoEdital })
                    .HasName("idxInfracaoNotificacaoEdital");

                entity.Property(e => e.ConteudoEdital).IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataPublicacao).HasColumnType("date");

                entity.Property(e => e.DataVencimentoEdital).HasColumnType("date");

                entity.Property(e => e.DataVencimentoNotificacao).HasColumnType("date");

                entity.Property(e => e.EditalCompletoArquivoDataGeracao).HasColumnType("datetime");

                entity.Property(e => e.EditalCompletoArquivoNome)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EditalCompletoArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EditalExtratoArquivoNome)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EditalExtratoArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoUrlPublicacaoEditalDou)
                    .HasColumnName("EnderecoUrlPublicacaoEditalDOU")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExtratoPublicacao).IsUnicode(false);

                entity.Property(e => e.NumeroEdital)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao).IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoNotificacaoEditalSituacaoArquivoCompletoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoEdital)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoEditalSituacaoArquivoCompleto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoEdital_InfracaoNotificacaoEditalSituacaoArquivo");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoEditalTipoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoEdital)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoEditalTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoEdital_InfracaoNotificacaoEditalTipo");
            });

            modelBuilder.Entity<TblInfracaoNotificacaoEditalArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoEditalArquivo)
                    .HasName("prkInfracaoNotificacaoEditalArquivo");

                entity.ToTable("tblInfracaoNotificacaoEditalArquivo");

                entity.HasIndex(e => e.CodigoInfracaoNotificacaoEdital)
                    .HasName("idxInfracaoNotificacaoEditalArquivo");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoNotificacaoEditalNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoEditalArquivo)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoEdital)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoEditalArquivo_InfracaoNotificacaoEdital");
            });

            modelBuilder.Entity<TblInfracaoNotificacaoEditalEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoEditalEvento)
                    .HasName("prkInfracaoNotificacaoEditalEvento");

                entity.ToTable("tblInfracaoNotificacaoEditalEvento");

                entity.HasIndex(e => new { e.CodigoInfracaoNotificacaoEdital, e.Data })
                    .HasName("idxInfracaoNotificacaoEditalEvento");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoNotificacaoEditalNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoEditalEvento)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoEdital)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoEditalEvento_InfracaoNotificacaoEdital");
            });

            modelBuilder.Entity<TblInfracaoNotificacaoEditalNotificacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoEditalNotificacao)
                    .HasName("prkInfracaoEditalNotificacao");

                entity.ToTable("tblInfracaoNotificacaoEditalNotificacao");

                entity.HasIndex(e => e.CodigoInfracaoNotificacao)
                    .HasName("idxInfracaoNotificacaoEditalNotificacao_GeracaoEdital");

                entity.HasIndex(e => new { e.PlacaUf, e.NumeroAit, e.DataInfracao, e.CodigoEnquadramentoTexto, e.ValorOriginal, e.CodigoInfracaoNotificacaoEdital, e.CodigoInfracaoNotificacao })
                    .HasName("idxInfracaoNotificacaoEditalNotificacao_Edital");

                entity.Property(e => e.CodigoEnquadramentoTexto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DataInfracao).HasColumnType("date");

                entity.Property(e => e.NumeroAit)
                    .IsRequired()
                    .HasColumnName("NumeroAIT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlacaUf)
                    .IsRequired()
                    .HasColumnName("PlacaUF")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ValorOriginal).HasColumnType("decimal(7, 2)");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoEditalNotificacao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEditalNotificacao_InfracaoNotificacao");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoEditalNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoEditalNotificacao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoEdital)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEditalNotificacao_InfracaoEdital");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoTipoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoEditalNotificacao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoEditalNotificacao_InfracaoNotificacaoTipo");
            });

            modelBuilder.Entity<TblInfracaoNotificacaoEditalNotificacaoExcecao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacao)
                    .HasName("prkInfracaoNotificacaoEditalNotificacaoExcecao");

                entity.ToTable("tblInfracaoNotificacaoEditalNotificacaoExcecao");

                entity.Property(e => e.CodigoInfracaoNotificacao).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblInfracaoNotificacaoEditalSituacaoArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoEditalSituacaoArquivo)
                    .HasName("prkInfracaoNotificacaoEditalSituacaoArquivo");

                entity.ToTable("tblInfracaoNotificacaoEditalSituacaoArquivo");

                entity.Property(e => e.CodigoInfracaoNotificacaoEditalSituacaoArquivo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNotificacaoEditalTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoEditalTipo)
                    .HasName("prkInfracaoNotificacaoEditalTipo");

                entity.ToTable("tblInfracaoNotificacaoEditalTipo");

                entity.Property(e => e.CodigoInfracaoNotificacaoEditalTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNotificacaoExpedicao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoExpedicao)
                    .HasName("prkInfracaoNotificacaoExpedicao");

                entity.ToTable("tblInfracaoNotificacaoExpedicao");

                entity.Property(e => e.ArquivoPacoteImpressaoNome)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoInfracaoFinanceiroGrucadastroTituloBanco).HasColumnName("CodigoInfracaoFinanceiroGRUCadastroTituloBanco");

                entity.Property(e => e.DataCancelamento).HasColumnType("date");

                entity.Property(e => e.DataColetaCorreios).HasColumnType("date");

                entity.Property(e => e.DataCriacaoArquivoSegundaVia).HasColumnType("datetime");

                entity.Property(e => e.DataPostagem).HasColumnType("date");

                entity.Property(e => e.DataPostagemCorreio).HasColumnType("date");

                entity.Property(e => e.DataProcessamento).HasColumnType("date");

                entity.Property(e => e.DataVencimento).HasColumnType("date");

                entity.Property(e => e.MensagemErroPacoteImpressao).IsUnicode(false);

                entity.Property(e => e.NumeroRemessa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResumoPostagemArquivoNome)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResumoPostagemArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.CodigoBaseCorreiosCartaoPostagemNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoExpedicao)
                    .HasForeignKey(d => d.CodigoBaseCorreiosCartaoPostagem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoExpedicao_BaseCorreiosCartaoPostagem");

                entity.HasOne(d => d.CodigoBaseCorreiosPlanoTriagemNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoExpedicao)
                    .HasForeignKey(d => d.CodigoBaseCorreiosPlanoTriagem)
                    .HasConstraintName("frkInfracaoNotificacaoExpedicao_BaseCorreiosPlanoTriagem");

                entity.HasOne(d => d.CodigoInfracaoFinanceiroGrucadastroTituloBancoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoExpedicao)
                    .HasForeignKey(d => d.CodigoInfracaoFinanceiroGrucadastroTituloBanco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoExpedicao_InfracaoFinanceiroGRUCadastroTituloBanco");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoExpedicaoFalhaNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoExpedicao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoExpedicaoFalha)
                    .HasConstraintName("frkInfracaoNotificacaoExpedicao_InfracaoNotificacaoExpedicaoFalha");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoExpedicaoFaseNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoExpedicao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoExpedicaoFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoExpedicao_InfracaoNotificacaoExpedicaoFase");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoExpedicaoServicoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoExpedicao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoExpedicaoServico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoExpedicao_InfracaoNotificacaoExpedicaoServico");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoExpedicaoSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoExpedicao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoExpedicaoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoExpedicao_InfracaoNotificacaoExpedicaoSituacao");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoExpedicaoTipoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoExpedicao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoExpedicaoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoExpedicao_InfracaoNotificacaoExpedicaoTipo");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoTipoGrupoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoExpedicao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoTipoGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoExpedicao_InfracaoNotificacaoTipoGrupo");
            });

            modelBuilder.Entity<TblInfracaoNotificacaoExpedicaoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoExpedicaoEvento)
                    .HasName("prkInfracaoNotificacaoExpedicaoEvento");

                entity.ToTable("tblInfracaoNotificacaoExpedicaoEvento");

                entity.HasIndex(e => new { e.CodigoInfracaoNotificacaoExpedicao, e.Data })
                    .HasName("idxInfracaoNotificacaoExpedicaoEvento");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoNotificacaoExpedicaoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoExpedicaoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoExpedicao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoExpedicaoEvento_InfracaoNotificacaoExpedicao");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoExpedicaoFaseNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoExpedicaoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoExpedicaoFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoExpedicaoEvento_InfracaoNotificacaoExpedicaoFase");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoExpedicaoSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoExpedicaoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoExpedicaoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoExpedicaoEvento_InfracaoNotificacaoExpedicaoSituacao");
            });

            modelBuilder.Entity<TblInfracaoNotificacaoExpedicaoFalha>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoExpedicaoFalha)
                    .HasName("prkInfracaoNotificacaoExpedicaoFalha");

                entity.ToTable("tblInfracaoNotificacaoExpedicaoFalha");

                entity.Property(e => e.CodigoInfracaoNotificacaoExpedicaoFalha).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNotificacaoExpedicaoFase>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoExpedicaoFase)
                    .HasName("prkInfracaoNotificacaoExpedicaoFase");

                entity.ToTable("tblInfracaoNotificacaoExpedicaoFase");

                entity.Property(e => e.CodigoInfracaoNotificacaoExpedicaoFase).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNotificacaoExpedicaoServico>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoExpedicaoServico)
                    .HasName("prkInfracaoNotificacaoExpedicaoServico");

                entity.ToTable("tblInfracaoNotificacaoExpedicaoServico");

                entity.Property(e => e.CodigoInfracaoNotificacaoExpedicaoServico).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNotificacaoExpedicaoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoExpedicaoSituacao)
                    .HasName("prkInfracaoNotificacaoExpedicaoSituacao");

                entity.ToTable("tblInfracaoNotificacaoExpedicaoSituacao");

                entity.Property(e => e.CodigoInfracaoNotificacaoExpedicaoSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNotificacaoExpedicaoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoExpedicaoTipo)
                    .HasName("prkInfracaoNotificacaoExpedicaoTipo");

                entity.ToTable("tblInfracaoNotificacaoExpedicaoTipo");

                entity.Property(e => e.CodigoInfracaoNotificacaoExpedicaoTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNotificacaoMidiaAr>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoMidiaAr)
                    .HasName("prkInfracaoNotificacaoMidiaAR");

                entity.ToTable("tblInfracaoNotificacaoMidiaAR");

                entity.Property(e => e.CodigoInfracaoNotificacaoMidiaAr).HasColumnName("CodigoInfracaoNotificacaoMidiaAR");

                entity.Property(e => e.DataGeracaoMidia).HasColumnType("date");

                entity.Property(e => e.DataProcessamento).HasColumnType("datetime");

                entity.Property(e => e.NumeroMidia)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNotificacaoRestricao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoRestricao)
                    .HasName("prkInfracaoNotificacaoRestricao");

                entity.ToTable("tblInfracaoNotificacaoRestricao");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IndicadorRestricaoNa).HasColumnName("IndicadorRestricaoNA");

                entity.Property(e => e.IndicadorRestricaoNp).HasColumnName("IndicadorRestricaoNP");

                entity.Property(e => e.PrazoVigenciaInicio).HasColumnType("date");

                entity.Property(e => e.PrazoVigenciaTermino).HasColumnType("date");
            });

            modelBuilder.Entity<TblInfracaoNotificacaoRestricaoArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoRestricaoArquivo)
                    .HasName("prkInfracaoNotificacaoRestricaoArquivo");

                entity.ToTable("tblInfracaoNotificacaoRestricaoArquivo");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoNotificacaoRestricaoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoRestricaoArquivo)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoRestricao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoRestricaoArquivo_InfracaoNotificacaoRestricao");
            });

            modelBuilder.Entity<TblInfracaoNotificacaoRestricaoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoRestricaoEvento)
                    .HasName("prkInfracaoNotificacaoRestricaoEvento");

                entity.ToTable("tblInfracaoNotificacaoRestricaoEvento");

                entity.HasIndex(e => new { e.CodigoInfracaoNotificacaoRestricao, e.Data })
                    .HasName("idxInfracaoNotificacaoRestricaoEvento");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoNotificacaoRestricaoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoRestricaoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoRestricao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoRestricaoEvento_InfracaoNotificacaoRestricao");
            });

            modelBuilder.Entity<TblInfracaoNotificacaoRestricaoPncvequipamento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoRestricaoPncvequipamento)
                    .HasName("prkInfracaoNotificacaoRestricaoPNCVEquipamento");

                entity.ToTable("tblInfracaoNotificacaoRestricaoPNCVEquipamento");

                entity.Property(e => e.CodigoInfracaoNotificacaoRestricaoPncvequipamento).HasColumnName("CodigoInfracaoNotificacaoRestricaoPNCVEquipamento");

                entity.Property(e => e.CodigoPncvequipamento).HasColumnName("CodigoPNCVEquipamento");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoRestricaoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoRestricaoPncvequipamento)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoRestricao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoRestricaoPNCVEquipamento_InfracaoNotificacaoRestricao");

                entity.HasOne(d => d.CodigoPncvequipamentoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoRestricaoPncvequipamento)
                    .HasForeignKey(d => d.CodigoPncvequipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoRestricaoPNCVEquipamento_PNCVEquipamento");
            });

            modelBuilder.Entity<TblInfracaoNotificacaoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoSituacao)
                    .HasName("prkInfracaoNotificacaoSituacao");

                entity.ToTable("tblInfracaoNotificacaoSituacao");

                entity.Property(e => e.CodigoInfracaoNotificacaoSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNotificacaoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoTipo)
                    .HasName("tblInfracaoNotificacaoTipo.prkInfracaoNotificacaoTipo");

                entity.ToTable("tblInfracaoNotificacaoTipo");

                entity.Property(e => e.CodigoInfracaoNotificacaoTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoNotificacaoTipoGrupoNavigation)
                    .WithMany(p => p.TblInfracaoNotificacaoTipo)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoTipoGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoNotificacaoTipo_InfracaoNotificacaoTipoGrupo");
            });

            modelBuilder.Entity<TblInfracaoNotificacaoTipoGrupo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNotificacaoTipoGrupo);

                entity.ToTable("tblInfracaoNotificacaoTipoGrupo");

                entity.Property(e => e.CodigoInfracaoNotificacaoTipoGrupo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNumeroAuto>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNumeroAuto)
                    .HasName("prkInfracaoNumeroAuto");

                entity.ToTable("tblInfracaoNumeroAuto");

                entity.HasIndex(e => e.NumeroAuto)
                    .HasName("idxInfracaoNumeroAuto");

                entity.HasIndex(e => new { e.Prefixo, e.NumeroSequencial })
                    .HasName("idxInfracaoNumeroAuto_PrefixoNumeroAuto");

                entity.Property(e => e.NumeroAuto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSequencial).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Prefixo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNumeroAutoPrefixo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNumeroAutoPrefixo)
                    .HasName("prkInfracaoNumeroAutoPrefixo");

                entity.ToTable("tblInfracaoNumeroAutoPrefixo");

                entity.Property(e => e.CodigoInfracaoNumeroAutoPrefixo).ValueGeneratedNever();

                entity.Property(e => e.FaixaInicio).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.FaixaTermino).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.LetraPrefixo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNumeroNotificacaoPenalidade>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNumeroNotificacaoPenalidade)
                    .HasName("prkInfracaoNumeroNotificacaoPenalidade");

                entity.ToTable("tblInfracaoNumeroNotificacaoPenalidade");

                entity.HasIndex(e => e.NumeroSequencial)
                    .HasName("idxInfracaoNumeroNotificacaoPenalidade_Sequencial");

                entity.Property(e => e.NumeroNotificacaoRenainf)
                    .IsRequired()
                    .HasColumnName("NumeroNotificacaoRENAINF")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSequencial).HasColumnType("decimal(10, 0)");
            });

            modelBuilder.Entity<TblInfracaoNumeroProcessoBaixaManual>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNumeroProcessoBaixaManual)
                    .HasName("prkInfracaoNumeroProcessoBaixaManual");

                entity.ToTable("tblInfracaoNumeroProcessoBaixaManual");

                entity.HasIndex(e => new { e.Ocorrencia, e.NumeroAutoInfracao, e.DataProtocolo })
                    .HasName("idxInfracaoNumeroProcessoBaixaManual");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.NumeroAutoInfracao)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroProcesso)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNumeroProcessoDa>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNumeroProcessoDa)
                    .HasName("prkInfracaoNumeroProcessoDA");

                entity.ToTable("tblInfracaoNumeroProcessoDA");

                entity.Property(e => e.CodigoInfracaoNumeroProcessoDa).HasColumnName("CodigoInfracaoNumeroProcessoDA");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.NumeroAutoInfracao)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroProcesso)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNumeroProcessoDesvinculacaoMulta>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNumeroProcessoDesvinculacaoMulta)
                    .HasName("prkInfracaoNumeroProcessoDesvinculacaoMulta");

                entity.ToTable("tblInfracaoNumeroProcessoDesvinculacaoMulta");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.NumeroAutoInfracao)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroProcesso)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNumeroProcessoEfeitoSuspensivo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNumeroProcessoEfeitoSuspensivo)
                    .HasName("prkInfracaoNumeroProcessoEfeitoSuspensivo");

                entity.ToTable("tblInfracaoNumeroProcessoEfeitoSuspensivo");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.NumeroAutoInfracao)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroProcesso)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNumeroProcessoIdentificacaoInfratorCondutor>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNumeroProcessoIdentificacaoInfratorCondutor)
                    .HasName("prkInfracaoNumeroProcessoIdentificacaoInfratorCondutor");

                entity.ToTable("tblInfracaoNumeroProcessoIdentificacaoInfratorCondutor");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.NumeroAutoInfracao)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroProcesso)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNumeroProcessoRecurso>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNumeroProcessoRecurso)
                    .HasName("prkInfracaoNumeroProcessoRecurso");

                entity.ToTable("tblInfracaoNumeroProcessoRecurso");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.NumeroAutoInfracao)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroProcesso)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoNumeroProcessoSolicitacaoAdvertencia>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoNumeroProcessoSolicitacaoAdvertencia)
                    .HasName("prkInfracaoNumeroProcessoSolicitacaoAdvertencia");

                entity.ToTable("tblInfracaoNumeroProcessoSolicitacaoAdvertencia");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.NumeroAutoInfracao)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroProcesso)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoOrigem>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoOrigem)
                    .HasName("prkInfracaoOrigem");

                entity.ToTable("tblInfracaoOrigem");

                entity.Property(e => e.CodigoInfracaoOrigem).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoOrigemContratacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoOrigemContratacao)
                    .HasName("prkInfracaoOrigemContratacao");

                entity.ToTable("tblInfracaoOrigemContratacao");

                entity.Property(e => e.CodigoInfracaoOrigemContratacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoOrigemContrato>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoOrigemContrato)
                    .HasName("prkInfracaoOrigemContrato");

                entity.ToTable("tblInfracaoOrigemContrato");

                entity.Property(e => e.CodigoInfracaoOrigemContrato).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoParametros>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoParametros)
                    .HasName("prkInfracaoParametros");

                entity.ToTable("tblInfracaoParametros");

                entity.Property(e => e.CodigoInfracaoParametros).ValueGeneratedNever();

                entity.Property(e => e.ConteudoEditalNa)
                    .IsRequired()
                    .HasColumnName("ConteudoEditalNA")
                    .IsUnicode(false);

                entity.Property(e => e.ConteudoEditalNd)
                    .HasColumnName("ConteudoEditalND")
                    .IsUnicode(false);

                entity.Property(e => e.ConteudoEditalNp)
                    .IsRequired()
                    .HasColumnName("ConteudoEditalNP")
                    .IsUnicode(false);

                entity.Property(e => e.ExtratoPublicacaoNa)
                    .IsRequired()
                    .HasColumnName("ExtratoPublicacaoNA")
                    .IsUnicode(false);

                entity.Property(e => e.ExtratoPublicacaoNd)
                    .HasColumnName("ExtratoPublicacaoND")
                    .IsUnicode(false);

                entity.Property(e => e.ExtratoPublicacaoNp)
                    .IsRequired()
                    .HasColumnName("ExtratoPublicacaoNP")
                    .IsUnicode(false);

                entity.Property(e => e.NomeAutoridadeTransito)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NotificacaoPrazoEditalNa).HasColumnName("NotificacaoPrazoEditalNA");

                entity.Property(e => e.NotificacaoPrazoEditalNd).HasColumnName("NotificacaoPrazoEditalND");

                entity.Property(e => e.NotificacaoPrazoEditalNp).HasColumnName("NotificacaoPrazoEditalNP");

                entity.Property(e => e.NotificacaoPrazoNacarencia).HasColumnName("NotificacaoPrazoNACarencia");

                entity.Property(e => e.NotificacaoPrazoNaquarta).HasColumnName("NotificacaoPrazoNAQuarta");

                entity.Property(e => e.NotificacaoPrazoNaquinta).HasColumnName("NotificacaoPrazoNAQuinta");

                entity.Property(e => e.NotificacaoPrazoNasegunda).HasColumnName("NotificacaoPrazoNASegunda");

                entity.Property(e => e.NotificacaoPrazoNasexta).HasColumnName("NotificacaoPrazoNASexta");

                entity.Property(e => e.NotificacaoPrazoNaterca).HasColumnName("NotificacaoPrazoNATerca");

                entity.Property(e => e.NotificacaoPrazoNdquarta).HasColumnName("NotificacaoPrazoNDQuarta");

                entity.Property(e => e.NotificacaoPrazoNdquinta).HasColumnName("NotificacaoPrazoNDQuinta");

                entity.Property(e => e.NotificacaoPrazoNdsegunda).HasColumnName("NotificacaoPrazoNDSegunda");

                entity.Property(e => e.NotificacaoPrazoNdsexta).HasColumnName("NotificacaoPrazoNDSexta");

                entity.Property(e => e.NotificacaoPrazoNdterca).HasColumnName("NotificacaoPrazoNDTerca");

                entity.Property(e => e.NotificacaoPrazoNpcarencia).HasColumnName("NotificacaoPrazoNPCarencia");

                entity.Property(e => e.NotificacaoPrazoNpquarta).HasColumnName("NotificacaoPrazoNPQuarta");

                entity.Property(e => e.NotificacaoPrazoNpquinta).HasColumnName("NotificacaoPrazoNPQuinta");

                entity.Property(e => e.NotificacaoPrazoNpsegunda).HasColumnName("NotificacaoPrazoNPSegunda");

                entity.Property(e => e.NotificacaoPrazoNpsexta).HasColumnName("NotificacaoPrazoNPSexta");

                entity.Property(e => e.NotificacaoPrazoNpterca).HasColumnName("NotificacaoPrazoNPTerca");

                entity.Property(e => e.PortariaAutoridadeTransito)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSistemaCatalogoConexaoNotificacaoAutuacaoSegundaViaRepositorioNavigation)
                    .WithMany(p => p.TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoAutuacaoSegundaViaRepositorioNavigation)
                    .HasForeignKey(d => d.CodigoSistemaCatalogoConexaoNotificacaoAutuacaoSegundaViaRepositorio)
                    .HasConstraintName("frkInfracaoParametros_SistemaCatalogoConexaoNotificacaoAutuacaoSegundaViaRepositorio");

                entity.HasOne(d => d.CodigoSistemaCatalogoConexaoNotificacaoDecisaoSegundaViaRepositorioNavigation)
                    .WithMany(p => p.TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoDecisaoSegundaViaRepositorioNavigation)
                    .HasForeignKey(d => d.CodigoSistemaCatalogoConexaoNotificacaoDecisaoSegundaViaRepositorio)
                    .HasConstraintName("frkInfracaoParametros_SistemaCatalogoConexaoNotificacaoDecisaoSegundaViaRepositorio");

                entity.HasOne(d => d.CodigoSistemaCatalogoConexaoNotificacaoExpedicaoInterfaceNavigation)
                    .WithMany(p => p.TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoExpedicaoInterfaceNavigation)
                    .HasForeignKey(d => d.CodigoSistemaCatalogoConexaoNotificacaoExpedicaoInterface)
                    .HasConstraintName("frkInfracaoParametros_SistemaCatalogoConexaoNotificacaoExpedicaoInterface");

                entity.HasOne(d => d.CodigoSistemaCatalogoConexaoNotificacaoExpedicaoProcessamentoNavigation)
                    .WithMany(p => p.TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoExpedicaoProcessamentoNavigation)
                    .HasForeignKey(d => d.CodigoSistemaCatalogoConexaoNotificacaoExpedicaoProcessamento)
                    .HasConstraintName("frkInfracaoParametros_SistemaCatalogoConexaoNotificacaoExpedicaoProcessamento");

                entity.HasOne(d => d.CodigoSistemaCatalogoConexaoNotificacaoPenalidadeSegundaViaRepositorioNavigation)
                    .WithMany(p => p.TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoPenalidadeSegundaViaRepositorioNavigation)
                    .HasForeignKey(d => d.CodigoSistemaCatalogoConexaoNotificacaoPenalidadeSegundaViaRepositorio)
                    .HasConstraintName("frkInfracaoParametros_SistemaCatalogoConexaoNotificacaoPenalidadeSegundaViaRepositorio");

                entity.HasOne(d => d.CodigoSistemaCatalogoConexaoNotificacaoSegundaViaInterfaceNavigation)
                    .WithMany(p => p.TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoSegundaViaInterfaceNavigation)
                    .HasForeignKey(d => d.CodigoSistemaCatalogoConexaoNotificacaoSegundaViaInterface)
                    .HasConstraintName("frkInfracaoParametros_SistemaCatalogoConexaoNotificacaoSegundaViaInterface");

                entity.HasOne(d => d.CodigoSistemaCatalogoConexaoNotificacaoSegundaViaProcessamentoNavigation)
                    .WithMany(p => p.TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoSegundaViaProcessamentoNavigation)
                    .HasForeignKey(d => d.CodigoSistemaCatalogoConexaoNotificacaoSegundaViaProcessamento)
                    .HasConstraintName("frkInfracaoParametros_SistemaCatalogoConexaoNotificacaoSegundaViaProcessamento");
            });

            modelBuilder.Entity<TblInfracaoPesagem>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPesagem)
                    .HasName("prkInfracaoPesagem");

                entity.ToTable("tblInfracaoPesagem");

                entity.Property(e => e.DescricaoVeiculo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExcessoAferidoCmt).HasColumnName("ExcessoAferidoCMT");

                entity.Property(e => e.ExcessoAferidoPbt).HasColumnName("ExcessoAferidoPBT");

                entity.Property(e => e.LimiteRegulamentarCmt).HasColumnName("LimiteRegulamentarCMT");

                entity.Property(e => e.LimiteRegulamentarComToleranciaCmt).HasColumnName("LimiteRegulamentarComToleranciaCMT");

                entity.Property(e => e.LimiteRegulamentarComToleranciaPbt).HasColumnName("LimiteRegulamentarComToleranciaPBT");

                entity.Property(e => e.LimiteRegulamentarPbt).HasColumnName("LimiteRegulamentarPBT");

                entity.Property(e => e.MedicaoRealizadaCmt).HasColumnName("MedicaoRealizadaCMT");

                entity.Property(e => e.MedicaoRealizadaPbt).HasColumnName("MedicaoRealizadaPBT");

                entity.Property(e => e.ToleranciaCmt).HasColumnName("ToleranciaCMT");

                entity.Property(e => e.ToleranciaPbt).HasColumnName("ToleranciaPBT");
            });

            modelBuilder.Entity<TblInfracaoPreAutuacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPreAutuacao)
                    .HasName("prkInfracaoPreAutuacao");

                entity.ToTable("tblInfracaoPreAutuacao");

                entity.HasIndex(e => e.DataInfracao)
                    .HasName("idxInfracaoPreAutuacao_Data");

                entity.HasIndex(e => new { e.CodigoInfracaoPreAutuacao, e.CodigoInfracaoPreAutuacaoSituacao, e.CodigoInfracaoPreAutuacaoFase, e.DataInfracao })
                    .HasName("idxInfracao_SituacaoFaseDataInfracao");

                entity.HasIndex(e => new { e.CodigoInfracaoPreAutuacao, e.CodigoPncveditalLote, e.CodigoInfracaoEnquadramento, e.DataHoraInfracao, e.CodigoInfracaoSistemaOrigem, e.CodigoInfracaoOrigemContratacao, e.DataInfracao })
                    .HasName("idxInfracaoPreAutuacao_AUX_UpdateDadosOrigem");

                entity.HasIndex(e => new { e.CodigoInfracaoPreAutuacao, e.ConferenciaData, e.DataCancelamento, e.ConferenciaIndicadorRegistroValido, e.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferencia, e.CodigoInfracaoOrigemContratacao, e.CodigoInfracaoOrigemContrato, e.CodigoInfracaoOrigemRemessaDados, e.CodigoInfracaoOrigemRegistro, e.CodigoInfracaoPreAutuacaoSituacao })
                    .HasName("idxInfracaoPreAutuacao_ApuracaoMedicao");

                entity.Property(e => e.AnaliseData).HasColumnType("datetime");

                entity.Property(e => e.CodigoPncveditalLote).HasColumnName("CodigoPNCVEditalLote");

                entity.Property(e => e.CodigoRenavammarcaModeloVeiculo).HasColumnName("CodigoRENAVAMMarcaModeloVeiculo");

                entity.Property(e => e.CodigoRenavammunicipioEmplacamentoVeiculo).HasColumnName("CodigoRENAVAMMunicipioEmplacamentoVeiculo");

                entity.Property(e => e.CodigoRenavammunicipioLocalInfracao).HasColumnName("CodigoRENAVAMMunicipioLocalInfracao");

                entity.Property(e => e.CodigoRenavamorgaoAutuador).HasColumnName("CodigoRENAVAMOrgaoAutuador");

                entity.Property(e => e.CodigoRenavamtipoVeiculo).HasColumnName("CodigoRENAVAMTipoVeiculo");

                entity.Property(e => e.CodigoRenavamunidadeMedida).HasColumnName("CodigoRENAVAMUnidadeMedida");

                entity.Property(e => e.CodigoRenavamveiculoCarroceria).HasColumnName("CodigoRENAVAMVeiculoCarroceria");

                entity.Property(e => e.CodigoRenavamveiculoCategoria).HasColumnName("CodigoRENAVAMVeiculoCategoria");

                entity.Property(e => e.CodigoRenavamveiculoCor).HasColumnName("CodigoRENAVAMVeiculoCor");

                entity.Property(e => e.CodigoRenavamveiculoEspecie).HasColumnName("CodigoRENAVAMVeiculoEspecie");

                entity.Property(e => e.CodigoUfjurisdicaoVeiculo).HasColumnName("CodigoUFJurisdicaoVeiculo");

                entity.Property(e => e.CodigoUflocalInfracao).HasColumnName("CodigoUFLocalInfracao");

                entity.Property(e => e.ConferenciaData).HasColumnType("datetime");

                entity.Property(e => e.ConferenciaDoisData).HasColumnType("datetime");

                entity.Property(e => e.ConferenciaDoisPlacaVeiculo)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ConferenciaRevisaoData).HasColumnType("datetime");

                entity.Property(e => e.ConferenciaRevisaoPlacaVeiculo)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ConferenciaUmData).HasColumnType("datetime");

                entity.Property(e => e.ConferenciaUmPlacaVeiculo)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataCancelamento).HasColumnType("datetime");

                entity.Property(e => e.DataHoraInfracao).HasColumnType("datetime");

                entity.Property(e => e.DataInfracao).HasColumnType("date");

                entity.Property(e => e.Debug).IsUnicode(false);

                entity.Property(e => e.EquipamentoAfericaoCodigoDnit)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.EquipamentoAfericaoInmetroVerificacaoData).HasColumnType("date");

                entity.Property(e => e.EquipamentoAfericaoInmetroVerificacaoNumero)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EquipamentoAfericaoMarca)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EquipamentoAfericaoModelo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImagemPrincipalArquivoNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImagemPrincipalArquivoNomeFisico)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LimiteRegulamentado).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.LocalInfracaoKm).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.LocalInfracaoRodovia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalInfracaoRodoviaFaixa)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MedicaoRealizada).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.NomeRenavammarcaModeloVeiculo)
                    .HasColumnName("NomeRENAVAMMarcaModeloVeiculo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PreparacaoImagemData).HasColumnType("datetime");

                entity.Property(e => e.ValorConsiderado).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorOriginal).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal60Porcento).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal80Porcento).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.VeiculoPlacaFinal)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.VeiculoPlacaOriginal)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoEnquadramentoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacao)
                    .HasForeignKey(d => d.CodigoInfracaoEnquadramento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacao_InfracaoEnquadramento");

                entity.HasOne(d => d.CodigoInfracaoEquipamentoAfericaoTipoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacao)
                    .HasForeignKey(d => d.CodigoInfracaoEquipamentoAfericaoTipo)
                    .HasConstraintName("frkInfracaoPreAutuacao_InfracaoEquipamentoAfericaoTipo");

                entity.HasOne(d => d.CodigoInfracaoGravidadeNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacao)
                    .HasForeignKey(d => d.CodigoInfracaoGravidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacao_InfracaoGravidade");

                entity.HasOne(d => d.CodigoInfracaoIndicadorResponsavelNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacao)
                    .HasForeignKey(d => d.CodigoInfracaoIndicadorResponsavel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacao_InfracaoIndicadorResponsavel");

                entity.HasOne(d => d.CodigoInfracaoOrigemNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacao)
                    .HasForeignKey(d => d.CodigoInfracaoOrigem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacao_InfracaoOrigem");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoArbitragemResultadoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacao)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacaoArbitragemResultado)
                    .HasConstraintName("frkInfracaoPreAutuacao_InfracaoPreAutuacaoArbitragemResultado");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoClasseVeiculoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacao)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacaoClasseVeiculo)
                    .HasConstraintName("frkInfracaoPreAutuacao_InfracaoPreAutuacaoClasseVeiculo");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoConferenciaTipoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacao)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacaoConferenciaTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacao_InfracaoPreAutuacaoConferenciaTipo");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoFaseNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacao)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacaoFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacao_InfracaoPreAutuacaoFase");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoMotivoInvalidacaoAnaliseNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoCodigoInfracaoPreAutuacaoMotivoInvalidacaoAnaliseNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacaoMotivoInvalidacaoAnalise)
                    .HasConstraintName("frkInfracaoPreAutuacao_InfracaoPreAutuacaoMotivoInvalidacaoAnalise");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDoisNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoCodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDoisNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDois)
                    .HasConstraintName("frkInfracaoPreAutuacao_InfracaoPreAutuacaoMotivoInvalidacaoConferenciaDois");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaRevisaoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoCodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaRevisaoNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaRevisao)
                    .HasConstraintName("frkInfracaoPreAutuacao_InfracaoPreAutuacaoMotivoInvalidacaoConferenciaRevisao");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUmNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoCodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUmNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUm)
                    .HasConstraintName("frkInfracaoPreAutuacao_InfracaoPreAutuacaoMotivoInvalidacaoConferenciaUm");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacao)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacaoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacao_InfracaoPreAutuacaoSituacao");

                entity.HasOne(d => d.CodigoInfracaoVeiculoTipoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacao)
                    .HasForeignKey(d => d.CodigoInfracaoVeiculoTipo)
                    .HasConstraintName("frkInfracaoPreAutuacao_InfracaoVeiculoTipo");

                entity.HasOne(d => d.CodigoRodoviaLocalInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacao)
                    .HasForeignKey(d => d.CodigoRodoviaLocalInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacao_RodoviaLocalInfracao");

                entity.HasOne(d => d.CodigoUfjurisdicaoVeiculoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoCodigoUfjurisdicaoVeiculoNavigation)
                    .HasForeignKey(d => d.CodigoUfjurisdicaoVeiculo)
                    .HasConstraintName("frkInfracaoPreAutuacao_UFJurisdicaoVeiculo");

                entity.HasOne(d => d.CodigoUflocalInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoCodigoUflocalInfracaoNavigation)
                    .HasForeignKey(d => d.CodigoUflocalInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacao_UFLocalInfracao");
            });

            modelBuilder.Entity<TblInfracaoPreAutuacaoAnalise>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPreAutuacaoAnalise)
                    .HasName("prkInfracaoPreAutuacaoAnalise");

                entity.ToTable("tblInfracaoPreAutuacaoAnalise");

                entity.HasIndex(e => e.CodigoInfracaoPreAutuacao)
                    .HasName("idxInfracaoPreAutuacaoAnalise_CodigoInfracaoPreAutuacao")
                    .IsUnique();

                entity.HasIndex(e => e.CodigoSistemaUsuario)
                    .HasName("idxInfracaoPreAutuacaoAnalise_CodigoSistemaUsuario");

                entity.Property(e => e.DataEmAnalise).HasColumnType("datetime");

                entity.Property(e => e.DataHoraInfracao).HasColumnType("datetime");

                entity.Property(e => e.MedicaoRealizada).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.CodigoInfracaoEnquadramentoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoAnalise)
                    .HasForeignKey(d => d.CodigoInfracaoEnquadramento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacaoAnalise_InfracaoEnquadramento");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoNavigation)
                    .WithOne(p => p.TblInfracaoPreAutuacaoAnalise)
                    .HasForeignKey<TblInfracaoPreAutuacaoAnalise>(d => d.CodigoInfracaoPreAutuacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacaoAnalise_InfracaoPreAutuacao");

                entity.HasOne(d => d.CodigoSistemaUsuarioNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoAnalise)
                    .HasForeignKey(d => d.CodigoSistemaUsuario)
                    .HasConstraintName("frkInfracaoPreAutuacaoAnalise_SistemaUsuario");
            });

            modelBuilder.Entity<TblInfracaoPreAutuacaoArbitragemResultado>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPreAutuacaoArbitragemResultado)
                    .HasName("prkInfracaoPreAutuacaoArbitragemResultado");

                entity.ToTable("tblInfracaoPreAutuacaoArbitragemResultado");

                entity.Property(e => e.CodigoInfracaoPreAutuacaoArbitragemResultado).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoPreAutuacaoClasseVeiculo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPreAutuacaoClasseVeiculo)
                    .HasName("prkInfracaoPreAutuacaoClasseVeiculo");

                entity.ToTable("tblInfracaoPreAutuacaoClasseVeiculo");

                entity.Property(e => e.CodigoInfracaoPreAutuacaoClasseVeiculo).ValueGeneratedNever();

                entity.Property(e => e.Classe)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Letra)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoPreAutuacaoConferenciaDupla>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPreAutuacaoConferenciaDupla)
                    .HasName("prkInfracaoPreAutuacaoConferenciaDupla");

                entity.ToTable("tblInfracaoPreAutuacaoConferenciaDupla");

                entity.HasIndex(e => e.CodigoInfracaoPreAutuacao)
                    .HasName("idxInfracaoPreAutuacaoConferenciaDupla_CodigoInfracaoPreAutuacao");

                entity.HasIndex(e => new { e.DataHoraInfracao, e.CodigoSistemaUsuarioConferenciaUm, e.CodigoSistemaUsuarioConferenciaDois, e.ConferenciaDataEmProcessamento })
                    .HasName("idxInfracaoPreAutuacaoConferenciaDupla");

                entity.Property(e => e.CodigoRenavammarcaModeloVeiculo).HasColumnName("CodigoRENAVAMMarcaModeloVeiculo");

                entity.Property(e => e.CodigoRenavammunicipioEmplacamentoVeiculo).HasColumnName("CodigoRENAVAMMunicipioEmplacamentoVeiculo");

                entity.Property(e => e.CodigoRenavamtipoVeiculo).HasColumnName("CodigoRENAVAMTipoVeiculo");

                entity.Property(e => e.CodigoRenavamveiculoCarroceria).HasColumnName("CodigoRENAVAMVeiculoCarroceria");

                entity.Property(e => e.CodigoRenavamveiculoCategoria).HasColumnName("CodigoRENAVAMVeiculoCategoria");

                entity.Property(e => e.CodigoRenavamveiculoCor).HasColumnName("CodigoRENAVAMVeiculoCor");

                entity.Property(e => e.CodigoRenavamveiculoEspecie).HasColumnName("CodigoRENAVAMVeiculoEspecie");

                entity.Property(e => e.CodigoUfjurisdicaoVeiculo).HasColumnName("CodigoUFJurisdicaoVeiculo");

                entity.Property(e => e.ConferenciaDataEmProcessamento).HasColumnType("datetime");

                entity.Property(e => e.ConferenciaDoisData).HasColumnType("datetime");

                entity.Property(e => e.ConferenciaDoisPlacaVeiculo)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ConferenciaUmCodigoRenavammarcaModeloVeiculo).HasColumnName("ConferenciaUmCodigoRENAVAMMarcaModeloVeiculo");

                entity.Property(e => e.ConferenciaUmCodigoRenavammunicipioEmplacamentoVeiculo).HasColumnName("ConferenciaUmCodigoRENAVAMMunicipioEmplacamentoVeiculo");

                entity.Property(e => e.ConferenciaUmCodigoRenavamtipoVeiculo).HasColumnName("ConferenciaUmCodigoRENAVAMTipoVeiculo");

                entity.Property(e => e.ConferenciaUmCodigoRenavamveiculoCarroceria).HasColumnName("ConferenciaUmCodigoRENAVAMVeiculoCarroceria");

                entity.Property(e => e.ConferenciaUmCodigoRenavamveiculoCategoria).HasColumnName("ConferenciaUmCodigoRENAVAMVeiculoCategoria");

                entity.Property(e => e.ConferenciaUmCodigoRenavamveiculoCor).HasColumnName("ConferenciaUmCodigoRENAVAMVeiculoCor");

                entity.Property(e => e.ConferenciaUmCodigoRenavamveiculoEspecie).HasColumnName("ConferenciaUmCodigoRENAVAMVeiculoEspecie");

                entity.Property(e => e.ConferenciaUmCodigoUfjurisdicaoVeiculo).HasColumnName("ConferenciaUmCodigoUFJurisdicaoVeiculo");

                entity.Property(e => e.ConferenciaUmData).HasColumnType("datetime");

                entity.Property(e => e.ConferenciaUmNomeRenavammarcaModeloVeiculo)
                    .HasColumnName("ConferenciaUmNomeRENAVAMMarcaModeloVeiculo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ConferenciaUmPlacaVeiculo)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DataHoraInfracao).HasColumnType("datetime");

                entity.Property(e => e.ImagemPrincipalArquivoNomeFisico)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LocalInfracaoMunicipioUf)
                    .IsRequired()
                    .HasColumnName("LocalInfracaoMunicipioUF")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MedicaoRealizada).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.NomeRenavammarcaModeloVeiculo)
                    .HasColumnName("NomeRENAVAMMarcaModeloVeiculo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlacaVeiculo)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoInfracaoEquipamentoAfericaoTipoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoConferenciaDupla)
                    .HasForeignKey(d => d.CodigoInfracaoEquipamentoAfericaoTipo)
                    .HasConstraintName("frkInfracaoPreAutuacaoConferenciaDupla_InfracaoEquipamentoAfericaoTipo");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoConferenciaDupla)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacaoConferenciaDupla_InfracaoPreAutuacao");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDoisNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoConferenciaDuplaCodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDoisNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDois)
                    .HasConstraintName("frkInfracaoPreAutuacaoConferenciaDupla_InfracaoPreAutuacaoMotivoInvalidacao_ConferenciaDois");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUmNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoConferenciaDuplaCodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUmNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUm)
                    .HasConstraintName("frkInfracaoPreAutuacaoConferenciaDupla_InfracaoPreAutuacaoMotivoInvalidacao_ConferenciaUm");

                entity.HasOne(d => d.CodigoSistemaUsuarioConferenciaDoisNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoConferenciaDuplaCodigoSistemaUsuarioConferenciaDoisNavigation)
                    .HasForeignKey(d => d.CodigoSistemaUsuarioConferenciaDois)
                    .HasConstraintName("frkInfracaoPreAutuacaoConferenciaDupla_SistemaUsuario_ConferenciaDois");

                entity.HasOne(d => d.CodigoSistemaUsuarioConferenciaRevisaoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoConferenciaDuplaCodigoSistemaUsuarioConferenciaRevisaoNavigation)
                    .HasForeignKey(d => d.CodigoSistemaUsuarioConferenciaRevisao)
                    .HasConstraintName("frkInfracaoPreAutuacaoConferenciaDupla_InfracaoPreAutuacaoConferenciaDupla_ConferenciaRevisao");

                entity.HasOne(d => d.CodigoSistemaUsuarioConferenciaUmNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoConferenciaDuplaCodigoSistemaUsuarioConferenciaUmNavigation)
                    .HasForeignKey(d => d.CodigoSistemaUsuarioConferenciaUm)
                    .HasConstraintName("frkInfracaoPreAutuacaoConferenciaDupla_SistemaUsuario_ConferenciaUm");

                entity.HasOne(d => d.CodigoUfjurisdicaoVeiculoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoConferenciaDupla)
                    .HasForeignKey(d => d.CodigoUfjurisdicaoVeiculo)
                    .HasConstraintName("frkInfracaoPreAutuacaoConferenciaDupla_BaseUF_JurisdicaoVeiculo");
            });

            modelBuilder.Entity<TblInfracaoPreAutuacaoConferenciaSimplesPncv>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPreAutuacaoConferenciaSimplesPncv)
                    .HasName("prkInfracaoPreAutuacaoConferenciaSimplesPNCV");

                entity.ToTable("tblInfracaoPreAutuacaoConferenciaSimplesPNCV");

                entity.HasIndex(e => e.CodigoInfracaoPreAutuacao)
                    .HasName("idx_InfracaoPreAtuacao");

                entity.HasIndex(e => e.CodigoPncveditalLote)
                    .HasName("idxInfracaoPreAutuacaoConferenciaSimplesPNCV_CodigoPNCVEditalLote");

                entity.Property(e => e.CodigoInfracaoPreAutuacaoConferenciaSimplesPncv).HasColumnName("CodigoInfracaoPreAutuacaoConferenciaSimplesPNCV");

                entity.Property(e => e.CodigoPncveditalLote).HasColumnName("CodigoPNCVEditalLote");

                entity.Property(e => e.DataEmProcessamento).HasColumnType("datetime");

                entity.Property(e => e.DataHoraInfracao).HasColumnType("datetime");

                entity.Property(e => e.ImagemPrincipalArquivoNomeFisico)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MedicaoRealizada).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PlacaVeiculo)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoInfracaoEnquadramentoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoConferenciaSimplesPncv)
                    .HasForeignKey(d => d.CodigoInfracaoEnquadramento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacaoConferenciaSimplesPNCV_InfracaoEnquadramento");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoConferenciaSimplesPncv)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacaoConferenciaSimplesPNCV_InfracaoPreAutuacao");

                entity.HasOne(d => d.CodigoPncveditalLoteNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoConferenciaSimplesPncv)
                    .HasForeignKey(d => d.CodigoPncveditalLote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacaoConferenciaSimplesPNCV_PNCVEditalLote");
            });

            modelBuilder.Entity<TblInfracaoPreAutuacaoConferenciaTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPreAutuacaoConferenciaTipo)
                    .HasName("prkInfracaoPreAutuacaoConferenciaTipo");

                entity.ToTable("tblInfracaoPreAutuacaoConferenciaTipo");

                entity.Property(e => e.CodigoInfracaoPreAutuacaoConferenciaTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoPreAutuacaoFase>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPreAutuacaoFase)
                    .HasName("prkInfracaoPreAutuacaoFase");

                entity.ToTable("tblInfracaoPreAutuacaoFase");

                entity.Property(e => e.CodigoInfracaoPreAutuacaoFase).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoPreAutuacaoImagem>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPreAutuacaoImagem)
                    .HasName("prkInfracaoPreAutuacaoImagem");

                entity.ToTable("tblInfracaoPreAutuacaoImagem");

                entity.HasIndex(e => e.CodigoInfracaoPreAutuacao)
                    .HasName("idxInfracaoPreAutuacaoImagem");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoImagemTipoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoImagem)
                    .HasForeignKey(d => d.CodigoInfracaoImagemTipo)
                    .HasConstraintName("frkInfracaoPreAutuacaoImagem_InfracaoImagemTipo");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoImagem)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacaoImagem_InfracaoPreAutuacao");
            });

            modelBuilder.Entity<TblInfracaoPreAutuacaoLavratura>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPreAutuacaoLavratura)
                    .HasName("prkInfracaoPreAutuacaoLavratura");

                entity.ToTable("tblInfracaoPreAutuacaoLavratura");

                entity.HasIndex(e => new { e.CodigoInfracaoPreAutuacaoLavratura, e.NumeroAutoPrefixo, e.IndicadorProcessamentoNumero })
                    .HasName("idxInfracaoPreAutuacaoLavratura_GerarNumeroProcesso");

                entity.Property(e => e.CodigoInfracaoPreAutuacaoLavratura).ValueGeneratedNever();

                entity.Property(e => e.CodigoInfracaoCtb)
                    .IsRequired()
                    .HasColumnName("CodigoInfracaoCTB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRenavammarcaModeloVeiculo).HasColumnName("CodigoRENAVAMMarcaModeloVeiculo");

                entity.Property(e => e.CodigoRenavammunicipioEmplacamentoVeiculo).HasColumnName("CodigoRENAVAMMunicipioEmplacamentoVeiculo");

                entity.Property(e => e.CodigoRenavammunicipioLocalInfracao).HasColumnName("CodigoRENAVAMMunicipioLocalInfracao");

                entity.Property(e => e.CodigoRenavampaisVeiculoPlacaEstrangeira).HasColumnName("CodigoRENAVAMPaisVeiculoPlacaEstrangeira");

                entity.Property(e => e.CodigoRenavamtipoVeiculo).HasColumnName("CodigoRENAVAMTipoVeiculo");

                entity.Property(e => e.CodigoRenavamunidadeMedida).HasColumnName("CodigoRENAVAMUnidadeMedida");

                entity.Property(e => e.CodigoRenavamveiculoCarroceria).HasColumnName("CodigoRENAVAMVeiculoCarroceria");

                entity.Property(e => e.CodigoRenavamveiculoCategoria).HasColumnName("CodigoRENAVAMVeiculoCategoria");

                entity.Property(e => e.CodigoRenavamveiculoCor).HasColumnName("CodigoRENAVAMVeiculoCor");

                entity.Property(e => e.CodigoRenavamveiculoEspecie).HasColumnName("CodigoRENAVAMVeiculoEspecie");

                entity.Property(e => e.CodigoUfjurisdicaoVeiculo).HasColumnName("CodigoUFJurisdicaoVeiculo");

                entity.Property(e => e.CodigoUflocalInfracao).HasColumnName("CodigoUFLocalInfracao");

                entity.Property(e => e.DataHoraInfracao).HasColumnType("datetime");

                entity.Property(e => e.DataInfracao).HasColumnType("date");

                entity.Property(e => e.EquipamentoAfericaoCodigoDnit)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.EquipamentoAfericaoInmetroVerificacaoData).HasColumnType("date");

                entity.Property(e => e.EquipamentoAfericaoMarca)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EquipamentoAfericaoModelo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ImagemPrincipalArquivoNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImagemPrincipalArquivoNomeFisico)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LimiteRegulamentado).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.LocalInfracaoKm).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.LocalInfracaoOcorrencia)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LocalInfracaoRodovia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalInfracaoRodoviaFaixa)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MedicaoRealizada).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.NumeroAgenteTransito)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAuto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAutoPrefixo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NupdataCadastro)
                    .HasColumnName("NUPDataCadastro")
                    .HasColumnType("date");

                entity.Property(e => e.Nupformatado)
                    .HasColumnName("NUPFormatado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PontosCnh).HasColumnName("PontosCNH");

                entity.Property(e => e.ValorConsiderado).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorOriginal).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal60Porcento).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal80Porcento).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.VeiculoPlaca)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoPreAutuacaoMotivoInvalidacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPreAutuacaoMotivoInvalidacao)
                    .HasName("prkInfracaoPreAutuacaoMotivoInvalidacao");

                entity.ToTable("tblInfracaoPreAutuacaoMotivoInvalidacao");

                entity.Property(e => e.CodigoInfracaoPreAutuacaoMotivoInvalidacao).ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoMotivoInvalidacaoGrupoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoMotivoInvalidacao)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacaoMotivoInvalidacaoGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacaoCausaInvalidacao_InfracaoPreAutuacaoCausaInvalidacaoGrupo");
            });

            modelBuilder.Entity<TblInfracaoPreAutuacaoMotivoInvalidacaoGrupo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPreAutuacaoMotivoInvalidacaoGrupo)
                    .HasName("prkInfracaoPreAutuacaoMotivoInvalidacaoGrupo");

                entity.ToTable("tblInfracaoPreAutuacaoMotivoInvalidacaoGrupo");

                entity.Property(e => e.CodigoInfracaoPreAutuacaoMotivoInvalidacaoGrupo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoPreAutuacaoPreparacaoImagem>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPreAutuacaoPreparacaoImagem)
                    .HasName("prkInfracaoPreAutuacaoPreparacaoImagem");

                entity.ToTable("tblInfracaoPreAutuacaoPreparacaoImagem");

                entity.HasIndex(e => e.CodigoInfracaoPreAutuacao)
                    .HasName("idxInfracaoPreAutuacaoPreparacaoImagem_PreAutuacao");

                entity.Property(e => e.DataEmPreparacaoImagem).HasColumnType("datetime");

                entity.Property(e => e.DataHoraInfracao).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoInfracaoEnquadramentoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoPreparacaoImagem)
                    .HasForeignKey(d => d.CodigoInfracaoEnquadramento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacaoPreparacaoImagem_InfracaoEnquadramento");

                entity.HasOne(d => d.CodigoInfracaoPreAutuacaoNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoPreparacaoImagem)
                    .HasForeignKey(d => d.CodigoInfracaoPreAutuacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoPreAutuacaoPreparacaoImagem_InfracaoPreAutuacao");

                entity.HasOne(d => d.CodigoSistemaUsuarioNavigation)
                    .WithMany(p => p.TblInfracaoPreAutuacaoPreparacaoImagem)
                    .HasForeignKey(d => d.CodigoSistemaUsuario)
                    .HasConstraintName("frkInfracaoPreAutuacaoPreparacaoImagem_SistemaUsuario");
            });

            modelBuilder.Entity<TblInfracaoPreAutuacaoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoPreAutuacaoSituacao)
                    .HasName("prkInfracaoPreAutuacaoSituacao");

                entity.ToTable("tblInfracaoPreAutuacaoSituacao");

                entity.Property(e => e.CodigoInfracaoPreAutuacaoSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoProprietario>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoProprietario)
                    .HasName("prkInfracaoProprietario");

                entity.ToTable("tblInfracaoProprietario");

                entity.HasIndex(e => e.NumeroCpfcnpj)
                    .HasName("idxInfracaoProprietario_NumeroCPFCNPJ");

                entity.Property(e => e.CodigoRenavammodeloCnh).HasColumnName("CodigoRENAVAMModeloCNH");

                entity.Property(e => e.CodigoRenavampossuidorOrigem).HasColumnName("CodigoRENAVAMPossuidorOrigem");

                entity.Property(e => e.CodigoRenavampossuidorTipoDocumento).HasColumnName("CodigoRENAVAMPossuidorTipoDocumento");

                entity.Property(e => e.CodigoUfexpedicaoCnh).HasColumnName("CodigoUFExpedicaoCNH");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCpfcnpj)
                    .HasColumnName("NumeroCPFCNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCpfcnpjformatado)
                    .HasColumnName("NumeroCPFCNPJFormatado")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroRegistroCnh)
                    .HasColumnName("NumeroRegistroCNH")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoUfexpedicaoCnhNavigation)
                    .WithMany(p => p.TblInfracaoProprietario)
                    .HasForeignKey(d => d.CodigoUfexpedicaoCnh)
                    .HasConstraintName("frkInfracaoProprietario_BaseUF_ExpedicaoCNH");
            });

            modelBuilder.Entity<TblInfracaoProprietarioEndereco>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoProprietarioEndereco)
                    .HasName("prkInfracaoProprietarioEndereco");

                entity.ToTable("tblInfracaoProprietarioEndereco");

                entity.HasIndex(e => new { e.CodigoInfracaoProprietario, e.IndicadorAtivo })
                    .HasName("idxInfracaoProprietarioEndereco_Ativo");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRenavammunicipio).HasColumnName("CodigoRENAVAMMunicipio");

                entity.Property(e => e.CodigoUf).HasColumnName("CodigoUF");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DataValidade).HasColumnType("datetime");

                entity.Property(e => e.Logradouro)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCep)
                    .IsRequired()
                    .HasColumnName("NumeroCEP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroImovel)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoProprietarioNavigation)
                    .WithMany(p => p.TblInfracaoProprietarioEndereco)
                    .HasForeignKey(d => d.CodigoInfracaoProprietario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoProprietarioEndereco_InfracaoProprietario");

                entity.HasOne(d => d.CodigoUfNavigation)
                    .WithMany(p => p.TblInfracaoProprietarioEndereco)
                    .HasForeignKey(d => d.CodigoUf)
                    .HasConstraintName("frkInfracaoProprietarioEndereco_BaseUF");
            });

            modelBuilder.Entity<TblInfracaoProtocoloAutomatico>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoProtocoloAutomatico)
                    .HasName("prkInfracaoProtocoloAutomatico");

                entity.ToTable("tblInfracaoProtocoloAutomatico");

                entity.HasIndex(e => new { e.IndicadorProcessado, e.IndicadorPreValidado, e.IndicadorFalha, e.DataCriacaoArquivo })
                    .HasName("idxInfracaoProtocoloAutomatico_Processamento");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataCriacaoArquivo).HasColumnType("datetime");

                entity.Property(e => e.DataProcessamento).HasColumnType("datetime");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.NomeArquivo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAuto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrigemProcesso)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PlacaVeiculo)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.SufixoErroRetorno)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProcesso)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoRecurso>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecurso)
                    .HasName("prkInfracaoRecurso");

                entity.ToTable("tblInfracaoRecurso");

                entity.HasIndex(e => new { e.CodigoInfracao, e.CodigoInfracaoRecursoTipo, e.CodigoInfracaoRecursoSituacao })
                    .HasName("idxInfracaoRecurso_Infracao");

                entity.HasIndex(e => new { e.CodigoInfracaoRecurso, e.CodigoInfracao, e.CodigoInfracaoRecursoIndicadorResultadoJulgamento, e.CodigoInfracaoRecursoTipo, e.CodigoInfracaoRecursoSituacao, e.CodigoInfracaoRecursoFase })
                    .HasName("idxInfracaoRecurso");

                entity.HasIndex(e => new { e.CodigoInfracaoRecurso, e.CodigoInfracao, e.CodigoSistemaUsuarioRelato, e.DataProtocolo, e.CodigoInfracaoEnquadramento, e.NumeroAuto, e.DataInfracao, e.VeiculoPlacaUf, e.CodigoInfracaoRecursoTipo, e.CodigoInfracaoRecursoSituacao, e.CodigoJari, e.CodigoInfracaoRecursoFase })
                    .HasName("idxInfracaoRecurso_Relato");

                entity.HasIndex(e => new { e.CodigoInfracaoRecurso, e.CodigoInfracao, e.CodigoInfracaoRecursoIndicadorAdmissibilidadeInstrucao, e.CodigoInfracaoRecursoIndicadorMeritoInstrucao, e.DataProtocolo, e.DataAtualizacao, e.RowVersion, e.NumeroAuto, e.DataInfracao, e.DataInstrucao, e.CodigoInfracaoRecursoTipo, e.CodigoInfracaoRecursoFase, e.CodigoSistemaUsuarioInstrucao, e.CodigoInfracaoRecursoSituacao })
                    .HasName("idxInfracaoRecurso_Distribuicao");

                entity.HasIndex(e => new { e.CodigoInfracaoRecurso, e.CodigoInfracao, e.CodigoSistemaUsuarioInstrucao, e.NumeroProcesso, e.DataProtocolo, e.PrazoJulgamento, e.RecorrenteNome, e.RecorrenteNumeroCpfcnpj, e.RecorrenteNumeroCpfcnpjformatado, e.RowVersion, e.NumeroAuto, e.DataInfracao, e.VeiculoPlaca, e.VeiculoPlacaUf, e.CodigoInfracaoEnquadramento, e.CodigoInfracaoRecursoTipo, e.CodigoInfracaoRecursoSituacao, e.CodigoInfracaoRecursoFase })
                    .HasName("idxInfracaoRecurso_Instrucao");

                entity.Property(e => e.CodigoJari).HasColumnName("CodigoJARI");

                entity.Property(e => e.CodigoJarisessaoJulgamento).HasColumnName("CodigoJARISessaoJulgamento");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataCancelamento).HasColumnType("date");

                entity.Property(e => e.DataEncaminhamento).HasColumnType("date");

                entity.Property(e => e.DataInfracao).HasColumnType("date");

                entity.Property(e => e.DataInstrucao).HasColumnType("date");

                entity.Property(e => e.DataJulgamento).HasColumnType("date");

                entity.Property(e => e.DataPedidoVistas).HasColumnType("date");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.DataRecebimentoDetran)
                    .HasColumnName("DataRecebimentoDETRAN")
                    .HasColumnType("date");

                entity.Property(e => e.DataRecebimentoDnit)
                    .HasColumnName("DataRecebimentoDNIT")
                    .HasColumnType("date");

                entity.Property(e => e.DataRelato).HasColumnType("date");

                entity.Property(e => e.DataRevisao).HasColumnType("date");

                entity.Property(e => e.IndicadorRegistroRenainf).HasColumnName("IndicadorRegistroRENAINF");

                entity.Property(e => e.InstrucaoAlegacao).IsUnicode(false);

                entity.Property(e => e.InstrucaoFundamentacao).IsUnicode(false);

                entity.Property(e => e.NumeroAuto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroProcesso)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrazoJulgamento).HasColumnType("date");

                entity.Property(e => e.RecorrenteNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecorrenteNumeroCpfcnpj)
                    .HasColumnName("RecorrenteNumeroCPFCNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.RecorrenteNumeroCpfcnpjformatado)
                    .HasColumnName("RecorrenteNumeroCPFCNPJFormatado")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.RelatoAlegacao).IsUnicode(false);

                entity.Property(e => e.RelatoFundamentacao).IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.VeiculoPlaca)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.VeiculoPlacaUf)
                    .IsRequired()
                    .HasColumnName("VeiculoPlacaUF")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoRecurso)
                    .HasForeignKey(d => d.CodigoInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecurso_Infracao");

                entity.HasOne(d => d.CodigoInfracaoRecursoFaseNavigation)
                    .WithMany(p => p.TblInfracaoRecurso)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecurso_InfracaoRecursoFase");

                entity.HasOne(d => d.CodigoInfracaoRecursoIndicadorAdmissibilidadeInstrucaoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoCodigoInfracaoRecursoIndicadorAdmissibilidadeInstrucaoNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoIndicadorAdmissibilidadeInstrucao)
                    .HasConstraintName("frkInfracaoRecurso_InfracaoRecursoIndicadorAdmissibilidadeInstrucao");

                entity.HasOne(d => d.CodigoInfracaoRecursoIndicadorAdmissibilidadeRelatoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoCodigoInfracaoRecursoIndicadorAdmissibilidadeRelatoNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoIndicadorAdmissibilidadeRelato)
                    .HasConstraintName("frkInfracaoRecurso_InfracaoRecursoIndicadorAdmissibilidadeRelato");

                entity.HasOne(d => d.CodigoInfracaoRecursoIndicadorMeritoInstrucaoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoCodigoInfracaoRecursoIndicadorMeritoInstrucaoNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoIndicadorMeritoInstrucao)
                    .HasConstraintName("frkInfracaoRecurso_InfracaoRecursoIndicadorMeritoInstrucao");

                entity.HasOne(d => d.CodigoInfracaoRecursoIndicadorMeritoRelatoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoCodigoInfracaoRecursoIndicadorMeritoRelatoNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoIndicadorMeritoRelato)
                    .HasConstraintName("frkInfracaoRecurso_InfracaoRecursoIndicadorMeritoRelato");

                entity.HasOne(d => d.CodigoInfracaoRecursoIndicadorRecorrenteNavigation)
                    .WithMany(p => p.TblInfracaoRecurso)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoIndicadorRecorrente)
                    .HasConstraintName("frkInfracaoRecurso_InfracaoRecursoIndicadorRecorrente");

                entity.HasOne(d => d.CodigoInfracaoRecursoIndicadorResultadoInstrucaoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoCodigoInfracaoRecursoIndicadorResultadoInstrucaoNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoIndicadorResultadoInstrucao)
                    .HasConstraintName("frkInfracaoRecurso_InfracaoRecursoIndicadorResultadoInstrucao");

                entity.HasOne(d => d.CodigoInfracaoRecursoIndicadorResultadoJulgamentoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoCodigoInfracaoRecursoIndicadorResultadoJulgamentoNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoIndicadorResultadoJulgamento)
                    .HasConstraintName("frkInfracaoRecurso_InfracaoRecursoIndicadorResultadoJulgamento");

                entity.HasOne(d => d.CodigoInfracaoRecursoIndicadorResultadoVotoRelatoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoCodigoInfracaoRecursoIndicadorResultadoVotoRelatoNavigation)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoIndicadorResultadoVotoRelato)
                    .HasConstraintName("frkInfracaoRecurso_InfracaoRecursoIndicadorResultadoVotoRelator");

                entity.HasOne(d => d.CodigoInfracaoRecursoOrigemNavigation)
                    .WithMany(p => p.TblInfracaoRecurso)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoOrigem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecurso_InfracaoRecursoOrigem");

                entity.HasOne(d => d.CodigoInfracaoRecursoSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoRecurso)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecurso_InfracaoRecursoSituacao");

                entity.HasOne(d => d.CodigoInfracaoRecursoTipoNavigation)
                    .WithMany(p => p.TblInfracaoRecurso)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecurso_InfracaoRecursoTipo");

                entity.HasOne(d => d.CodigoJariNavigation)
                    .WithMany(p => p.TblInfracaoRecurso)
                    .HasForeignKey(d => d.CodigoJari)
                    .HasConstraintName("frklInfracaoRecurso_JARI");

                entity.HasOne(d => d.CodigoJarisessaoJulgamentoNavigation)
                    .WithMany(p => p.TblInfracaoRecurso)
                    .HasForeignKey(d => d.CodigoJarisessaoJulgamento)
                    .HasConstraintName("frkInfracaoRecurso_JARISessaoJulgamento");

                entity.HasOne(d => d.CodigoSistemaUsuarioEmVistasNavigation)
                    .WithMany(p => p.TblInfracaoRecursoCodigoSistemaUsuarioEmVistasNavigation)
                    .HasForeignKey(d => d.CodigoSistemaUsuarioEmVistas)
                    .HasConstraintName("frkInfracaoRecurso_SistemaUsuarioEmVistas");

                entity.HasOne(d => d.CodigoSistemaUsuarioInstrucaoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoCodigoSistemaUsuarioInstrucaoNavigation)
                    .HasForeignKey(d => d.CodigoSistemaUsuarioInstrucao)
                    .HasConstraintName("frkInfracaoRecurso_SistemaUsuarioInstrucao");

                entity.HasOne(d => d.CodigoSistemaUsuarioRelatoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoCodigoSistemaUsuarioRelatoNavigation)
                    .HasForeignKey(d => d.CodigoSistemaUsuarioRelato)
                    .HasConstraintName("frkInfracaoRecurso_SistemaUsuarioRelato");

                entity.HasOne(d => d.CodigoSistemaUsuarioRevisaoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoCodigoSistemaUsuarioRevisaoNavigation)
                    .HasForeignKey(d => d.CodigoSistemaUsuarioRevisao)
                    .HasConstraintName("frkInfracaoRecurso_SistemaUsuarioRevisao");
            });

            modelBuilder.Entity<TblInfracaoRecursoAlegacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoAlegacao)
                    .HasName("prkInfracaoRecursoAlegacao");

                entity.ToTable("tblInfracaoRecursoAlegacao");

                entity.Property(e => e.Conteudo)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoRecursoAlegacaoEnquadramento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoAlegacaoEnquadramento)
                    .HasName("prkInfracaoRecursoAlegacaoEnquadramento");

                entity.ToTable("tblInfracaoRecursoAlegacaoEnquadramento");

                entity.HasOne(d => d.CodigoInfracaoEnquadramentoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoAlegacaoEnquadramento)
                    .HasForeignKey(d => d.CodigoInfracaoEnquadramento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecursoAlegacaoEnquadramento_InfracaoEnquadramento");

                entity.HasOne(d => d.CodigoInfracaoRecursoAlegacaoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoAlegacaoEnquadramento)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoAlegacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecursoAlegacaoEnquadramento_InfracaoRecursoAlegacao");
            });

            modelBuilder.Entity<TblInfracaoRecursoAnaliseJulgamentoJari>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoAnaliseJulgamentoJari)
                    .HasName("prkInfracaoRecursoAnaliseJulgamentoJARI");

                entity.ToTable("tblInfracaoRecursoAnaliseJulgamentoJARI");

                entity.HasIndex(e => e.CodigoInfracaoRecurso)
                    .HasName("idxInfracaoRecursoAnaliseJulgamentoJARI");

                entity.Property(e => e.CodigoInfracaoRecursoAnaliseJulgamentoJari).HasColumnName("CodigoInfracaoRecursoAnaliseJulgamentoJARI");

                entity.Property(e => e.CodigoInfracaoRecursoAnaliseJulgamentoJarisituacao).HasColumnName("CodigoInfracaoRecursoAnaliseJulgamentoJARISituacao");

                entity.Property(e => e.DataAnalise).HasColumnType("datetime");

                entity.Property(e => e.IndicadorAcompanharDecisaoJari).HasColumnName("IndicadorAcompanharDecisaoJARI");

                entity.Property(e => e.NomeSistemaUsuarioAnalise)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoInfracaoRecursoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoAnaliseJulgamentoJari)
                    .HasForeignKey(d => d.CodigoInfracaoRecurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecursoAnaliseJulgamentoJARI_InfracaoRecurso");

                entity.HasOne(d => d.CodigoInfracaoRecursoAnaliseJulgamentoJarisituacaoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoAnaliseJulgamentoJari)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoAnaliseJulgamentoJarisituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecursoAnaliseJulgamentoJARI_InfracaoRecursoAnaliseJulgamentoJARISituacao");

                entity.HasOne(d => d.CodigoSistemaUsuarioEmAnaliseNavigation)
                    .WithMany(p => p.TblInfracaoRecursoAnaliseJulgamentoJari)
                    .HasForeignKey(d => d.CodigoSistemaUsuarioEmAnalise)
                    .HasConstraintName("frkInfracaoRecursoAnaliseJulgamentoJARI_SistemaUsuario");
            });

            modelBuilder.Entity<TblInfracaoRecursoAnaliseJulgamentoJarievento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoAnaliseJulgamentoJarievento)
                    .HasName("prkInfracaoRecursoAnaliseJulgamentoJARIEvento");

                entity.ToTable("tblInfracaoRecursoAnaliseJulgamentoJARIEvento");

                entity.HasIndex(e => e.CodigoInfracaoRecursoAnaliseJulgamentoJari)
                    .HasName("idxInfracaoRecursoAnaliseJulgamentoJARIEvento");

                entity.Property(e => e.CodigoInfracaoRecursoAnaliseJulgamentoJarievento).HasColumnName("CodigoInfracaoRecursoAnaliseJulgamentoJARIEvento");

                entity.Property(e => e.CodigoInfracaoRecursoAnaliseJulgamentoJari).HasColumnName("CodigoInfracaoRecursoAnaliseJulgamentoJARI");

                entity.Property(e => e.CodigoInfracaoRecursoAnaliseJulgamentoJarisituacao).HasColumnName("CodigoInfracaoRecursoAnaliseJulgamentoJARISituacao");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoRecursoAnaliseJulgamentoJariNavigation)
                    .WithMany(p => p.TblInfracaoRecursoAnaliseJulgamentoJarievento)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoAnaliseJulgamentoJari)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecursoAnaliseJulgamentoJARIEvento_InfracaoRecursoAnaliseJulgamentoJARI");

                entity.HasOne(d => d.CodigoInfracaoRecursoAnaliseJulgamentoJarisituacaoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoAnaliseJulgamentoJarievento)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoAnaliseJulgamentoJarisituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecursoAnaliseJulgamentoJARIEvento_InfracaoRecursoAnaliseJulgamentoJARISituacao");
            });

            modelBuilder.Entity<TblInfracaoRecursoAnaliseJulgamentoJarisituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoAnaliseJulgamentoJarisituacao)
                    .HasName("prkInfracaoRecursoAnaliseJulgamentoJARISituacao");

                entity.ToTable("tblInfracaoRecursoAnaliseJulgamentoJARISituacao");

                entity.Property(e => e.CodigoInfracaoRecursoAnaliseJulgamentoJarisituacao)
                    .HasColumnName("CodigoInfracaoRecursoAnaliseJulgamentoJARISituacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoRecursoArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoArquivo)
                    .HasName("prkInfracaoRecursoArquivo");

                entity.ToTable("tblInfracaoRecursoArquivo");

                entity.HasIndex(e => e.CodigoInfracaoRecurso)
                    .HasName("idxInfracaoRecursoArquivo");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacaoCaixa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoRecursoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoArquivo)
                    .HasForeignKey(d => d.CodigoInfracaoRecurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecursoArquivo_InfracaoRecurso");
            });

            modelBuilder.Entity<TblInfracaoRecursoCausaNaoConhecer>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoCausaNaoConhecer)
                    .HasName("prkInfracaoRecursoCausaNaoConhecer");

                entity.ToTable("tblInfracaoRecursoCausaNaoConhecer");

                entity.Property(e => e.CodigoInfracaoRecursoCausaNaoConhecer).ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoRecursoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoEvento)
                    .HasName("prkInfracaoRecursoEvento");

                entity.ToTable("tblInfracaoRecursoEvento");

                entity.HasIndex(e => new { e.CodigoInfracaoRecurso, e.Data })
                    .HasName("idxInfracaoRecursoEvento");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoRecursoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoRecurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecursoEvento_InfracaoRecurso");

                entity.HasOne(d => d.CodigoInfracaoRecursoFaseNavigation)
                    .WithMany(p => p.TblInfracaoRecursoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecursoEvento_InfracaoRecursoFase");

                entity.HasOne(d => d.CodigoInfracaoRecursoSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecursoEvento_InfracaoRecursoSituacao");
            });

            modelBuilder.Entity<TblInfracaoRecursoFase>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoFase)
                    .HasName("prkInfracaoRecursoFase");

                entity.ToTable("tblInfracaoRecursoFase");

                entity.Property(e => e.CodigoInfracaoRecursoFase).ValueGeneratedNever();

                entity.Property(e => e.IndicadorSegundaInstanciaContran).HasColumnName("IndicadorSegundaInstanciaCONTRAN");

                entity.Property(e => e.IndicadorSegundaInstanciaJari).HasColumnName("IndicadorSegundaInstanciaJARI");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoRecursoFundamentacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoFundamentacao)
                    .HasName("prkInfracaoRecursoFundamentacao");

                entity.ToTable("tblInfracaoRecursoFundamentacao");

                entity.Property(e => e.Conteudo)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoRecursoFundamentacaoEnquadramento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoFundamentacaoEnquadramento)
                    .HasName("prkInfracaoRecursoFundamentacaoEnquadramento");

                entity.ToTable("tblInfracaoRecursoFundamentacaoEnquadramento");

                entity.HasOne(d => d.CodigoInfracaoEnquadramentoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoFundamentacaoEnquadramento)
                    .HasForeignKey(d => d.CodigoInfracaoEnquadramento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecursoFundamentacaoEnquadramento_InfracaoEnquadramento");

                entity.HasOne(d => d.CodigoInfracaoRecursoFundamentacaoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoFundamentacaoEnquadramento)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoFundamentacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecursoFundamentacaoEnquadramento_InfracaoRecursoFundamentacao");
            });

            modelBuilder.Entity<TblInfracaoRecursoIndicadorAdmissibilidade>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoIndicadorAdmissibilidade)
                    .HasName("prkInfracaoRecursoIndicadorAdmissibilidade");

                entity.ToTable("tblInfracaoRecursoIndicadorAdmissibilidade");

                entity.Property(e => e.CodigoInfracaoRecursoIndicadorAdmissibilidade).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoRecursoIndicadorMerito>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoIndicadorMerito)
                    .HasName("prkInfracaoRecursoIndicadorMerito");

                entity.ToTable("tblInfracaoRecursoIndicadorMerito");

                entity.Property(e => e.CodigoInfracaoRecursoIndicadorMerito).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoRecursoIndicadorRecorrente>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoIndicadorRecorrente)
                    .HasName("prkInfracaoRecursoIndicadorRecorrente");

                entity.ToTable("tblInfracaoRecursoIndicadorRecorrente");

                entity.Property(e => e.CodigoInfracaoRecursoIndicadorRecorrente).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoRecursoIndicadorResultado>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoIndicadorResultado)
                    .HasName("prkInfracaoRecursoIndicadorResultado");

                entity.ToTable("tblInfracaoRecursoIndicadorResultado");

                entity.Property(e => e.CodigoInfracaoRecursoIndicadorResultado).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoRecursoInstrucaoNaoConhecer>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoInstrucaoNaoConhecer)
                    .HasName("prkInfracaoRecursoInstrucaoNaoConhecer");

                entity.ToTable("tblInfracaoRecursoInstrucaoNaoConhecer");

                entity.HasIndex(e => new { e.CodigoInfracaoRecursoCausaNaoConhecer, e.CodigoInfracaoRecurso })
                    .HasName("idxInfracaoRecursoInstrucaoNaoConhecer");

                entity.HasOne(d => d.CodigoInfracaoRecursoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoInstrucaoNaoConhecer)
                    .HasForeignKey(d => d.CodigoInfracaoRecurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecursoInstrucaoNaoConhecer_InfracaoRecurso");

                entity.HasOne(d => d.CodigoInfracaoRecursoCausaNaoConhecerNavigation)
                    .WithMany(p => p.TblInfracaoRecursoInstrucaoNaoConhecer)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoCausaNaoConhecer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecursoInstrucaoNaoConhecer_InfracaoRecursoCausaNaoConhecer");
            });

            modelBuilder.Entity<TblInfracaoRecursoOrigem>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoOrigem)
                    .HasName("prkInfracaoRecursoOrigem");

                entity.ToTable("tblInfracaoRecursoOrigem");

                entity.Property(e => e.CodigoInfracaoRecursoOrigem).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoRecursoRelatoNaoConhecer>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoRelatoNaoConhecer)
                    .HasName("prkInfracaoRecursoRelatoNaoConhecer");

                entity.ToTable("tblInfracaoRecursoRelatoNaoConhecer");

                entity.HasIndex(e => new { e.CodigoInfracaoRecursoCausaNaoConhecer, e.CodigoInfracaoRecurso })
                    .HasName("idxInfracaoRecursoRelatoNaoConhecer");

                entity.HasOne(d => d.CodigoInfracaoRecursoNavigation)
                    .WithMany(p => p.TblInfracaoRecursoRelatoNaoConhecer)
                    .HasForeignKey(d => d.CodigoInfracaoRecurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecursoRelatoNaoConhecer_InfracaoRecurso");

                entity.HasOne(d => d.CodigoInfracaoRecursoCausaNaoConhecerNavigation)
                    .WithMany(p => p.TblInfracaoRecursoRelatoNaoConhecer)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoCausaNaoConhecer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoRecursoRelatoNaoConhecer_InfracaoRecursoCausaNaoConhecer");
            });

            modelBuilder.Entity<TblInfracaoRecursoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoSituacao);

                entity.ToTable("tblInfracaoRecursoSituacao");

                entity.Property(e => e.CodigoInfracaoRecursoSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoRecursoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoRecursoTipo)
                    .HasName("prkInfracaoRecursoTipo");

                entity.ToTable("tblInfracaoRecursoTipo");

                entity.Property(e => e.CodigoInfracaoRecursoTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OrgaoJulgador)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSituacao)
                    .HasName("prkInfracaoSituacao");

                entity.ToTable("tblInfracaoSituacao");

                entity.Property(e => e.CodigoInfracaoSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoAdvertencia>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoAdvertencia)
                    .HasName("prkInfracaoSolicitacaoAdvertencia");

                entity.ToTable("tblInfracaoSolicitacaoAdvertencia");

                entity.HasIndex(e => new { e.CodigoInfracao, e.NumeroProcesso })
                    .HasName("idxInfracaoSolicitacaoAdvertencia_InfracaoProcesso")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodigoInfracaoSolicitacaoAdvertencia, e.CodigoInfracao, e.CodigoInfracaoSolicitacaoAdvertenciaSituacao, e.CodigoInfracaoSolicitacaoAdvertenciaFase })
                    .HasName("idxInfracaoSolicitacaoAdvertencia_SituacaoFase");

                entity.HasIndex(e => new { e.CodigoInfracaoSolicitacaoAdvertenciaSituacao, e.CodigoInfracaoSolicitacaoAdvertenciaFase, e.CodigoInfracaoSolicitacaoAdvertenciaIndicadorResultadoJulgamento, e.CodigoInfracao })
                    .HasName("IdxInfracaoSolicitacaoAdvertencia_Infracao");

                entity.HasIndex(e => new { e.CodigoInfracaoSolicitacaoAdvertencia, e.CodigoInfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidade, e.CodigoInfracaoSolicitacaoAdvertenciaIndicadorMerito, e.DataProtocolo, e.DataInstrucao, e.NumeroAuto, e.DataInfracao, e.CodigoSistemaUsuarioInstrucao, e.CodigoInfracaoSolicitacaoAdvertenciaSituacao, e.CodigoInfracaoSolicitacaoAdvertenciaFase })
                    .HasName("idxInfracaoSolicitacaoAdvertencia_InstrucaoDistribuicao");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataCadastroDetran)
                    .HasColumnName("DataCadastroDETRAN")
                    .HasColumnType("date");

                entity.Property(e => e.DataCadastroDnit)
                    .HasColumnName("DataCadastroDNIT")
                    .HasColumnType("date");

                entity.Property(e => e.DataCancelamento).HasColumnType("date");

                entity.Property(e => e.DataInfracao).HasColumnType("date");

                entity.Property(e => e.DataInstrucao).HasColumnType("date");

                entity.Property(e => e.DataJulgamento).HasColumnType("date");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.IndicadorRegistroRenainf).HasColumnName("IndicadorRegistroRENAINF");

                entity.Property(e => e.InstrucaoFundamentacao).IsUnicode(false);

                entity.Property(e => e.NumeroAuto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroProcesso)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrazoJulgamento).HasColumnType("date");

                entity.Property(e => e.RecorrenteNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecorrenteNumeroCpfcnpj)
                    .HasColumnName("RecorrenteNumeroCPFCNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.RecorrenteNumeroCpfcnpjformatado)
                    .HasColumnName("RecorrenteNumeroCPFCNPJFormatado")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.VeiculoPlaca)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.VeiculoPlacaUf)
                    .IsRequired()
                    .HasColumnName("VeiculoPlacaUF")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoAdvertencia)
                    .HasForeignKey(d => d.CodigoInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoAdvertencia_Infracao");

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoAdvertenciaFaseNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoAdvertencia)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoAdvertenciaFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoAdvertencia_InfracaoSolicitacaoAdvertenciaFase");

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidadeNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoAdvertencia)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidade)
                    .HasConstraintName("frkInfracaoSolicitacaoAdvertencia_InfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidade");

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoAdvertenciaIndicadorMeritoNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoAdvertencia)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoAdvertenciaIndicadorMerito)
                    .HasConstraintName("frkInfracaoSolicitacaoAdvertencia_InfracaoSolicitacaoAdvertenciaIndicadorMerito");

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoAdvertenciaIndicadorRecorrenteNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoAdvertencia)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoAdvertenciaIndicadorRecorrente)
                    .HasConstraintName("frkInfracaoSolicitacaoAdvertencia_InfracaoSolicitacaoAdvertenciaIndicadorRecorrente");

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoAdvertenciaIndicadorResultadoJulgamentoNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoAdvertencia)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoAdvertenciaIndicadorResultadoJulgamento)
                    .HasConstraintName("frkInfracaoSolicitacaoAdvertencia_InfracaoSolicitacaoAdvertenciaIndicadorResultado");

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoAdvertenciaOrigemNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoAdvertencia)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoAdvertenciaOrigem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoAdvertencia_InfracaoSolicitacaoAdvertenciaOrigem");

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoAdvertenciaSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoAdvertencia)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoAdvertenciaSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoAdvertencia_InfracaoSolicitacaoAdvertenciaSituacao");

                entity.HasOne(d => d.CodigoSistemaUsuarioEmInstrucaoNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoAdvertencia)
                    .HasForeignKey(d => d.CodigoSistemaUsuarioInstrucao)
                    .HasConstraintName("frkInfracaoSolicitacaoAdvertencia_SistemaUsuarioEmInstrucao");
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoAdvertenciaArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoAdvertenciaArquivo)
                    .HasName("prkInfracaoSolicitacaoAdvertenciaArquivo");

                entity.ToTable("tblInfracaoSolicitacaoAdvertenciaArquivo");

                entity.HasIndex(e => e.CodigoInfracaoSolicitacaoAdvertencia)
                    .HasName("idxInfracaoSolicitacaoAdvertenciaArquivo");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacaoCaixa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoAdvertenciaNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoAdvertenciaArquivo)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoAdvertencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoAdvertenciaArquivo_InfracaoSolicitacaoAdvertencia");
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoAdvertenciaCausaNaoConhecer>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoAdvertenciaCausaNaoConhecer)
                    .HasName("prkInfracaoSolicitacaoAdvertenciaCausaNaoConhecer");

                entity.ToTable("tblInfracaoSolicitacaoAdvertenciaCausaNaoConhecer");

                entity.Property(e => e.CodigoInfracaoSolicitacaoAdvertenciaCausaNaoConhecer).ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoAdvertenciaEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoAdvertenciaEvento)
                    .HasName("prkInfracaoSolicitacaoAdvertenciaEvento");

                entity.ToTable("tblInfracaoSolicitacaoAdvertenciaEvento");

                entity.HasIndex(e => new { e.CodigoInfracaoSolicitacaoAdvertencia, e.Data })
                    .HasName("idxInfracaoSolicitacaoAdvertenciaEvento");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoAdvertenciaNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoAdvertenciaEvento)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoAdvertencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoAdvertenciaEvento_InfracaoSolicitacaoAdvertencia");

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoAdvertenciaFaseNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoAdvertenciaEvento)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoAdvertenciaFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoAdvertenciaEvento_InfracaoSolicitacaoAdvertenciaFase");

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoAdvertenciaSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoAdvertenciaEvento)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoAdvertenciaSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoAdvertenciaEvento_InfracaoSolicitacaoAdvertenciaSituacao");
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoAdvertenciaFase>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoAdvertenciaFase)
                    .HasName("prkInfracaoSolicitacaoAdvertenciaFase");

                entity.ToTable("tblInfracaoSolicitacaoAdvertenciaFase");

                entity.Property(e => e.CodigoInfracaoSolicitacaoAdvertenciaFase).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoAdvertenciaFundamentacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoAdvertenciaFundamentacao)
                    .HasName("prkInfracaoSolicitacaoAdvertenciaFundamentacao");

                entity.ToTable("tblInfracaoSolicitacaoAdvertenciaFundamentacao");

                entity.Property(e => e.Conteudo)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidade>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidade)
                    .HasName("prkInfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidade");

                entity.ToTable("tblInfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidade");

                entity.Property(e => e.CodigoInfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidade).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoAdvertenciaIndicadorMerito>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoAdvertenciaIndicadorMerito)
                    .HasName("prkInfracaoSolicitacaoAdvertenciaIndicadorMerito");

                entity.ToTable("tblInfracaoSolicitacaoAdvertenciaIndicadorMerito");

                entity.Property(e => e.CodigoInfracaoSolicitacaoAdvertenciaIndicadorMerito).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoAdvertenciaIndicadorRecorrente>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoAdvertenciaIndicadorRecorrente)
                    .HasName("prkInfracaoSolicitacaoAdvertenciaIndicadorRecorrente");

                entity.ToTable("tblInfracaoSolicitacaoAdvertenciaIndicadorRecorrente");

                entity.Property(e => e.CodigoInfracaoSolicitacaoAdvertenciaIndicadorRecorrente).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoAdvertenciaIndicadorResultado>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoAdvertenciaIndicadorResultado)
                    .HasName("prkInfracaoSolicitacaoAdvertenciaIndicadorResultado");

                entity.ToTable("tblInfracaoSolicitacaoAdvertenciaIndicadorResultado");

                entity.Property(e => e.CodigoInfracaoSolicitacaoAdvertenciaIndicadorResultado).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoAdvertenciaNaoConhecer>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoAdvertenciaNaoConhecer)
                    .HasName("prkInfracaoSolicitacaoAdvertenciaNaoConhecer");

                entity.ToTable("tblInfracaoSolicitacaoAdvertenciaNaoConhecer");

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoAdvertenciaNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoAdvertenciaNaoConhecer)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoAdvertencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoAdvertenciaNaoConhecer_InfracaoSolicitacaoAdvertencia");

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoAdvertenciaCausaNaoConhecerNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoAdvertenciaNaoConhecer)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoAdvertenciaCausaNaoConhecer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoAdvertenciaNaoConhecer_InfracaoSolicitacaoAdvertenciaCausaNaoConhecer");
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoAdvertenciaOrigem>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoAdvertenciaOrigem)
                    .HasName("prkInfracaoSolicitacaoAdvertenciaOrigem");

                entity.ToTable("tblInfracaoSolicitacaoAdvertenciaOrigem");

                entity.Property(e => e.CodigoInfracaoSolicitacaoAdvertenciaOrigem).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoAdvertenciaSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoAdvertenciaSituacao)
                    .HasName("prkInfracaoSolicitacaoAdvertenciaSituacao");

                entity.ToTable("tblInfracaoSolicitacaoAdvertenciaSituacao");

                entity.Property(e => e.CodigoInfracaoSolicitacaoAdvertenciaSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoCancelamento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoCancelamento)
                    .HasName("prkInfracaoSolicitacaoCancelamento");

                entity.ToTable("tblInfracaoSolicitacaoCancelamento");

                entity.Property(e => e.DataAnalise).HasColumnType("datetime");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSolicitante)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSolicitacao)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoCancelamentoMotivoNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoCancelamento)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoCancelamentoMotivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoCancelamento_InfracaoSolicitacaoCancelamentoMotivo");

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoCancelamentoSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoCancelamento)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoCancelamentoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoCancelamento_InfracaoSolicitacaoCancelamentoSituacao");

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoCancelamentoTipoNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoCancelamento)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoCancelamentoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoCancelamento_InfracaoSolicitacaoCancelamentoTipo");
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoCancelamentoArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoCancelamentoArquivo)
                    .HasName("prkInfracaoSolicitacaoCancelamentoArquivo");

                entity.ToTable("tblInfracaoSolicitacaoCancelamentoArquivo");

                entity.HasIndex(e => e.CodigoInfracaoSolicitacaoCancelamento)
                    .HasName("idxInfracaoSolicitacaoCancelamentoArquivo");

                entity.Property(e => e.ArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoCancelamentoNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoCancelamentoArquivo)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoCancelamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoCancelamentoArquivo_InfracaoSolicitacaoCancelamento");
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoCancelamentoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoCancelamentoEvento)
                    .HasName("prkInfracaoSolicitacaoCancelamentoEvento");

                entity.ToTable("tblInfracaoSolicitacaoCancelamentoEvento");

                entity.HasIndex(e => new { e.CodigoInfracaoSolicitacaoCancelamento, e.Data })
                    .HasName("idxInfracaoSolicitacaoCancelamentoEvento");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoCancelamentoNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoCancelamentoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoCancelamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoCancelamentoEvento_InfracaoSolicitacaoCancelamento");

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoCancelamentoSituacaoNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoCancelamentoEvento)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoCancelamentoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoCancelamentoEvento_InfracaoSolicitacaoCancelamentoSituacao");
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoCancelamentoInfracao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoCancelamentoInfracao)
                    .HasName("prkInfracaoSolicitacaoCancelamentoInfracao");

                entity.ToTable("tblInfracaoSolicitacaoCancelamentoInfracao");

                entity.HasIndex(e => e.CodigoInfracao)
                    .HasName("idxInfracaoSolicitacaoCancelamentoInfracao_Cadastro_PesquisaInfracao");

                entity.HasIndex(e => new { e.CodigoInfracaoSolicitacaoCancelamento, e.CodigoInfracao })
                    .HasName("idxInfracaoSolicitacaoCancelamentoInfracao");

                entity.Property(e => e.NumeroAuto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoCancelamentoInfracao)
                    .HasForeignKey(d => d.CodigoInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoCancelamentoInfracao_Infracao");

                entity.HasOne(d => d.CodigoInfracaoNotificacaoTipoNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoCancelamentoInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoNotificacaoTipo)
                    .HasConstraintName("frkInfracaoSolicitacaoCancelamentoInfracao_InfracaoNotificacaoTipo");

                entity.HasOne(d => d.CodigoInfracaoSolicitacaoCancelamentoNavigation)
                    .WithMany(p => p.TblInfracaoSolicitacaoCancelamentoInfracao)
                    .HasForeignKey(d => d.CodigoInfracaoSolicitacaoCancelamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkInfracaoSolicitacaoCancelamentoInfracao_InfracaoSolicitacaoCancelamento");
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoCancelamentoMotivo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoCancelamentoMotivo);

                entity.ToTable("tblInfracaoSolicitacaoCancelamentoMotivo");

                entity.Property(e => e.CodigoInfracaoSolicitacaoCancelamentoMotivo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoCancelamentoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoCancelamentoSituacao)
                    .HasName("prkInfracaoSolicitacaoCancelamentoSituacao");

                entity.ToTable("tblInfracaoSolicitacaoCancelamentoSituacao");

                entity.Property(e => e.CodigoInfracaoSolicitacaoCancelamentoSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoSolicitacaoCancelamentoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoSolicitacaoCancelamentoTipo)
                    .HasName("prkInfracaoSolicitacaoCancelamentoTipo");

                entity.ToTable("tblInfracaoSolicitacaoCancelamentoTipo");

                entity.Property(e => e.CodigoInfracaoSolicitacaoCancelamentoTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblInfracaoTransportador>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoTransportador)
                    .HasName("prkInfracaoTransportador");

                entity.ToTable("tblInfracaoTransportador");

                entity.Property(e => e.CodigoRenavamtipoDocumentoEmbarcadorTransportador).HasColumnName("CodigoRENAVAMTipoDocumentoEmbarcadorTransportador");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCpfcnpj)
                    .IsRequired()
                    .HasColumnName("NumeroCPFCNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCpfcnpjformatado)
                    .IsRequired()
                    .HasColumnName("NumeroCPFCNPJFormatado")
                    .HasMaxLength(18)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoVeiculo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoVeiculo)
                    .HasName("prkInfracaoVeiculo");

                entity.ToTable("tblInfracaoVeiculo");

                entity.HasIndex(e => new { e.CodigoInfracaoVeiculo, e.CodigoUfjurisdicao, e.Placa })
                    .HasName("idxInfracaoVeiculo_Placa");

                entity.Property(e => e.CodigoRenavamindicadorRestricaoRenajud).HasColumnName("CodigoRENAVAMIndicadorRestricaoRENAJUD");

                entity.Property(e => e.CodigoRenavamindicadorRestricaoRenavam).HasColumnName("CodigoRENAVAMIndicadorRestricaoRENAVAM");

                entity.Property(e => e.CodigoRenavamindicadorRestricaoRenavam1).HasColumnName("CodigoRENAVAMIndicadorRestricaoRENAVAM1");

                entity.Property(e => e.CodigoRenavamindicadorRestricaoRenavam2).HasColumnName("CodigoRENAVAMIndicadorRestricaoRENAVAM2");

                entity.Property(e => e.CodigoRenavamindicadorRestricaoRenavam3).HasColumnName("CodigoRENAVAMIndicadorRestricaoRENAVAM3");

                entity.Property(e => e.CodigoRenavamindicadorRestricaoRenavam4).HasColumnName("CodigoRENAVAMIndicadorRestricaoRENAVAM4");

                entity.Property(e => e.CodigoRenavamindicadorRouboFurtoRenavam).HasColumnName("CodigoRENAVAMIndicadorRouboFurtoRENAVAM");

                entity.Property(e => e.CodigoRenavammarcaModeloVeiculo).HasColumnName("CodigoRENAVAMMarcaModeloVeiculo");

                entity.Property(e => e.CodigoRenavammunicipioEmplacamento).HasColumnName("CodigoRENAVAMMunicipioEmplacamento");

                entity.Property(e => e.CodigoRenavampaisVeiculoPlacaEstrangeira).HasColumnName("CodigoRENAVAMPaisVeiculoPlacaEstrangeira");

                entity.Property(e => e.CodigoRenavamtipoVeiculo).HasColumnName("CodigoRENAVAMTipoVeiculo");

                entity.Property(e => e.CodigoRenavamveiculoCarroceria).HasColumnName("CodigoRENAVAMVeiculoCarroceria");

                entity.Property(e => e.CodigoRenavamveiculoCategoria).HasColumnName("CodigoRENAVAMVeiculoCategoria");

                entity.Property(e => e.CodigoRenavamveiculoCor).HasColumnName("CodigoRENAVAMVeiculoCor");

                entity.Property(e => e.CodigoRenavamveiculoEspecie).HasColumnName("CodigoRENAVAMVeiculoEspecie");

                entity.Property(e => e.CodigoUfjurisdicao).HasColumnName("CodigoUFJurisdicao");

                entity.Property(e => e.NumeroCodigoRenavam).HasColumnName("NumeroCodigoRENAVAM");

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoVeiculoTipoNavigation)
                    .WithMany(p => p.TblInfracaoVeiculo)
                    .HasForeignKey(d => d.CodigoInfracaoVeiculoTipo)
                    .HasConstraintName("frkInfracaoVeiculo_InfracaoVeiculoTipo");

                entity.HasOne(d => d.CodigoUfjurisdicaoNavigation)
                    .WithMany(p => p.TblInfracaoVeiculo)
                    .HasForeignKey(d => d.CodigoUfjurisdicao)
                    .HasConstraintName("frkInfracaoVeiculo_BaseUF_Jurisdicao");
            });

            modelBuilder.Entity<TblInfracaoVeiculoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoVeiculoTipo)
                    .HasName("prkInfracaoVeiculoTipo");

                entity.ToTable("tblInfracaoVeiculoTipo");

                entity.Property(e => e.CodigoInfracaoVeiculoTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfracaoVelocidadeValorConsiderado>(entity =>
            {
                entity.HasKey(e => e.CodigoInfracaoVelocidadeValorConsiderado)
                    .HasName("prkInfracaoVelocidadeValorConsiderado");

                entity.ToTable("tblInfracaoVelocidadeValorConsiderado");

                entity.Property(e => e.CodigoInfracaoVelocidadeValorConsiderado).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblJari>(entity =>
            {
                entity.HasKey(e => e.CodigoJari)
                    .HasName("prkJARI");

                entity.ToTable("tblJARI");

                entity.Property(e => e.CodigoJari).HasColumnName("CodigoJARI");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoRenavammunicipio).HasColumnName("CodigoRENAVAMMunicipio");

                entity.Property(e => e.EnderecoBairro)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoCep)
                    .HasColumnName("EnderecoCEP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoComplemento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoLogradouro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoNumeroImovel)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MandatoDataInicio).HasColumnType("date");

                entity.Property(e => e.MandatoDataTermino).HasColumnType("date");

                entity.Property(e => e.MandatoPortaria)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblJari)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkJARI_BaseUF");
            });

            modelBuilder.Entity<TblJariarquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoJariarquivo)
                    .HasName("prkJARIArquivo");

                entity.ToTable("tblJARIArquivo");

                entity.Property(e => e.CodigoJariarquivo).HasColumnName("CodigoJARIArquivo");

                entity.Property(e => e.CodigoJari).HasColumnName("CodigoJARI");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoJariNavigation)
                    .WithMany(p => p.TblJariarquivo)
                    .HasForeignKey(d => d.CodigoJari)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkJARIArquivo_JARI");
            });

            modelBuilder.Entity<TblJariintegrante>(entity =>
            {
                entity.HasKey(e => e.CodigoJariintegrante)
                    .HasName("prkJARIIntegrante");

                entity.ToTable("tblJARIIntegrante");

                entity.HasIndex(e => e.CodigoJari)
                    .HasName("idxJARIIntegrante");

                entity.Property(e => e.CodigoJariintegrante).HasColumnName("CodigoJARIIntegrante");

                entity.Property(e => e.CodigoJari).HasColumnName("CodigoJARI");

                entity.Property(e => e.CodigoJariintegranteTipo).HasColumnName("CodigoJARIIntegranteTipo");

                entity.Property(e => e.CodigoJariintegranteVinculo).HasColumnName("CodigoJARIIntegranteVinculo");

                entity.HasOne(d => d.CodigoJariNavigation)
                    .WithMany(p => p.TblJariintegrante)
                    .HasForeignKey(d => d.CodigoJari)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkJARIIntegrante_JARI");

                entity.HasOne(d => d.CodigoJariintegranteTipoNavigation)
                    .WithMany(p => p.TblJariintegrante)
                    .HasForeignKey(d => d.CodigoJariintegranteTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkJARIIntegrante_JARIIntegranteTipo");

                entity.HasOne(d => d.CodigoJariintegranteVinculoNavigation)
                    .WithMany(p => p.TblJariintegrante)
                    .HasForeignKey(d => d.CodigoJariintegranteVinculo)
                    .HasConstraintName("frkJARIIntegrante_JARIIntegranteVinculo");

                entity.HasOne(d => d.CodigoSistemaUsuarioNavigation)
                    .WithMany(p => p.TblJariintegrante)
                    .HasForeignKey(d => d.CodigoSistemaUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkJARIIntegrante_SistemaUsuario");
            });

            modelBuilder.Entity<TblJariintegranteTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoJariintegranteTipo)
                    .HasName("prkJARIIntegranteTipo");

                entity.ToTable("tblJARIIntegranteTipo");

                entity.Property(e => e.CodigoJariintegranteTipo)
                    .HasColumnName("CodigoJARIIntegranteTipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblJariintegranteVinculo>(entity =>
            {
                entity.HasKey(e => e.CodigoJariintegranteVinculo)
                    .HasName("prkJARIIntegranteVinculo");

                entity.ToTable("tblJARIIntegranteVinculo");

                entity.Property(e => e.CodigoJariintegranteVinculo)
                    .HasColumnName("CodigoJARIIntegranteVinculo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblJarisessaoJulgamento>(entity =>
            {
                entity.HasKey(e => e.CodigoJarisessaoJulgamento)
                    .HasName("prkJARISessaoJulgamento");

                entity.ToTable("tblJARISessaoJulgamento");

                entity.Property(e => e.CodigoJarisessaoJulgamento).HasColumnName("CodigoJARISessaoJulgamento");

                entity.Property(e => e.CodigoJari).HasColumnName("CodigoJARI");

                entity.Property(e => e.CodigoJarisessaoJulgamentoSituacao).HasColumnName("CodigoJARISessaoJulgamentoSituacao");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataInicio).HasColumnType("date");

                entity.Property(e => e.DataTermino).HasColumnType("date");

                entity.Property(e => e.NumeroSessaoJulgamento)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoInfracaoRecursoTipoNavigation)
                    .WithMany(p => p.TblJarisessaoJulgamento)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frklJARISessaoJulgamento_InfracaoRecursoTipo");

                entity.HasOne(d => d.CodigoJariNavigation)
                    .WithMany(p => p.TblJarisessaoJulgamento)
                    .HasForeignKey(d => d.CodigoJari)
                    .HasConstraintName("frkJARISessaoJulgamento_JARI");

                entity.HasOne(d => d.CodigoJarisessaoJulgamentoSituacaoNavigation)
                    .WithMany(p => p.TblJarisessaoJulgamento)
                    .HasForeignKey(d => d.CodigoJarisessaoJulgamentoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkJARISessaoJulgamento_JARISessaoJulgamentoSituacao");
            });

            modelBuilder.Entity<TblJarisessaoJulgamentoArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoJarisessaoJulgamentoArquivo)
                    .HasName("prkJARISessaoJulgamentoArquivo");

                entity.ToTable("tblJARISessaoJulgamentoArquivo");

                entity.HasIndex(e => e.CodigoJarisessaoJulgamento)
                    .HasName("idxJARISessaoJulgamentoArquivo");

                entity.Property(e => e.CodigoJarisessaoJulgamentoArquivo).HasColumnName("CodigoJARISessaoJulgamentoArquivo");

                entity.Property(e => e.CodigoJarisessaoJulgamento).HasColumnName("CodigoJARISessaoJulgamento");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoJarisessaoJulgamentoNavigation)
                    .WithMany(p => p.TblJarisessaoJulgamentoArquivo)
                    .HasForeignKey(d => d.CodigoJarisessaoJulgamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkJARISessaoJulgamentoArquivo_JARISessaoJulgamento");
            });

            modelBuilder.Entity<TblJarisessaoJulgamentoColegiado>(entity =>
            {
                entity.HasKey(e => e.CodigoJarisessaoJulgamentoColegiado)
                    .HasName("prkJARISessaoJulgamentoColegiado");

                entity.ToTable("tblJARISessaoJulgamentoColegiado");

                entity.HasIndex(e => new { e.CodigoSistemaUsuario, e.CodigoJarisessaoJulgamento })
                    .HasName("idxJARISessaoJulgamentoColegiado");

                entity.Property(e => e.CodigoJarisessaoJulgamentoColegiado).HasColumnName("CodigoJARISessaoJulgamentoColegiado");

                entity.Property(e => e.CodigoJarisessaoJulgamento).HasColumnName("CodigoJARISessaoJulgamento");

                entity.HasOne(d => d.CodigoJarisessaoJulgamentoNavigation)
                    .WithMany(p => p.TblJarisessaoJulgamentoColegiado)
                    .HasForeignKey(d => d.CodigoJarisessaoJulgamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkJARISessaoJulgamentoColegiado_JARISessaoJulgamento");

                entity.HasOne(d => d.CodigoSistemaUsuarioNavigation)
                    .WithMany(p => p.TblJarisessaoJulgamentoColegiado)
                    .HasForeignKey(d => d.CodigoSistemaUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkJARISessaoJulgamentoColegiado_SistemaUsuario");
            });

            modelBuilder.Entity<TblJarisessaoJulgamentoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoJarisessaoJulgamentoEvento)
                    .HasName("prkJARISessaoJulgamentoEvento");

                entity.ToTable("tblJARISessaoJulgamentoEvento");

                entity.HasIndex(e => new { e.CodigoJarisessaoJulgamento, e.Data })
                    .HasName("idxJARISessaoJulgamentoEvento");

                entity.Property(e => e.CodigoJarisessaoJulgamentoEvento).HasColumnName("CodigoJARISessaoJulgamentoEvento");

                entity.Property(e => e.CodigoJarisessaoJulgamento).HasColumnName("CodigoJARISessaoJulgamento");

                entity.Property(e => e.CodigoJarisessaoJulgamentoSituacao).HasColumnName("CodigoJARISessaoJulgamentoSituacao");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoJarisessaoJulgamentoNavigation)
                    .WithMany(p => p.TblJarisessaoJulgamentoEvento)
                    .HasForeignKey(d => d.CodigoJarisessaoJulgamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkJARISessaoJulgamentoEvento_JARISessaoJulgamento");

                entity.HasOne(d => d.CodigoJarisessaoJulgamentoSituacaoNavigation)
                    .WithMany(p => p.TblJarisessaoJulgamentoEvento)
                    .HasForeignKey(d => d.CodigoJarisessaoJulgamentoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkJARISessaoJulgamentoEvento_JARISessaoJulgamentoSituacao");
            });

            modelBuilder.Entity<TblJarisessaoJulgamentoPauta>(entity =>
            {
                entity.HasKey(e => e.CodigoJarisessaoJulgamentoPauta)
                    .HasName("prkJARISessaoJulgamentoPauta");

                entity.ToTable("tblJARISessaoJulgamentoPauta");

                entity.HasIndex(e => new { e.CodigoJarisessaoJulgamento, e.CodigoInfracaoRecurso })
                    .HasName("idxJARISessaoJulgamentoPauta_Apuracao");

                entity.Property(e => e.CodigoJarisessaoJulgamentoPauta).HasColumnName("CodigoJARISessaoJulgamentoPauta");

                entity.Property(e => e.CodigoJarisessaoJulgamento).HasColumnName("CodigoJARISessaoJulgamento");

                entity.HasOne(d => d.CodigoInfracaoRecursoNavigation)
                    .WithMany(p => p.TblJarisessaoJulgamentoPauta)
                    .HasForeignKey(d => d.CodigoInfracaoRecurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkJARISessaoJulgamentoPauta_InfracaoRecurso");

                entity.HasOne(d => d.CodigoInfracaoRecursoIndicadorResultadoNavigation)
                    .WithMany(p => p.TblJarisessaoJulgamentoPauta)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoIndicadorResultado)
                    .HasConstraintName("frkJARISessaoJulgamentoPauta_InfracaoRecursoIndicadorResultado");

                entity.HasOne(d => d.CodigoJarisessaoJulgamentoNavigation)
                    .WithMany(p => p.TblJarisessaoJulgamentoPauta)
                    .HasForeignKey(d => d.CodigoJarisessaoJulgamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkARISessaoJulgamentoPauta_JARISessaoJulgamento");
            });

            modelBuilder.Entity<TblJarisessaoJulgamentoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoJarisessaoJulgamentoSituacao)
                    .HasName("prkJARISessaoJulgamentoSituacao");

                entity.ToTable("tblJARISessaoJulgamentoSituacao");

                entity.Property(e => e.CodigoJarisessaoJulgamentoSituacao)
                    .HasColumnName("CodigoJARISessaoJulgamentoSituacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblJarisessaoJulgamentoVoto>(entity =>
            {
                entity.HasKey(e => e.CodigoJarisessaoJulgamentoVoto)
                    .HasName("prkJARISessaoJulgamentoVoto");

                entity.ToTable("tblJARISessaoJulgamentoVoto");

                entity.HasIndex(e => new { e.CodigoJarisessaoJulgamento, e.CodigoSistemaUsuario })
                    .HasName("idxJARISessaoJulgamentoVoto_Julgamento");

                entity.HasIndex(e => new { e.CodigoInfracaoRecursoIndicadorResultado, e.CodigoJarisessaoJulgamento, e.CodigoInfracaoRecurso })
                    .HasName("idxJARISessaoJulgamentoVoto_Apuracao");

                entity.Property(e => e.CodigoJarisessaoJulgamentoVoto).HasColumnName("CodigoJARISessaoJulgamentoVoto");

                entity.Property(e => e.CodigoJarisessaoJulgamento).HasColumnName("CodigoJARISessaoJulgamento");

                entity.Property(e => e.DataVoto).HasColumnType("date");

                entity.Property(e => e.Fundamentacao).IsUnicode(false);

                entity.HasOne(d => d.CodigoInfracaoRecursoNavigation)
                    .WithMany(p => p.TblJarisessaoJulgamentoVoto)
                    .HasForeignKey(d => d.CodigoInfracaoRecurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkJARISessaoJulgamentoVoto_InfracaoRecurso");

                entity.HasOne(d => d.CodigoInfracaoRecursoIndicadorResultadoNavigation)
                    .WithMany(p => p.TblJarisessaoJulgamentoVoto)
                    .HasForeignKey(d => d.CodigoInfracaoRecursoIndicadorResultado)
                    .HasConstraintName("frkJARISessaoJulgamentoVoto_InfracaoRecursoIndicadorResultado");

                entity.HasOne(d => d.CodigoJarisessaoJulgamentoNavigation)
                    .WithMany(p => p.TblJarisessaoJulgamentoVoto)
                    .HasForeignKey(d => d.CodigoJarisessaoJulgamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkJARISessaoJulgamentoVoto_JARISessaoJulgamento");

                entity.HasOne(d => d.CodigoSistemaUsuarioNavigation)
                    .WithMany(p => p.TblJarisessaoJulgamentoVoto)
                    .HasForeignKey(d => d.CodigoSistemaUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkJARISessaoJulgamentoVoto_SistemaUsuario");
            });

            modelBuilder.Entity<TblPesagemEquipamento>(entity =>
            {
                entity.HasKey(e => e.CodigoPesagemEquipamento)
                    .HasName("prkPesagemEquipamentoAfericao");

                entity.ToTable("tblPesagemEquipamento");

                entity.HasIndex(e => e.CodigoEquipamentoDnit)
                    .HasName("unqEquipamentoDNIT")
                    .IsUnique();

                entity.Property(e => e.CodigoEquipamentoDnit)
                    .IsRequired()
                    .HasColumnName("CodigoEquipamentoDNIT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPesagemEquipamentoBalancaTipoNavigation)
                    .WithMany(p => p.TblPesagemEquipamento)
                    .HasForeignKey(d => d.CodigoPesagemEquipamentoBalancaTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPesagemEquipamento_PesagemEquipamentoBalancaTipo");
            });

            modelBuilder.Entity<TblPesagemEquipamentoBalancaTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoPesagemEquipamentoBalancaTipo)
                    .HasName("prkPesagemEquipamentoBalancaTipo");

                entity.ToTable("tblPesagemEquipamentoBalancaTipo");

                entity.Property(e => e.CodigoPesagemEquipamentoBalancaTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPesagemPosto>(entity =>
            {
                entity.HasKey(e => e.CodigoPesagemPosto)
                    .HasName("prkPesagemPosto");

                entity.ToTable("tblPesagemPosto");

                entity.HasIndex(e => e.CodigoIdentificacaoPosto)
                    .HasName("unqIdentificacaoPosto")
                    .IsUnique();

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoIdentificacaoPosto)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRenavammunicipio).HasColumnName("CodigoRENAVAMMunicipio");

                entity.Property(e => e.Quilometro).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.Sentido)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblPesagemPosto)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPesagemPosto_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblPesagemPosto)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPesagemPosto_BaseUF");

                entity.HasOne(d => d.CodigoPesagemEquipamentoBalancaTipoNavigation)
                    .WithMany(p => p.TblPesagemPosto)
                    .HasForeignKey(d => d.CodigoPesagemEquipamentoBalancaTipo)
                    .HasConstraintName("frkPesagemPosto_PesagemEquipamentoBalancaTipo");
            });

            modelBuilder.Entity<TblPesagemPostoEquipamento>(entity =>
            {
                entity.HasKey(e => e.CodigoPesagemPostoEquipamento)
                    .HasName("prkPesagemPostoEquipamento");

                entity.ToTable("tblPesagemPostoEquipamento");

                entity.HasOne(d => d.CodigoPesagemEquipamentoNavigation)
                    .WithMany(p => p.TblPesagemPostoEquipamento)
                    .HasForeignKey(d => d.CodigoPesagemEquipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPesagemPostoEquipamento_PesagemEquipamento");

                entity.HasOne(d => d.CodigoPesagemPostoNavigation)
                    .WithMany(p => p.TblPesagemPostoEquipamento)
                    .HasForeignKey(d => d.CodigoPesagemPosto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPesagemPostoEquipamento_PesagemPosto");
            });

            modelBuilder.Entity<TblPncvagenteTransitoAtividadeDesempenhada>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvagenteTransitoAtividadeDesempenhada)
                    .HasName("prkPNCVAgenteTransitoAtividadeDesempenhada")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVAgenteTransitoAtividadeDesempenhada");

                entity.Property(e => e.CodigoPncvagenteTransitoAtividadeDesempenhada).HasColumnName("CodigoPNCVAgenteTransitoAtividadeDesempenhada");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvagenteTransitoCredenciamento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvagenteTransitoCredenciamento)
                    .HasName("prkPNCVAgenteTransitoCredenciamento");

                entity.ToTable("tblPNCVAgenteTransitoCredenciamento");

                entity.Property(e => e.CodigoPncvagenteTransitoCredenciamento).HasColumnName("CodigoPNCVAgenteTransitoCredenciamento");

                entity.Property(e => e.CertificadoCursoArquivoNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CertificadoCursoArquivoNomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncvagenteTransitoCredenciamentoSituacao).HasColumnName("CodigoPNCVAgenteTransitoCredenciamentoSituacao");

                entity.Property(e => e.CodigoPncvagenteTransitoIndicadorTipoSanguineo).HasColumnName("CodigoPNCVAgenteTransitoIndicadorTipoSanguineo");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoCredenciamento).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoCredenciamento");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoDescredenciamento).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoDescredenciamento");

                entity.Property(e => e.CodigoRenavammunicipioNaturalidade).HasColumnName("CodigoRENAVAMMunicipioNaturalidade");

                entity.Property(e => e.CodigoUflotacao).HasColumnName("CodigoUFLotacao");

                entity.Property(e => e.CodigoUfnaturalidade).HasColumnName("CodigoUFNaturalidade");

                entity.Property(e => e.CodigoUforgaoExpedidor).HasColumnName("CodigoUFOrgaoExpedidor");

                entity.Property(e => e.DataNascimento).HasColumnType("date");

                entity.Property(e => e.DataPortaria).HasColumnType("date");

                entity.Property(e => e.DataPublicacaoPortariaDou)
                    .HasColumnName("DataPublicacaoPortariaDOU")
                    .HasColumnType("date");

                entity.Property(e => e.FotoArquivoNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FotoArquivoNomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IndicadorFatorRhpositivo).HasColumnName("IndicadorFatorRHPositivo");

                entity.Property(e => e.NomeCargo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeMae)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomePai)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PortariaArquivoNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PortariaArquivoNomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Rg)
                    .IsRequired()
                    .HasColumnName("RG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RgsiglaOrgaoExpedidor)
                    .IsRequired()
                    .HasColumnName("RGSiglaOrgaoExpedidor")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoPncvagenteTransitoCredenciamentoSituacaoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoCredenciamento)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoCredenciamentoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoCredenciamento_PNCVAgenteTransitoCredenciamentoSituacao");

                entity.HasOne(d => d.CodigoPncvagenteTransitoIndicadorTipoSanguineoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoCredenciamento)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoIndicadorTipoSanguineo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoCredenciamento_PNCVAgenteTransitoIndicadorTipoSanguineo");

                entity.HasOne(d => d.CodigoPncvagenteTransitoSolicitacaoCredenciamentoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoCredenciamento)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoSolicitacaoCredenciamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoCredenciamento_PNCVAgenteTransitoSolicitacaoCredenciamento");

                entity.HasOne(d => d.CodigoPncvagenteTransitoSolicitacaoDescredenciamentoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoCredenciamento)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoSolicitacaoDescredenciamento)
                    .HasConstraintName("frkPNCVAgenteTransitoCredenciamento_AgenteTransitoSolicitacaoDescredenciamento");

                entity.HasOne(d => d.CodigoSistemaUsuarioNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoCredenciamento)
                    .HasForeignKey(d => d.CodigoSistemaUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoCredenciamento_SistemaUsuario");

                entity.HasOne(d => d.CodigoUflotacaoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoCredenciamentoCodigoUflotacaoNavigation)
                    .HasForeignKey(d => d.CodigoUflotacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoCredenciamento_BaseUFLotacao");

                entity.HasOne(d => d.CodigoUfnaturalidadeNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoCredenciamentoCodigoUfnaturalidadeNavigation)
                    .HasForeignKey(d => d.CodigoUfnaturalidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoCredenciamento_BaseUFNaturalidade");

                entity.HasOne(d => d.CodigoUforgaoExpedidorNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoCredenciamentoCodigoUforgaoExpedidorNavigation)
                    .HasForeignKey(d => d.CodigoUforgaoExpedidor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoCredenciamento_BaseUFOrgaoExpedidor");
            });

            modelBuilder.Entity<TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvagenteTransitoCredenciamentoAtividadeDesempenhada)
                    .HasName("prkPNCVAgenteTransitoCredenciamentoAtividadeDesempenhada");

                entity.ToTable("tblPNCVAgenteTransitoCredenciamentoAtividadeDesempenhada");

                entity.Property(e => e.CodigoPncvagenteTransitoCredenciamentoAtividadeDesempenhada).HasColumnName("CodigoPNCVAgenteTransitoCredenciamentoAtividadeDesempenhada");

                entity.Property(e => e.CodigoPncvagenteTransitoAtividadeDesempenhada).HasColumnName("CodigoPNCVAgenteTransitoAtividadeDesempenhada");

                entity.Property(e => e.CodigoPncvagenteTransitoCredenciamento).HasColumnName("CodigoPNCVAgenteTransitoCredenciamento");

                entity.HasOne(d => d.CodigoPncvagenteTransitoAtividadeDesempenhadaNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoAtividadeDesempenhada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoCredenciamentoAtividadeDesempenhada_PNCVAgenteTransitoAtividadeDesempenhada");

                entity.HasOne(d => d.CodigoPncvagenteTransitoCredenciamentoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoCredenciamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoCredenciamentoAtividadeDesempenhada_PNCVAgenteTransitoCredenciamento");
            });

            modelBuilder.Entity<TblPncvagenteTransitoCredenciamentoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvagenteTransitoCredenciamentoEvento)
                    .HasName("prkPNCVAgenteTransitoCredenciamentoEvento");

                entity.ToTable("tblPNCVAgenteTransitoCredenciamentoEvento");

                entity.Property(e => e.CodigoPncvagenteTransitoCredenciamentoEvento).HasColumnName("CodigoPNCVAgenteTransitoCredenciamentoEvento");

                entity.Property(e => e.CodigoPncvagenteTransitoCredenciamento).HasColumnName("CodigoPNCVAgenteTransitoCredenciamento");

                entity.Property(e => e.CodigoPncvagenteTransitoCredenciamentoSituacao).HasColumnName("CodigoPNCVAgenteTransitoCredenciamentoSituacao");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvagenteTransitoCredenciamentoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoCredenciamentoEvento)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoCredenciamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoCredenciamentoEvento_PNCVAgenteTransitoCredenciamento");

                entity.HasOne(d => d.CodigoPncvagenteTransitoCredenciamentoSituacaoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoCredenciamentoEvento)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoCredenciamentoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoCredenciamentoEvento_PNCVAgenteTransitoCredenciamentoSituacao");
            });

            modelBuilder.Entity<TblPncvagenteTransitoCredenciamentoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvagenteTransitoCredenciamentoSituacao)
                    .HasName("prkPNCVAgenteTransitoCredenciamentoSituacao");

                entity.ToTable("tblPNCVAgenteTransitoCredenciamentoSituacao");

                entity.Property(e => e.CodigoPncvagenteTransitoCredenciamentoSituacao)
                    .HasColumnName("CodigoPNCVAgenteTransitoCredenciamentoSituacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvagenteTransitoIndicadorResultadoVerificacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvagenteTransitoIndicadorResultadoVerificacao)
                    .HasName("prkPNCVAgenteTransitoSolicitacaoCredenciamentoIndicadorResultadoVerificacao")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVAgenteTransitoIndicadorResultadoVerificacao");

                entity.Property(e => e.CodigoPncvagenteTransitoIndicadorResultadoVerificacao).HasColumnName("CodigoPNCVAgenteTransitoIndicadorResultadoVerificacao");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvagenteTransitoIndicadorTipoSanguineo>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvagenteTransitoIndicadorTipoSanguineo)
                    .HasName("prkPNCVAgenteTransitoIndicadorTipoSanguineo")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVAgenteTransitoIndicadorTipoSanguineo");

                entity.Property(e => e.CodigoPncvagenteTransitoIndicadorTipoSanguineo).HasColumnName("CodigoPNCVAgenteTransitoIndicadorTipoSanguineo");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvagenteTransitoSolicitacaoCredenciamento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvagenteTransitoSolicitacaoCredenciamento)
                    .HasName("prkPNCVAgenteTransitoSolicitacaoCredenciamento")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVAgenteTransitoSolicitacaoCredenciamento");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoCredenciamento).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoCredenciamento");

                entity.Property(e => e.CertificadoCursoArquivoNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CertificadoCursoArquivoNomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncvagenteTransitoIndicadorResultadoVerificacaoPortaria).HasColumnName("CodigoPNCVAgenteTransitoIndicadorResultadoVerificacaoPortaria");

                entity.Property(e => e.CodigoPncvagenteTransitoIndicadorResultadoVerificacaoSolicitacao).HasColumnName("CodigoPNCVAgenteTransitoIndicadorResultadoVerificacaoSolicitacao");

                entity.Property(e => e.CodigoPncvagenteTransitoIndicadorTipoSanguineo).HasColumnName("CodigoPNCVAgenteTransitoIndicadorTipoSanguineo");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoCredenciamentoSituacao).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoCredenciamentoSituacao");

                entity.Property(e => e.CodigoRenavammunicipioNaturalidade).HasColumnName("CodigoRENAVAMMunicipioNaturalidade");

                entity.Property(e => e.CodigoUflotacao).HasColumnName("CodigoUFLotacao");

                entity.Property(e => e.CodigoUfnaturalidade).HasColumnName("CodigoUFNaturalidade");

                entity.Property(e => e.CodigoUforgaoExpedidor).HasColumnName("CodigoUFOrgaoExpedidor");

                entity.Property(e => e.DataNascimento).HasColumnType("date");

                entity.Property(e => e.DataPortaria).HasColumnType("date");

                entity.Property(e => e.DataPublicacaoPortariaDou)
                    .HasColumnName("DataPublicacaoPortariaDOU")
                    .HasColumnType("date");

                entity.Property(e => e.DataSolicitacao).HasColumnType("datetime");

                entity.Property(e => e.FotoArquivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FotoArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IndicadorFatorRhpositivo).HasColumnName("IndicadorFatorRHPositivo");

                entity.Property(e => e.NomeCargo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeMae)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomePai)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSolicitante)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacaoSolicitacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacaoVerificacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PortariaArquivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PortariaArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Rg)
                    .IsRequired()
                    .HasColumnName("RG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RgsiglaOrgaoExpedidor)
                    .IsRequired()
                    .HasColumnName("RGSiglaOrgaoExpedidor")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoPncvagenteTransitoIndicadorResultadoVerificacaoPortariaNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoCredenciamentoCodigoPncvagenteTransitoIndicadorResultadoVerificacaoPortariaNavigation)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoIndicadorResultadoVerificacaoPortaria)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoCredenciamento_PNCVAgenteTransitoSolicitacaoCredenciamentoIndicadorResultadoVerificacaoPortaria");

                entity.HasOne(d => d.CodigoPncvagenteTransitoIndicadorResultadoVerificacaoSolicitacaoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoCredenciamentoCodigoPncvagenteTransitoIndicadorResultadoVerificacaoSolicitacaoNavigation)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoIndicadorResultadoVerificacaoSolicitacao)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoCredenciamento_PNCVAgenteTransitoSolicitacaoCredenciamentoVerificacaoSolicitacao");

                entity.HasOne(d => d.CodigoPncvagenteTransitoIndicadorTipoSanguineoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoCredenciamento)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoIndicadorTipoSanguineo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoCredenciamento_PNCVAgenteTransitoIndicadorTipoSanguineo");

                entity.HasOne(d => d.CodigoPncvagenteTransitoSolicitacaoCredenciamentoSituacaoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoCredenciamento)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoSolicitacaoCredenciamentoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoCredenciamento_PNCVAgenteTransitoSolicitacaoCredenciamentoSituacao");

                entity.HasOne(d => d.CodigoSistemaUsuarioNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoCredenciamento)
                    .HasForeignKey(d => d.CodigoSistemaUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoCredenciamento_SistemaUsuario");

                entity.HasOne(d => d.CodigoUflotacaoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoCredenciamentoCodigoUflotacaoNavigation)
                    .HasForeignKey(d => d.CodigoUflotacao)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoCredenciamento_UFLotacao");

                entity.HasOne(d => d.CodigoUfnaturalidadeNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoCredenciamentoCodigoUfnaturalidadeNavigation)
                    .HasForeignKey(d => d.CodigoUfnaturalidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoCredenciamento_UFNaturalidade");

                entity.HasOne(d => d.CodigoUforgaoExpedidorNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoCredenciamentoCodigoUforgaoExpedidorNavigation)
                    .HasForeignKey(d => d.CodigoUforgaoExpedidor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PNCVAgenteTransitoSolicitacaoCredenciamento_UFOrgaoExpedidor");
            });

            modelBuilder.Entity<TblPncvagenteTransitoSolicitacaoCredenciamentoArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvagenteTransitoSolicitacaoCredenciamentoArquivo)
                    .HasName("prkPNCVAgenteTransitoSolicitacaoCredenciamentoArquivo")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVAgenteTransitoSolicitacaoCredenciamentoArquivo");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoCredenciamentoArquivo).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoCredenciamentoArquivo");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoCredenciamento).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoCredenciamento");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvagenteTransitoSolicitacaoCredenciamentoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoCredenciamentoArquivo)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoSolicitacaoCredenciamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoCredenciamentoArquivo_PNCVAgenteTransitoSolicitacaoCredenciamento");
            });

            modelBuilder.Entity<TblPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada)
                    .HasName("prkPNCVAgenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada");

                entity.ToTable("tblPNCVAgenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada");

                entity.Property(e => e.CodigoPncvagenteTransitoAtividadeDesempenhada).HasColumnName("CodigoPNCVAgenteTransitoAtividadeDesempenhada");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoCredenciamento).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoCredenciamento");

                entity.HasOne(d => d.CodigoPncvagenteTransitoAtividadeDesempenhadaNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoAtividadeDesempenhada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada_PNCVAgenteTransitoAtividadeDesempenhada");

                entity.HasOne(d => d.CodigoPncvagenteTransitoSolicitacaoCredenciamentoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoSolicitacaoCredenciamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada_PNCVAgenteTransitoSolicitacaoCredenciamento");
            });

            modelBuilder.Entity<TblPncvagenteTransitoSolicitacaoCredenciamentoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvagenteTransitoSolicitacaoCredenciamentoEvento)
                    .HasName("prkPNCVAgenteTransitoSolicitacaoCredenciamentoEvento")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVAgenteTransitoSolicitacaoCredenciamentoEvento");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoCredenciamentoEvento).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoCredenciamentoEvento");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoCredenciamento).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoCredenciamento");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoCredenciamentoSituacao).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoCredenciamentoSituacao");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvagenteTransitoSolicitacaoCredenciamentoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoCredenciamentoEvento)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoSolicitacaoCredenciamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoCredenciamentoEvento_PNCVAgenteTransitoSolicitacaoCredenciamento");

                entity.HasOne(d => d.CodigoPncvagenteTransitoSolicitacaoCredenciamentoSituacaoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoCredenciamentoEvento)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoSolicitacaoCredenciamentoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoCredenciamentoEvento_PNCVAgenteTransitoSolicitacaoCredenciamentoSituacao");
            });

            modelBuilder.Entity<TblPncvagenteTransitoSolicitacaoCredenciamentoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvagenteTransitoSolicitacaoCredenciamentoSituacao)
                    .HasName("prkPNCVAgenteTransitoSolicitacaoCredenciamentoSituacao")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVAgenteTransitoSolicitacaoCredenciamentoSituacao");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoCredenciamentoSituacao).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoCredenciamentoSituacao");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvagenteTransitoSolicitacaoDescredenciamento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvagenteTransitoSolicitacaoDescredenciamento)
                    .HasName("prkPNCVAgenteTransitoSolicitacaoDescredenciamento")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVAgenteTransitoSolicitacaoDescredenciamento");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoDescredenciamento).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoDescredenciamento");

                entity.Property(e => e.CodigoPncvagenteTransitoCredenciamento).HasColumnName("CodigoPNCVAgenteTransitoCredenciamento");

                entity.Property(e => e.CodigoPncvagenteTransitoIndicadorResultadoVerificacao).HasColumnName("CodigoPNCVAgenteTransitoIndicadorResultadoVerificacao");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoDescredenciamentoSituacao).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoDescredenciamentoSituacao");

                entity.Property(e => e.DataPortaria).HasColumnType("date");

                entity.Property(e => e.DataPublicacaoPortariaDou)
                    .HasColumnName("DataPublicacaoPortariaDOU")
                    .HasColumnType("datetime");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PortariaArquivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PortariaArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoPncvagenteTransitoCredenciamentoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoDescredenciamento)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoCredenciamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoDescredenciamento_PNCVAgenteTransitoCredenciamento");

                entity.HasOne(d => d.CodigoPncvagenteTransitoIndicadorResultadoVerificacaoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoDescredenciamento)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoIndicadorResultadoVerificacao)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoDescredenciamento_PNCVAgenteTransitoIndicadorResultadoVerificacao");

                entity.HasOne(d => d.CodigoPncvagenteTransitoSolicitacaoDescredenciamentoSituacaoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoDescredenciamento)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoSolicitacaoDescredenciamentoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoDescredenciamento_PNCVAgenteTransitoSolicitacaoDescredenciamentoSituacao");

                entity.HasOne(d => d.CodigoSistemaUsuarioNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoDescredenciamento)
                    .HasForeignKey(d => d.CodigoSistemaUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoDescredenciamento_SistemaUsuario");
            });

            modelBuilder.Entity<TblPncvagenteTransitoSolicitacaoDescredenciamentoArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvagenteTransitoSolicitacaoDescredenciamentoArquivo)
                    .HasName("prkPNCVAgenteTransitoSolicitacaoDescredenciamentoArquivo")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVAgenteTransitoSolicitacaoDescredenciamentoArquivo");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoDescredenciamentoArquivo).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoDescredenciamentoArquivo");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoDescredenciamento).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoDescredenciamento");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvagenteTransitoSolicitacaoDescredenciamentoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoDescredenciamentoArquivo)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoSolicitacaoDescredenciamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoDescredenciamentoArquivo_PNCVAgenteTransitoSolicitacaoDescredenciamento");
            });

            modelBuilder.Entity<TblPncvagenteTransitoSolicitacaoDescredenciamentoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvagenteTransitoSolicitacaoDescredenciamentoEvento)
                    .HasName("prkPNCVAgenteTransitoSolicitacaoDescredenciamentoEvento")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVAgenteTransitoSolicitacaoDescredenciamentoEvento");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoDescredenciamentoEvento).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoDescredenciamentoEvento");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoDescredenciamento).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoDescredenciamento");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoDescredenciamentoSituacao).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoDescredenciamentoSituacao");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvagenteTransitoSolicitacaoDescredenciamentoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoDescredenciamentoEvento)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoSolicitacaoDescredenciamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoDescredenciamentoEvento_PNCVAgenteTransitoSolicitacaoDescredenciamento");

                entity.HasOne(d => d.CodigoPncvagenteTransitoSolicitacaoDescredenciamentoSituacaoNavigation)
                    .WithMany(p => p.TblPncvagenteTransitoSolicitacaoDescredenciamentoEvento)
                    .HasForeignKey(d => d.CodigoPncvagenteTransitoSolicitacaoDescredenciamentoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAgenteTransitoSolicitacaoDescredenciamentoEvento_PNCVAgenteTransitoSolicitacaoDescredenciamentoSituacao");
            });

            modelBuilder.Entity<TblPncvagenteTransitoSolicitacaoDescredenciamentoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvagenteTransitoSolicitacaoDescredenciamentoSituacao)
                    .HasName("prkPNCVAgenteTransitoSolicitacaoDescredenciamentoSituacao")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVAgenteTransitoSolicitacaoDescredenciamentoSituacao");

                entity.Property(e => e.CodigoPncvagenteTransitoSolicitacaoDescredenciamentoSituacao).HasColumnName("CodigoPNCVAgenteTransitoSolicitacaoDescredenciamentoSituacao");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvautorizacaoInstalacaoEquipamento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvautorizacaoInstalacaoEquipamento)
                    .HasName("prkPNCVAutorizacaoInstalacaoEquipamento");

                entity.ToTable("tblPNCVAutorizacaoInstalacaoEquipamento");

                entity.Property(e => e.CodigoPncvautorizacaoInstalacaoEquipamento).HasColumnName("CodigoPNCVAutorizacaoInstalacaoEquipamento");

                entity.Property(e => e.CodigoPncvautorizacaoInstalacaoEquipamentoSituacao).HasColumnName("CodigoPNCVAutorizacaoInstalacaoEquipamentoSituacao");

                entity.Property(e => e.CodigoPncvequipamento).HasColumnName("CodigoPNCVEquipamento");

                entity.Property(e => e.CodigoPncvequipamentoIndicadorInstalacao).HasColumnName("CodigoPNCVEquipamentoIndicadorInstalacao");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacao).HasColumnName("CodigoPNCVEstudoTecnicoInstalacao");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacaoEquipamento).HasColumnName("CodigoPNCVEstudoTecnicoInstalacaoEquipamento");

                entity.Property(e => e.DataAnalise).HasColumnType("datetime");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataRevisao).HasColumnType("datetime");

                entity.Property(e => e.DataSolicitacao).HasColumnType("datetime");

                entity.Property(e => e.DataSolicitacaoRevisao).HasColumnType("datetime");

                entity.Property(e => e.NomeUsuarioAnalise)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeUsuarioRevisao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeUsuarioSolicitacao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeUsuarioSolicitacaoRevisao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RevisaoMotivo).IsUnicode(false);

                entity.Property(e => e.RevisaoObservacao).IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoPncvautorizacaoInstalacaoEquipamentoSituacaoNavigation)
                    .WithMany(p => p.TblPncvautorizacaoInstalacaoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvautorizacaoInstalacaoEquipamentoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAutorizacaoInstalacaoEquipamento_PNCVAutorizacaoInstalacaoEquipamentoSituacao");

                entity.HasOne(d => d.CodigoPncvequipamentoNavigation)
                    .WithMany(p => p.TblPncvautorizacaoInstalacaoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvequipamento)
                    .HasConstraintName("frkPNCVAutorizacaoInstalacaoEquipamento_PNCVEquipamento");

                entity.HasOne(d => d.CodigoPncvequipamentoIndicadorInstalacaoNavigation)
                    .WithMany(p => p.TblPncvautorizacaoInstalacaoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvequipamentoIndicadorInstalacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAutorizacaoInstalacaoEquipamento_PNCVEquipamentoIndicadorInstalacao");

                entity.HasOne(d => d.CodigoPncvestudoTecnicoInstalacaoNavigation)
                    .WithMany(p => p.TblPncvautorizacaoInstalacaoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvestudoTecnicoInstalacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAutorizacaoInstalacaoEquipamento_PNCVEquipamentoEstudoTecnico");

                entity.HasOne(d => d.CodigoPncvestudoTecnicoInstalacaoEquipamentoNavigation)
                    .WithMany(p => p.TblPncvautorizacaoInstalacaoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvestudoTecnicoInstalacaoEquipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAutorizacaoInstalacaoEquipamento_PNCVEstudoTecnicoInstalacaoEquipamento");
            });

            modelBuilder.Entity<TblPncvautorizacaoInstalacaoEquipamentoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvautorizacaoInstalacaoEquipamentoEvento)
                    .HasName("prkPNCVAutorizacaoInstalacaoEquipamentoEvento");

                entity.ToTable("tblPNCVAutorizacaoInstalacaoEquipamentoEvento");

                entity.Property(e => e.CodigoPncvautorizacaoInstalacaoEquipamentoEvento).HasColumnName("CodigoPNCVAutorizacaoInstalacaoEquipamentoEvento");

                entity.Property(e => e.CodigoPncvautorizacaoInstalacaoEquipamento).HasColumnName("CodigoPNCVAutorizacaoInstalacaoEquipamento");

                entity.Property(e => e.CodigoPncvautorizacaoInstalacaoEquipamentoSituacao).HasColumnName("CodigoPNCVAutorizacaoInstalacaoEquipamentoSituacao");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvautorizacaoInstalacaoEquipamentoNavigation)
                    .WithMany(p => p.TblPncvautorizacaoInstalacaoEquipamentoEvento)
                    .HasForeignKey(d => d.CodigoPncvautorizacaoInstalacaoEquipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAutorizacaoInstalacaoEquipamentoEvento_PNCVAutorizacaoInstalacaoEquipamento");

                entity.HasOne(d => d.CodigoPncvautorizacaoInstalacaoEquipamentoSituacaoNavigation)
                    .WithMany(p => p.TblPncvautorizacaoInstalacaoEquipamentoEvento)
                    .HasForeignKey(d => d.CodigoPncvautorizacaoInstalacaoEquipamentoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAutorizacaoInstalacaoEquipamentoEvento_PNCVAutorizacaoInstalacaoEquipamentoSituacao");
            });

            modelBuilder.Entity<TblPncvautorizacaoInstalacaoEquipamentoRemanejamento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvautorizacaoInstalacaoEquipamentoRemanejamento)
                    .HasName("prkPNCVAutorizacaoInstalacaoEquipamentoRemanejamento");

                entity.ToTable("tblPNCVAutorizacaoInstalacaoEquipamentoRemanejamento");

                entity.Property(e => e.CodigoPncvautorizacaoInstalacaoEquipamentoRemanejamento).HasColumnName("CodigoPNCVAutorizacaoInstalacaoEquipamentoRemanejamento");

                entity.Property(e => e.CodigoPncvautorizacaoInstalacaoEquipamento).HasColumnName("CodigoPNCVAutorizacaoInstalacaoEquipamento");

                entity.Property(e => e.CodigoPncvequipamento).HasColumnName("CodigoPNCVEquipamento");

                entity.HasOne(d => d.CodigoPncvautorizacaoInstalacaoEquipamentoNavigation)
                    .WithMany(p => p.TblPncvautorizacaoInstalacaoEquipamentoRemanejamento)
                    .HasForeignKey(d => d.CodigoPncvautorizacaoInstalacaoEquipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAutorizacaoInstalacaoEquipamentoRemanejamento_PNCVAutorizacaoInstalacaoEquipamento");

                entity.HasOne(d => d.CodigoPncvequipamentoNavigation)
                    .WithMany(p => p.TblPncvautorizacaoInstalacaoEquipamentoRemanejamento)
                    .HasForeignKey(d => d.CodigoPncvequipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAutorizacaoInstalacaoEquipamentoRemanejamento_PNCVEquipamento");
            });

            modelBuilder.Entity<TblPncvautorizacaoInstalacaoEquipamentoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvautorizacaoInstalacaoEquipamentoSituacao)
                    .HasName("prkPNCVAutorizacaoInstalacaoEquipamentoSituacao");

                entity.ToTable("tblPNCVAutorizacaoInstalacaoEquipamentoSituacao");

                entity.Property(e => e.CodigoPncvautorizacaoInstalacaoEquipamentoSituacao)
                    .HasColumnName("CodigoPNCVAutorizacaoInstalacaoEquipamentoSituacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvautorizacaoInstalacaoEquipamentoSubstituicao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvautorizacaoInstalacaoEquipamentoSubstituicao)
                    .HasName("prkPNCVAutorizacaoInstalacaoEquipamentoSubstituicao");

                entity.ToTable("tblPNCVAutorizacaoInstalacaoEquipamentoSubstituicao");

                entity.Property(e => e.CodigoPncvautorizacaoInstalacaoEquipamentoSubstituicao).HasColumnName("CodigoPNCVAutorizacaoInstalacaoEquipamentoSubstituicao");

                entity.Property(e => e.CodigoPncvautorizacaoInstalacaoEquipamento).HasColumnName("CodigoPNCVAutorizacaoInstalacaoEquipamento");

                entity.Property(e => e.CodigoPncvequipamento).HasColumnName("CodigoPNCVEquipamento");

                entity.HasOne(d => d.CodigoPncvautorizacaoInstalacaoEquipamentoNavigation)
                    .WithMany(p => p.TblPncvautorizacaoInstalacaoEquipamentoSubstituicao)
                    .HasForeignKey(d => d.CodigoPncvautorizacaoInstalacaoEquipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAutorizacaoInstalacaoEquipamentoSubstituicao_PNCVAutorizacaoInstalacaoEquipamento");

                entity.HasOne(d => d.CodigoPncvequipamentoNavigation)
                    .WithMany(p => p.TblPncvautorizacaoInstalacaoEquipamentoSubstituicao)
                    .HasForeignKey(d => d.CodigoPncvequipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVAutorizacaoInstalacaoEquipamentoSubstituicao_PNCVEquipamento");
            });

            modelBuilder.Entity<TblPncvedital>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvedital)
                    .HasName("prkPNCVEdital");

                entity.ToTable("tblPNCVEdital");

                entity.HasIndex(e => e.ArquivoReferenciaNomeFisico)
                    .HasName("unqPNCVEditalArquivoReferenciaNomeFisico")
                    .IsUnique();

                entity.Property(e => e.CodigoPncvedital).HasColumnName("CodigoPNCVEdital");

                entity.Property(e => e.ArquivoReferenciaNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoReferenciaNomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncveditalObjeto).HasColumnName("CodigoPNCVEditalObjeto");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncveditalObjetoNavigation)
                    .WithMany(p => p.TblPncvedital)
                    .HasForeignKey(d => d.CodigoPncveditalObjeto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEdital_PNCVEditalObjeto");
            });

            modelBuilder.Entity<TblPncveditalLote>(entity =>
            {
                entity.HasKey(e => e.CodigoPncveditalLote)
                    .HasName("prkPNCVEditalLote");

                entity.ToTable("tblPNCVEditalLote");

                entity.Property(e => e.CodigoPncveditalLote).HasColumnName("CodigoPNCVEditalLote");

                entity.Property(e => e.CodigoPncvedital).HasColumnName("CodigoPNCVEdital");

                entity.Property(e => e.CodigoPncvoperadora).HasColumnName("CodigoPNCVOperadora");

                entity.Property(e => e.DataInicioVigencia).HasColumnType("date");

                entity.Property(e => e.DataTerminoVigencia).HasColumnType("date");

                entity.Property(e => e.NumeroContrato)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroProcessoContrato)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncveditalNavigation)
                    .WithMany(p => p.TblPncveditalLote)
                    .HasForeignKey(d => d.CodigoPncvedital)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEditalLote_PNCVEdital");

                entity.HasOne(d => d.CodigoPncvoperadoraNavigation)
                    .WithMany(p => p.TblPncveditalLote)
                    .HasForeignKey(d => d.CodigoPncvoperadora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEditalLote_PNCVOperadora");
            });

            modelBuilder.Entity<TblPncveditalLoteAbrangencia>(entity =>
            {
                entity.HasKey(e => e.CodigoPncveditalLoteAbrangencia)
                    .HasName("prkPNCVEditalLoteAbrangencia")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEditalLoteAbrangencia");

                entity.Property(e => e.CodigoPncveditalLoteAbrangencia).HasColumnName("CodigoPNCVEditalLoteAbrangencia");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoPncveditalLote).HasColumnName("CodigoPNCVEditalLote");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblPncveditalLoteAbrangencia)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEditalLoteAbrangencia_UF");

                entity.HasOne(d => d.CodigoPncveditalLoteNavigation)
                    .WithMany(p => p.TblPncveditalLoteAbrangencia)
                    .HasForeignKey(d => d.CodigoPncveditalLote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEditalLoteAbrangencia_PNCVEditalLote");
            });

            modelBuilder.Entity<TblPncveditalObjeto>(entity =>
            {
                entity.HasKey(e => e.CodigoPncveditalObjeto)
                    .HasName("prkPNCVEditalObjeto");

                entity.ToTable("tblPNCVEditalObjeto");

                entity.Property(e => e.CodigoPncveditalObjeto)
                    .HasColumnName("CodigoPNCVEditalObjeto")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvequipamento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamento)
                    .HasName("prkPNCVEquipamento");

                entity.ToTable("tblPNCVEquipamento");

                entity.HasIndex(e => e.CodigoEquipamentoDnit)
                    .HasName("unqPNCVEquipamentoDNIT")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodigoPncvequipamento, e.DataCancelamento })
                    .HasName("idxtblPNCVEquipamento_DataCancelamento");

                entity.HasIndex(e => new { e.CodigoPncvequipamento, e.CodigoBaseRodovia, e.CodigoBaseUf, e.CodigoRenavammunicipio, e.CodigoPncveditalLote })
                    .HasName("idxPNCVEquipamento_EditalLote");

                entity.Property(e => e.CodigoPncvequipamento).HasColumnName("CodigoPNCVEquipamento");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoEquipamentoDnit)
                    .IsRequired()
                    .HasColumnName("CodigoEquipamentoDNIT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncveditalLote).HasColumnName("CodigoPNCVEditalLote");

                entity.Property(e => e.CodigoPncvequipamentoTipo).HasColumnName("CodigoPNCVEquipamentoTipo");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacao).HasColumnName("CodigoPNCVEstudoTecnicoInstalacao");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacaoEquipamento).HasColumnName("CodigoPNCVEstudoTecnicoInstalacaoEquipamento");

                entity.Property(e => e.CodigoPncvmodeloEquipamento).HasColumnName("CodigoPNCVModeloEquipamento");

                entity.Property(e => e.CodigoRenavammunicipio).HasColumnName("CodigoRENAVAMMunicipio");

                entity.Property(e => e.CodigoSnv)
                    .IsRequired()
                    .HasColumnName("CodigoSNV")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DataCancelamento).HasColumnType("date");

                entity.Property(e => e.DataInicioOperacao).HasColumnType("date");
                entity.Property(e => e.Coordenadas).HasColumnType("geometry");

                entity.Property(e => e.DataVersaoSnv)
                    .HasColumnName("DataVersaoSNV")
                    .HasColumnType("date");

                entity.Property(e => e.NumeroKm).HasColumnType("decimal(7, 3)");

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblPncvequipamento)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamento_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblPncvequipamento)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamento_BaseUF");

                entity.HasOne(d => d.CodigoPncveditalLoteNavigation)
                    .WithMany(p => p.TblPncvequipamento)
                    .HasForeignKey(d => d.CodigoPncveditalLote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamento_PNCVEditalLote");

                entity.HasOne(d => d.CodigoPncvequipamentoTipoNavigation)
                    .WithMany(p => p.TblPncvequipamento)
                    .HasForeignKey(d => d.CodigoPncvequipamentoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamento_PNCVEquipamentoTipo");

                entity.HasOne(d => d.CodigoPncvestudoTecnicoInstalacaoNavigation)
                    .WithMany(p => p.TblPncvequipamento)
                    .HasForeignKey(d => d.CodigoPncvestudoTecnicoInstalacao)
                    .HasConstraintName("frkPNCVEquipamento_PNCVEstudoTecnicoInstalacao");

                entity.HasOne(d => d.CodigoPncvestudoTecnicoInstalacaoEquipamentoNavigation)
                    .WithMany(p => p.TblPncvequipamento)
                    .HasForeignKey(d => d.CodigoPncvestudoTecnicoInstalacaoEquipamento)
                    .HasConstraintName("frkPNCVEquipamento_PNCVEstudoTecnicoInstalacaoEquipamento");

                entity.HasOne(d => d.CodigoPncvmodeloEquipamentoNavigation)
                    .WithMany(p => p.TblPncvequipamento)
                    .HasForeignKey(d => d.CodigoPncvmodeloEquipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamento_PNCVModeloEquipamento");
            });

            modelBuilder.Entity<TblPncvequipamentoCodigo>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoCodigo)
                    .HasName("prkPNCVEquipamentoCodigo")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEquipamentoCodigo");

                entity.Property(e => e.CodigoPncvequipamentoCodigo).HasColumnName("CodigoPNCVEquipamentoCodigo");

                entity.Property(e => e.CodigoEquipamento)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.SiglaUf)
                    .IsRequired()
                    .HasColumnName("SiglaUF")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEquipamento)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvequipamentoEstudoTecnico>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoEstudoTecnico)
                    .HasName("prkPNCVEquipamentoEstudoTecnico");

                entity.ToTable("tblPNCVEquipamentoEstudoTecnico");

                entity.HasIndex(e => new { e.Data, e.CodigoPncvequipamento })
                    .HasName("idxPNCVEquipamentoEstudoTecnico_Equipamento");

                entity.Property(e => e.CodigoPncvequipamentoEstudoTecnico).HasColumnName("CodigoPNCVEquipamentoEstudoTecnico");

                entity.Property(e => e.CodigoPncvequipamento).HasColumnName("CodigoPNCVEquipamento");

                entity.Property(e => e.CodigoPncvequipamentoIndicadorComunicacao).HasColumnName("CodigoPNCVEquipamentoIndicadorComunicacao");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacao).HasColumnName("CodigoPNCVEstudoTecnicoInstalacao");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.HasOne(d => d.CodigoPncvequipamentoNavigation)
                    .WithMany(p => p.TblPncvequipamentoEstudoTecnico)
                    .HasForeignKey(d => d.CodigoPncvequipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoEstudoTecnico_PNCVEquipamento");

                entity.HasOne(d => d.CodigoPncvequipamentoIndicadorComunicacaoNavigation)
                    .WithMany(p => p.TblPncvequipamentoEstudoTecnico)
                    .HasForeignKey(d => d.CodigoPncvequipamentoIndicadorComunicacao)
                    .HasConstraintName("frkPNCVEquipamentoEstudoTecnico_PNCVEquipamentoIndicadorComunicacao");

                entity.HasOne(d => d.CodigoPncvestudoTecnicoInstalacaoNavigation)
                    .WithMany(p => p.TblPncvequipamentoEstudoTecnico)
                    .HasForeignKey(d => d.CodigoPncvestudoTecnicoInstalacao)
                    .HasConstraintName("frkPNCVEquipamentoEstudoTecnico_PNCVEstudoTecnicoInstalacao");
            });

            modelBuilder.Entity<TblPncvequipamentoEstudoTecnicoArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoEstudoTecnicoArquivo)
                    .HasName("prkPNCVEquipamentoEstudoTecnicoArquivo");

                entity.ToTable("tblPNCVEquipamentoEstudoTecnicoArquivo");

                entity.HasIndex(e => e.CodigoPncvequipamentoEstudoTecnico)
                    .HasName("idxPNCVEquipamentoEstudoTecnicoArquivo");

                entity.Property(e => e.CodigoPncvequipamentoEstudoTecnicoArquivo).HasColumnName("CodigoPNCVEquipamentoEstudoTecnicoArquivo");

                entity.Property(e => e.ArquivoReferenciaNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoReferenciaNomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncvequipamentoEstudoTecnico).HasColumnName("CodigoPNCVEquipamentoEstudoTecnico");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvequipamentoEstudoTecnicoNavigation)
                    .WithMany(p => p.TblPncvequipamentoEstudoTecnicoArquivo)
                    .HasForeignKey(d => d.CodigoPncvequipamentoEstudoTecnico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoEstudoTecnicoArquivo_PNCVEquipamentoEstudoTecnico");
            });

            modelBuilder.Entity<TblPncvequipamentoEstudoTecnicoFaixa>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoEstudoTecnicoFaixa)
                    .HasName("prkPNCVEquipamentoEstudoTecnicoFaixa");

                entity.ToTable("tblPNCVEquipamentoEstudoTecnicoFaixa");

                entity.HasIndex(e => new { e.CodigoPncvequipamentoEstudoTecnico, e.CodigoPncvequipamentoFaixa })
                    .HasName("unqPNCVEstudoTecnicoFaixa")
                    .IsUnique();

                entity.Property(e => e.CodigoPncvequipamentoEstudoTecnicoFaixa).HasColumnName("CodigoPNCVEquipamentoEstudoTecnicoFaixa");

                entity.Property(e => e.CodigoPncvequipamentoEstudoTecnico).HasColumnName("CodigoPNCVEquipamentoEstudoTecnico");

                entity.Property(e => e.CodigoPncvequipamentoFaixa).HasColumnName("CodigoPNCVEquipamentoFaixa");

                entity.HasOne(d => d.CodigoPncvequipamentoEstudoTecnicoNavigation)
                    .WithMany(p => p.TblPncvequipamentoEstudoTecnicoFaixa)
                    .HasForeignKey(d => d.CodigoPncvequipamentoEstudoTecnico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoEstudoTecnicoFaixa_PNCVEquipamentoEstudoTecnico");

                entity.HasOne(d => d.CodigoPncvequipamentoFaixaNavigation)
                    .WithMany(p => p.TblPncvequipamentoEstudoTecnicoFaixa)
                    .HasForeignKey(d => d.CodigoPncvequipamentoFaixa)
                    .HasConstraintName("frkPNCVEquipamentoEstudoTecnicoFaixa_PNCVEquipamentoFaixa");
            });

            modelBuilder.Entity<TblPncvequipamentoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoEvento)
                    .HasName("prkPNCVEquipamentoEvento");

                entity.ToTable("tblPNCVEquipamentoEvento");

                entity.HasIndex(e => new { e.CodigoPncvequipamento, e.Data })
                    .HasName("idxPNCVEquipamentoEvento_Equipamento");

                entity.Property(e => e.CodigoPncvequipamentoEvento).HasColumnName("CodigoPNCVEquipamentoEvento");

                entity.Property(e => e.CodigoPncvequipamento).HasColumnName("CodigoPNCVEquipamento");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvequipamentoNavigation)
                    .WithMany(p => p.TblPncvequipamentoEvento)
                    .HasForeignKey(d => d.CodigoPncvequipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoEvento_PNCVEquipamento");
            });

            modelBuilder.Entity<TblPncvequipamentoFaixa>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoFaixa)
                    .HasName("prkPNCVEquipamentoFaixa");

                entity.ToTable("tblPNCVEquipamentoFaixa");

                entity.HasIndex(e => new { e.CodigoPncvequipamento, e.CodigoPncvsentidoRodovia, e.CodigoPncvtipoVia, e.Numero })
                    .HasName("idx_PNCVEquipamentoFaixa_Equipamento_Sentido_TipoVia_Numero");

                entity.Property(e => e.CodigoPncvequipamentoFaixa).HasColumnName("CodigoPNCVEquipamentoFaixa");

                entity.Property(e => e.CodigoPncvequipamento).HasColumnName("CodigoPNCVEquipamento");

                entity.Property(e => e.CodigoPncvequipamentoFaixaSituacao).HasColumnName("CodigoPNCVEquipamentoFaixaSituacao");

                entity.Property(e => e.CodigoPncvsentidoRodovia).HasColumnName("CodigoPNCVSentidoRodovia");

                entity.Property(e => e.CodigoPncvtipoVia).HasColumnName("CodigoPNCVTipoVia");

                entity.Property(e => e.DataCancelamento).HasColumnType("date");

                entity.Property(e => e.DataInicioOperacao).HasColumnType("date");

                entity.HasOne(d => d.CodigoPncvequipamentoNavigation)
                    .WithMany(p => p.TblPncvequipamentoFaixa)
                    .HasForeignKey(d => d.CodigoPncvequipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoFaixa_PNCVEquipamento");

                entity.HasOne(d => d.CodigoPncvequipamentoFaixaSituacaoNavigation)
                    .WithMany(p => p.TblPncvequipamentoFaixa)
                    .HasForeignKey(d => d.CodigoPncvequipamentoFaixaSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoFaixa_PNCVEquipamentoFaixaSituacao");

                entity.HasOne(d => d.CodigoPncvsentidoRodoviaNavigation)
                    .WithMany(p => p.TblPncvequipamentoFaixa)
                    .HasForeignKey(d => d.CodigoPncvsentidoRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoFaixa_PNCVSentidoRodovia");

                entity.HasOne(d => d.CodigoPncvtipoViaNavigation)
                    .WithMany(p => p.TblPncvequipamentoFaixa)
                    .HasForeignKey(d => d.CodigoPncvtipoVia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoFaixa_PNCVTipoVia");
            });

            modelBuilder.Entity<TblPncvequipamentoFaixaParalisacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoFaixaParalisacao)
                    .HasName("prkPNCVEquipamentoFaixaParalisacao");

                entity.ToTable("tblPNCVEquipamentoFaixaParalisacao");

                entity.HasIndex(e => e.ArquivoInicioNomeFisico)
                    .HasName("unqPNCVEquipamentoFaixaParalisacaoArquivoInicioNomeFisico")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodigoPncvequipamentoFaixaParalisacaoSituacao, e.CodigoPncvequipamentoFaixa, e.DataInicio })
                    .HasName("idxPNCVEquipamentoFaixaParalisacao");

                entity.HasIndex(e => new { e.CodigoPncvequipamentoFaixaParalisacaoSituacao, e.DataInicio, e.DataEncerramento, e.CodigoPncvequipamentoFaixa })
                    .HasName("idxPNCVEquipamentoFaixaParalisacao_EquipamentoFaixa");

                entity.Property(e => e.CodigoPncvequipamentoFaixaParalisacao).HasColumnName("CodigoPNCVEquipamentoFaixaParalisacao");

                entity.Property(e => e.ArquivoEncerramentoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoEncerramentoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoInicioNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoInicioNomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncvequipamentoFaixa).HasColumnName("CodigoPNCVEquipamentoFaixa");

                entity.Property(e => e.CodigoPncvequipamentoFaixaParalisacaoMotivo).HasColumnName("CodigoPNCVEquipamentoFaixaParalisacaoMotivo");

                entity.Property(e => e.CodigoPncvequipamentoFaixaParalisacaoSituacao).HasColumnName("CodigoPNCVEquipamentoFaixaParalisacaoSituacao");

                entity.Property(e => e.DataEncerramento).HasColumnType("date");

                entity.Property(e => e.DataInicio).HasColumnType("date");

                entity.Property(e => e.ObservacaoAnaliseEncerramento)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacaoAnaliseInicio)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoPncvequipamentoFaixaNavigation)
                    .WithMany(p => p.TblPncvequipamentoFaixaParalisacao)
                    .HasForeignKey(d => d.CodigoPncvequipamentoFaixa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoFaixaParalisacao_PNCVEquipamentoFaixa");

                entity.HasOne(d => d.CodigoPncvequipamentoFaixaParalisacaoMotivoNavigation)
                    .WithMany(p => p.TblPncvequipamentoFaixaParalisacao)
                    .HasForeignKey(d => d.CodigoPncvequipamentoFaixaParalisacaoMotivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoFaixaParalisacao_PNCVEquipamentoFaixaParalisacaoMotivo");

                entity.HasOne(d => d.CodigoPncvequipamentoFaixaParalisacaoSituacaoNavigation)
                    .WithMany(p => p.TblPncvequipamentoFaixaParalisacao)
                    .HasForeignKey(d => d.CodigoPncvequipamentoFaixaParalisacaoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoFaixaParalisacao_PNCVEquipamentoFaixaParalisacaoSituacao");
            });

            modelBuilder.Entity<TblPncvequipamentoFaixaParalisacaoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoFaixaParalisacaoEvento)
                    .HasName("prkPNCVEquipamentoFaixaParalisacaoEvento");

                entity.ToTable("tblPNCVEquipamentoFaixaParalisacaoEvento");

                entity.HasIndex(e => new { e.CodigoPncvequipamentoFaixaParalisacao, e.Data })
                    .HasName("idxPNCVEquipamentoFaixaParalisacaoEvento");

                entity.Property(e => e.CodigoPncvequipamentoFaixaParalisacaoEvento).HasColumnName("CodigoPNCVEquipamentoFaixaParalisacaoEvento");

                entity.Property(e => e.CodigoPncvequipamentoFaixaParalisacao).HasColumnName("CodigoPNCVEquipamentoFaixaParalisacao");

                entity.Property(e => e.CodigoPncvequipamentoFaixaParalisacaoSituacao).HasColumnName("CodigoPNCVEquipamentoFaixaParalisacaoSituacao");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvequipamentoFaixaParalisacaoNavigation)
                    .WithMany(p => p.TblPncvequipamentoFaixaParalisacaoEvento)
                    .HasForeignKey(d => d.CodigoPncvequipamentoFaixaParalisacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoFaixaParalisacaoEvento_PNCVEquipamentoFaixaParalisacao");

                entity.HasOne(d => d.CodigoPncvequipamentoFaixaParalisacaoSituacaoNavigation)
                    .WithMany(p => p.TblPncvequipamentoFaixaParalisacaoEvento)
                    .HasForeignKey(d => d.CodigoPncvequipamentoFaixaParalisacaoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoFaixaParalisacaoEvento_PNCVEquipamentoFaixaParalisacaoSituacao");
            });

            modelBuilder.Entity<TblPncvequipamentoFaixaParalisacaoMotivo>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoFaixaParalisacaoMotivo)
                    .HasName("prkPNCVEquipamentoFaixaParalisacaoMotivo");

                entity.ToTable("tblPNCVEquipamentoFaixaParalisacaoMotivo");

                entity.Property(e => e.CodigoPncvequipamentoFaixaParalisacaoMotivo).HasColumnName("CodigoPNCVEquipamentoFaixaParalisacaoMotivo");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvequipamentoFaixaParalisacaoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoFaixaParalisacaoSituacao)
                    .HasName("prkPNCVEquipamentoFaixaParalisacaoSituacao");

                entity.ToTable("tblPNCVEquipamentoFaixaParalisacaoSituacao");

                entity.Property(e => e.CodigoPncvequipamentoFaixaParalisacaoSituacao)
                    .HasColumnName("CodigoPNCVEquipamentoFaixaParalisacaoSituacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvequipamentoFaixaSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoFaixaSituacao)
                    .HasName("prkPNCVEquipamentoFaixaSituacao");

                entity.ToTable("tblPNCVEquipamentoFaixaSituacao");

                entity.Property(e => e.CodigoPncvequipamentoFaixaSituacao)
                    .HasColumnName("CodigoPNCVEquipamentoFaixaSituacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvequipamentoFaixaVerificacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoFaixaVerificacao)
                    .HasName("prkPNCVEquipamentoFaixaVerificacao");

                entity.ToTable("tblPNCVEquipamentoFaixaVerificacao");

                entity.HasIndex(e => new { e.CodigoPncvequipamentoFaixaVerificacaoSituacao, e.CodigoPncvequipamentoFaixa, e.DataVerificacao })
                    .HasName("idxPNCVEquipamentoFaixaVerificacao");

                entity.HasIndex(e => new { e.CodigoPncvequipamentoFaixaVerificacaoSituacao, e.DataVerificacao, e.CodigoPncvequipamentoFaixa })
                    .HasName("idxPNCVEquipamentoFaixaVerificacao_Equipamento");

                entity.Property(e => e.CodigoPncvequipamentoFaixaVerificacao).HasColumnName("CodigoPNCVEquipamentoFaixaVerificacao");

                entity.Property(e => e.ArquivoCertificadoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoCertificadoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoLaudoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoLaudoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncvequipamentoFaixa).HasColumnName("CodigoPNCVEquipamentoFaixa");

                entity.Property(e => e.CodigoPncvequipamentoFaixaVerificacaoSituacao).HasColumnName("CodigoPNCVEquipamentoFaixaVerificacaoSituacao");

                entity.Property(e => e.DataDeferimento).HasColumnType("date");

                entity.Property(e => e.DataFotosSinalizacao).HasColumnType("date");

                entity.Property(e => e.DataValidadeVerificacao).HasColumnType("date");

                entity.Property(e => e.DataVerificacao).HasColumnType("date");

                entity.Property(e => e.FotoNumeroVerificacaoNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FotoNumeroVerificacaoNomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FotoPanoramicaEquipamentoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FotoPanoramicaEquipamentoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FotoPanoramicaEquipamentoOpcionalNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FotoPanoramicaEquipamentoOpcionalNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FotoTesteInfracaoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FotoTesteInfracaoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FotoVeiculoInmetroNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FotoVeiculoInmetroNomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroVerificacaoInmetro)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacaoAnalise)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoPncvequipamentoFaixaNavigation)
                    .WithMany(p => p.TblPncvequipamentoFaixaVerificacao)
                    .HasForeignKey(d => d.CodigoPncvequipamentoFaixa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoFaixaVerificacao_PNCVEquipamentoFaixa");

                entity.HasOne(d => d.CodigoPncvequipamentoFaixaVerificacaoSituacaoNavigation)
                    .WithMany(p => p.TblPncvequipamentoFaixaVerificacao)
                    .HasForeignKey(d => d.CodigoPncvequipamentoFaixaVerificacaoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoFaixaVerificacao_PNCVEquipamentoFaixaVerificacaoSituacao");
            });

            modelBuilder.Entity<TblPncvequipamentoFaixaVerificacaoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoFaixaVerificacaoEvento)
                    .HasName("prkPNCVEquipamentoFaixaVerificacaoEvento");

                entity.ToTable("tblPNCVEquipamentoFaixaVerificacaoEvento");

                entity.HasIndex(e => new { e.CodigoPncvequipamentoFaixaVerificacao, e.Data })
                    .HasName("idxprkPNCVEquipamentoFaixaVerificacaoEvento");

                entity.Property(e => e.CodigoPncvequipamentoFaixaVerificacaoEvento).HasColumnName("CodigoPNCVEquipamentoFaixaVerificacaoEvento");

                entity.Property(e => e.CodigoPncvequipamentoFaixaVerificacao).HasColumnName("CodigoPNCVEquipamentoFaixaVerificacao");

                entity.Property(e => e.CodigoPncvequipamentoFaixaVerificacaoSituacao).HasColumnName("CodigoPNCVEquipamentoFaixaVerificacaoSituacao");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvequipamentoFaixaVerificacaoNavigation)
                    .WithMany(p => p.TblPncvequipamentoFaixaVerificacaoEvento)
                    .HasForeignKey(d => d.CodigoPncvequipamentoFaixaVerificacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoFaixaVerificacaoEvento_PNCVEquipamentoFaixaVerificacao");

                entity.HasOne(d => d.CodigoPncvequipamentoFaixaVerificacaoSituacaoNavigation)
                    .WithMany(p => p.TblPncvequipamentoFaixaVerificacaoEvento)
                    .HasForeignKey(d => d.CodigoPncvequipamentoFaixaVerificacaoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoFaixaVerificacaoEvento_PNCVEquipamentoFaixaVerificacaoSituacao");
            });

            modelBuilder.Entity<TblPncvequipamentoFaixaVerificacaoPlaca>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoFaixaVerificacaoPlaca)
                    .HasName("prkPNCVEquipamentoFaixaVerificacaoPlaca");

                entity.ToTable("tblPNCVEquipamentoFaixaVerificacaoPlaca");

                entity.HasIndex(e => e.FotoNomeFisico)
                    .HasName("unqPNCVEquipamentoFaixaVerificacaoPlacaFotoNomeFisico")
                    .IsUnique();

                entity.Property(e => e.CodigoPncvequipamentoFaixaVerificacaoPlaca).HasColumnName("CodigoPNCVEquipamentoFaixaVerificacaoPlaca");

                entity.Property(e => e.CodigoPncvequipamentoFaixaVerificacao).HasColumnName("CodigoPNCVEquipamentoFaixaVerificacao");

                entity.Property(e => e.CodigoPncvtipoPlacaSinalizacao).HasColumnName("CodigoPNCVTipoPlacaSinalizacao");

                entity.Property(e => e.FotoNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FotoNomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvequipamentoFaixaVerificacaoNavigation)
                    .WithMany(p => p.TblPncvequipamentoFaixaVerificacaoPlaca)
                    .HasForeignKey(d => d.CodigoPncvequipamentoFaixaVerificacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoFaixaVerificacaoPlaca_PNCVEquipamentoFaixaVerificacao");

                entity.HasOne(d => d.CodigoPncvtipoPlacaSinalizacaoNavigation)
                    .WithMany(p => p.TblPncvequipamentoFaixaVerificacaoPlaca)
                    .HasForeignKey(d => d.CodigoPncvtipoPlacaSinalizacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEquipamentoFaixaVerificacaoPlaca_PNCVTipoPlacaSinalizacao");
            });

            modelBuilder.Entity<TblPncvequipamentoFaixaVerificacaoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoFaixaVerificacaoSituacao)
                    .HasName("prkPNCVEquipamentoFaixaVerificacaoSituacao");

                entity.ToTable("tblPNCVEquipamentoFaixaVerificacaoSituacao");

                entity.Property(e => e.CodigoPncvequipamentoFaixaVerificacaoSituacao).HasColumnName("CodigoPNCVEquipamentoFaixaVerificacaoSituacao");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvequipamentoIndicadorCapturaImagem>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoIndicadorCapturaImagem)
                    .HasName("prkPNCVEquipamentoIndicadorCapturaImagem");

                entity.ToTable("tblPNCVEquipamentoIndicadorCapturaImagem");

                entity.Property(e => e.CodigoPncvequipamentoIndicadorCapturaImagem)
                    .HasColumnName("CodigoPNCVEquipamentoIndicadorCapturaImagem")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvequipamentoIndicadorComunicacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoIndicadorComunicacao)
                    .HasName("prkPNCVEquipamentoIndicadorComunicacao");

                entity.ToTable("tblPNCVEquipamentoIndicadorComunicacao");

                entity.Property(e => e.CodigoPncvequipamentoIndicadorComunicacao)
                    .HasColumnName("CodigoPNCVEquipamentoIndicadorComunicacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvequipamentoIndicadorInstalacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoIndicadorInstalacao)
                    .HasName("prkPNCVEquipamentoIndicadorInstalacao");

                entity.ToTable("tblPNCVEquipamentoIndicadorInstalacao");

                entity.Property(e => e.CodigoPncvequipamentoIndicadorInstalacao)
                    .HasColumnName("CodigoPNCVEquipamentoIndicadorInstalacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvequipamentoIndicadorTecnologia>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoIndicadorTecnologia)
                    .HasName("prkPNCVEquipamentoIndicadorTecnologia");

                entity.ToTable("tblPNCVEquipamentoIndicadorTecnologia");

                entity.Property(e => e.CodigoPncvequipamentoIndicadorTecnologia)
                    .HasColumnName("CodigoPNCVEquipamentoIndicadorTecnologia")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvequipamentoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvequipamentoTipo)
                    .HasName("prkPNCVEquipamentoTipo");

                entity.ToTable("tblPNCVEquipamentoTipo");

                entity.Property(e => e.CodigoPncvequipamentoTipo)
                    .HasColumnName("CodigoPNCVEquipamentoTipo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Letra)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoIndicadorClasseRodovia>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoIndicadorClasseRodovia)
                    .HasName("prkPNCVEstudoIndicadorClasseRodovia")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoIndicadorClasseRodovia");

                entity.Property(e => e.CodigoPncvestudoIndicadorClasseRodovia)
                    .HasColumnName("CodigoPNCVEstudoIndicadorClasseRodovia")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoIndicadorComparacaoVelocidade>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoIndicadorComparacaoVelocidade)
                    .HasName("prkPNCVEstudoIndicadorComparacaoVelocidade")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoIndicadorComparacaoVelocidade");

                entity.Property(e => e.CodigoPncvestudoIndicadorComparacaoVelocidade)
                    .HasColumnName("CodigoPNCVEstudoIndicadorComparacaoVelocidade")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoIndicadorCondicaoPavimento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoIndicadorCondicaoPavimento)
                    .HasName("prkPNCVEstudoIndicadorCondicaoPavimento")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoIndicadorCondicaoPavimento");

                entity.Property(e => e.CodigoPncvestudoIndicadorCondicaoPavimento)
                    .HasColumnName("CodigoPNCVEstudoIndicadorCondicaoPavimento")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoIndicadorDefensaMetalicaTerminal>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoIndicadorDefensaMetalicaTerminal)
                    .HasName("prkPNCVEstudoIndicadorDefensaMetalicaTerminal")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoIndicadorDefensaMetalicaTerminal");

                entity.Property(e => e.CodigoPncvestudoIndicadorDefensaMetalicaTerminal)
                    .HasColumnName("CodigoPNCVEstudoIndicadorDefensaMetalicaTerminal")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoIndicadorDispositivoSeguranca>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoIndicadorDispositivoSeguranca)
                    .HasName("prkPNCVEstudoIndicadorDispositivoSeguranca")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoIndicadorDispositivoSeguranca");

                entity.Property(e => e.CodigoPncvestudoIndicadorDispositivoSeguranca)
                    .HasColumnName("CodigoPNCVEstudoIndicadorDispositivoSeguranca")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoIndicadorGeometriaVia>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoIndicadorGeometriaVia)
                    .HasName("prkPNCVEstudoIndicadorGeometriaVia")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoIndicadorGeometriaVia");

                entity.Property(e => e.CodigoPncvestudoIndicadorGeometriaVia)
                    .HasColumnName("CodigoPNCVEstudoIndicadorGeometriaVia")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoIndicadorNivelRisco>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoIndicadorNivelRisco)
                    .HasName("prkPNCVEstudoIndicadorNivelRisco");

                entity.ToTable("tblPNCVEstudoIndicadorNivelRisco");

                entity.Property(e => e.CodigoPncvestudoIndicadorNivelRisco)
                    .HasColumnName("CodigoPNCVEstudoIndicadorNivelRisco")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoIndicadorRelevo>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoIndicadorRelevo)
                    .HasName("prkPNCVEstudoIndicadorRelevo")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoIndicadorRelevo");

                entity.Property(e => e.CodigoPncvestudoIndicadorRelevo)
                    .HasColumnName("CodigoPNCVEstudoIndicadorRelevo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoIndicadorSinalizacaoLadoRodovia>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoIndicadorSinalizacaoLadoRodovia)
                    .HasName("prkPNCVEstudoSinalizacaoIndicadorLadoRodovia");

                entity.ToTable("tblPNCVEstudoIndicadorSinalizacaoLadoRodovia");

                entity.Property(e => e.CodigoPncvestudoIndicadorSinalizacaoLadoRodovia)
                    .HasColumnName("CodigoPNCVEstudoIndicadorSinalizacaoLadoRodovia")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoIndicadorTracadoVia>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoIndicadorTracadoVia)
                    .HasName("prkPNCVEstudoIndicadorTracadoVia");

                entity.ToTable("tblPNCVEstudoIndicadorTracadoVia");

                entity.Property(e => e.CodigoPncvestudoIndicadorTracadoVia)
                    .HasColumnName("CodigoPNCVEstudoIndicadorTracadoVia")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoIndicadorTransito>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoIndicadorTransito)
                    .HasName("prkPNCVEstudoIndicadorTransito")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoIndicadorTransito");

                entity.Property(e => e.CodigoPncvestudoIndicadorTransito)
                    .HasColumnName("CodigoPNCVEstudoIndicadorTransito")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoTecnicoInstalacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoTecnicoInstalacao)
                    .HasName("prkPNCVEstudoTecnicoInstalacao")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoTecnicoInstalacao");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacao).HasColumnName("CodigoPNCVEstudoTecnicoInstalacao");

                entity.Property(e => e.AnaliseEngenheiroResponsavelCreanumero)
                    .HasColumnName("AnaliseEngenheiroResponsavelCREANumero")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AnaliseEngenheiroResponsavelNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AnaliseObservacaoAjuste).IsUnicode(false);

                entity.Property(e => e.AnaliseParecer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AnaliseRiscoFatorIndicadorOutroDescricao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AnaliseRiscoHistoricoMedidasAdotadas)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AnaliseRiscoOutrasInformacoesNecessarias)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoIdentificacaoDnit)
                    .IsRequired()
                    .HasColumnName("CodigoIdentificacaoDNIT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncveditalLote).HasColumnName("CodigoPNCVEditalLote");

                entity.Property(e => e.CodigoPncvequipamentoTipo).HasColumnName("CodigoPNCVEquipamentoTipo");

                entity.Property(e => e.CodigoPncvestudoIndicadorClasseRodovia).HasColumnName("CodigoPNCVEstudoIndicadorClasseRodovia");

                entity.Property(e => e.CodigoPncvestudoIndicadorDefensaMetalicaTerminalEntrada).HasColumnName("CodigoPNCVEstudoIndicadorDefensaMetalicaTerminalEntrada");

                entity.Property(e => e.CodigoPncvestudoIndicadorDefensaMetalicaTerminalSaida).HasColumnName("CodigoPNCVEstudoIndicadorDefensaMetalicaTerminalSaida");

                entity.Property(e => e.CodigoPncvestudoIndicadorDispositivoSeguranca).HasColumnName("CodigoPNCVEstudoIndicadorDispositivoSeguranca");

                entity.Property(e => e.CodigoPncvestudoIndicadorRelevo).HasColumnName("CodigoPNCVEstudoIndicadorRelevo");

                entity.Property(e => e.CodigoPncvestudoIndicadorTransitoCiclista).HasColumnName("CodigoPNCVEstudoIndicadorTransitoCiclista");

                entity.Property(e => e.CodigoPncvestudoIndicadorTransitoPedestre).HasColumnName("CodigoPNCVEstudoIndicadorTransitoPedestre");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacaoSituacao).HasColumnName("CodigoPNCVEstudoTecnicoInstalacaoSituacao");

                entity.Property(e => e.CodigoPncvestudoViabilidade).HasColumnName("CodigoPNCVEstudoViabilidade");

                entity.Property(e => e.CodigoRenavammunicipio).HasColumnName("CodigoRENAVAMMunicipio");

                entity.Property(e => e.CodigoUfcreaanaliseEngenheiroResponsavel).HasColumnName("CodigoUFCREAAnaliseEngenheiroResponsavel");

                entity.Property(e => e.CodigoUfcreaelaboracaoEngenheiroResponsavel).HasColumnName("CodigoUFCREAElaboracaoEngenheiroResponsavel");

                entity.Property(e => e.CroquiCaracterizacaoTrechoArquivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CroquiCaracterizacaoTrechoArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CroquiInstalacaoEquipamentoArquivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CroquiInstalacaoEquipamentoArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DataAnalise).HasColumnType("datetime");

                entity.Property(e => e.DataAnulacao).HasColumnType("datetime");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataAutorizacao).HasColumnType("datetime");

                entity.Property(e => e.DataElaboracao).HasColumnType("datetime");

                entity.Property(e => e.DataSolicitacaoRevisao).HasColumnType("datetime");

                entity.Property(e => e.DispositivoSegurancaJustificativa)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ElaboracaoEngenheiroResponsavelCreanumero)
                    .HasColumnName("ElaboracaoEngenheiroResponsavelCREANumero")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ElaboracaoEngenheiroResponsavelNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ElaboracaoParecer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EstudoPosteColapsivelArquivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EstudoPosteColapsivelArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EstudoVelocidadeArquivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EstudoVelocidadeArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LocalEstudoCodigoSnv)
                    .HasColumnName("LocalEstudoCodigoSNV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocalEstudoDataVersaoSnv)
                    .HasColumnName("LocalEstudoDataVersaoSNV")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalEstudoKm).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.RelatorioArquivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RelatorioArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RevisaoMotivo).IsUnicode(false);

                entity.Property(e => e.RevisaoObservacao).IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacao)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacao_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacao)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacao_BaseUF");

                entity.HasOne(d => d.CodigoPncveditalLoteNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacao)
                    .HasForeignKey(d => d.CodigoPncveditalLote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacao_PNCVEditalLote");

                entity.HasOne(d => d.CodigoPncvequipamentoTipoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacao)
                    .HasForeignKey(d => d.CodigoPncvequipamentoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacao_PNCVEquipamentoTipo");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorClasseRodoviaNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacao)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorClasseRodovia)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacao_PNCVEstudoIndicadorClasseRodovia");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorDefensaMetalicaTerminalEntradaNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoCodigoPncvestudoIndicadorDefensaMetalicaTerminalEntradaNavigation)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorDefensaMetalicaTerminalEntrada)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacao_PNCVEstudoIndicadorDefensaMetalicaTerminalEntrada");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorDefensaMetalicaTerminalSaidaNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoCodigoPncvestudoIndicadorDefensaMetalicaTerminalSaidaNavigation)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorDefensaMetalicaTerminalSaida)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacao_PNCVEstudoIndicadorDefensaMetalicaTerminalSaida");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorDispositivoSegurancaNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacao)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorDispositivoSeguranca)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacao_PNCVEstudoIndicadorDispositivoSeguranca");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorRelevoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacao)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorRelevo)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacao_PNCVEstudoIndicadorRelevo");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorTransitoCiclistaNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoCodigoPncvestudoIndicadorTransitoCiclistaNavigation)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorTransitoCiclista)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacao_PNCVEstudoIndicadorTransitoCiclista");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorTransitoPedestreNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoCodigoPncvestudoIndicadorTransitoPedestreNavigation)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorTransitoPedestre)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacao_PNCVEstudoIndicadorTransitoPedestre");

                entity.HasOne(d => d.CodigoPncvestudoTecnicoInstalacaoSituacaoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacao)
                    .HasForeignKey(d => d.CodigoPncvestudoTecnicoInstalacaoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacao_PNCVEstudoTecnicoInstalacaoSituacao");

                entity.HasOne(d => d.CodigoPncvestudoViabilidadeNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacao)
                    .HasForeignKey(d => d.CodigoPncvestudoViabilidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacao_PNCVEstudoViabilidade");

                entity.HasOne(d => d.CodigoSistemaUsuarioAnaliseNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoCodigoSistemaUsuarioAnaliseNavigation)
                    .HasForeignKey(d => d.CodigoSistemaUsuarioAnalise)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacao_SistemaUsuarioAnalise");

                entity.HasOne(d => d.CodigoSistemaUsuarioElaboracaoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoCodigoSistemaUsuarioElaboracaoNavigation)
                    .HasForeignKey(d => d.CodigoSistemaUsuarioElaboracao)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacao_SistemaUsuarioElaboracao");
            });

            modelBuilder.Entity<TblPncvestudoTecnicoInstalacaoAcidente>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoTecnicoInstalacaoAcidente)
                    .HasName("prkPNCVEstudoTecnicoInstalacaoAcidente");

                entity.ToTable("tblPNCVEstudoTecnicoInstalacaoAcidente");

                entity.HasIndex(e => e.CodigoPncvestudoTecnicoInstalacao)
                    .HasName("idxPNCVEstudoTecnicoInstalacaoAcidente");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacaoAcidente).HasColumnName("CodigoPNCVEstudoTecnicoInstalacaoAcidente");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacao).HasColumnName("CodigoPNCVEstudoTecnicoInstalacao");

                entity.Property(e => e.Ups).HasColumnName("UPS");

                entity.HasOne(d => d.CodigoPncvestudoTecnicoInstalacaoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoAcidente)
                    .HasForeignKey(d => d.CodigoPncvestudoTecnicoInstalacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoAcidente_PNCVEstudoTecnicoInstalacao");
            });

            modelBuilder.Entity<TblPncvestudoTecnicoInstalacaoCodigo>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoTecnicoInstalacaoCodigo)
                    .HasName("prkPNCVEstudoTecnicoInstalacaoCodigo")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoTecnicoInstalacaoCodigo");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacaoCodigo).HasColumnName("CodigoPNCVEstudoTecnicoInstalacaoCodigo");

                entity.Property(e => e.CodigoIdentificacaoDnit)
                    .IsRequired()
                    .HasColumnName("CodigoIdentificacaoDNIT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.SiglaUf)
                    .IsRequired()
                    .HasColumnName("SiglaUF")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoTecnicoInstalacaoEquipamento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoTecnicoInstalacaoEquipamento)
                    .HasName("prkPNCVEstudoTecnicoInstalacaoEquipamento");

                entity.ToTable("tblPNCVEstudoTecnicoInstalacaoEquipamento");

                entity.HasIndex(e => e.CodigoPncvestudoTecnicoInstalacao)
                    .HasName("idxPNCVEstudoTecnicoInstalacaoEquipamento");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacaoEquipamento).HasColumnName("CodigoPNCVEstudoTecnicoInstalacaoEquipamento");

                entity.Property(e => e.CodigoPncvautorizacaoInstalacaoEquipamento).HasColumnName("CodigoPNCVAutorizacaoInstalacaoEquipamento");

                entity.Property(e => e.CodigoPncvequipamento).HasColumnName("CodigoPNCVEquipamento");

                entity.Property(e => e.CodigoPncvequipamentoIndicadorComunicacao).HasColumnName("CodigoPNCVEquipamentoIndicadorComunicacao");

                entity.Property(e => e.CodigoPncvequipamentoIndicadorInstalacao).HasColumnName("CodigoPNCVEquipamentoIndicadorInstalacao");

                entity.Property(e => e.CodigoPncvequipamentoIndicadorTecnologia).HasColumnName("CodigoPNCVEquipamentoIndicadorTecnologia");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacao).HasColumnName("CodigoPNCVEstudoTecnicoInstalacao");

                entity.Property(e => e.CodigoPncvmodeloEquipamento).HasColumnName("CodigoPNCVModeloEquipamento");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvautorizacaoInstalacaoEquipamentoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvautorizacaoInstalacaoEquipamento)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoEquipamento_PNCVAutorizacaoInstalacaoEquipamento");

                entity.HasOne(d => d.CodigoPncvequipamentoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvequipamento)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoEquipamento_PNCVEquipamento");

                entity.HasOne(d => d.CodigoPncvequipamentoIndicadorComunicacaoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvequipamentoIndicadorComunicacao)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoEquipamento_PNCVEquipamentoIndicadorComunicacao");

                entity.HasOne(d => d.CodigoPncvequipamentoIndicadorInstalacaoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvequipamentoIndicadorInstalacao)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoEquipamento_PNCVEquipamentoIndicadorInstalacao");

                entity.HasOne(d => d.CodigoPncvequipamentoIndicadorTecnologiaNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvequipamentoIndicadorTecnologia)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoEquipamento_PNCVEquipamentoIndicadorTecnologia");

                entity.HasOne(d => d.CodigoPncvestudoTecnicoInstalacaoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvestudoTecnicoInstalacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoEquipamento_PNCVEstudoTecnicoInstalacao");

                entity.HasOne(d => d.CodigoPncvmodeloEquipamentoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvmodeloEquipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoEquipamento_PNCVModeloEquipamento");
            });

            modelBuilder.Entity<TblPncvestudoTecnicoInstalacaoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoTecnicoInstalacaoEvento)
                    .HasName("prkPNCVEstudoTecnicoInstalacaoEvento")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoTecnicoInstalacaoEvento");

                entity.HasIndex(e => new { e.CodigoPncvestudoTecnicoInstalacao, e.Data })
                    .HasName("idxPNCVEstudoTecnicoInstalacaoEvento");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacaoEvento).HasColumnName("CodigoPNCVEstudoTecnicoInstalacaoEvento");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacao).HasColumnName("CodigoPNCVEstudoTecnicoInstalacao");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacaoSituacao).HasColumnName("CodigoPNCVEstudoTecnicoInstalacaoSituacao");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvestudoTecnicoInstalacaoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoEvento)
                    .HasForeignKey(d => d.CodigoPncvestudoTecnicoInstalacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoEvento_PNCVEstudoTecnicoInstalacao");

                entity.HasOne(d => d.CodigoPncvestudoTecnicoInstalacaoSituacaoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoEvento)
                    .HasForeignKey(d => d.CodigoPncvestudoTecnicoInstalacaoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoEvento_PNCVEstudoTecnicoInstalacaoSituacao");
            });

            modelBuilder.Entity<TblPncvestudoTecnicoInstalacaoFaixa>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoTecnicoInstalacaoFaixa)
                    .HasName("prkPNCVEstudoTecnicoInstalacaoFaixa")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoTecnicoInstalacaoFaixa");

                entity.HasIndex(e => new { e.CodigoPncvestudoTecnicoInstalacao, e.CodigoPncvtipoVia, e.CodigoPncvsentidoRodovia, e.NumeroFaixa })
                    .HasName("idxPNCVEstudoTecnicoInstalacaoFaixa");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacaoFaixa).HasColumnName("CodigoPNCVEstudoTecnicoInstalacaoFaixa");

                entity.Property(e => e.CodigoPncvequipamentoIndicadorCapturaImagem).HasColumnName("CodigoPNCVEquipamentoIndicadorCapturaImagem");

                entity.Property(e => e.CodigoPncvestudoIndicadorComparacaoVelocidade).HasColumnName("CodigoPNCVEstudoIndicadorComparacaoVelocidade");

                entity.Property(e => e.CodigoPncvestudoIndicadorCondicaoPavimento).HasColumnName("CodigoPNCVEstudoIndicadorCondicaoPavimento");

                entity.Property(e => e.CodigoPncvestudoIndicadorGeometriaVia).HasColumnName("CodigoPNCVEstudoIndicadorGeometriaVia");

                entity.Property(e => e.CodigoPncvestudoIndicadorTracadoVia).HasColumnName("CodigoPNCVEstudoIndicadorTracadoVia");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacao).HasColumnName("CodigoPNCVEstudoTecnicoInstalacao");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacaoEquipamento).HasColumnName("CodigoPNCVEstudoTecnicoInstalacaoEquipamento");

                entity.Property(e => e.CodigoPncvsentidoRodovia).HasColumnName("CodigoPNCVSentidoRodovia");

                entity.Property(e => e.CodigoPncvtipoVia).HasColumnName("CodigoPNCVTipoVia");

                entity.Property(e => e.LarguraAcostamento).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.LarguraFaixa).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.TrechoAnteriorVelocidadePraticadaDataLevantamento).HasColumnType("date");

                entity.Property(e => e.Vmdano).HasColumnName("VMDAno");

                entity.Property(e => e.VmdpercentualVeiculosPesados).HasColumnName("VMDPercentualVeiculosPesados");

                entity.Property(e => e.Vmdvalor).HasColumnName("VMDValor");

                entity.HasOne(d => d.CodigoPncvequipamentoIndicadorCapturaImagemNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoFaixa)
                    .HasForeignKey(d => d.CodigoPncvequipamentoIndicadorCapturaImagem)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoFaixa_PNCVEquipamentoIndicadorCapturaImagem");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorComparacaoVelocidadeNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoFaixa)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorComparacaoVelocidade)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoFaixa_PNCVPNCVEstudoIndicadorComparacaoVelocidade");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorCondicaoPavimentoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoFaixa)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorCondicaoPavimento)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoFaixa_PNCVIndicadorCondicaoPavimento");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorGeometriaViaNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoFaixa)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorGeometriaVia)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoFaixa_PNCVEstudoIndicadorGeometriaVia");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorTracadoViaNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoFaixa)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorTracadoVia)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoFaixa_PNCVEstudoIndicadorTracadoVia");

                entity.HasOne(d => d.CodigoPncvestudoTecnicoInstalacaoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoFaixa)
                    .HasForeignKey(d => d.CodigoPncvestudoTecnicoInstalacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoFaixa_PNCVEstudoTecnicoInstalacao");

                entity.HasOne(d => d.CodigoPncvestudoTecnicoInstalacaoEquipamentoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoFaixa)
                    .HasForeignKey(d => d.CodigoPncvestudoTecnicoInstalacaoEquipamento)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoFaixa_PNCVEstudoTecnicoInstalacaoEquipamento");

                entity.HasOne(d => d.CodigoPncvsentidoRodoviaNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoFaixa)
                    .HasForeignKey(d => d.CodigoPncvsentidoRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoFaixa_PNCVSentidoFerrovia");

                entity.HasOne(d => d.CodigoPncvtipoViaNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoFaixa)
                    .HasForeignKey(d => d.CodigoPncvtipoVia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoFaixa_PNCVTipoVia");
            });

            modelBuilder.Entity<TblPncvestudoTecnicoInstalacaoFoto>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoTecnicoInstalacaoFoto)
                    .HasName("prkPNCVEstudoTecnicoInstalacaoFoto")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoTecnicoInstalacaoFoto");

                entity.HasIndex(e => e.CodigoPncvestudoTecnicoInstalacao)
                    .HasName("idxPNCVEstudoTecnicoInstalacaoFoto");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacaoFoto).HasColumnName("CodigoPNCVEstudoTecnicoInstalacaoFoto");

                entity.Property(e => e.ArquivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacao).HasColumnName("CodigoPNCVEstudoTecnicoInstalacao");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvestudoTecnicoInstalacaoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoFoto)
                    .HasForeignKey(d => d.CodigoPncvestudoTecnicoInstalacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoFoto_PNCVEstudoTecnicoInstalacao");
            });

            modelBuilder.Entity<TblPncvestudoTecnicoInstalacaoSinalizacaoVertical>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoTecnicoInstalacaoSinalizacaoVertical)
                    .HasName("prkPNCVEstudoTecnicoInstalacaoSinalizacaoVertical")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoTecnicoInstalacaoSinalizacaoVertical");

                entity.HasIndex(e => e.CodigoPncvestudoTecnicoInstalacao)
                    .HasName("idxPNCVEstudoTecnicoInstalacaoSinalizacaoVertical");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacaoSinalizacaoVertical).HasColumnName("CodigoPNCVEstudoTecnicoInstalacaoSinalizacaoVertical");

                entity.Property(e => e.CodigoPncvestudoIndicadorSinalizacaoLadoRodovia).HasColumnName("CodigoPNCVEstudoIndicadorSinalizacaoLadoRodovia");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacao).HasColumnName("CodigoPNCVEstudoTecnicoInstalacao");

                entity.Property(e => e.CodigoPncvsentidoRodovia).HasColumnName("CodigoPNCVSentidoRodovia");

                entity.Property(e => e.CodigoPncvtipoPlacaSinalizacao).HasColumnName("CodigoPNCVTipoPlacaSinalizacao");

                entity.Property(e => e.DimensaoAltura).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.DimensaoLargura).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.DistanciaAteEquipamento).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorSinalizacaoLadoRodoviaNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoSinalizacaoVertical)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorSinalizacaoLadoRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoSinalizacaoVertical_PNCVLadoRodovia");

                entity.HasOne(d => d.CodigoPncvestudoTecnicoInstalacaoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoSinalizacaoVertical)
                    .HasForeignKey(d => d.CodigoPncvestudoTecnicoInstalacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoSinalizacaoVertical_PNCVEstudoTecnicoInstalacao");

                entity.HasOne(d => d.CodigoPncvsentidoRodoviaNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoSinalizacaoVertical)
                    .HasForeignKey(d => d.CodigoPncvsentidoRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoSinalizacaoVertical_PNCVSentidoRodovia");

                entity.HasOne(d => d.CodigoPncvtipoPlacaSinalizacaoNavigation)
                    .WithMany(p => p.TblPncvestudoTecnicoInstalacaoSinalizacaoVertical)
                    .HasForeignKey(d => d.CodigoPncvtipoPlacaSinalizacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoTecnicoInstalacaoSinalizacaoVertical_PNCVTipoPlacaSinalizacao");
            });

            modelBuilder.Entity<TblPncvestudoTecnicoInstalacaoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoTecnicoInstalacaoSituacao)
                    .HasName("prkPNCVEstudoTecnicoInstalacaoSituacao");

                entity.ToTable("tblPNCVEstudoTecnicoInstalacaoSituacao");

                entity.Property(e => e.CodigoPncvestudoTecnicoInstalacaoSituacao)
                    .HasColumnName("CodigoPNCVEstudoTecnicoInstalacaoSituacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoViabilidade>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoViabilidade)
                    .HasName("prkPNCVEstudoViabilidade")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoViabilidade");

                entity.Property(e => e.CodigoPncvestudoViabilidade).HasColumnName("CodigoPNCVEstudoViabilidade");

                entity.Property(e => e.AnaliseParecer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AnaliseResponsavelNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoIdentificacaoDnit)
                    .HasColumnName("CodigoIdentificacaoDNIT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncvequipamentoTipo).HasColumnName("CodigoPNCVEquipamentoTipo");

                entity.Property(e => e.CodigoPncvestudoIndicadorClasseRodovia).HasColumnName("CodigoPNCVEstudoIndicadorClasseRodovia");

                entity.Property(e => e.CodigoPncvestudoIndicadorNivelRisco).HasColumnName("CodigoPNCVEstudoIndicadorNivelRisco");

                entity.Property(e => e.CodigoPncvestudoIndicadorRelevo).HasColumnName("CodigoPNCVEstudoIndicadorRelevo");

                entity.Property(e => e.CodigoPncvestudoIndicadorTransitoCiclista).HasColumnName("CodigoPNCVEstudoIndicadorTransitoCiclista");

                entity.Property(e => e.CodigoPncvestudoIndicadorTransitoPedestre).HasColumnName("CodigoPNCVEstudoIndicadorTransitoPedestre");

                entity.Property(e => e.CodigoPncvestudoViabilidadeMotivacao).HasColumnName("CodigoPNCVEstudoViabilidadeMotivacao");

                entity.Property(e => e.CodigoPncvestudoViabilidadeOrigem).HasColumnName("CodigoPNCVEstudoViabilidadeOrigem");

                entity.Property(e => e.CodigoPncvestudoViabilidadeResultado).HasColumnName("CodigoPNCVEstudoViabilidadeResultado");

                entity.Property(e => e.CodigoPncvestudoViabilidadeSituacao).HasColumnName("CodigoPNCVEstudoViabilidadeSituacao");

                entity.Property(e => e.CodigoRenavammunicipio).HasColumnName("CodigoRENAVAMMunicipio");

                entity.Property(e => e.DataAnalise).HasColumnType("datetime");

                entity.Property(e => e.DataAnulacao).HasColumnType("datetime");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataElaboracao).HasColumnType("datetime");

                entity.Property(e => e.ElaboracaoParecer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ElaboracaoResponsavelNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IndicadorObraCrema).HasColumnName("IndicadorObraCREMA");

                entity.Property(e => e.IndicadorObraIntervencaoBrlegal).HasColumnName("IndicadorObraIntervencaoBRLEGAL");

                entity.Property(e => e.LocalEstudoCodigoSnv)
                    .HasColumnName("LocalEstudoCodigoSNV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocalEstudoDataVersaoSnv)
                    .HasColumnName("LocalEstudoDataVersaoSNV")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalEstudoKm).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidade)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoViabilidade_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidade)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoViabilidade_BaseUF");

                entity.HasOne(d => d.CodigoPncvequipamentoTipoNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidade)
                    .HasForeignKey(d => d.CodigoPncvequipamentoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoViabilidade_PNCVEquipamentoTipo");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorClasseRodoviaNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidade)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorClasseRodovia)
                    .HasConstraintName("frkPNCVEstudoViabilidade_PNCVEstudoIndicadorClasseRodovia");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorNivelRiscoNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidade)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorNivelRisco)
                    .HasConstraintName("frkPNCVEstudoViabilidade_PNCVEstudoIndicadorNivelRisco");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorRelevoNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidade)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorRelevo)
                    .HasConstraintName("frkPNCVEstudoViabilidade_PNCVEstudoIndicadorRelevo");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorTransitoCiclistaNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidadeCodigoPncvestudoIndicadorTransitoCiclistaNavigation)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorTransitoCiclista)
                    .HasConstraintName("frkPNCVEstudoViabilidade_PNCVEstudoIndicadorTransitoCiclista");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorTransitoPedestreNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidadeCodigoPncvestudoIndicadorTransitoPedestreNavigation)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorTransitoPedestre)
                    .HasConstraintName("frkPNCVEstudoViabilidade_PNCVEstudoIndicadorTransitoPedestre");

                entity.HasOne(d => d.CodigoPncvestudoViabilidadeMotivacaoNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidade)
                    .HasForeignKey(d => d.CodigoPncvestudoViabilidadeMotivacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoViabilidade_PNCVEstudoViabilidadeMotivacao");

                entity.HasOne(d => d.CodigoPncvestudoViabilidadeOrigemNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidade)
                    .HasForeignKey(d => d.CodigoPncvestudoViabilidadeOrigem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoViabilidade_PNCVEstudoViabilidadeOrigem");

                entity.HasOne(d => d.CodigoPncvestudoViabilidadeResultadoNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidade)
                    .HasForeignKey(d => d.CodigoPncvestudoViabilidadeResultado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoViabilidade_PNCVEstudoViabilidadeResultado");

                entity.HasOne(d => d.CodigoPncvestudoViabilidadeSituacaoNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidade)
                    .HasForeignKey(d => d.CodigoPncvestudoViabilidadeSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoViabilidade_PNCVEstudoViabilidadeSituacao");

                entity.HasOne(d => d.CodigoSistemaUsuarioAnaliseNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidadeCodigoSistemaUsuarioAnaliseNavigation)
                    .HasForeignKey(d => d.CodigoSistemaUsuarioAnalise)
                    .HasConstraintName("frkPNCVEstudoViabilidade_SistemaUsuarioAnalise");

                entity.HasOne(d => d.CodigoSistemaUsuarioElaboracaoNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidadeCodigoSistemaUsuarioElaboracaoNavigation)
                    .HasForeignKey(d => d.CodigoSistemaUsuarioElaboracao)
                    .HasConstraintName("frkPNCVEstudoViabilidade_SistemaUsuarioElaboracao");
            });

            modelBuilder.Entity<TblPncvestudoViabilidadeAcidente>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoViabilidadeAcidente)
                    .HasName("prkPNCVEstudoViabilidadeAcidente")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoViabilidadeAcidente");

                entity.HasIndex(e => e.CodigoPncvestudoViabilidade)
                    .HasName("idxPNCVEstudoViabilidadeAcidente_PNCVEstudoViabilidade");

                entity.Property(e => e.CodigoPncvestudoViabilidadeAcidente).HasColumnName("CodigoPNCVEstudoViabilidadeAcidente");

                entity.Property(e => e.CodigoPncvestudoViabilidade).HasColumnName("CodigoPNCVEstudoViabilidade");

                entity.Property(e => e.Ups).HasColumnName("UPS");

                entity.HasOne(d => d.CodigoPncvestudoViabilidadeNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidadeAcidente)
                    .HasForeignKey(d => d.CodigoPncvestudoViabilidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoViabilidadeAcidente_PNCVEstudoViabilidade");
            });

            modelBuilder.Entity<TblPncvestudoViabilidadeCodigo>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoViabilidadeCodigo)
                    .HasName("prkPNCVEstudoViabilidadeCodigo")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoViabilidadeCodigo");

                entity.Property(e => e.CodigoPncvestudoViabilidadeCodigo).HasColumnName("CodigoPNCVEstudoViabilidadeCodigo");

                entity.Property(e => e.CodigoIdentificacaoDnit)
                    .IsRequired()
                    .HasColumnName("CodigoIdentificacaoDNIT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.SiglaUf)
                    .IsRequired()
                    .HasColumnName("SiglaUF")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoViabilidadeDocumento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoViabilidadeDocumento)
                    .HasName("prkPNCVEstudoViabilidadeDocumento")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoViabilidadeDocumento");

                entity.HasIndex(e => e.CodigoPncvestudoViabilidade)
                    .HasName("idxPNCVEstudoViabilidadeDocumento_PNCVEstudoViabilidade");

                entity.Property(e => e.CodigoPncvestudoViabilidadeDocumento).HasColumnName("CodigoPNCVEstudoViabilidadeDocumento");

                entity.Property(e => e.ArquivoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncvestudoViabilidade).HasColumnName("CodigoPNCVEstudoViabilidade");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvestudoViabilidadeNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidadeDocumento)
                    .HasForeignKey(d => d.CodigoPncvestudoViabilidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoViabilidadeDocumento_PNCVEstudoViabilidade");
            });

            modelBuilder.Entity<TblPncvestudoViabilidadeEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoViabilidadeEvento)
                    .HasName("prkPNCVEstudoViabilidadeEvento")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoViabilidadeEvento");

                entity.HasIndex(e => e.CodigoPncvestudoViabilidade)
                    .HasName("idxPNCVEstudoViabilidadeEvento_PNCVEstudoViabilidade");

                entity.Property(e => e.CodigoPncvestudoViabilidadeEvento).HasColumnName("CodigoPNCVEstudoViabilidadeEvento");

                entity.Property(e => e.CodigoPncvestudoViabilidade).HasColumnName("CodigoPNCVEstudoViabilidade");

                entity.Property(e => e.CodigoPncvestudoViabilidadeSituacao).HasColumnName("CodigoPNCVEstudoViabilidadeSituacao");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvestudoViabilidadeNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidadeEvento)
                    .HasForeignKey(d => d.CodigoPncvestudoViabilidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoViabilidadeEvento_PNCVEstudoViabilidade");

                entity.HasOne(d => d.CodigoPncvestudoViabilidadeSituacaoNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidadeEvento)
                    .HasForeignKey(d => d.CodigoPncvestudoViabilidadeSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoViabilidadeEvento_PNCVEstudoViabilidadeSituacao");
            });

            modelBuilder.Entity<TblPncvestudoViabilidadeFaixa>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoViabilidadeFaixa)
                    .HasName("prkPNCVEstudoViabilidadeFaixa")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoViabilidadeFaixa");

                entity.HasIndex(e => e.CodigoPncvestudoViabilidade)
                    .HasName("idxPNCVEstudoViabilidadeFaixa_PNCVEstudoViabilidade");

                entity.Property(e => e.CodigoPncvestudoViabilidadeFaixa).HasColumnName("CodigoPNCVEstudoViabilidadeFaixa");

                entity.Property(e => e.CodigoPncvestudoIndicadorCondicaoPavimento).HasColumnName("CodigoPNCVEstudoIndicadorCondicaoPavimento");

                entity.Property(e => e.CodigoPncvestudoIndicadorGeometriaVia).HasColumnName("CodigoPNCVEstudoIndicadorGeometriaVia");

                entity.Property(e => e.CodigoPncvestudoIndicadorTracadoVia).HasColumnName("CodigoPNCVEstudoIndicadorTracadoVia");

                entity.Property(e => e.CodigoPncvestudoViabilidade).HasColumnName("CodigoPNCVEstudoViabilidade");

                entity.Property(e => e.CodigoPncvsentidoRodovia).HasColumnName("CodigoPNCVSentidoRodovia");

                entity.Property(e => e.CodigoPncvtipoVia).HasColumnName("CodigoPNCVTipoVia");

                entity.Property(e => e.LarguraAcostamento).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.LarguraFaixa).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Vmdano).HasColumnName("VMDAno");

                entity.Property(e => e.VmdpercentualVeiculosPesados).HasColumnName("VMDPercentualVeiculosPesados");

                entity.Property(e => e.Vmdvalor).HasColumnName("VMDValor");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorCondicaoPavimentoNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidadeFaixa)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorCondicaoPavimento)
                    .HasConstraintName("frkPNCVEstudoViabilidadeFaixa_PNCVIndicadorCondicaoPavimento");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorGeometriaViaNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidadeFaixa)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorGeometriaVia)
                    .HasConstraintName("frkPNCVEstudoViabilidadeFaixa_PNCVEstudoIndicadorGeometriaVia");

                entity.HasOne(d => d.CodigoPncvestudoIndicadorTracadoViaNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidadeFaixa)
                    .HasForeignKey(d => d.CodigoPncvestudoIndicadorTracadoVia)
                    .HasConstraintName("frkPNCVEstudoViabilidadeFaixa_PNCVEstudoIndicadorTracadoVia");

                entity.HasOne(d => d.CodigoPncvestudoViabilidadeNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidadeFaixa)
                    .HasForeignKey(d => d.CodigoPncvestudoViabilidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoViabilidadeFaixa_PNCVEstudoViabilidade");

                entity.HasOne(d => d.CodigoPncvsentidoRodoviaNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidadeFaixa)
                    .HasForeignKey(d => d.CodigoPncvsentidoRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoViabilidadeFaixa_PNCVSentidoRodovia");

                entity.HasOne(d => d.CodigoPncvtipoViaNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidadeFaixa)
                    .HasForeignKey(d => d.CodigoPncvtipoVia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoViabilidadeFaixa_PNCVTipoVia");
            });

            modelBuilder.Entity<TblPncvestudoViabilidadeFoto>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoViabilidadeFoto)
                    .HasName("prkPNCVEstudoViabilidadeFoto")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoViabilidadeFoto");

                entity.HasIndex(e => e.CodigoPncvestudoViabilidade)
                    .HasName("idxPNCVEstudoViabilidadeFoto_PNCVEstudoViabilidade");

                entity.Property(e => e.CodigoPncvestudoViabilidadeFoto).HasColumnName("CodigoPNCVEstudoViabilidadeFoto");

                entity.Property(e => e.ArquivoNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoNomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncvestudoViabilidade).HasColumnName("CodigoPNCVEstudoViabilidade");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvestudoViabilidadeNavigation)
                    .WithMany(p => p.TblPncvestudoViabilidadeFoto)
                    .HasForeignKey(d => d.CodigoPncvestudoViabilidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVEstudoViabilidadeFoto_PNCVEstudoViabilidade");
            });

            modelBuilder.Entity<TblPncvestudoViabilidadeMotivacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoViabilidadeMotivacao)
                    .HasName("prkPNCVEstudoViabilidadeMotivacao")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoViabilidadeMotivacao");

                entity.Property(e => e.CodigoPncvestudoViabilidadeMotivacao)
                    .HasColumnName("CodigoPNCVEstudoViabilidadeMotivacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoViabilidadeOrigem>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoViabilidadeOrigem)
                    .HasName("prkPNCVEstudoViabilidadeOrigem")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoViabilidadeOrigem");

                entity.Property(e => e.CodigoPncvestudoViabilidadeOrigem)
                    .HasColumnName("CodigoPNCVEstudoViabilidadeOrigem")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoViabilidadeResultado>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoViabilidadeResultado)
                    .HasName("prkPNCVEstudoViabilidadeResultado");

                entity.ToTable("tblPNCVEstudoViabilidadeResultado");

                entity.Property(e => e.CodigoPncvestudoViabilidadeResultado)
                    .HasColumnName("CodigoPNCVEstudoViabilidadeResultado")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvestudoViabilidadeSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvestudoViabilidadeSituacao)
                    .HasName("prkPNCVEstudoViabilidadeSituacao")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPNCVEstudoViabilidadeSituacao");

                entity.Property(e => e.CodigoPncvestudoViabilidadeSituacao)
                    .HasColumnName("CodigoPNCVEstudoViabilidadeSituacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvmarcaEquipamento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvmarcaEquipamento)
                    .HasName("prkPNCVMarcaEquipamento");

                entity.ToTable("tblPNCVMarcaEquipamento");

                entity.Property(e => e.CodigoPncvmarcaEquipamento).HasColumnName("CodigoPNCVMarcaEquipamento");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvmodeloEquipamento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvmodeloEquipamento)
                    .HasName("prkPNCVModeloEquipamento");

                entity.ToTable("tblPNCVModeloEquipamento");

                entity.Property(e => e.CodigoPncvmodeloEquipamento).HasColumnName("CodigoPNCVModeloEquipamento");

                entity.Property(e => e.CodigoPncvmarcaEquipamento).HasColumnName("CodigoPNCVMarcaEquipamento");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvmarcaEquipamentoNavigation)
                    .WithMany(p => p.TblPncvmodeloEquipamento)
                    .HasForeignKey(d => d.CodigoPncvmarcaEquipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVModeloEquipamento_PNCVMarcaEquipamento");
            });

            modelBuilder.Entity<TblPncvmodeloEquipamentoRegistroSanmft>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvmodeloEquipamentoRegistroSanmft)
                    .HasName("prkPNCVModeloEquipamentoRegistroSANMFT");

                entity.ToTable("tblPNCVModeloEquipamentoRegistroSANMFT");

                entity.HasIndex(e => e.ArquivoReferenciaNomeFisico)
                    .HasName("unqPNCVModeloEquipamentoRegistroSANMFTArquivoReferenciaNomeFisico")
                    .IsUnique();

                entity.Property(e => e.CodigoPncvmodeloEquipamentoRegistroSanmft).HasColumnName("CodigoPNCVModeloEquipamentoRegistroSANMFT");

                entity.Property(e => e.ArquivoReferenciaNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoReferenciaNomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncvmodeloEquipamento).HasColumnName("CodigoPNCVModeloEquipamento");

                entity.Property(e => e.DataRegistro).HasColumnType("date");

                entity.Property(e => e.DataValidade).HasColumnType("date");

                entity.Property(e => e.NumeroRegistro)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvmodeloEquipamentoNavigation)
                    .WithMany(p => p.TblPncvmodeloEquipamentoRegistroSanmft)
                    .HasForeignKey(d => d.CodigoPncvmodeloEquipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVModeloEquipamentoRegistroSANMFT_PNCVModeloEquipamento");
            });

            modelBuilder.Entity<TblPncvnotaInstalacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvnotaInstalacao)
                    .HasName("prkPNCVNotaInstalacao");

                entity.ToTable("tblPNCVNotaInstalacao");

                entity.HasIndex(e => e.ArquivoReferenciaNomeFisico)
                    .HasName("unqPNCVNotaInstalacaoArquivoReferenciaNomeFisico")
                    .IsUnique();

                entity.Property(e => e.CodigoPncvnotaInstalacao).HasColumnName("CodigoPNCVNotaInstalacao");

                entity.Property(e => e.ArquivoReferenciaNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoReferenciaNomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncveditalLote).HasColumnName("CodigoPNCVEditalLote");

                entity.Property(e => e.DataEmissao).HasColumnType("date");

                entity.HasOne(d => d.CodigoPncveditalLoteNavigation)
                    .WithMany(p => p.TblPncvnotaInstalacao)
                    .HasForeignKey(d => d.CodigoPncveditalLote)
                    .HasConstraintName("frkPNCVNotaInstalacao_PNCVEditalLote");
            });

            modelBuilder.Entity<TblPncvnotaInstalacaoEquipamento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvnotaInstalacaoEquipamento)
                    .HasName("prkPNCVNotaInstalacaoEquipamento");

                entity.ToTable("tblPNCVNotaInstalacaoEquipamento");

                entity.Property(e => e.CodigoPncvnotaInstalacaoEquipamento).HasColumnName("CodigoPNCVNotaInstalacaoEquipamento");

                entity.Property(e => e.CodigoPncvequipamento).HasColumnName("CodigoPNCVEquipamento");

                entity.Property(e => e.CodigoPncvnotaInstalacao).HasColumnName("CodigoPNCVNotaInstalacao");

                entity.HasOne(d => d.CodigoPncvequipamentoNavigation)
                    .WithMany(p => p.TblPncvnotaInstalacaoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvequipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVNotaInstalacaoEquipamento_PNCVEquipamento");

                entity.HasOne(d => d.CodigoPncvnotaInstalacaoNavigation)
                    .WithMany(p => p.TblPncvnotaInstalacaoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvnotaInstalacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVNotaInstalacaoEquipamento_PNCVNotaInstalacao");
            });

            modelBuilder.Entity<TblPncvoperadora>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvoperadora)
                    .HasName("prkPNCVOperadora");

                entity.ToTable("tblPNCVOperadora");

                entity.Property(e => e.CodigoPncvoperadora).HasColumnName("CodigoPNCVOperadora");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvparametros>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvparametros)
                    .HasName("prkPNCVParametros");

                entity.ToTable("tblPNCVParametros");

                entity.Property(e => e.CodigoPncvparametros).HasColumnName("CodigoPNCVParametros");

                entity.Property(e => e.CaminhoLogRemessaContagem)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CaminhoLogRemessaInfracao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorSftpCaminhoPastaRaiz)
                    .IsRequired()
                    .HasColumnName("ServidorSFTP_CaminhoPastaRaiz")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorSftpEndereco)
                    .IsRequired()
                    .HasColumnName("ServidorSFTP_Endereco")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorSftpPorta).HasColumnName("ServidorSFTP_Porta");

                entity.Property(e => e.ServidorSftpUsuarioNome)
                    .IsRequired()
                    .HasColumnName("ServidorSFTP_UsuarioNome")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorSftpUsuarioSenha)
                    .IsRequired()
                    .HasColumnName("ServidorSFTP_UsuarioSenha")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvparametrosEditalLote>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvparametrosEditalLote)
                    .HasName("prkPNCVParametrosEditalLote");

                entity.ToTable("tblPNCVParametrosEditalLote");

                entity.HasIndex(e => e.CodigoPncveditalLote)
                    .HasName("unqPNCVParametrosEditalLote")
                    .IsUnique();

                entity.Property(e => e.CodigoPncvparametrosEditalLote).HasColumnName("CodigoPNCVParametrosEditalLote");

                entity.Property(e => e.CaminhoProcessamentoRemessaContagem)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CaminhoProcessamentoRemessaInfracao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CaminhoRemessaContagem)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CaminhoRemessaInfracao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CaminhoRetornoContagem)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CaminhoRetornoInfracao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncveditalLote).HasColumnName("CodigoPNCVEditalLote");

                entity.Property(e => e.CodigoPncvparametros).HasColumnName("CodigoPNCVParametros");

                entity.Property(e => e.ServidorSftpCaminhoRemessaContagem)
                    .IsRequired()
                    .HasColumnName("ServidorSFTP_CaminhoRemessaContagem")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorSftpCaminhoRemessaInfracao)
                    .IsRequired()
                    .HasColumnName("ServidorSFTP_CaminhoRemessaInfracao")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorSftpCaminhoRemessaProcessamentoContagem)
                    .IsRequired()
                    .HasColumnName("ServidorSFTP_CaminhoRemessaProcessamentoContagem")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorSftpCaminhoRemessaProcessamentoInfracao)
                    .IsRequired()
                    .HasColumnName("ServidorSFTP_CaminhoRemessaProcessamentoInfracao")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorSftpCaminhoRetornoContagem)
                    .IsRequired()
                    .HasColumnName("ServidorSFTP_CaminhoRetornoContagem")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorSftpCaminhoRetornoInfracao)
                    .IsRequired()
                    .HasColumnName("ServidorSFTP_CaminhoRetornoInfracao")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorSftpUsuarioNome)
                    .IsRequired()
                    .HasColumnName("ServidorSFTP_UsuarioNome")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorSftpUsuarioSenha)
                    .IsRequired()
                    .HasColumnName("ServidorSFTP_UsuarioSenha")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncveditalLoteNavigation)
                    .WithOne(p => p.TblPncvparametrosEditalLote)
                    .HasForeignKey<TblPncvparametrosEditalLote>(d => d.CodigoPncveditalLote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVParametrosEditalLote_PNCVEditalLote");

                entity.HasOne(d => d.CodigoPncvparametrosNavigation)
                    .WithMany(p => p.TblPncvparametrosEditalLote)
                    .HasForeignKey(d => d.CodigoPncvparametros)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVParametrosEditalLote_PNCVParametros");
            });

            modelBuilder.Entity<TblPncvsentidoRodovia>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvsentidoRodovia)
                    .HasName("prkPNCVSentidoRodovia");

                entity.ToTable("tblPNCVSentidoRodovia");

                entity.Property(e => e.CodigoPncvsentidoRodovia).HasColumnName("CodigoPNCVSentidoRodovia");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvsolicitacaoCancelamento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvsolicitacaoCancelamento)
                    .HasName("prkPNCVSolicitacaoCancelamento");

                entity.ToTable("tblPNCVSolicitacaoCancelamento");

                entity.Property(e => e.CodigoPncvsolicitacaoCancelamento).HasColumnName("CodigoPNCVSolicitacaoCancelamento");

                entity.Property(e => e.CodigoPncvsolicitacaoCancelamentoSituacao).HasColumnName("CodigoPNCVSolicitacaoCancelamentoSituacao");

                entity.Property(e => e.DataDeferimento).HasColumnType("date");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.Observacoes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Solicitante)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvsolicitacaoCancelamentoSituacaoNavigation)
                    .WithMany(p => p.TblPncvsolicitacaoCancelamento)
                    .HasForeignKey(d => d.CodigoPncvsolicitacaoCancelamentoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVSolicitacaoCancelamento_PNCVSolicitacaoCancelamentoSituacao");
            });

            modelBuilder.Entity<TblPncvsolicitacaoCancelamentoArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvsolicitacaoCancelamentoArquivo)
                    .HasName("prkPNCVSolicitacaoCancelamentoArquivo");

                entity.ToTable("tblPNCVSolicitacaoCancelamentoArquivo");

                entity.HasIndex(e => e.CodigoPncvsolicitacaoCancelamento)
                    .HasName("idxPNCVSolicitacaoCancelamentoArquivo");

                entity.Property(e => e.CodigoPncvsolicitacaoCancelamentoArquivo).HasColumnName("CodigoPNCVSolicitacaoCancelamentoArquivo");

                entity.Property(e => e.ArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncvsolicitacaoCancelamento).HasColumnName("CodigoPNCVSolicitacaoCancelamento");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvsolicitacaoCancelamentoNavigation)
                    .WithMany(p => p.TblPncvsolicitacaoCancelamentoArquivo)
                    .HasForeignKey(d => d.CodigoPncvsolicitacaoCancelamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVSolicitacaoCancelamentoArquivo_PNCVSolicitacaoCancelamento");
            });

            modelBuilder.Entity<TblPncvsolicitacaoCancelamentoEquipamento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvsolicitacaoCancelamentoEquipamento)
                    .HasName("prkPNCVSolicitacaoCancelamentoEquipamento");

                entity.ToTable("tblPNCVSolicitacaoCancelamentoEquipamento");

                entity.HasIndex(e => new { e.CodigoPncvequipamento, e.CodigoPncvsolicitacaoCancelamento })
                    .HasName("idxPNCVSolicitacaoCancelamentoEquipamento");

                entity.Property(e => e.CodigoPncvsolicitacaoCancelamentoEquipamento).HasColumnName("CodigoPNCVSolicitacaoCancelamentoEquipamento");

                entity.Property(e => e.CodigoPncvequipamento).HasColumnName("CodigoPNCVEquipamento");

                entity.Property(e => e.CodigoPncvsolicitacaoCancelamento).HasColumnName("CodigoPNCVSolicitacaoCancelamento");

                entity.HasOne(d => d.CodigoPncvequipamentoNavigation)
                    .WithMany(p => p.TblPncvsolicitacaoCancelamentoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvequipamento)
                    .HasConstraintName("frkPNCVSolicitacaoCancelamentoEquipamento_PNCVEquipamento");

                entity.HasOne(d => d.CodigoPncvsolicitacaoCancelamentoNavigation)
                    .WithMany(p => p.TblPncvsolicitacaoCancelamentoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvsolicitacaoCancelamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVSolicitacaoCancelamentoEquipamento_PNCVSolicitacaoCancelamento");
            });

            modelBuilder.Entity<TblPncvsolicitacaoCancelamentoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvsolicitacaoCancelamentoEvento)
                    .HasName("prkPNCVSolicitacaoCancelamentoEvento");

                entity.ToTable("tblPNCVSolicitacaoCancelamentoEvento");

                entity.HasIndex(e => new { e.CodigoPncvsolicitacaoCancelamento, e.Data })
                    .HasName("idxPNCVSolicitacaoCancelamentoEvento");

                entity.Property(e => e.CodigoPncvsolicitacaoCancelamentoEvento).HasColumnName("CodigoPNCVSolicitacaoCancelamentoEvento");

                entity.Property(e => e.CodigoPncvsolicitacaoCancelamento).HasColumnName("CodigoPNCVSolicitacaoCancelamento");

                entity.Property(e => e.CodigoPncvsolicitacaoCancelamentoSituacao).HasColumnName("CodigoPNCVSolicitacaoCancelamentoSituacao");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvsolicitacaoCancelamentoNavigation)
                    .WithMany(p => p.TblPncvsolicitacaoCancelamentoEvento)
                    .HasForeignKey(d => d.CodigoPncvsolicitacaoCancelamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVSolicitacaoCancelamentoEvento_PNCVSolicitacaoCancelamento");

                entity.HasOne(d => d.CodigoPncvsolicitacaoCancelamentoSituacaoNavigation)
                    .WithMany(p => p.TblPncvsolicitacaoCancelamentoEvento)
                    .HasForeignKey(d => d.CodigoPncvsolicitacaoCancelamentoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVSolicitacaoCancelamentoEvento_PNCVSolicitacaoCancelamentoSituacao");
            });

            modelBuilder.Entity<TblPncvsolicitacaoCancelamentoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvsolicitacaoCancelamentoSituacao)
                    .HasName("prkPNCVSolicitacaoCancelamentoSituacao");

                entity.ToTable("tblPNCVSolicitacaoCancelamentoSituacao");

                entity.Property(e => e.CodigoPncvsolicitacaoCancelamentoSituacao)
                    .HasColumnName("CodigoPNCVSolicitacaoCancelamentoSituacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvsolicitacaoTransferenciaContrato>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvsolicitacaoTransferenciaContrato)
                    .HasName("prkPNCVSolicitacaoTransferenciaContrato");

                entity.ToTable("tblPNCVSolicitacaoTransferenciaContrato");

                entity.Property(e => e.CodigoPncvsolicitacaoTransferenciaContrato).HasColumnName("CodigoPNCVSolicitacaoTransferenciaContrato");

                entity.Property(e => e.CodigoPncveditalLote).HasColumnName("CodigoPNCVEditalLote");

                entity.Property(e => e.CodigoPncvsolicitacaoTransferenciaContratoSituacao).HasColumnName("CodigoPNCVSolicitacaoTransferenciaContratoSituacao");

                entity.Property(e => e.DataProtocolo).HasColumnType("date");

                entity.Property(e => e.Observacoes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Solicitante)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncveditalLoteNavigation)
                    .WithMany(p => p.TblPncvsolicitacaoTransferenciaContrato)
                    .HasForeignKey(d => d.CodigoPncveditalLote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVSolicitacaoTransferenciaContrato_PNCVEditalLote");

                entity.HasOne(d => d.CodigoPncvsolicitacaoTransferenciaContratoSituacaoNavigation)
                    .WithMany(p => p.TblPncvsolicitacaoTransferenciaContrato)
                    .HasForeignKey(d => d.CodigoPncvsolicitacaoTransferenciaContratoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVSolicitacaoTransferenciaContrato_PNCVSolicitacaoTransferenciaContratoSituacao");
            });

            modelBuilder.Entity<TblPncvsolicitacaoTransferenciaContratoArquivo>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvsolicitacaoTransferenciaContratoArquivo)
                    .HasName("prkPNCVSolicitacaoTransferenciaContratoArquivo");

                entity.ToTable("tblPNCVSolicitacaoTransferenciaContratoArquivo");

                entity.HasIndex(e => e.CodigoPncvsolicitacaoTransferenciaContrato)
                    .HasName("idxPNCVSolicitacaoTransferenciaContratoArquivo");

                entity.Property(e => e.CodigoPncvsolicitacaoTransferenciaContratoArquivo).HasColumnName("CodigoPNCVSolicitacaoTransferenciaContratoArquivo");

                entity.Property(e => e.ArquivoNomeFisico)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncvsolicitacaoTransferenciaContrato).HasColumnName("CodigoPNCVSolicitacaoTransferenciaContrato");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvsolicitacaoTransferenciaContratoNavigation)
                    .WithMany(p => p.TblPncvsolicitacaoTransferenciaContratoArquivo)
                    .HasForeignKey(d => d.CodigoPncvsolicitacaoTransferenciaContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVSolicitacaoTransferenciaContratoArquivo_PNCVSolicitacaoTransferenciaContrato");
            });

            modelBuilder.Entity<TblPncvsolicitacaoTransferenciaContratoEquipamento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvsolicitacaoTransferenciaContratoEquipamento)
                    .HasName("prkPNCVSolicitacaoTransferenciaContratoEquipamento");

                entity.ToTable("tblPNCVSolicitacaoTransferenciaContratoEquipamento");

                entity.HasIndex(e => e.CodigoPncvsolicitacaoTransferenciaContrato)
                    .HasName("idxPNCVSolicitacaoTransferenciaContratoEquipamento");

                entity.Property(e => e.CodigoPncvsolicitacaoTransferenciaContratoEquipamento).HasColumnName("CodigoPNCVSolicitacaoTransferenciaContratoEquipamento");

                entity.Property(e => e.CodigoPncvequipamento).HasColumnName("CodigoPNCVEquipamento");

                entity.Property(e => e.CodigoPncvsolicitacaoTransferenciaContrato).HasColumnName("CodigoPNCVSolicitacaoTransferenciaContrato");

                entity.HasOne(d => d.CodigoPncvequipamentoNavigation)
                    .WithMany(p => p.TblPncvsolicitacaoTransferenciaContratoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvequipamento)
                    .HasConstraintName("frkPNCVSolicitacaoTransferenciaContratoEquipamento_PNCVEquipamento");

                entity.HasOne(d => d.CodigoPncvsolicitacaoTransferenciaContratoNavigation)
                    .WithMany(p => p.TblPncvsolicitacaoTransferenciaContratoEquipamento)
                    .HasForeignKey(d => d.CodigoPncvsolicitacaoTransferenciaContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVSolicitacaoTransferenciaContratoEquipamento_PNCVSolicitacaoTransferenciaContrato");
            });

            modelBuilder.Entity<TblPncvsolicitacaoTransferenciaContratoEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvsolicitacaoTransferenciaContratoEvento)
                    .HasName("prkPNCVSolicitacaoTransferenciaContratoEvento");

                entity.ToTable("tblPNCVSolicitacaoTransferenciaContratoEvento");

                entity.HasIndex(e => new { e.CodigoPncvsolicitacaoTransferenciaContrato, e.Data })
                    .HasName("idxPNCVSolicitacaoTransferenciaContratoEvento");

                entity.Property(e => e.CodigoPncvsolicitacaoTransferenciaContratoEvento).HasColumnName("CodigoPNCVSolicitacaoTransferenciaContratoEvento");

                entity.Property(e => e.CodigoPncvsolicitacaoTransferenciaContrato).HasColumnName("CodigoPNCVSolicitacaoTransferenciaContrato");

                entity.Property(e => e.CodigoPncvsolicitacaoTransferenciaContratoSituacao).HasColumnName("CodigoPNCVSolicitacaoTransferenciaContratoSituacao");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoPncvsolicitacaoTransferenciaContratoNavigation)
                    .WithMany(p => p.TblPncvsolicitacaoTransferenciaContratoEvento)
                    .HasForeignKey(d => d.CodigoPncvsolicitacaoTransferenciaContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVSolicitacaoTransferenciaContratoEvento_PNCVSolicitacaoTransferenciaContrato");

                entity.HasOne(d => d.CodigoPncvsolicitacaoTransferenciaContratoSituacaoNavigation)
                    .WithMany(p => p.TblPncvsolicitacaoTransferenciaContratoEvento)
                    .HasForeignKey(d => d.CodigoPncvsolicitacaoTransferenciaContratoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkPNCVSolicitacaoTransferenciaContratoEvento_PNCVSolicitacaoTransferenciaContratoSituacao");
            });

            modelBuilder.Entity<TblPncvsolicitacaoTransferenciaContratoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvsolicitacaoTransferenciaContratoSituacao)
                    .HasName("prkPNCVSolicitacaoTransferenciaContratoSituacao");

                entity.ToTable("tblPNCVSolicitacaoTransferenciaContratoSituacao");

                entity.Property(e => e.CodigoPncvsolicitacaoTransferenciaContratoSituacao)
                    .HasColumnName("CodigoPNCVSolicitacaoTransferenciaContratoSituacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvtipoPlacaSinalizacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvtipoPlacaSinalizacao)
                    .HasName("prkPNCVTipoPlacaSinalizacao");

                entity.ToTable("tblPNCVTipoPlacaSinalizacao");

                entity.Property(e => e.CodigoPncvtipoPlacaSinalizacao).HasColumnName("CodigoPNCVTipoPlacaSinalizacao");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPncvtipoVia>(entity =>
            {
                entity.HasKey(e => e.CodigoPncvtipoVia)
                    .HasName("prkPNCVTipoVia");

                entity.ToTable("tblPNCVTipoVia");

                entity.Property(e => e.CodigoPncvtipoVia)
                    .HasColumnName("CodigoPNCVTipoVia")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSegurancaAcidenteTransito>(entity =>
            {
                entity.HasKey(e => e.CodigoSegurancaAcidenteTransito)
                    .HasName("prkSegurancaAcidenteTransito");

                entity.ToTable("tblSegurancaAcidenteTransito");

                entity.HasIndex(e => new { e.CodigoBaseUf, e.CodigoBaseRodovia, e.CodigoSegurancaAcidenteTransitoGravidade, e.CodigoSegurancaAcidenteTransitoTipo, e.CodigoSegurancaAcidenteTransitoCausa, e.Quilometro, e.Data })
                    .HasName("idxSegurancaAcidenteTransito");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Quilometro).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.Snvtrecho)
                    .HasColumnName("SNVTrecho")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblSegurancaAcidenteTransito)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSegurancaAcidenteTransito_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblSegurancaAcidenteTransito)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSegurancaAcidenteTransito_BaseUF");

                entity.HasOne(d => d.CodigoSegurancaAcidenteTransitoCausaNavigation)
                    .WithMany(p => p.TblSegurancaAcidenteTransito)
                    .HasForeignKey(d => d.CodigoSegurancaAcidenteTransitoCausa)
                    .HasConstraintName("frkSegurancaAcidenteTransito_SegurancaAcidenteTransitoCausa");

                entity.HasOne(d => d.CodigoSegurancaAcidenteTransitoGravidadeNavigation)
                    .WithMany(p => p.TblSegurancaAcidenteTransito)
                    .HasForeignKey(d => d.CodigoSegurancaAcidenteTransitoGravidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSegurancaAcidenteTransito_SegurancaAcidenteTransitoGravidade");

                entity.HasOne(d => d.CodigoSegurancaAcidenteTransitoSentidoNavigation)
                    .WithMany(p => p.TblSegurancaAcidenteTransito)
                    .HasForeignKey(d => d.CodigoSegurancaAcidenteTransitoSentido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSegurancaAcidenteTransito_SegurancaAcidenteTransitoSentido");

                entity.HasOne(d => d.CodigoSegurancaAcidenteTransitoTipoNavigation)
                    .WithMany(p => p.TblSegurancaAcidenteTransito)
                    .HasForeignKey(d => d.CodigoSegurancaAcidenteTransitoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSegurancaAcidenteTransito_SegurancaAcidenteTransitoTipo");

                entity.HasOne(d => d.CodigoSegurancaAcidenteTransitoUsoSoloNavigation)
                    .WithMany(p => p.TblSegurancaAcidenteTransito)
                    .HasForeignKey(d => d.CodigoSegurancaAcidenteTransitoUsoSolo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSegurancaAcidenteTransito_SegurancaAcidenteTransitoUsoSolo");
            });

            modelBuilder.Entity<TblSegurancaAcidenteTransitoCausa>(entity =>
            {
                entity.HasKey(e => e.CodigoSegurancaAcidenteTransitoCausa)
                    .HasName("prkSegurancaAcidenteTransitoCausa");

                entity.ToTable("tblSegurancaAcidenteTransitoCausa");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSegurancaAcidenteTransitoFonteDados>(entity =>
            {
                entity.HasKey(e => e.CodigoSegurancaAcidenteTransitoFonteDados)
                    .HasName("prkSegurancaAcidenteTransitoFonteDados");

                entity.ToTable("tblSegurancaAcidenteTransitoFonteDados");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.Nome)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSegurancaAcidenteTransitoGravidade>(entity =>
            {
                entity.HasKey(e => e.CodigoSegurancaAcidenteTransitoGravidade)
                    .HasName("prkSegurancaAcidenteTransitoGravidade");

                entity.ToTable("tblSegurancaAcidenteTransitoGravidade");

                entity.HasIndex(e => e.Nome)
                    .HasName("idxSegurancaAcidenteTransitoGravidade_Nome")
                    .IsUnique();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSegurancaAcidenteTransitoSentido>(entity =>
            {
                entity.HasKey(e => e.CodigoSegurancaAcidenteTransitoSentido)
                    .HasName("prkSegurancaAcidenteTransitoSentido");

                entity.ToTable("tblSegurancaAcidenteTransitoSentido");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSegurancaAcidenteTransitoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoSegurancaAcidenteTransitoTipo)
                    .HasName("prkSegurancaAcidenteTransitoTipo");

                entity.ToTable("tblSegurancaAcidenteTransitoTipo");

                entity.HasIndex(e => new { e.Nome, e.Sigla })
                    .HasName("idxSegurancaAcidenteTransitoTipo_Nome_Sigla")
                    .IsUnique();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(22)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSegurancaAcidenteTransitoUsoSolo>(entity =>
            {
                entity.HasKey(e => e.CodigoSegurancaAcidenteTransitoUsoSolo)
                    .HasName("prkSegurancaAcidenteTransitoUsoSolo");

                entity.ToTable("tblSegurancaAcidenteTransitoUsoSolo");

                entity.HasIndex(e => e.Nome)
                    .HasName("idxSegurancaAcidenteTransitoUsoSolo_Nome")
                    .IsUnique();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSegurancaClasseSegmentoRodovia>(entity =>
            {
                entity.HasKey(e => e.CodigoSegurancaClasseSegmentoRodovia)
                    .HasName("prkSegurancaClasseSegmentoRodovia");

                entity.ToTable("tblSegurancaClasseSegmentoRodovia");

                entity.HasIndex(e => e.Nome)
                    .HasName("idxSegurancaClasseSegmentoRodovia_Nome")
                    .IsUnique();

                entity.Property(e => e.CodigoSegurancaClasseSegmentoRodovia).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSegurancaSegmentoCritico>(entity =>
            {
                entity.HasKey(e => e.CodigoSegmentoCritico)
                    .HasName("prkSegurancaSegmentoCritico");

                entity.ToTable("tblSegurancaSegmentoCritico");

                entity.Property(e => e.Classe)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoSnvtrechoDnit)
                    .IsRequired()
                    .HasColumnName("CodigoSNVTrechoDNIT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Criticidade)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.QuilometroFinal).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.QuilometroInicial).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.SiglaTipoSuperficie)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Vmda).HasColumnName("VMDa");

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblSegurancaSegmentoCritico)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSegurancaSegmentoCritico_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblSegurancaSegmentoCritico)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSegurancaSegmentoCritico_BaseUF");
            });

            modelBuilder.Entity<TblSegurancaSegmentoHomogeneo>(entity =>
            {
                entity.HasKey(e => e.CodigoSegurancaSegmentoHomogeneo)
                    .HasName("prkSegurancaSegmentoHomogeneo");

                entity.ToTable("tblSegurancaSegmentoHomogeneo");

                entity.Property(e => e.Classe)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoSnvtrecho)
                    .IsRequired()
                    .HasColumnName("CodigoSNVTrecho")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QuilometroFinal).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.QuilometroInicial).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.Superficie)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Terreno)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsoSolo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblSegurancaSegmentoHomogeneo)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSegurancaSegmentoHomogeneo_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblSegurancaSegmentoHomogeneo)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSegurancaSegmentoHomogeneo_BaseUF");
            });

            modelBuilder.Entity<TblSistemaAcao>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaAcao)
                    .HasName("prkSistemaAcao");

                entity.ToTable("tblSistemaAcao");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeApresentacao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSistemaControleNavigation)
                    .WithMany(p => p.TblSistemaAcao)
                    .HasForeignKey(d => d.CodigoSistemaControle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaAcao_SistemaControle");
            });

            modelBuilder.Entity<TblSistemaArea>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaArea)
                    .HasName("prkSistemaArea");

                entity.ToTable("tblSistemaArea");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSistemaCatalogoConexao>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaCatalogoConexao)
                    .HasName("prkSistemaCatalogoConexao");

                entity.ToTable("tblSistemaCatalogoConexao");

                entity.Property(e => e.CertificadoAplicacaoEnderecoArquivo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CertificadoAplicacaoSenha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoIdentificacao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PastaLocalPadrao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PastaRemotaPadrao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PastaRemotaTemporariaPadrao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSistemaCatalogoConexaoServicoNavigation)
                    .WithMany(p => p.TblSistemaCatalogoConexao)
                    .HasForeignKey(d => d.CodigoSistemaCatalogoConexaoServico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaCatalogoConexao_SistemaCatalogoConexaoServico");
            });

            modelBuilder.Entity<TblSistemaCatalogoConexaoServico>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaCatalogoConexaoServico)
                    .HasName("prkSistemaCatalogoConexaoServico");

                entity.ToTable("tblSistemaCatalogoConexaoServico");

                entity.Property(e => e.CodigoSistemaCatalogoConexaoServico).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSistemaConfiguracao>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaConfiguracao)
                    .HasName("prkSistemaConfiguracao");

                entity.ToTable("tblSistemaConfiguracao");

                entity.Property(e => e.NomePropriedade)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ValorPropriedade)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSistemaConfiguracaoPropriedadeTipoNavigation)
                    .WithMany(p => p.TblSistemaConfiguracao)
                    .HasForeignKey(d => d.CodigoSistemaConfiguracaoPropriedadeTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaConfiguracao_SistemaConfiguracaoPropriedadeTipo");
            });

            modelBuilder.Entity<TblSistemaConfiguracaoPropriedadeTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaConfiguracaoPropriedadeTipo)
                    .HasName("prkSistemaConfiguracaoPropriedadeTipo");

                entity.ToTable("tblSistemaConfiguracaoPropriedadeTipo");

                entity.Property(e => e.CodigoSistemaConfiguracaoPropriedadeTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSistemaControle>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaControle)
                    .HasName("prkSistemaControle");

                entity.ToTable("tblSistemaControle");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSistemaAreaNavigation)
                    .WithMany(p => p.TblSistemaControle)
                    .HasForeignKey(d => d.CodigoSistemaArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaControle_SistemaArea");
            });

            modelBuilder.Entity<TblSistemaEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaEvento)
                    .HasName("prkSistemaEvento");

                entity.ToTable("tblSistemaEvento");

                entity.HasIndex(e => new { e.CodigoSistemaEventoTipo, e.CodigoSistemaUsuario, e.Data })
                    .HasName("idxSistemaEvento_Usuario_Data");

                entity.Property(e => e.CaminhoFuncionalidadeAcao)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Detalhes).IsUnicode(false);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeComputador)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIp)
                    .IsRequired()
                    .HasColumnName("NumeroIP")
                    .HasMaxLength(39)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSistemaEventoTipoNavigation)
                    .WithMany(p => p.TblSistemaEvento)
                    .HasForeignKey(d => d.CodigoSistemaEventoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaEvento_SistemaEventoTipo");
            });

            modelBuilder.Entity<TblSistemaEventoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaEventoTipo)
                    .HasName("prkSistemaEventoTipo");

                entity.ToTable("tblSistemaEventoTipo");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSistemaInstituicao>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaInstituicao)
                    .HasName("prkSistemaInstituicao");

                entity.ToTable("tblSistemaInstituicao");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeEmpresaLiderConsorcio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBaseMunicipioNavigation)
                    .WithMany(p => p.TblSistemaInstituicao)
                    .HasForeignKey(d => d.CodigoBaseMunicipio)
                    .HasConstraintName("frkSistemaInstituicao_BaseMunicipio");

                entity.HasOne(d => d.CodigoSistemaInstituicaoTipoNavigation)
                    .WithMany(p => p.TblSistemaInstituicao)
                    .HasForeignKey(d => d.CodigoSistemaInstituicaoTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaInstituicao_SistemaInstituicaoTipo");
            });

            modelBuilder.Entity<TblSistemaInstituicaoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaInstituicaoTipo)
                    .HasName("prkSistemaInstituicaoTipo");

                entity.ToTable("tblSistemaInstituicaoTipo");

                entity.Property(e => e.CodigoSistemaInstituicaoTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSistemaMenu>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaMenu)
                    .HasName("prkSistemaMenu");

                entity.ToTable("tblSistemaMenu");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParametroFiltro)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSistemaAcaoRotaNavigation)
                    .WithMany(p => p.TblSistemaMenu)
                    .HasForeignKey(d => d.CodigoSistemaAcaoRota)
                    .HasConstraintName("frkSistemaMenu_SistemaAcaoRota");

                entity.HasOne(d => d.CodigoSistemaControleNavigation)
                    .WithMany(p => p.TblSistemaMenu)
                    .HasForeignKey(d => d.CodigoSistemaControle)
                    .HasConstraintName("frkSistemaMenu_SistemaControle");

                entity.HasOne(d => d.CodigoSistemaMenuPaiNavigation)
                    .WithMany(p => p.InverseCodigoSistemaMenuPaiNavigation)
                    .HasForeignKey(d => d.CodigoSistemaMenuPai)
                    .HasConstraintName("frkSistemaMenu_SistemaMenuPai");
            });

            modelBuilder.Entity<TblSistemaPerfil>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaPerfil)
                    .HasName("prkSistemaPerfil");

                entity.ToTable("tblSistemaPerfil");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSistemaPerfilAcao>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaPerfilAcao)
                    .HasName("prkSistemaPerfilAcao");

                entity.ToTable("tblSistemaPerfilAcao");

                entity.HasOne(d => d.CodigoSistemaAcaoNavigation)
                    .WithMany(p => p.TblSistemaPerfilAcao)
                    .HasForeignKey(d => d.CodigoSistemaAcao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaPerfilAcao_SistemaAcao");

                entity.HasOne(d => d.CodigoSistemaMenuNavigation)
                    .WithMany(p => p.TblSistemaPerfilAcao)
                    .HasForeignKey(d => d.CodigoSistemaMenu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaPerfilAcao_SistemaMenu");

                entity.HasOne(d => d.CodigoSistemaPerfilNavigation)
                    .WithMany(p => p.TblSistemaPerfilAcao)
                    .HasForeignKey(d => d.CodigoSistemaPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaPerfilAcao_SistemaPerfil");
            });

            modelBuilder.Entity<TblSistemaPerfilMenu>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaPerfilMenu)
                    .HasName("prkSistemaPerfilMenu");

                entity.ToTable("tblSistemaPerfilMenu");

                entity.HasOne(d => d.CodigoSistemaMenuNavigation)
                    .WithMany(p => p.TblSistemaPerfilMenu)
                    .HasForeignKey(d => d.CodigoSistemaMenu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaPerfilMenu_SistemaMenu");

                entity.HasOne(d => d.CodigoSistemaPerfilNavigation)
                    .WithMany(p => p.TblSistemaPerfilMenu)
                    .HasForeignKey(d => d.CodigoSistemaPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaPerfilMenu_SistemaPerfil");
            });

            modelBuilder.Entity<TblSistemaPerfilPerfil>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaPerfilPerfil)
                    .HasName("prkSistemaPerfilPerfil");

                entity.ToTable("tblSistemaPerfilPerfil");

                entity.HasOne(d => d.CodigoSistemaPerfilFilhoNavigation)
                    .WithMany(p => p.TblSistemaPerfilPerfilCodigoSistemaPerfilFilhoNavigation)
                    .HasForeignKey(d => d.CodigoSistemaPerfilFilho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaPerfilPerfil_SistemaPerfilFilho");

                entity.HasOne(d => d.CodigoSistemaPerfilPaiNavigation)
                    .WithMany(p => p.TblSistemaPerfilPerfilCodigoSistemaPerfilPaiNavigation)
                    .HasForeignKey(d => d.CodigoSistemaPerfilPai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaPerfilPerfil_SistemaPerfilPai");
            });

            modelBuilder.Entity<TblSistemaSolicitacaoAcesso>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaSolicitacaoAcesso)
                    .HasName("prkSistemaSolicitacaoAcesso");

                entity.ToTable("tblSistemaSolicitacaoAcesso");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("CPF")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DataAnalise).HasColumnType("datetime");

                entity.Property(e => e.DataSolicitacaoAcesso).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IndicadorUsuarioDnit).HasColumnName("IndicadorUsuarioDNIT");

                entity.Property(e => e.MatriculaDnit)
                    .HasColumnName("MatriculaDNIT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeAnalista)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeInstituicao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroMatriculaSiape)
                    .HasColumnName("NumeroMatriculaSIAPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacaoAnalise)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacaoSolicitacao)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSistemaSolicitacaoAcessoSituacaoNavigation)
                    .WithMany(p => p.TblSistemaSolicitacaoAcesso)
                    .HasForeignKey(d => d.CodigoSistemaSolicitacaoAcessoSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaSolicitacaoAcesso_SistemaSolicitacaoAcessoSituacao");
            });

            modelBuilder.Entity<TblSistemaSolicitacaoAcessoSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaSolicitacaoAcessoSituacao);

                entity.ToTable("tblSistemaSolicitacaoAcessoSituacao");

                entity.Property(e => e.CodigoSistemaSolicitacaoAcessoSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSistemaSsrs>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaSsrs)
                    .HasName("prkSistemaSSRS");

                entity.ToTable("tblSistemaSSRS");

                entity.Property(e => e.CodigoSistemaSsrs)
                    .HasColumnName("CodigoSistemaSSRS")
                    .ValueGeneratedNever();

                entity.Property(e => e.ServidorEndereco)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorUsuarioDominio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorUsuarioNome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorUsuarioSenha)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSistemaSsrsrelatorio>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaSsrsrelatorio)
                    .HasName("prkSistemaSSRSRelatorio");

                entity.ToTable("tblSistemaSSRSRelatorio");

                entity.Property(e => e.CodigoSistemaSsrsrelatorio).HasColumnName("CodigoSistemaSSRSRelatorio");

                entity.Property(e => e.CodigoSistemaSsrs).HasColumnName("CodigoSistemaSSRS");

                entity.Property(e => e.RelatorioCaminhoPasta)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RelatorioNome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSistemaSsrsNavigation)
                    .WithMany(p => p.TblSistemaSsrsrelatorio)
                    .HasForeignKey(d => d.CodigoSistemaSsrs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaSSRSRelatorio_SistemaSSRS");
            });

            modelBuilder.Entity<TblSistemaUsuario>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaUsuario)
                    .HasName("prkSistemaUsuario");

                entity.ToTable("tblSistemaUsuario");

                entity.HasIndex(e => e.Cpf)
                    .HasName("unqSistemaUsuario_CPF")
                    .IsUnique();

                entity.HasIndex(e => e.Login)
                    .HasName("unqSistemaUsuario_Login")
                    .IsUnique();

                entity.HasIndex(e => new { e.Nome, e.CodigoSistemaUsuario })
                    .HasName("idxSistemaUsuario_Nome");

                entity.Property(e => e.CodigoSistemaUsuarioPncvindicadorVinculo).HasColumnName("CodigoSistemaUsuarioPNCVIndicadorVinculo");

                entity.Property(e => e.CodigoUfpncvengenheiroCrea).HasColumnName("CodigoUFPNCVEngenheiroCREA");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("CPF")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasColumnType("date");

                entity.Property(e => e.DataUltimaAtividade).HasColumnType("datetime");

                entity.Property(e => e.DataVencimentoConta).HasColumnType("date");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IndicadorEspecialistaBrlegal).HasColumnName("IndicadorEspecialistaBRLegal");

                entity.Property(e => e.IndicadorMembroJari).HasColumnName("IndicadorMembroJARI");

                entity.Property(e => e.IndicadorUsuarioDnit).HasColumnName("IndicadorUsuarioDNIT");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MatriculaDnit)
                    .HasColumnName("MatriculaDNIT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroMatriculaSiape)
                    .HasColumnName("NumeroMatriculaSIAPE")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PncvengenheiroCreanumero)
                    .HasColumnName("PNCVEngenheiroCREANumero")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PncvindicadorEngenheiro).HasColumnName("PNCVIndicadorEngenheiro");

                entity.Property(e => e.PncvindicadorUsuarioDnit).HasColumnName("PNCVIndicadorUsuarioDNIT");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(68);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSistemaInstituicaoNavigation)
                    .WithMany(p => p.TblSistemaUsuario)
                    .HasForeignKey(d => d.CodigoSistemaInstituicao)
                    .HasConstraintName("frkSistemaUsuario_SistemaInstituicao");

                entity.HasOne(d => d.CodigoSistemaUsuarioPncvindicadorVinculoNavigation)
                    .WithMany(p => p.TblSistemaUsuario)
                    .HasForeignKey(d => d.CodigoSistemaUsuarioPncvindicadorVinculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaUsuario_SistemaUsuarioPNCVIndicadorVinculo");

                entity.HasOne(d => d.CodigoUfpncvengenheiroCreaNavigation)
                    .WithMany(p => p.TblSistemaUsuario)
                    .HasForeignKey(d => d.CodigoUfpncvengenheiroCrea)
                    .HasConstraintName("frkSistemaUsuario_UF_PNCVEngenheiroCREA");
            });

            modelBuilder.Entity<TblSistemaUsuarioAcao>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaUsuarioAcao)
                    .HasName("prkSistemaUsuarioAcao");

                entity.ToTable("tblSistemaUsuarioAcao");

                entity.HasOne(d => d.CodigoSistemaAcaoNavigation)
                    .WithMany(p => p.TblSistemaUsuarioAcao)
                    .HasForeignKey(d => d.CodigoSistemaAcao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaUsuarioAcao_SistemaAcao");

                entity.HasOne(d => d.CodigoSistemaMenuNavigation)
                    .WithMany(p => p.TblSistemaUsuarioAcao)
                    .HasForeignKey(d => d.CodigoSistemaMenu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaUsuarioAcao_SistemaMenu");

                entity.HasOne(d => d.CodigoSistemaUsuarioNavigation)
                    .WithMany(p => p.TblSistemaUsuarioAcao)
                    .HasForeignKey(d => d.CodigoSistemaUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaUsuarioAcao_SistemaUsuario");
            });

            modelBuilder.Entity<TblSistemaUsuarioBrlegalContrato>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaUsuarioBrlegalContrato)
                    .HasName("prkSistemaUsuarioBRLegalEtapaLote");

                entity.ToTable("tblSistemaUsuarioBRLegalContrato");

                entity.Property(e => e.CodigoSistemaUsuarioBrlegalContrato).HasColumnName("CodigoSistemaUsuarioBRLegalContrato");

                entity.Property(e => e.CodigoBrlegalContrato).HasColumnName("CodigoBRLegalContrato");

                entity.HasOne(d => d.CodigoBrlegalContratoNavigation)
                    .WithMany(p => p.TblSistemaUsuarioBrlegalContrato)
                    .HasForeignKey(d => d.CodigoBrlegalContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaUsuarioBRLegalContrato_BRLegalContrato");

                entity.HasOne(d => d.CodigoSistemaUsuarioNavigation)
                    .WithMany(p => p.TblSistemaUsuarioBrlegalContrato)
                    .HasForeignKey(d => d.CodigoSistemaUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaUsuarioBRLegalContrato_SistemaUsuario");
            });

            modelBuilder.Entity<TblSistemaUsuarioEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaUsuarioEvento)
                    .HasName("prkSistemaUsuarioEvento");

                entity.ToTable("tblSistemaUsuarioEvento");

                entity.HasIndex(e => e.CodigoSistemaUsuario)
                    .HasName("idxSistemaUsuarioEvento");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSistemaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSistemaUsuarioNavigation)
                    .WithMany(p => p.TblSistemaUsuarioEvento)
                    .HasForeignKey(d => d.CodigoSistemaUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frktblSistemaUsuarioEvento_SistemaUsuario");
            });

            modelBuilder.Entity<TblSistemaUsuarioMenu>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaUsuarioMenu)
                    .HasName("prkSistemaUsuarioMenu");

                entity.ToTable("tblSistemaUsuarioMenu");

                entity.HasOne(d => d.CodigoSistemaMenuNavigation)
                    .WithMany(p => p.TblSistemaUsuarioMenu)
                    .HasForeignKey(d => d.CodigoSistemaMenu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaUsuarioMenu_SistemaMenu");

                entity.HasOne(d => d.CodigoSistemaUsuarioNavigation)
                    .WithMany(p => p.TblSistemaUsuarioMenu)
                    .HasForeignKey(d => d.CodigoSistemaUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaUsuarioMenu_SistemaUsuario");
            });

            modelBuilder.Entity<TblSistemaUsuarioPerfil>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaUsuarioPerfil)
                    .HasName("prkSistemaUsuarioPerfil");

                entity.ToTable("tblSistemaUsuarioPerfil");

                entity.HasIndex(e => e.CodigoSistemaUsuario)
                    .HasName("idxSistemaUsuarioPerfil");

                entity.HasOne(d => d.CodigoSistemaPerfilNavigation)
                    .WithMany(p => p.TblSistemaUsuarioPerfil)
                    .HasForeignKey(d => d.CodigoSistemaPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaUsuarioPerfil_SistemaPerfil");

                entity.HasOne(d => d.CodigoSistemaUsuarioNavigation)
                    .WithMany(p => p.TblSistemaUsuarioPerfil)
                    .HasForeignKey(d => d.CodigoSistemaUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaUsuarioPerfil_SistemaUsuario");
            });

            modelBuilder.Entity<TblSistemaUsuarioPncvabrangencia>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaUsuarioPncvabrangencia)
                    .HasName("prkSistemaUsuarioPNCVAbrangencia");

                entity.ToTable("tblSistemaUsuarioPNCVAbrangencia");

                entity.Property(e => e.CodigoSistemaUsuarioPncvabrangencia).HasColumnName("CodigoSistemaUsuarioPNCVAbrangencia");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblSistemaUsuarioPncvabrangencia)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaUsuarioPNCVAbrangencia_BaseUF");

                entity.HasOne(d => d.CodigoSistemaUsuarioNavigation)
                    .WithMany(p => p.TblSistemaUsuarioPncvabrangencia)
                    .HasForeignKey(d => d.CodigoSistemaUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaUsuarioPNCVAbrangencia_SistemaUsuario");
            });

            modelBuilder.Entity<TblSistemaUsuarioPncveditalLote>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaUsuarioPncveditalLote)
                    .HasName("prkSistemaUsuarioPNCVEditalLote");

                entity.ToTable("tblSistemaUsuarioPNCVEditalLote");

                entity.HasIndex(e => new { e.CodigoSistemaUsuario, e.CodigoPncveditalLote })
                    .HasName("idxSistemaUsuarioPNCVEditalLote_CodigoSistemaUsuario_CodigoPNCVEditalLote");

                entity.Property(e => e.CodigoSistemaUsuarioPncveditalLote).HasColumnName("CodigoSistemaUsuarioPNCVEditalLote");

                entity.Property(e => e.CodigoPncveditalLote).HasColumnName("CodigoPNCVEditalLote");

                entity.HasOne(d => d.CodigoPncveditalLoteNavigation)
                    .WithMany(p => p.TblSistemaUsuarioPncveditalLote)
                    .HasForeignKey(d => d.CodigoPncveditalLote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaUsuarioPNCVEditalLote_PNCVEditalLote");

                entity.HasOne(d => d.CodigoSistemaUsuarioNavigation)
                    .WithMany(p => p.TblSistemaUsuarioPncveditalLote)
                    .HasForeignKey(d => d.CodigoSistemaUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSistemaUsuarioPNCVEditalLote_SistemaUsuario");
            });

            modelBuilder.Entity<TblSistemaUsuarioPncvindicadorVinculo>(entity =>
            {
                entity.HasKey(e => e.CodigoSistemaUsuarioPncvindicadorVinculo)
                    .HasName("prkSistemaUsuarioPNCVIndicadorVinculo");

                entity.ToTable("tblSistemaUsuarioPNCVIndicadorVinculo");

                entity.Property(e => e.CodigoSistemaUsuarioPncvindicadorVinculo)
                    .HasColumnName("CodigoSistemaUsuarioPNCVIndicadorVinculo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSnvtrecho>(entity =>
            {
                entity.HasKey(e => e.CodigoSnvtrecho)
                    .HasName("prkSNVTrecho");

                entity.ToTable("tblSNVTrecho");

                entity.HasIndex(e => e.CodigoSnvtrechoDnit)
                    .HasName("unqTrechoSNVCodigoDNIT_CA");

                entity.Property(e => e.CodigoSnvtrecho).HasColumnName("CodigoSNVTrecho");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoSnvtrechoDnit)
                    .IsRequired()
                    .HasColumnName("CodigoSNVTrechoDNIT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblSnvtrecho)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSNVTrecho_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblSnvtrecho)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSNVTrecho_BaseUF");
            });

            modelBuilder.Entity<TblSnvtrechoCoincidente>(entity =>
            {
                entity.HasKey(e => e.CodigoSnvtrechoCoincidente)
                    .HasName("prkSNVTrechoCoincidente");

                entity.ToTable("tblSNVTrechoCoincidente");

                entity.HasIndex(e => new { e.CodigoSnvtrechoHistorico, e.CodigoSnvtrechoHistoricoCoincidente })
                    .HasName("unqSNVTrechoCoincidente")
                    .IsUnique();

                entity.Property(e => e.CodigoSnvtrechoCoincidente).HasColumnName("CodigoSNVTrechoCoincidente");

                entity.Property(e => e.CodigoSnvtrechoHistorico).HasColumnName("CodigoSNVTrechoHistorico");

                entity.Property(e => e.CodigoSnvtrechoHistoricoCoincidente).HasColumnName("CodigoSNVTrechoHistoricoCoincidente");

                entity.HasOne(d => d.CodigoSnvtrechoHistoricoNavigation)
                    .WithMany(p => p.TblSnvtrechoCoincidenteCodigoSnvtrechoHistoricoNavigation)
                    .HasForeignKey(d => d.CodigoSnvtrechoHistorico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSNVTrechoHistorico_SNVTrechoCoincidente");

                entity.HasOne(d => d.CodigoSnvtrechoHistoricoCoincidenteNavigation)
                    .WithMany(p => p.TblSnvtrechoCoincidenteCodigoSnvtrechoHistoricoCoincidenteNavigation)
                    .HasForeignKey(d => d.CodigoSnvtrechoHistoricoCoincidente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSNVTrechoHistorico_SNVTrechoCoincidente_Coincidente");
            });

            modelBuilder.Entity<TblSnvtrechoFonteDados>(entity =>
            {
                entity.HasKey(e => e.CodigoSnvtrechoFonteDados)
                    .HasName("prkSNVTrechoFonteDados");

                entity.ToTable("tblSNVTrechoFonteDados");

                entity.Property(e => e.CodigoSnvtrechoFonteDados).HasColumnName("CodigoSNVTrechoFonteDados");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.Nome)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSnvtrechoHistorico>(entity =>
            {
                entity.HasKey(e => e.CodigoSnvtrechoHistorico)
                    .HasName("prkSNVTrechoHistorico");

                entity.ToTable("tblSNVTrechoHistorico");

                entity.HasIndex(e => new { e.CodigoSnvtrecho, e.AnoReferencia })
                    .HasName("unqSNVTrechoHistorico_CodigoSNVTrecho_Ano")
                    .IsUnique();

                entity.HasIndex(e => new { e.QuilometroInicio, e.QuilometroFim, e.AnoReferencia })
                    .HasName("idxSNVTrechoHistorico");

                entity.Property(e => e.CodigoSnvtrechoHistorico).HasColumnName("CodigoSNVTrechoHistorico");

                entity.Property(e => e.CodigoSnvtrecho).HasColumnName("CodigoSNVTrecho");

                entity.Property(e => e.CodigoSnvtrechoOcupacao).HasColumnName("CodigoSNVTrechoOcupacao");

                entity.Property(e => e.CodigoSnvtrechoSuperficie).HasColumnName("CodigoSNVTrechoSuperficie");

                entity.Property(e => e.CodigoSnvtrechoSuperficieEstadualCoincidente).HasColumnName("CodigoSNVTrechoSuperficieEstadualCoincidente");

                entity.Property(e => e.CodigoSnvtrechoTipo).HasColumnName("CodigoSNVTrechoTipo");

                entity.Property(e => e.ConcessaoConvenio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescricaoLocalFim)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescricaoLocalInicio)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Extensao).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Mp082).HasColumnName("MP_082");

                entity.Property(e => e.QuilometroFim).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.QuilometroInicio).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.SiglaRodoviaEstadualCoincidente)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSnvtrechoNavigation)
                    .WithMany(p => p.TblSnvtrechoHistorico)
                    .HasForeignKey(d => d.CodigoSnvtrecho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSNVTrechoHistorico_SNVTrecho");

                entity.HasOne(d => d.CodigoSnvtrechoOcupacaoNavigation)
                    .WithMany(p => p.TblSnvtrechoHistorico)
                    .HasForeignKey(d => d.CodigoSnvtrechoOcupacao)
                    .HasConstraintName("frkSNVTrechoHistorico_SNVTrechoOcupacao");

                entity.HasOne(d => d.CodigoSnvtrechoSuperficieNavigation)
                    .WithMany(p => p.TblSnvtrechoHistoricoCodigoSnvtrechoSuperficieNavigation)
                    .HasForeignKey(d => d.CodigoSnvtrechoSuperficie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkSNVTrechoHistorico_SNVTrechoSuperficie");

                entity.HasOne(d => d.CodigoSnvtrechoSuperficieEstadualCoincidenteNavigation)
                    .WithMany(p => p.TblSnvtrechoHistoricoCodigoSnvtrechoSuperficieEstadualCoincidenteNavigation)
                    .HasForeignKey(d => d.CodigoSnvtrechoSuperficieEstadualCoincidente)
                    .HasConstraintName("frkSNVTrechoHistorico_SNVTrechoSuperficieEstadualCoincidente");

                entity.HasOne(d => d.CodigoSnvtrechoTipoNavigation)
                    .WithMany(p => p.TblSnvtrechoHistorico)
                    .HasForeignKey(d => d.CodigoSnvtrechoTipo)
                    .HasConstraintName("frkSNVTrechoHistorico_SNVTrechoTipo");
            });

            modelBuilder.Entity<TblSnvtrechoOcupacao>(entity =>
            {
                entity.HasKey(e => e.CodigoSnvtrechoOcupacao)
                    .HasName("prkSNVTipoOcupacaoTrecho");

                entity.ToTable("tblSNVTrechoOcupacao");

                entity.Property(e => e.CodigoSnvtrechoOcupacao)
                    .HasColumnName("CodigoSNVTrechoOcupacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSnvtrechoSuperficie>(entity =>
            {
                entity.HasKey(e => e.CodigoSnvtrechoSuperficie)
                    .HasName("prkSNVTrechoSuperficie");

                entity.ToTable("tblSNVTrechoSuperficie");

                entity.Property(e => e.CodigoSnvtrechoSuperficie)
                    .HasColumnName("CodigoSNVTrechoSuperficie")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSnvtrechoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoSnvtrechoTipo)
                    .HasName("prkSNVTrechoTipo");

                entity.ToTable("tblSNVTrechoTipo");

                entity.Property(e => e.CodigoSnvtrechoTipo).HasColumnName("CodigoSNVTrechoTipo");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTrafegoVelocidadeMediaHorario>(entity =>
            {
                entity.HasKey(e => e.CodigoTrafegoVelocidadeMediaHorario)
                    .HasName("prkTrafegoVelocidadeMediaHorario");

                entity.ToTable("tblTrafegoVelocidadeMediaHorario");

                entity.HasIndex(e => new { e.Quilometro, e.AnoReferencia })
                    .HasName("idxTrafegoVelocidadeMediaHorario");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoSnv)
                    .HasColumnName("CodigoSNV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Quilometro).HasColumnType("numeric(5, 1)");

                entity.HasOne(d => d.CodigoBaseMesNavigation)
                    .WithMany(p => p.TblTrafegoVelocidadeMediaHorario)
                    .HasForeignKey(d => d.CodigoBaseMes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVelocidadeMediaHorario_BaseMes");

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblTrafegoVelocidadeMediaHorario)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVelocidadeMediaHorario_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblTrafegoVelocidadeMediaHorario)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVelocidadeMediaHorario_BaseUF");
            });

            modelBuilder.Entity<TblTrafegoVelocidadeMediaSemanal>(entity =>
            {
                entity.HasKey(e => e.CodigoTrafegoVelocidadeMediaSemanal)
                    .HasName("prkTrafegoVelocidadeMediaSemanal");

                entity.ToTable("tblTrafegoVelocidadeMediaSemanal");

                entity.HasIndex(e => new { e.Quilometro, e.AnoReferencia })
                    .HasName("idxTrafegoVelocidadeMediaSemanal");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoSnv)
                    .HasColumnName("CodigoSNV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Quilometro).HasColumnType("numeric(5, 1)");

                entity.HasOne(d => d.CodigoBaseMesNavigation)
                    .WithMany(p => p.TblTrafegoVelocidadeMediaSemanal)
                    .HasForeignKey(d => d.CodigoBaseMes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVelocidadeMediaSemanal_BaseMes");

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblTrafegoVelocidadeMediaSemanal)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVelocidadeMediaSemanal_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblTrafegoVelocidadeMediaSemanal)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVelocidadeMediaSemanal_BaseUF");
            });

            modelBuilder.Entity<TblTrafegoVmdanual>(entity =>
            {
                entity.HasKey(e => e.CodigoTrafegoVmdanual)
                    .HasName("prkTrafegoVMDAnual");

                entity.ToTable("tblTrafegoVMDAnual");

                entity.HasIndex(e => new { e.Quilometro, e.AnoReferencia })
                    .HasName("idxVMDAnual");

                entity.Property(e => e.CodigoTrafegoVmdanual).HasColumnName("CodigoTrafegoVMDAnual");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoSnv)
                    .HasColumnName("CodigoSNV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTrafegoVmdfonteDados).HasColumnName("CodigoTrafegoVMDFonteDados");

                entity.Property(e => e.Quilometro).HasColumnType("numeric(5, 1)");

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblTrafegoVmdanual)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDAnual_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblTrafegoVmdanual)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDAnual_BaseUF");

                entity.HasOne(d => d.CodigoTrafegoVmdfonteDadosNavigation)
                    .WithMany(p => p.TblTrafegoVmdanual)
                    .HasForeignKey(d => d.CodigoTrafegoVmdfonteDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDAnual_TrafegoVMDFonteDados");
            });

            modelBuilder.Entity<TblTrafegoVmdanualClassificado>(entity =>
            {
                entity.HasKey(e => e.CodigoTrafegoVmdanualClassificado)
                    .HasName("prkTrafegoVMDAnualClassificado");

                entity.ToTable("tblTrafegoVMDAnualClassificado");

                entity.HasIndex(e => new { e.Quilometro, e.AnoReferencia })
                    .HasName("idxVMDAnualClassificado");

                entity.Property(e => e.CodigoTrafegoVmdanualClassificado).HasColumnName("CodigoTrafegoVMDAnualClassificado");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoSnv)
                    .HasColumnName("CodigoSNV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTrafegoVmdfonteDados).HasColumnName("CodigoTrafegoVMDFonteDados");

                entity.Property(e => e.Quilometro).HasColumnType("numeric(5, 1)");

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblTrafegoVmdanualClassificado)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDAnualClassificado_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblTrafegoVmdanualClassificado)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDAnualClassificado_BaseUF");

                entity.HasOne(d => d.CodigoTrafegoVmdfonteDadosNavigation)
                    .WithMany(p => p.TblTrafegoVmdanualClassificado)
                    .HasForeignKey(d => d.CodigoTrafegoVmdfonteDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDAnualClassificado_TrafegoVMDFonteDados");
            });

            modelBuilder.Entity<TblTrafegoVmdanualClassificadoClasseVeiculo>(entity =>
            {
                entity.HasKey(e => e.CodigoTrafegoVmdanualClassificadoClasseVeiculo)
                    .HasName("prkTrafegoVMDAnualClassificadoClasseVeiculo");

                entity.ToTable("tblTrafegoVMDAnualClassificadoClasseVeiculo");

                entity.Property(e => e.CodigoTrafegoVmdanualClassificadoClasseVeiculo).HasColumnName("CodigoTrafegoVMDAnualClassificadoClasseVeiculo");

                entity.Property(e => e.CodigoTrafegoVmdanualClassificado).HasColumnName("CodigoTrafegoVMDAnualClassificado");

                entity.Property(e => e.CodigoTrafegoVmdclasseVeiculo).HasColumnName("CodigoTrafegoVMDClasseVeiculo");

                entity.HasOne(d => d.CodigoTrafegoVmdanualClassificadoNavigation)
                    .WithMany(p => p.TblTrafegoVmdanualClassificadoClasseVeiculo)
                    .HasForeignKey(d => d.CodigoTrafegoVmdanualClassificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDAnualClassificadoClasseVeiculo_TrafegoVMDAnualClassificado");

                entity.HasOne(d => d.CodigoTrafegoVmdclasseVeiculoNavigation)
                    .WithMany(p => p.TblTrafegoVmdanualClassificadoClasseVeiculo)
                    .HasForeignKey(d => d.CodigoTrafegoVmdclasseVeiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDAnualClassificadoClasseVeiculo_TrafegoVMDClasseVeiculo");
            });

            modelBuilder.Entity<TblTrafegoVmdclasseVeiculo>(entity =>
            {
                entity.HasKey(e => e.CodigoTrafegoVmdclasseVeiculo)
                    .HasName("prkTrafegoVMDClasseVeiculo");

                entity.ToTable("tblTrafegoVMDClasseVeiculo");

                entity.HasIndex(e => new { e.Nome, e.CodigoTrafegoVmdfonteDados })
                    .HasName("idxNome_VMDClasseVeiculo")
                    .IsUnique();

                entity.Property(e => e.CodigoTrafegoVmdclasseVeiculo).HasColumnName("CodigoTrafegoVMDClasseVeiculo");

                entity.Property(e => e.CodigoTrafegoVmdfonteDados).HasColumnName("CodigoTrafegoVMDFonteDados");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoTrafegoVmdfonteDadosNavigation)
                    .WithMany(p => p.TblTrafegoVmdclasseVeiculo)
                    .HasForeignKey(d => d.CodigoTrafegoVmdfonteDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDClasseVeiculo_TrafegoVMDFonteDados");
            });

            modelBuilder.Entity<TblTrafegoVmdfonteDados>(entity =>
            {
                entity.HasKey(e => e.CodigoTrafegoVmdfonteDados)
                    .HasName("prkTrafegoVMDFonteDados");

                entity.ToTable("tblTrafegoVMDFonteDados");

                entity.Property(e => e.CodigoTrafegoVmdfonteDados).HasColumnName("CodigoTrafegoVMDFonteDados");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTrafegoVmdhorario>(entity =>
            {
                entity.HasKey(e => e.CodigoTrafegoVmdhorario)
                    .HasName("prkTrafegoVMDHorario");

                entity.ToTable("tblTrafegoVMDHorario");

                entity.HasIndex(e => new { e.Quilometro, e.AnoReferencia })
                    .HasName("idxVMDHorario");

                entity.Property(e => e.CodigoTrafegoVmdhorario).HasColumnName("CodigoTrafegoVMDHorario");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoSnv)
                    .HasColumnName("CodigoSNV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTrafegoVmdfonteDados).HasColumnName("CodigoTrafegoVMDFonteDados");

                entity.Property(e => e.Quilometro).HasColumnType("numeric(5, 1)");

                entity.HasOne(d => d.CodigoBaseMesNavigation)
                    .WithMany(p => p.TblTrafegoVmdhorario)
                    .HasForeignKey(d => d.CodigoBaseMes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDHorario_BaseMes");

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblTrafegoVmdhorario)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDHorario_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblTrafegoVmdhorario)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDHorario_BaseUF");

                entity.HasOne(d => d.CodigoTrafegoVmdfonteDadosNavigation)
                    .WithMany(p => p.TblTrafegoVmdhorario)
                    .HasForeignKey(d => d.CodigoTrafegoVmdfonteDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDHorario_TrafegoVMDFonteDados");
            });

            modelBuilder.Entity<TblTrafegoVmdhorarioClassificado>(entity =>
            {
                entity.HasKey(e => e.CodigoTrafegoVmdhorarioClassificado)
                    .HasName("prkTrafegoVMDHorarioClassificado");

                entity.ToTable("tblTrafegoVMDHorarioClassificado");

                entity.HasIndex(e => new { e.Quilometro, e.AnoReferencia })
                    .HasName("idxVMDHorarioClassificado");

                entity.Property(e => e.CodigoTrafegoVmdhorarioClassificado).HasColumnName("CodigoTrafegoVMDHorarioClassificado");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoSnv)
                    .HasColumnName("CodigoSNV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTrafegoVmdfonteDados).HasColumnName("CodigoTrafegoVMDFonteDados");

                entity.Property(e => e.Quilometro).HasColumnType("numeric(5, 1)");

                entity.HasOne(d => d.CodigoBaseHoraNavigation)
                    .WithMany(p => p.TblTrafegoVmdhorarioClassificado)
                    .HasForeignKey(d => d.CodigoBaseHora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDHorarioClassificado_BaseHora");

                entity.HasOne(d => d.CodigoBaseMesNavigation)
                    .WithMany(p => p.TblTrafegoVmdhorarioClassificado)
                    .HasForeignKey(d => d.CodigoBaseMes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDHorarioClassificado_BaseMes");

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblTrafegoVmdhorarioClassificado)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDHorarioClassificado_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblTrafegoVmdhorarioClassificado)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDHorarioClassificado_BaseUF");

                entity.HasOne(d => d.CodigoTrafegoVmdfonteDadosNavigation)
                    .WithMany(p => p.TblTrafegoVmdhorarioClassificado)
                    .HasForeignKey(d => d.CodigoTrafegoVmdfonteDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDHorarioClassificado_TrafegoVMDFonteDados");
            });

            modelBuilder.Entity<TblTrafegoVmdhorarioClassificadoClasseVeiculo>(entity =>
            {
                entity.HasKey(e => e.CodigoTrafegoVmdhorarioClassificadoClasseVeiculo)
                    .HasName("prkTrafegoVMDHorarioClassificadoClasseVeiculo");

                entity.ToTable("tblTrafegoVMDHorarioClassificadoClasseVeiculo");

                entity.Property(e => e.CodigoTrafegoVmdhorarioClassificadoClasseVeiculo).HasColumnName("CodigoTrafegoVMDHorarioClassificadoClasseVeiculo");

                entity.Property(e => e.CodigoTrafegoVmdclasseVeiculo).HasColumnName("CodigoTrafegoVMDClasseVeiculo");

                entity.Property(e => e.CodigoTrafegoVmdhorarioClassificado).HasColumnName("CodigoTrafegoVMDHorarioClassificado");

                entity.HasOne(d => d.CodigoTrafegoVmdclasseVeiculoNavigation)
                    .WithMany(p => p.TblTrafegoVmdhorarioClassificadoClasseVeiculo)
                    .HasForeignKey(d => d.CodigoTrafegoVmdclasseVeiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDHorarioClassificadoClasseVeiculo_VMDClasseVeiculo");

                entity.HasOne(d => d.CodigoTrafegoVmdhorarioClassificadoNavigation)
                    .WithMany(p => p.TblTrafegoVmdhorarioClassificadoClasseVeiculo)
                    .HasForeignKey(d => d.CodigoTrafegoVmdhorarioClassificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDHorarioClassificadoClasseVeiculo_TrafegoVMDHorarioClassificado");
            });

            modelBuilder.Entity<TblTrafegoVmdmensal>(entity =>
            {
                entity.HasKey(e => e.CodigoTrafegoVmdmensal)
                    .HasName("prkTrafegoVMDMensal");

                entity.ToTable("tblTrafegoVMDMensal");

                entity.HasIndex(e => new { e.Quilometro, e.AnoReferencia })
                    .HasName("idxVMDMensal");

                entity.Property(e => e.CodigoTrafegoVmdmensal).HasColumnName("CodigoTrafegoVMDMensal");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoSnv)
                    .HasColumnName("CodigoSNV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTrafegoVmdfonteDados).HasColumnName("CodigoTrafegoVMDFonteDados");

                entity.Property(e => e.Quilometro).HasColumnType("numeric(5, 1)");

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblTrafegoVmdmensal)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDMensal_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblTrafegoVmdmensal)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDMensal_BaseUF");

                entity.HasOne(d => d.CodigoTrafegoVmdfonteDadosNavigation)
                    .WithMany(p => p.TblTrafegoVmdmensal)
                    .HasForeignKey(d => d.CodigoTrafegoVmdfonteDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDMensal_TrafegoVMDFonteDados");
            });

            modelBuilder.Entity<TblTrafegoVmdmensalClassificado>(entity =>
            {
                entity.HasKey(e => e.CodigoTrafegoVmdmensalClassificado)
                    .HasName("prkTrafegoVMDMensalClassificado");

                entity.ToTable("tblTrafegoVMDMensalClassificado");

                entity.HasIndex(e => new { e.Quilometro, e.AnoReferencia })
                    .HasName("idxVMDMensalClassificado");

                entity.Property(e => e.CodigoTrafegoVmdmensalClassificado).HasColumnName("CodigoTrafegoVMDMensalClassificado");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoSnv)
                    .HasColumnName("CodigoSNV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTrafegoVmdfonteDados).HasColumnName("CodigoTrafegoVMDFonteDados");

                entity.Property(e => e.Quilometro).HasColumnType("numeric(5, 1)");

                entity.HasOne(d => d.CodigoBaseMesNavigation)
                    .WithMany(p => p.TblTrafegoVmdmensalClassificado)
                    .HasForeignKey(d => d.CodigoBaseMes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDMensalClassificado_BaseMes");

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblTrafegoVmdmensalClassificado)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDMensalClassificado_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblTrafegoVmdmensalClassificado)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDMensalClassificado_BaseUF");

                entity.HasOne(d => d.CodigoTrafegoVmdfonteDadosNavigation)
                    .WithMany(p => p.TblTrafegoVmdmensalClassificado)
                    .HasForeignKey(d => d.CodigoTrafegoVmdfonteDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDMensalClassificado_TrafegoVMDFonteDados");
            });

            modelBuilder.Entity<TblTrafegoVmdmensalClassificadoClasseVeiculo>(entity =>
            {
                entity.HasKey(e => e.CodigoTrafegoVmdmensalClassificadoClasseVeiculo)
                    .HasName("prkTrafegoVMDMensalClassificadoClasseVeiculo");

                entity.ToTable("tblTrafegoVMDMensalClassificadoClasseVeiculo");

                entity.Property(e => e.CodigoTrafegoVmdmensalClassificadoClasseVeiculo).HasColumnName("CodigoTrafegoVMDMensalClassificadoClasseVeiculo");

                entity.Property(e => e.CodigoTrafegoVmdclasseVeiculo).HasColumnName("CodigoTrafegoVMDClasseVeiculo");

                entity.Property(e => e.CodigoTrafegoVmdmensalClassificado).HasColumnName("CodigoTrafegoVMDMensalClassificado");

                entity.HasOne(d => d.CodigoTrafegoVmdclasseVeiculoNavigation)
                    .WithMany(p => p.TblTrafegoVmdmensalClassificadoClasseVeiculo)
                    .HasForeignKey(d => d.CodigoTrafegoVmdclasseVeiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDMensalClassificadoClasseVeiculo_TrafegoVMDClasseVeiculo");

                entity.HasOne(d => d.CodigoTrafegoVmdmensalClassificadoNavigation)
                    .WithMany(p => p.TblTrafegoVmdmensalClassificadoClasseVeiculo)
                    .HasForeignKey(d => d.CodigoTrafegoVmdmensalClassificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDMensalClassificadoClasseVeiculo_TrafegoVMDMensalClassificado");
            });

            modelBuilder.Entity<TblTrafegoVmdsemanal>(entity =>
            {
                entity.HasKey(e => e.CodigoTrafegoVmdsemanal)
                    .HasName("prkTrafegoVMDSemanal");

                entity.ToTable("tblTrafegoVMDSemanal");

                entity.HasIndex(e => new { e.Quilometro, e.AnoReferencia })
                    .HasName("idxVMDSemanal");

                entity.Property(e => e.CodigoTrafegoVmdsemanal).HasColumnName("CodigoTrafegoVMDSemanal");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoSnv)
                    .HasColumnName("CodigoSNV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTrafegoVmdfonteDados).HasColumnName("CodigoTrafegoVMDFonteDados");

                entity.Property(e => e.Quilometro).HasColumnType("numeric(5, 1)");

                entity.HasOne(d => d.CodigoBaseMesNavigation)
                    .WithMany(p => p.TblTrafegoVmdsemanal)
                    .HasForeignKey(d => d.CodigoBaseMes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDSemanal_BaseMes");

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblTrafegoVmdsemanal)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDSemanal_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblTrafegoVmdsemanal)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDSemanal_BaseUF");

                entity.HasOne(d => d.CodigoTrafegoVmdfonteDadosNavigation)
                    .WithMany(p => p.TblTrafegoVmdsemanal)
                    .HasForeignKey(d => d.CodigoTrafegoVmdfonteDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDSemanal_TrafegoVMDFonteDados");
            });

            modelBuilder.Entity<TblTrafegoVmdsemanalClassificado>(entity =>
            {
                entity.HasKey(e => e.CodigoTrafegoVmdsemanalClassificado)
                    .HasName("prkTrafegoVMDSemanalClassificado");

                entity.ToTable("tblTrafegoVMDSemanalClassificado");

                entity.HasIndex(e => new { e.Quilometro, e.AnoReferencia })
                    .HasName("idxVMDSemanalClassificado");

                entity.Property(e => e.CodigoTrafegoVmdsemanalClassificado).HasColumnName("CodigoTrafegoVMDSemanalClassificado");

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoSnv)
                    .HasColumnName("CodigoSNV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTrafegoVmdfonteDados).HasColumnName("CodigoTrafegoVMDFonteDados");

                entity.Property(e => e.Quilometro).HasColumnType("numeric(5, 1)");

                entity.HasOne(d => d.CodigoBaseDiaSemanaNavigation)
                    .WithMany(p => p.TblTrafegoVmdsemanalClassificado)
                    .HasForeignKey(d => d.CodigoBaseDiaSemana)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDSemanalClassificado_BaseDiaSemana");

                entity.HasOne(d => d.CodigoBaseMesNavigation)
                    .WithMany(p => p.TblTrafegoVmdsemanalClassificado)
                    .HasForeignKey(d => d.CodigoBaseMes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDSemanalClassificado_BaseMes");

                entity.HasOne(d => d.CodigoBaseRodoviaNavigation)
                    .WithMany(p => p.TblTrafegoVmdsemanalClassificado)
                    .HasForeignKey(d => d.CodigoBaseRodovia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDSemanalClassificado_BaseRodovia");

                entity.HasOne(d => d.CodigoBaseUfNavigation)
                    .WithMany(p => p.TblTrafegoVmdsemanalClassificado)
                    .HasForeignKey(d => d.CodigoBaseUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDSemanalClassificado_BaseUF");

                entity.HasOne(d => d.CodigoTrafegoVmdfonteDadosNavigation)
                    .WithMany(p => p.TblTrafegoVmdsemanalClassificado)
                    .HasForeignKey(d => d.CodigoTrafegoVmdfonteDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDSemanalClassificado_TrafegoVMDFonteDados");
            });

            modelBuilder.Entity<TblTrafegoVmdsemanalClassificadoClasseVeiculo>(entity =>
            {
                entity.HasKey(e => e.CodigoTrafegoVmdsemanalClassificadoClasseVeiculo)
                    .HasName("prkTrafegoVMDSemanalClassificadoClasseVeiculo");

                entity.ToTable("tblTrafegoVMDSemanalClassificadoClasseVeiculo");

                entity.Property(e => e.CodigoTrafegoVmdsemanalClassificadoClasseVeiculo).HasColumnName("CodigoTrafegoVMDSemanalClassificadoClasseVeiculo");

                entity.Property(e => e.CodigoTrafegoVmdclasseVeiculo).HasColumnName("CodigoTrafegoVMDClasseVeiculo");

                entity.Property(e => e.CodigoTrafegoVmdsemanalClassificado).HasColumnName("CodigoTrafegoVMDSemanalClassificado");

                entity.HasOne(d => d.CodigoTrafegoVmdclasseVeiculoNavigation)
                    .WithMany(p => p.TblTrafegoVmdsemanalClassificadoClasseVeiculo)
                    .HasForeignKey(d => d.CodigoTrafegoVmdclasseVeiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDSemanalClassificadoClasseVeiculo_TrafegoVMDClasseVeiculo");

                entity.HasOne(d => d.CodigoTrafegoVmdsemanalClassificadoNavigation)
                    .WithMany(p => p.TblTrafegoVmdsemanalClassificadoClasseVeiculo)
                    .HasForeignKey(d => d.CodigoTrafegoVmdsemanalClassificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkTrafegoVMDSemanalClassificadoClasseVeiculo_TrafegoVMDSemanalClassificado");
            });
        }
    }
}
