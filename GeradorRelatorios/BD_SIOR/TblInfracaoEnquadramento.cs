using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoEnquadramento
    {
        public TblInfracaoEnquadramento()
        {
            TblCobrancaInfracao = new HashSet<TblCobrancaInfracao>();
            TblInfracao = new HashSet<TblInfracao>();
            TblInfracaoDaalegacaoEnquadramento = new HashSet<TblInfracaoDaalegacaoEnquadramento>();
            TblInfracaoDafundamentacaoEnquadramento = new HashSet<TblInfracaoDafundamentacaoEnquadramento>();
            TblInfracaoEnquadramentoEvento = new HashSet<TblInfracaoEnquadramentoEvento>();
            TblInfracaoEnquadramentoValor = new HashSet<TblInfracaoEnquadramentoValor>();
            TblInfracaoEnquadramentoVelocidade = new HashSet<TblInfracaoEnquadramentoVelocidade>();
            TblInfracaoFinanceiroDebito = new HashSet<TblInfracaoFinanceiroDebito>();
            TblInfracaoPreAutuacao = new HashSet<TblInfracaoPreAutuacao>();
            TblInfracaoPreAutuacaoAnalise = new HashSet<TblInfracaoPreAutuacaoAnalise>();
            TblInfracaoPreAutuacaoConferenciaSimplesPncv = new HashSet<TblInfracaoPreAutuacaoConferenciaSimplesPncv>();
            TblInfracaoPreAutuacaoPreparacaoImagem = new HashSet<TblInfracaoPreAutuacaoPreparacaoImagem>();
            TblInfracaoRecursoAlegacaoEnquadramento = new HashSet<TblInfracaoRecursoAlegacaoEnquadramento>();
            TblInfracaoRecursoFundamentacaoEnquadramento = new HashSet<TblInfracaoRecursoFundamentacaoEnquadramento>();
        }

        public int CodigoInfracaoEnquadramento { get; set; }
        public int CodigoInfracaoIndicadorResponsavel { get; set; }
        public int CodigoInfracaoNumeroAutoPrefixo { get; set; }
        public int? CodigoRenavamunidadeMedida { get; set; }
        public int CodigoBaseGrucodigoRecolhimentoTes { get; set; }
        public int? CodigoInfracaoCtb { get; set; }
        public string CodigoInfracaoTextoCtb { get; set; }
        public string CodigoEnquadramentoTexto { get; set; }
        public int Desdobramento { get; set; }
        public string DescricaoInfracao { get; set; }
        public string AmparoLegal { get; set; }
        public bool IndicadorFiscalizacaoManual { get; set; }
        public bool IndicadorFiscalizacaoEletronica { get; set; }
        public bool IndicadorRegistroPesagem { get; set; }
        public int CodigoInfracaoEnquadramentoTipoInfracional { get; set; }
        public string DescricaoInfracaoResumo { get; set; }

        public virtual TblBaseGruCodigoRecolhimentoTes CodigoBaseGrucodigoRecolhimentoTesNavigation { get; set; }
        public virtual TblInfracaoEnquadramentoTipoInfracional CodigoInfracaoEnquadramentoTipoInfracionalNavigation { get; set; }
        public virtual TblInfracaoIndicadorResponsavel CodigoInfracaoIndicadorResponsavelNavigation { get; set; }
        public virtual TblInfracaoNumeroAutoPrefixo CodigoInfracaoNumeroAutoPrefixoNavigation { get; set; }
        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracao { get; set; }
        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
        public virtual ICollection<TblInfracaoDaalegacaoEnquadramento> TblInfracaoDaalegacaoEnquadramento { get; set; }
        public virtual ICollection<TblInfracaoDafundamentacaoEnquadramento> TblInfracaoDafundamentacaoEnquadramento { get; set; }
        public virtual ICollection<TblInfracaoEnquadramentoEvento> TblInfracaoEnquadramentoEvento { get; set; }
        public virtual ICollection<TblInfracaoEnquadramentoValor> TblInfracaoEnquadramentoValor { get; set; }
        public virtual ICollection<TblInfracaoEnquadramentoVelocidade> TblInfracaoEnquadramentoVelocidade { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroDebito> TblInfracaoFinanceiroDebito { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacao { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoAnalise> TblInfracaoPreAutuacaoAnalise { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoConferenciaSimplesPncv> TblInfracaoPreAutuacaoConferenciaSimplesPncv { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoPreparacaoImagem> TblInfracaoPreAutuacaoPreparacaoImagem { get; set; }
        public virtual ICollection<TblInfracaoRecursoAlegacaoEnquadramento> TblInfracaoRecursoAlegacaoEnquadramento { get; set; }
        public virtual ICollection<TblInfracaoRecursoFundamentacaoEnquadramento> TblInfracaoRecursoFundamentacaoEnquadramento { get; set; }
    }
}
