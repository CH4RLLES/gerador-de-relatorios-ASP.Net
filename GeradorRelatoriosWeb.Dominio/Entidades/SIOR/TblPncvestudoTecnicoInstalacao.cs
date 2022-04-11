using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoTecnicoInstalacao
    {
        public TblPncvestudoTecnicoInstalacao()
        {
            TblPncvautorizacaoInstalacaoEquipamento = new HashSet<TblPncvautorizacaoInstalacaoEquipamento>();
            TblPncvequipamento = new HashSet<TblPncvequipamento>();
            TblPncvequipamentoEstudoTecnico = new HashSet<TblPncvequipamentoEstudoTecnico>();
            TblPncvestudoTecnicoInstalacaoAcidente = new HashSet<TblPncvestudoTecnicoInstalacaoAcidente>();
            TblPncvestudoTecnicoInstalacaoEquipamento = new HashSet<TblPncvestudoTecnicoInstalacaoEquipamento>();
            TblPncvestudoTecnicoInstalacaoEvento = new HashSet<TblPncvestudoTecnicoInstalacaoEvento>();
            TblPncvestudoTecnicoInstalacaoFaixa = new HashSet<TblPncvestudoTecnicoInstalacaoFaixa>();
            TblPncvestudoTecnicoInstalacaoFoto = new HashSet<TblPncvestudoTecnicoInstalacaoFoto>();
            TblPncvestudoTecnicoInstalacaoSinalizacaoVertical = new HashSet<TblPncvestudoTecnicoInstalacaoSinalizacaoVertical>();
        }

        public int CodigoPncvestudoTecnicoInstalacao { get; set; }
        public byte[] RowVersion { get; set; }
        public int CodigoPncvestudoTecnicoInstalacaoSituacao { get; set; }
        public int CodigoPncvestudoViabilidade { get; set; }
        public int CodigoBaseUf { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public int CodigoRenavammunicipio { get; set; }
        public int CodigoPncveditalLote { get; set; }
        public int CodigoPncvequipamentoTipo { get; set; }
        public int? CodigoPncvestudoIndicadorRelevo { get; set; }
        public int? CodigoPncvestudoIndicadorDispositivoSeguranca { get; set; }
        public int? CodigoPncvestudoIndicadorDefensaMetalicaTerminalEntrada { get; set; }
        public int? CodigoPncvestudoIndicadorDefensaMetalicaTerminalSaida { get; set; }
        public int? CodigoPncvestudoIndicadorTransitoCiclista { get; set; }
        public int? CodigoPncvestudoIndicadorTransitoPedestre { get; set; }
        public int? CodigoSistemaUsuarioElaboracao { get; set; }
        public int? CodigoSistemaUsuarioAnalise { get; set; }
        public int? CodigoUfcreaelaboracaoEngenheiroResponsavel { get; set; }
        public int? CodigoUfcreaanaliseEngenheiroResponsavel { get; set; }
        public string CodigoIdentificacaoDnit { get; set; }
        public decimal LocalEstudoKm { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataAutorizacao { get; set; }
        public DateTime? DataElaboracao { get; set; }
        public DateTime? DataAnalise { get; set; }
        public bool? IndicadorTrechoUrbano { get; set; }
        public bool? DispositivoSegurancaIndicadorPosteColapsivel { get; set; }
        public string DispositivoSegurancaJustificativa { get; set; }
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
        public string AnaliseRiscoHistoricoMedidasAdotadas { get; set; }
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
        public string ElaboracaoParecer { get; set; }
        public string ElaboracaoEngenheiroResponsavelNome { get; set; }
        public string ElaboracaoEngenheiroResponsavelCreanumero { get; set; }
        public string AnaliseParecer { get; set; }
        public string AnaliseEngenheiroResponsavelNome { get; set; }
        public string AnaliseEngenheiroResponsavelCreanumero { get; set; }
        public string LocalEstudoCodigoSnv { get; set; }
        public DateTime? LocalEstudoDataVersaoSnv { get; set; }
        public int? CodigoPncvestudoIndicadorClasseRodovia { get; set; }
        public string RelatorioArquivoNome { get; set; }
        public string RelatorioArquivoNomeFisico { get; set; }
        public int? RelatorioArquivoTamanho { get; set; }
        public string EstudoPosteColapsivelArquivoNome { get; set; }
        public string EstudoPosteColapsivelArquivoNomeFisico { get; set; }
        public int? EstudoPosteColapsivelArquivoTamanho { get; set; }
        public bool IndicadorAjusteElaboracao { get; set; }
        public DateTime? DataSolicitacaoRevisao { get; set; }
        public string RevisaoMotivo { get; set; }
        public string RevisaoObservacao { get; set; }
        public string AnaliseObservacaoAjuste { get; set; }
        public bool IndicadorSolicitacaoRevisao { get; set; }
        public DateTime? DataAnulacao { get; set; }

        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual TblPncveditalLote CodigoPncveditalLoteNavigation { get; set; }
        public virtual TblPncvequipamentoTipo CodigoPncvequipamentoTipoNavigation { get; set; }
        public virtual TblPncvestudoIndicadorClasseRodovia CodigoPncvestudoIndicadorClasseRodoviaNavigation { get; set; }
        public virtual TblPncvestudoIndicadorDefensaMetalicaTerminal CodigoPncvestudoIndicadorDefensaMetalicaTerminalEntradaNavigation { get; set; }
        public virtual TblPncvestudoIndicadorDefensaMetalicaTerminal CodigoPncvestudoIndicadorDefensaMetalicaTerminalSaidaNavigation { get; set; }
        public virtual TblPncvestudoIndicadorDispositivoSeguranca CodigoPncvestudoIndicadorDispositivoSegurancaNavigation { get; set; }
        public virtual TblPncvestudoIndicadorRelevo CodigoPncvestudoIndicadorRelevoNavigation { get; set; }
        public virtual TblPncvestudoIndicadorTransito CodigoPncvestudoIndicadorTransitoCiclistaNavigation { get; set; }
        public virtual TblPncvestudoIndicadorTransito CodigoPncvestudoIndicadorTransitoPedestreNavigation { get; set; }
        public virtual TblPncvestudoTecnicoInstalacaoSituacao CodigoPncvestudoTecnicoInstalacaoSituacaoNavigation { get; set; }
        public virtual TblPncvestudoViabilidade CodigoPncvestudoViabilidadeNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioAnaliseNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioElaboracaoNavigation { get; set; }
        public virtual ICollection<TblPncvautorizacaoInstalacaoEquipamento> TblPncvautorizacaoInstalacaoEquipamento { get; set; }
        public virtual ICollection<TblPncvequipamento> TblPncvequipamento { get; set; }
        public virtual ICollection<TblPncvequipamentoEstudoTecnico> TblPncvequipamentoEstudoTecnico { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoAcidente> TblPncvestudoTecnicoInstalacaoAcidente { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoEquipamento> TblPncvestudoTecnicoInstalacaoEquipamento { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoEvento> TblPncvestudoTecnicoInstalacaoEvento { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoFaixa> TblPncvestudoTecnicoInstalacaoFaixa { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoFoto> TblPncvestudoTecnicoInstalacaoFoto { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoSinalizacaoVertical> TblPncvestudoTecnicoInstalacaoSinalizacaoVertical { get; set; }
    }
}
