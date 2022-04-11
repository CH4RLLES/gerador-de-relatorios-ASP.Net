using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoViabilidade
    {
        public TblPncvestudoViabilidade()
        {
            TblPncvestudoTecnicoInstalacao = new HashSet<TblPncvestudoTecnicoInstalacao>();
            TblPncvestudoViabilidadeAcidente = new HashSet<TblPncvestudoViabilidadeAcidente>();
            TblPncvestudoViabilidadeDocumento = new HashSet<TblPncvestudoViabilidadeDocumento>();
            TblPncvestudoViabilidadeEvento = new HashSet<TblPncvestudoViabilidadeEvento>();
            TblPncvestudoViabilidadeFaixa = new HashSet<TblPncvestudoViabilidadeFaixa>();
            TblPncvestudoViabilidadeFoto = new HashSet<TblPncvestudoViabilidadeFoto>();
        }

        public int CodigoPncvestudoViabilidade { get; set; }
        public byte[] RowVersion { get; set; }
        public int CodigoPncvestudoViabilidadeSituacao { get; set; }
        public int CodigoPncvestudoViabilidadeMotivacao { get; set; }
        public int CodigoPncvestudoViabilidadeResultado { get; set; }
        public int CodigoPncvequipamentoTipo { get; set; }
        public int CodigoBaseUf { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public int CodigoRenavammunicipio { get; set; }
        public int? CodigoPncvestudoIndicadorClasseRodovia { get; set; }
        public int? CodigoPncvestudoIndicadorTransitoPedestre { get; set; }
        public int? CodigoPncvestudoIndicadorTransitoCiclista { get; set; }
        public int? CodigoPncvestudoIndicadorRelevo { get; set; }
        public int? CodigoPncvestudoIndicadorNivelRisco { get; set; }
        public int? CodigoSistemaUsuarioElaboracao { get; set; }
        public int? CodigoSistemaUsuarioAnalise { get; set; }
        public string CodigoIdentificacaoDnit { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime? DataElaboracao { get; set; }
        public DateTime? DataAnalise { get; set; }
        public DateTime? DataAnulacao { get; set; }
        public decimal LocalEstudoKm { get; set; }
        public string LocalEstudoCodigoSnv { get; set; }
        public DateTime? LocalEstudoDataVersaoSnv { get; set; }
        public string Observacao { get; set; }
        public bool? IndicadorTrechoUrbano { get; set; }
        public bool? IndicadorObraCrema { get; set; }
        public bool? IndicadorObraDuplicacao { get; set; }
        public bool? IndicadorObraPato { get; set; }
        public bool? IndicadorObraRestauracao { get; set; }
        public bool? IndicadorObraIntervencaoBrlegal { get; set; }
        public bool? AnaliseRiscoFatorIndicadorAreaUrbanizadaComConflitoTransversal { get; set; }
        public bool? AnaliseRiscoFatorIndicadorCirculacaoCiclistasPedestresNaLateralVia { get; set; }
        public bool? AnaliseRiscoFatorIndicadorCondicaoSuperficiePavimento { get; set; }
        public bool? AnaliseRiscoFatorIndicadorConflitoEntreIntersecaoRodovia { get; set; }
        public bool? AnaliseRiscoFatorIndicadorFaltaIluminacaoEmLocalCritico { get; set; }
        public bool? AnaliseRiscoFatorIndicadorGeometriaDesfavoravel { get; set; }
        public bool? AnaliseRiscoFatorIndicadorIndicesElevadosNebulosidadePrecitacao { get; set; }
        public bool? AnaliseRiscoFatorIndicadorSinalizacaoDeficiente { get; set; }
        public bool? AnaliseRiscoSituacaoIndicadorAreaUrbanizadaSemIluminacao { get; set; }
        public bool? AnaliseRiscoSituacaoIndicadorIntersecaoNivelEmConflitoComViaPrincipal { get; set; }
        public bool? AnaliseRiscoSituacaoIndicadorLongaTangenteAntecedendoCurvaAcentuada { get; set; }
        public bool? AnaliseRiscoSituacaoIndicadorPresencaPedestresCiclistasLongoVia { get; set; }
        public bool? AnaliseRiscoSituacaoIndicadorAltoIndiceAcidente { get; set; }
        public bool? AnaliseRiscoSituacaoIndicadorCurvasReversas { get; set; }
        public bool? AnaliseRiscoSituacaoIndicadorObraArteEspecialEstreita { get; set; }
        public bool? AnaliseRiscoSituacaoIndicadorPavimentoDefeituoso { get; set; }
        public bool? AnaliseRiscoSituacaoIndicadorPerfilTerrenoMontanhoso { get; set; }
        public bool? AnaliseRiscoSituacaoIndicadorSinalizacaoInadequada { get; set; }
        public bool? AnaliseRiscoSituacaoIndicadorVariosAcessosLocais { get; set; }
        public bool? AnaliseRiscoSituacaoIndicadorDecliveAntecedeCurvaAcentuada { get; set; }
        public bool? AnaliseRiscoSituacaoIndicadorTangenteGrandeFluxoVeiculosPesados { get; set; }
        public bool? AnaliseRiscoSituacaoIndicadorLongoPerfilTerrenoOndulado { get; set; }
        public bool? AnaliseRiscoSituacaoIndicadorTravessiaUrbanaComDeslocamentoTransversal { get; set; }
        public string ElaboracaoParecer { get; set; }
        public string ElaboracaoResponsavelNome { get; set; }
        public string AnaliseResponsavelNome { get; set; }
        public int CodigoPncvestudoViabilidadeOrigem { get; set; }
        public string AnaliseParecer { get; set; }
        public bool IndicadorAjusteElaboracao { get; set; }

        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual TblPncvequipamentoTipo CodigoPncvequipamentoTipoNavigation { get; set; }
        public virtual TblPncvestudoIndicadorClasseRodovia CodigoPncvestudoIndicadorClasseRodoviaNavigation { get; set; }
        public virtual TblPncvestudoIndicadorNivelRisco CodigoPncvestudoIndicadorNivelRiscoNavigation { get; set; }
        public virtual TblPncvestudoIndicadorRelevo CodigoPncvestudoIndicadorRelevoNavigation { get; set; }
        public virtual TblPncvestudoIndicadorTransito CodigoPncvestudoIndicadorTransitoCiclistaNavigation { get; set; }
        public virtual TblPncvestudoIndicadorTransito CodigoPncvestudoIndicadorTransitoPedestreNavigation { get; set; }
        public virtual TblPncvestudoViabilidadeMotivacao CodigoPncvestudoViabilidadeMotivacaoNavigation { get; set; }
        public virtual TblPncvestudoViabilidadeOrigem CodigoPncvestudoViabilidadeOrigemNavigation { get; set; }
        public virtual TblPncvestudoViabilidadeResultado CodigoPncvestudoViabilidadeResultadoNavigation { get; set; }
        public virtual TblPncvestudoViabilidadeSituacao CodigoPncvestudoViabilidadeSituacaoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioAnaliseNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioElaboracaoNavigation { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacao> TblPncvestudoTecnicoInstalacao { get; set; }
        public virtual ICollection<TblPncvestudoViabilidadeAcidente> TblPncvestudoViabilidadeAcidente { get; set; }
        public virtual ICollection<TblPncvestudoViabilidadeDocumento> TblPncvestudoViabilidadeDocumento { get; set; }
        public virtual ICollection<TblPncvestudoViabilidadeEvento> TblPncvestudoViabilidadeEvento { get; set; }
        public virtual ICollection<TblPncvestudoViabilidadeFaixa> TblPncvestudoViabilidadeFaixa { get; set; }
        public virtual ICollection<TblPncvestudoViabilidadeFoto> TblPncvestudoViabilidadeFoto { get; set; }
    }
}
