using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroRepasseDetran
    {
        public TblInfracaoFinanceiroRepasseDetran()
        {
            TblInfracaoFinanceiroPagamentoDetran = new HashSet<TblInfracaoFinanceiroPagamentoDetran>();
            TblInfracaoFinanceiroRepasseDetranevento = new HashSet<TblInfracaoFinanceiroRepasseDetranevento>();
            TblInfracaoFinanceiroRepasseDetranretornoExecucaoErro = new HashSet<TblInfracaoFinanceiroRepasseDetranretornoExecucaoErro>();
        }

        public int CodigoInfracaoFinanceiroRepasseDetran { get; set; }
        public int CodigoInfracaoFinanceiroRepasseDetransituacao { get; set; }
        public int CodigoInfracaoFinanceiroDetran { get; set; }
        public int CodigoRenavamorgaoAutuador { get; set; }
        public DateTime DataCadastro { get; set; }
        public string IdentificacaoRepasse { get; set; }
        public string IdentificacaoArquivo { get; set; }
        public int AnoReferencia { get; set; }
        public int MesReferencia { get; set; }
        public int? TotalRegistros { get; set; }
        public int? TotalRegistrosTipo1Boleto { get; set; }
        public int? TotalRegistrosTipo2Gru { get; set; }
        public int? TotalRegistrosTipo3Infracao { get; set; }
        public string GrucodigoRecolhimento { get; set; }
        public string GrucodigoRecolhimentoDv { get; set; }
        public string GrunumeroReferencia { get; set; }
        public int? GruanoCompetencia { get; set; }
        public int? GrumesCompetencia { get; set; }
        public DateTime? GrudataVencimento { get; set; }
        public string Gruuggestao { get; set; }
        public decimal? GruvalorPrincipal { get; set; }
        public decimal? GruvalorDescontosAbatimento { get; set; }
        public decimal? GruvalorOutrasDeducoes { get; set; }
        public decimal? GruvalorRepasse { get; set; }
        public string Gruobservacoes { get; set; }
        public DateTime? RespostaDetrandataRepasse { get; set; }
        public decimal? RespostaDetranvalorRepassado { get; set; }
        public string Arquivo1Nome { get; set; }
        public int? Arquivo1Tamanho { get; set; }
        public string Arquivo1NomeFisico { get; set; }
        public DateTime? Arquivo1DataCriacao { get; set; }
        public string Arquivo2Nome { get; set; }
        public int? Arquivo2Tamanho { get; set; }
        public string Arquivo2NomeFisico { get; set; }
        public DateTime? Arquivo2DataCriacao { get; set; }
        public string Arquivo1CancelamentoNome { get; set; }
        public int? Arquivo1CancelamentoTamanho { get; set; }
        public string Arquivo1CancelamentoNomeFisico { get; set; }
        public DateTime? Arquivo1CancelamentoDataCriacao { get; set; }
        public string Arquivo2CancelamentoNome { get; set; }
        public int? Arquivo2CancelamentoTamanho { get; set; }
        public string Arquivo2CancelamentoNomeFisico { get; set; }
        public DateTime? Arquivo2CancelamentoDataCriacao { get; set; }
        public string Arquivo2CodigoRetornoExecucaoHeader { get; set; }
        public string Arquivo2CodigoRetornoExecucaoGru { get; set; }
        public string Arquivo2CodigoRetornoExecucaoTrailer { get; set; }
        public string Arquivo2CancelamentoCodigoRetornoExecucaoHeader { get; set; }
        public string Arquivo2CancelamentoCodigoRetornoExecucaoGru { get; set; }
        public string Arquivo2CancelamentoCodigoRetornoExecucaoTrailer { get; set; }
        public string ArquivoConfirmacaoSiafinome { get; set; }
        public int? ArquivoConfirmacaoSiafitamanho { get; set; }
        public string ArquivoConfirmacaoSiafinomeFisico { get; set; }
        public int? CodigoInfracaoFinanceiroRepasseDetransituacaoArquivoInclusao { get; set; }
        public int? CodigoInfracaoFinanceiroRepasseDetransituacaoArquivoExclusao { get; set; }

        public virtual TblInfracaoFinanceiroDetran CodigoInfracaoFinanceiroDetranNavigation { get; set; }
        public virtual TblInfracaoFinanceiroRepasseDetransituacaoArquivo CodigoInfracaoFinanceiroRepasseDetransituacaoArquivoExclusaoNavigation { get; set; }
        public virtual TblInfracaoFinanceiroRepasseDetransituacaoArquivo CodigoInfracaoFinanceiroRepasseDetransituacaoArquivoInclusaoNavigation { get; set; }
        public virtual TblInfracaoFinanceiroRepasseDetransituacao CodigoInfracaoFinanceiroRepasseDetransituacaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroPagamentoDetran> TblInfracaoFinanceiroPagamentoDetran { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroRepasseDetranevento> TblInfracaoFinanceiroRepasseDetranevento { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroRepasseDetranretornoExecucaoErro> TblInfracaoFinanceiroRepasseDetranretornoExecucaoErro { get; set; }
    }
}
