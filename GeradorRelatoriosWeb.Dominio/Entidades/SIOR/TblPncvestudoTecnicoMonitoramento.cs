using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoTecnicoMonitoramento
    {
        public TblPncvestudoTecnicoMonitoramento()
        {
            TblPncvestudoTecnicoMonitoramentoAcidenteAntesInicioOperacao = new HashSet<TblPncvestudoTecnicoMonitoramentoAcidenteAntesInicioOperacao>();
            TblPncvestudoTecnicoMonitoramentoAcidenteAposInicioOperacao = new HashSet<TblPncvestudoTecnicoMonitoramentoAcidenteAposInicioOperacao>();
            TblPncvestudoTecnicoMonitoramentoEvento = new HashSet<TblPncvestudoTecnicoMonitoramentoEvento>();
            TblPncvestudoTecnicoMonitoramentoFaixa = new HashSet<TblPncvestudoTecnicoMonitoramentoFaixa>();
            TblPncvestudoTecnicoMonitoramentoFoto = new HashSet<TblPncvestudoTecnicoMonitoramentoFoto>();
            TblPncvestudoTecnicoMonitoramentoSinalizacaoVertical = new HashSet<TblPncvestudoTecnicoMonitoramentoSinalizacaoVertical>();
        }

        public int CodigoPncvestudoTecnicoMonitoramento { get; set; }
        public byte[] RowVersion { get; set; }
        public int CodigoPncvestudoTecnicoMonitoramentoSituacao { get; set; }
        public int CodigoPncvestudoTecnicoTipo { get; set; }
        public int CodigoBaseUf { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public int CodigoRenavammunicipio { get; set; }
        public int CodigoPncveditalLote { get; set; }
        public int CodigoPncvequipamento { get; set; }
        public int CodigoPncvequipamentoTipo { get; set; }
        public int CodigoPncvequipamentoIndicadorComunicacao { get; set; }
        public short CodigoPncvmodeloEquipamento { get; set; }
        public int? CodigoPncvestudoIndicadorRelevo { get; set; }
        public int? CodigoPncvestudoIndicadorTransitoCiclista { get; set; }
        public int? CodigoPncvestudoIndicadorTransitoPedestre { get; set; }
        public int? CodigoSistemaUsuarioElaboracao { get; set; }
        public int? CodigoSistemaUsuarioAnalise { get; set; }
        public int? CodigoUfcreaelaboracaoEngenheiroResponsavel { get; set; }
        public int? CodigoUfcreaanaliseEngenheiroResponsavel { get; set; }
        public string CodigoIdentificacaoDnit { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataAutorizacao { get; set; }
        public DateTime? DataElaboracao { get; set; }
        public DateTime? DataAnalise { get; set; }
        public string MotivoEstudoTecnico { get; set; }
        public string EquipamentoCodigoIdentificacaoDnit { get; set; }
        public decimal LocalEstudoKm { get; set; }
        public string LocalEstudoCodigoSnv { get; set; }
        public DateTime? LocalEstudoDataVersaoSnv { get; set; }
        public bool? IndicadorTrechoUrbano { get; set; }
        public bool? AnaliseRiscoFatorIndicadorAreaUrbanizadaComConflitoTransversal { get; set; }
        public bool? AnaliseRiscoFatorIndicadorCirculacaoCiclistasPedestresNaLateralVia { get; set; }
        public bool? AnaliseRiscoFatorIndicadorCondicaoSuperficiePavimento { get; set; }
        public bool? AnaliseRiscoFatorIndicadorConflitoEntreIntersecaoRodovia { get; set; }
        public bool? AnaliseRiscoFatorIndicadorFaltaIluminacaoEmLocalCritico { get; set; }
        public bool? AnaliseRiscoFatorIndicadorGeometriaDesfavoravel { get; set; }
        public bool? AnaliseRiscoFatorIndicadorIndicesElevadosNebulosidadePrecitacao { get; set; }
        public bool? AnaliseRiscoFatorIndicadorSinalizacaoDeficiente { get; set; }
        public bool? AnaliseRiscoFatorIndicadorOutro { get; set; }
        public string AnaliseRiscoFatorIndicadorOutroDescricao { get; set; }
        public string AnaliseRiscoHistoricoMedidasAdotadasAntesInstalacao { get; set; }
        public string AnaliseRiscoHistoricoMedidasAdotadasAposInstalacao { get; set; }
        public string AnaliseRiscoOutrasInformacoesNecessarias { get; set; }
        public string CroquiCaracterizacaoTrechoArquivoNome { get; set; }
        public string CroquiCaracterizacaoTrechoArquivoNomeFisico { get; set; }
        public int? CroquiCaracterizacaoTrechoArquivoTamanho { get; set; }
        public string CroquiInstalacaoEquipamentoArquivoNome { get; set; }
        public string CroquiInstalacaoEquipamentoArquivoNomeFisico { get; set; }
        public int? CroquiInstalacaoEquipamentoArquivoTamanho { get; set; }
        public string EstudoVelocidadeArquivoNome { get; set; }
        public string EstudoVelocidadeArquivoNomeFisico { get; set; }
        public int? EstudoVelocidadeArquivoTamanho { get; set; }
        public int? EstudoPosteColapsivelArquivoTamanho { get; set; }
        public string ElaboracaoParecer { get; set; }
        public string ElaboracaoEngenheiroResponsavelNome { get; set; }
        public string ElaboracaoEngenheiroResponsavelCreanumero { get; set; }
        public bool AnaliseIndicadorAjusteElaboracao { get; set; }
        public string AnaliseObservacaoAjuste { get; set; }
        public string AnaliseParecer { get; set; }
        public string AnaliseEngenheiroResponsavelNome { get; set; }
        public string AnaliseEngenheiroResponsavelCreanumero { get; set; }
        public string RelatorioArquivoNome { get; set; }
        public string RelatorioArquivoNomeFisico { get; set; }
        public int? RelatorioArquivoTamanho { get; set; }

        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual TblPncveditalLote CodigoPncveditalLoteNavigation { get; set; }
        public virtual TblPncvequipamentoIndicadorComunicacao CodigoPncvequipamentoIndicadorComunicacaoNavigation { get; set; }
        public virtual TblPncvequipamento CodigoPncvequipamentoNavigation { get; set; }
        public virtual TblPncvequipamentoTipo CodigoPncvequipamentoTipoNavigation { get; set; }
        public virtual TblPncvestudoIndicadorRelevo CodigoPncvestudoIndicadorRelevoNavigation { get; set; }
        public virtual TblPncvestudoIndicadorTransito CodigoPncvestudoIndicadorTransitoCiclistaNavigation { get; set; }
        public virtual TblPncvestudoIndicadorTransito CodigoPncvestudoIndicadorTransitoPedestreNavigation { get; set; }
        public virtual TblPncvestudoTecnicoMonitoramentoSituacao CodigoPncvestudoTecnicoMonitoramentoSituacaoNavigation { get; set; }
        public virtual TblPncvestudoTecnicoTipo CodigoPncvestudoTecnicoTipoNavigation { get; set; }
        public virtual TblPncvmodeloEquipamento CodigoPncvmodeloEquipamentoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioAnaliseNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioElaboracaoNavigation { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramentoAcidenteAntesInicioOperacao> TblPncvestudoTecnicoMonitoramentoAcidenteAntesInicioOperacao { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramentoAcidenteAposInicioOperacao> TblPncvestudoTecnicoMonitoramentoAcidenteAposInicioOperacao { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramentoEvento> TblPncvestudoTecnicoMonitoramentoEvento { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramentoFaixa> TblPncvestudoTecnicoMonitoramentoFaixa { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramentoFoto> TblPncvestudoTecnicoMonitoramentoFoto { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramentoSinalizacaoVertical> TblPncvestudoTecnicoMonitoramentoSinalizacaoVertical { get; set; }
    }
}
