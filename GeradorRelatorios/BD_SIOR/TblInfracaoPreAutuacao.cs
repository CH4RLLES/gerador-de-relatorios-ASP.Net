using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoPreAutuacao
    {
        public TblInfracaoPreAutuacao()
        {
            TblInfracao = new HashSet<TblInfracao>();
            TblInfracaoPreAutuacaoConferenciaDupla = new HashSet<TblInfracaoPreAutuacaoConferenciaDupla>();
            TblInfracaoPreAutuacaoConferenciaSimplesPncv = new HashSet<TblInfracaoPreAutuacaoConferenciaSimplesPncv>();
            TblInfracaoPreAutuacaoImagem = new HashSet<TblInfracaoPreAutuacaoImagem>();
            TblInfracaoPreAutuacaoPreparacaoImagem = new HashSet<TblInfracaoPreAutuacaoPreparacaoImagem>();
        }

        public long CodigoInfracaoPreAutuacao { get; set; }
        public int CodigoInfracaoPreAutuacaoSituacao { get; set; }
        public int CodigoInfracaoPreAutuacaoFase { get; set; }
        public int CodigoInfracaoPreAutuacaoConferenciaTipo { get; set; }
        public int CodigoInfracaoOrigem { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public int CodigoInfracaoGravidade { get; set; }
        public int CodigoInfracaoIndicadorResponsavel { get; set; }
        public int CodigoUflocalInfracao { get; set; }
        public int CodigoRodoviaLocalInfracao { get; set; }
        public int CodigoRenavammunicipioLocalInfracao { get; set; }
        public int CodigoRenavamorgaoAutuador { get; set; }
        public int CodigoRenavamunidadeMedida { get; set; }
        public int? CodigoUfjurisdicaoVeiculo { get; set; }
        public int? CodigoRenavammunicipioEmplacamentoVeiculo { get; set; }
        public int? CodigoRenavammarcaModeloVeiculo { get; set; }
        public int? CodigoRenavamtipoVeiculo { get; set; }
        public int? CodigoRenavamveiculoEspecie { get; set; }
        public int? CodigoRenavamveiculoCarroceria { get; set; }
        public int? CodigoRenavamveiculoCategoria { get; set; }
        public int? CodigoRenavamveiculoCor { get; set; }
        public int? CodigoSistemaUsuarioConferenciaUm { get; set; }
        public int? CodigoSistemaUsuarioConferenciaDois { get; set; }
        public int? CodigoSistemaUsuarioConferenciaRevisao { get; set; }
        public int? CodigoSistemaUsuarioAnalise { get; set; }
        public int? CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUm { get; set; }
        public int? CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDois { get; set; }
        public int? CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaRevisao { get; set; }
        public int? CodigoInfracaoPreAutuacaoMotivoInvalidacaoAnalise { get; set; }
        public string LocalInfracaoRodovia { get; set; }
        public decimal LocalInfracaoKm { get; set; }
        public string LocalInfracaoRodoviaFaixa { get; set; }
        public DateTime DataHoraInfracao { get; set; }
        public DateTime DataInfracao { get; set; }
        public byte PontosCnh { get; set; }
        public string EquipamentoAfericaoCodigoDnit { get; set; }
        public string EquipamentoAfericaoMarca { get; set; }
        public string EquipamentoAfericaoModelo { get; set; }
        public string EquipamentoAfericaoInmetroVerificacaoNumero { get; set; }
        public DateTime EquipamentoAfericaoInmetroVerificacaoData { get; set; }
        public decimal LimiteRegulamentado { get; set; }
        public decimal MedicaoRealizada { get; set; }
        public decimal ValorConsiderado { get; set; }
        public string ImagemPrincipalArquivoNome { get; set; }
        public string ImagemPrincipalArquivoNomeFisico { get; set; }
        public int ImagemPrincipalArquivoTamanho { get; set; }
        public int ImagemPrincipalSequencia { get; set; }
        public decimal ValorOriginal { get; set; }
        public string VeiculoPlacaOriginal { get; set; }
        public bool? ConferenciaUmIndicadorRegistroValido { get; set; }
        public string ConferenciaUmPlacaVeiculo { get; set; }
        public DateTime? ConferenciaUmData { get; set; }
        public bool? ConferenciaDoisIndicadorRegistroValido { get; set; }
        public string ConferenciaDoisPlacaVeiculo { get; set; }
        public DateTime? ConferenciaDoisData { get; set; }
        public bool? ConferenciaRevisaoIndicadorRegistroValido { get; set; }
        public string ConferenciaRevisaoPlacaVeiculo { get; set; }
        public DateTime? ConferenciaRevisaoData { get; set; }
        public bool? AnaliseIndicadorRegistroValido { get; set; }
        public DateTime? AnaliseData { get; set; }
        public string VeiculoPlacaFinal { get; set; }
        public decimal ValorOriginal80Porcento { get; set; }
        public decimal ValorOriginal60Porcento { get; set; }
        public DateTime DataCadastro { get; set; }
        public long? CodigoInfracaoSistemaOrigem { get; set; }
        public int? CodigoPncveditalLote { get; set; }
        public string NomeRenavammarcaModeloVeiculo { get; set; }
        public int? CodigoInfracaoVeiculoTipo { get; set; }
        public int? CodigoInfracaoPreAutuacaoClasseVeiculo { get; set; }
        public int? CodigoInfracaoEquipamentoAfericaoTipo { get; set; }
        public int? CodigoInfracaoPreAutuacaoArbitragemResultado { get; set; }
        public int? CodigoSistemaUsuarioPreparacaoImagem { get; set; }
        public DateTime? PreparacaoImagemData { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public int? CodigoSituacaoAnterior { get; set; }
        public string Debug { get; set; }
        public long? CodigoInfracaoOrigemContratacao { get; set; }
        public long? CodigoInfracaoOrigemContrato { get; set; }
        public long? CodigoInfracaoOrigemRemessaDados { get; set; }
        public long? CodigoInfracaoOrigemRegistro { get; set; }
        public DateTime? ConferenciaData { get; set; }
        public bool? ConferenciaIndicadorRegistroValido { get; set; }
        public int? CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferencia { get; set; }

        public virtual TblInfracaoEnquadramento CodigoInfracaoEnquadramentoNavigation { get; set; }
        public virtual TblInfracaoEquipamentoAfericaoTipo CodigoInfracaoEquipamentoAfericaoTipoNavigation { get; set; }
        public virtual TblInfracaoGravidade CodigoInfracaoGravidadeNavigation { get; set; }
        public virtual TblInfracaoIndicadorResponsavel CodigoInfracaoIndicadorResponsavelNavigation { get; set; }
        public virtual TblInfracaoOrigem CodigoInfracaoOrigemNavigation { get; set; }
        public virtual TblInfracaoPreAutuacaoArbitragemResultado CodigoInfracaoPreAutuacaoArbitragemResultadoNavigation { get; set; }
        public virtual TblInfracaoPreAutuacaoClasseVeiculo CodigoInfracaoPreAutuacaoClasseVeiculoNavigation { get; set; }
        public virtual TblInfracaoPreAutuacaoConferenciaTipo CodigoInfracaoPreAutuacaoConferenciaTipoNavigation { get; set; }
        public virtual TblInfracaoPreAutuacaoFase CodigoInfracaoPreAutuacaoFaseNavigation { get; set; }
        public virtual TblInfracaoPreAutuacaoMotivoInvalidacao CodigoInfracaoPreAutuacaoMotivoInvalidacaoAnaliseNavigation { get; set; }
        public virtual TblInfracaoPreAutuacaoMotivoInvalidacao CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDoisNavigation { get; set; }
        public virtual TblInfracaoPreAutuacaoMotivoInvalidacao CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaRevisaoNavigation { get; set; }
        public virtual TblInfracaoPreAutuacaoMotivoInvalidacao CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUmNavigation { get; set; }
        public virtual TblInfracaoPreAutuacaoSituacao CodigoInfracaoPreAutuacaoSituacaoNavigation { get; set; }
        public virtual TblInfracaoVeiculoTipo CodigoInfracaoVeiculoTipoNavigation { get; set; }
        public virtual TblBaseRodovia CodigoRodoviaLocalInfracaoNavigation { get; set; }
        public virtual TblBaseUf CodigoUfjurisdicaoVeiculoNavigation { get; set; }
        public virtual TblBaseUf CodigoUflocalInfracaoNavigation { get; set; }
        public virtual TblInfracaoPreAutuacaoAnalise TblInfracaoPreAutuacaoAnalise { get; set; }
        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoConferenciaDupla> TblInfracaoPreAutuacaoConferenciaDupla { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoConferenciaSimplesPncv> TblInfracaoPreAutuacaoConferenciaSimplesPncv { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoImagem> TblInfracaoPreAutuacaoImagem { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoPreparacaoImagem> TblInfracaoPreAutuacaoPreparacaoImagem { get; set; }
    }
}
