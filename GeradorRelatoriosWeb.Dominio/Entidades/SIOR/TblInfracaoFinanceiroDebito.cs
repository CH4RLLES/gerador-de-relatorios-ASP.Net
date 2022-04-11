using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroDebito
    {
        public TblInfracaoFinanceiroDebito()
        {
            TblInfracaoFinanceiroDebitoEvento = new HashSet<TblInfracaoFinanceiroDebitoEvento>();
        }

        public long CodigoInfracaoFinanceiroDebito { get; set; }
        public int CodigoInfracaoFinanceiroDebitoSituacao { get; set; }
        public long? CodigoInfracaoFinanceiroGru { get; set; }
        public int? CodigoInfracaoFinanceiroGrutipoValor { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal ValorOriginal80Porcento { get; set; }
        public decimal ValorOriginal60Porcento { get; set; }
        public DateTime? DataVencimentoNp { get; set; }
        public decimal ValorPago { get; set; }
        public string NumeroAit { get; set; }
        public string CodigoInfracaoCtb { get; set; }
        public byte SequencialGru { get; set; }
        public long? CodigoInfracaoFinanceiroGrunp { get; set; }
        public int? CodigoInfracaoFinanceiroGrunptipoValor { get; set; }
        public string DevedorNome { get; set; }
        public int DevedorTipoInscricao { get; set; }
        public string DevedorNumeroInscricao { get; set; }
        public string DevedorLogradouro { get; set; }
        public string DevedorNumeroImovel { get; set; }
        public string DevedorComplemento { get; set; }
        public string DevedorBairro { get; set; }
        public string DevedorCep { get; set; }
        public string DevedorCidade { get; set; }
        public string DevedorUf { get; set; }
        public DateTime? DataInfracao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataConstituicaoDefinitivaCredito { get; set; }
        public decimal? CorrecaoMultaValorCorrigido { get; set; }
        public DateTime? CorrecaoMultaPeriodoReferencia { get; set; }
        public decimal? CorrecaoMultaFatorMultiplicador { get; set; }
        public bool? IndicadorCorrecaoMulta { get; set; }
        public DateTime? CorrecaoMultaVigenciaDataInicio { get; set; }
        public DateTime? CorrecaoMultaVigenciaDataTermino { get; set; }
        public DateTime? CorrecaoMultaDataInicioControle { get; set; }
        public int? CodigoBaseGrucodigoRecolhimentoTes { get; set; }
        public long? CodigoInfracaoFinanceiroGrundr1 { get; set; }
        public int? CodigoInfracaoFinanceiroGrundr1tipoValor { get; set; }
        public long? CodigoInfracaoFinanceiroGrundr2 { get; set; }
        public int? CodigoInfracaoFinanceiroGrundr2tipoValor { get; set; }

        public virtual TblInfracaoEnquadramento CodigoInfracaoEnquadramentoNavigation { get; set; }
        public virtual TblInfracao CodigoInfracaoFinanceiroDebitoNavigation { get; set; }
        public virtual TblInfracaoFinanceiroDebitoSituacao CodigoInfracaoFinanceiroDebitoSituacaoNavigation { get; set; }
        public virtual TblInfracaoFinanceiroGru CodigoInfracaoFinanceiroGruNavigation { get; set; }
        public virtual TblInfracaoFinanceiroGru CodigoInfracaoFinanceiroGrundr1Navigation { get; set; }
        public virtual TblInfracaoFinanceiroGrutipoValor CodigoInfracaoFinanceiroGrundr1tipoValorNavigation { get; set; }
        public virtual TblInfracaoFinanceiroGru CodigoInfracaoFinanceiroGrundr2Navigation { get; set; }
        public virtual TblInfracaoFinanceiroGrutipoValor CodigoInfracaoFinanceiroGrundr2tipoValorNavigation { get; set; }
        public virtual TblInfracaoFinanceiroGru CodigoInfracaoFinanceiroGrunpNavigation { get; set; }
        public virtual TblInfracaoFinanceiroGrutipoValor CodigoInfracaoFinanceiroGrunptipoValorNavigation { get; set; }
        public virtual TblInfracaoFinanceiroGrutipoValor CodigoInfracaoFinanceiroGrutipoValorNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroDebitoEvento> TblInfracaoFinanceiroDebitoEvento { get; set; }
    }
}
