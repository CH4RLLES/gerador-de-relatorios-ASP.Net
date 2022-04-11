using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoExpedicao
    {
        public TblInfracaoNotificacaoExpedicao()
        {
            TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo = new HashSet<TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo>();
            TblInfracaoNotificacao = new HashSet<TblInfracaoNotificacao>();
            TblInfracaoNotificacaoExpedicaoEvento = new HashSet<TblInfracaoNotificacaoExpedicaoEvento>();
        }

        public long CodigoInfracaoNotificacaoExpedicao { get; set; }
        public int CodigoInfracaoNotificacaoExpedicaoSituacao { get; set; }
        public int CodigoInfracaoNotificacaoExpedicaoServico { get; set; }
        public int CodigoInfracaoNotificacaoExpedicaoTipo { get; set; }
        public int CodigoInfracaoNotificacaoTipoGrupo { get; set; }
        public int CodigoInfracaoFinanceiroGrucadastroTituloBanco { get; set; }
        public string NumeroRemessa { get; set; }
        public DateTime DataPostagem { get; set; }
        public DateTime DataProcessamento { get; set; }
        public DateTime DataPostagemCorreio { get; set; }
        public DateTime? DataColetaCorreios { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public int QuantidadeNotificacoes { get; set; }
        public string ResumoPostagemArquivoNome { get; set; }
        public string ResumoPostagemArquivoNomeFisico { get; set; }
        public int? ResumoPostagemArquivoTamanho { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime DataVencimento { get; set; }
        public int CodigoInfracaoNotificacaoExpedicaoFase { get; set; }
        public string ArquivoPacoteImpressaoNome { get; set; }
        public int? CodigoInfracaoNotificacaoExpedicaoFalha { get; set; }
        public string MensagemErroPacoteImpressao { get; set; }
        public long CodigoBaseCorreiosCartaoPostagem { get; set; }
        public int? CodigoBaseCorreiosPlanoTriagem { get; set; }
        public DateTime? DataCriacaoArquivoSegundaVia { get; set; }
        public string CedocodigoServicoPrincipal { get; set; }
        public string CedocodigoAdministrativoContrato { get; set; }
        public DateTime? CedodataControle { get; set; }
        public int? CedonumeroSequencialInicio { get; set; }
        public int? CedonumeroSequencialTermino { get; set; }
        public bool? CedoindicadorDevolucaoEletronica { get; set; }

        public virtual TblBaseCorreiosCartaoPostagem CodigoBaseCorreiosCartaoPostagemNavigation { get; set; }
        public virtual TblBaseCorreiosPlanoTriagem CodigoBaseCorreiosPlanoTriagemNavigation { get; set; }
        public virtual TblInfracaoFinanceiroGrucadastroTituloBanco CodigoInfracaoFinanceiroGrucadastroTituloBancoNavigation { get; set; }
        public virtual TblInfracaoNotificacaoExpedicaoFalha CodigoInfracaoNotificacaoExpedicaoFalhaNavigation { get; set; }
        public virtual TblInfracaoNotificacaoExpedicaoFase CodigoInfracaoNotificacaoExpedicaoFaseNavigation { get; set; }
        public virtual TblInfracaoNotificacaoExpedicaoServico CodigoInfracaoNotificacaoExpedicaoServicoNavigation { get; set; }
        public virtual TblInfracaoNotificacaoExpedicaoSituacao CodigoInfracaoNotificacaoExpedicaoSituacaoNavigation { get; set; }
        public virtual TblInfracaoNotificacaoExpedicaoTipo CodigoInfracaoNotificacaoExpedicaoTipoNavigation { get; set; }
        public virtual TblInfracaoNotificacaoTipoGrupo CodigoInfracaoNotificacaoTipoGrupoNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo> TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo { get; set; }
        public virtual ICollection<TblInfracaoNotificacao> TblInfracaoNotificacao { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoExpedicaoEvento> TblInfracaoNotificacaoExpedicaoEvento { get; set; }
    }
}
