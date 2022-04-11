using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracao
    {
        public TblInfracao()
        {
            TblInfracaoArquivoAnexo = new HashSet<TblInfracaoArquivoAnexo>();
            TblInfracaoDa = new HashSet<TblInfracaoDa>();
            TblInfracaoDesvinculacaoMulta = new HashSet<TblInfracaoDesvinculacaoMulta>();
            TblInfracaoEfeitoSuspensivo = new HashSet<TblInfracaoEfeitoSuspensivo>();
            TblInfracaoEvento = new HashSet<TblInfracaoEvento>();
            TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo = new HashSet<TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo>();
            TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo = new HashSet<TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo>();
            TblInfracaoFinanceiroGru = new HashSet<TblInfracaoFinanceiroGru>();
            TblInfracaoFinanceiroPagamento = new HashSet<TblInfracaoFinanceiroPagamento>();
            TblInfracaoIdentificacaoInfratorCondutor = new HashSet<TblInfracaoIdentificacaoInfratorCondutor>();
            TblInfracaoImagem = new HashSet<TblInfracaoImagem>();
            TblInfracaoNotificacao = new HashSet<TblInfracaoNotificacao>();
            TblInfracaoRecurso = new HashSet<TblInfracaoRecurso>();
            TblInfracaoSolicitacaoAdvertencia = new HashSet<TblInfracaoSolicitacaoAdvertencia>();
            TblInfracaoSolicitacaoCancelamentoInfracao = new HashSet<TblInfracaoSolicitacaoCancelamentoInfracao>();
        }

        public long CodigoInfracao { get; set; }
        public byte[] RowVersion { get; set; }
        public long? CodigoInfracaoPreAutuacao { get; set; }
        public int CodigoInfracaoSituacao { get; set; }
        public int CodigoInfracaoFase { get; set; }
        public int CodigoInfracaoOrigem { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public int? CodigoInfracaoGravidade { get; set; }
        public int CodigoInfracaoIndicadorResponsavel { get; set; }
        public int CodigoUflocalInfracao { get; set; }
        public int CodigoRodoviaLocalInfracao { get; set; }
        public long? CodigoInfracaoVeiculo { get; set; }
        public long? CodigoInfracaoCondutor { get; set; }
        public long? CodigoInfracaoProprietario { get; set; }
        public long? CodigoInfracaoEmbarcador { get; set; }
        public long? CodigoInfracaoTransportador { get; set; }
        public long? CodigoInfracaoInfrator { get; set; }
        public long? CodigoInfracaoPesagem { get; set; }
        public int? CodigoInfracaoCausaCancelamento { get; set; }
        public int CodigoRenavamorgaoAutuador { get; set; }
        public int CodigoRenavamtipoAutoInfracao { get; set; }
        public int CodigoRenavamindicadorAssinaturaAuto { get; set; }
        public int CodigoRenavammunicipioLocalInfracao { get; set; }
        public int? CodigoRenavamunidadeMedida { get; set; }
        public decimal? CodigoRenainf { get; set; }
        public string NumeroAit { get; set; }
        public string NumeroAgenteTransito { get; set; }
        public bool IndicadorAutuacaoEmFlagrante { get; set; }
        public string LocalInfracao { get; set; }
        public string NomeRodoviaLocalInfracao { get; set; }
        public decimal NumeroKmLocalInfracao { get; set; }
        public string FaixaRodoviaLocalInfracao { get; set; }
        public DateTime DataHoraInfracao { get; set; }
        public DateTime DataInfracao { get; set; }
        public decimal? LimiteRegulamentado { get; set; }
        public decimal? MedicaoRealizada { get; set; }
        public decimal? ValorConsiderado { get; set; }
        public string CodigoEquipamentoDnit { get; set; }
        public string MarcaEquipamento { get; set; }
        public string ModeloEquipamento { get; set; }
        public string NumeroVerificacaoInmetro { get; set; }
        public DateTime? DataVerificacaoInmetro { get; set; }
        public byte? PontosCnh { get; set; }
        public decimal? ValorOriginal { get; set; }
        public decimal? ValorOriginal80Porcento { get; set; }
        public decimal? ValorOriginal60Porcento { get; set; }
        public DateTime? PrazoExpedicaoNp { get; set; }
        public string Observacao { get; set; }
        public string ImagemPrincipalArquivoNome { get; set; }
        public string ImagemPrincipalArquivoNomeFisico { get; set; }
        public int? ImagemPrincipalArquivoTamanho { get; set; }
        public int? ImagemPrincipalSequencia { get; set; }
        public int? CodigoRenavamindicadorAdesaoSne { get; set; }
        public DateTime? DataAdesaoSne { get; set; }
        public bool IndicadorReconhecidoCometimentoInfracao { get; set; }
        public DateTime? DataReconhecidoCometimentoInfracao { get; set; }
        public long? CodigoInfracaoSistemaOrigem { get; set; }
        public int CodigoInfracaoNotificacaoExpedicaoTipo { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? CodigoPncveditalLote { get; set; }
        public bool IndicadorMultaDesvinculada { get; set; }
        public DateTime? DataDesvinculacaoMulta { get; set; }
        public bool? IndicadorRegistroRenainf { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public string Nupformatado { get; set; }
        public int? CodigoInfracaoEquipamentoAfericaoTipo { get; set; }
        public DateTime NupdataCadastro { get; set; }
        public long? CodigoInfracaoOrigemContratacao { get; set; }
        public long? CodigoInfracaoOrigemContrato { get; set; }
        public long? CodigoInfracaoOrigemRemessaDados { get; set; }
        public long? CodigoInfracaoOrigemRegistro { get; set; }

        public virtual TblInfracaoCausaCancelamento CodigoInfracaoCausaCancelamentoNavigation { get; set; }
        public virtual TblInfracaoCondutor CodigoInfracaoCondutorNavigation { get; set; }
        public virtual TblInfracaoEmbarcador CodigoInfracaoEmbarcadorNavigation { get; set; }
        public virtual TblInfracaoEnquadramento CodigoInfracaoEnquadramentoNavigation { get; set; }
        public virtual TblInfracaoEquipamentoAfericaoTipo CodigoInfracaoEquipamentoAfericaoTipoNavigation { get; set; }
        public virtual TblInfracaoFase CodigoInfracaoFaseNavigation { get; set; }
        public virtual TblInfracaoGravidade CodigoInfracaoGravidadeNavigation { get; set; }
        public virtual TblInfracaoIndicadorResponsavel CodigoInfracaoIndicadorResponsavelNavigation { get; set; }
        public virtual TblInfracaoInfrator CodigoInfracaoInfratorNavigation { get; set; }
        public virtual TblInfracaoNotificacaoExpedicaoTipo CodigoInfracaoNotificacaoExpedicaoTipoNavigation { get; set; }
        public virtual TblInfracaoOrigem CodigoInfracaoOrigemNavigation { get; set; }
        public virtual TblInfracaoPesagem CodigoInfracaoPesagemNavigation { get; set; }
        public virtual TblInfracaoPreAutuacao CodigoInfracaoPreAutuacaoNavigation { get; set; }
        public virtual TblInfracaoProprietario CodigoInfracaoProprietarioNavigation { get; set; }
        public virtual TblInfracaoSituacao CodigoInfracaoSituacaoNavigation { get; set; }
        public virtual TblInfracaoTransportador CodigoInfracaoTransportadorNavigation { get; set; }
        public virtual TblInfracaoVeiculo CodigoInfracaoVeiculoNavigation { get; set; }
        public virtual TblBaseRodovia CodigoRodoviaLocalInfracaoNavigation { get; set; }
        public virtual TblBaseUf CodigoUflocalInfracaoNavigation { get; set; }
        public virtual TblCobrancaInfracao TblCobrancaInfracao { get; set; }
        public virtual TblInfracaoFinanceiroDebito TblInfracaoFinanceiroDebito { get; set; }
        public virtual ICollection<TblInfracaoArquivoAnexo> TblInfracaoArquivoAnexo { get; set; }
        public virtual ICollection<TblInfracaoDa> TblInfracaoDa { get; set; }
        public virtual ICollection<TblInfracaoDesvinculacaoMulta> TblInfracaoDesvinculacaoMulta { get; set; }
        public virtual ICollection<TblInfracaoEfeitoSuspensivo> TblInfracaoEfeitoSuspensivo { get; set; }
        public virtual ICollection<TblInfracaoEvento> TblInfracaoEvento { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo> TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo> TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroGru> TblInfracaoFinanceiroGru { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroPagamento> TblInfracaoFinanceiroPagamento { get; set; }
        public virtual ICollection<TblInfracaoIdentificacaoInfratorCondutor> TblInfracaoIdentificacaoInfratorCondutor { get; set; }
        public virtual ICollection<TblInfracaoImagem> TblInfracaoImagem { get; set; }
        public virtual ICollection<TblInfracaoNotificacao> TblInfracaoNotificacao { get; set; }
        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecurso { get; set; }
        public virtual ICollection<TblInfracaoSolicitacaoAdvertencia> TblInfracaoSolicitacaoAdvertencia { get; set; }
        public virtual ICollection<TblInfracaoSolicitacaoCancelamentoInfracao> TblInfracaoSolicitacaoCancelamentoInfracao { get; set; }
    }
}
