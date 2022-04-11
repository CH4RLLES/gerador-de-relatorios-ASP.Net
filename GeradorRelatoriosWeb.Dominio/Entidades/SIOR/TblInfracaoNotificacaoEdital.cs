using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoEdital
    {
        public TblInfracaoNotificacaoEdital()
        {
            TblInfracaoNotificacaoEditalArquivo = new HashSet<TblInfracaoNotificacaoEditalArquivo>();
            TblInfracaoNotificacaoEditalEvento = new HashSet<TblInfracaoNotificacaoEditalEvento>();
            TblInfracaoNotificacaoEditalNotificacao = new HashSet<TblInfracaoNotificacaoEditalNotificacao>();
        }

        public int CodigoInfracaoNotificacaoEdital { get; set; }
        public int CodigoInfracaoNotificacaoEditalTipo { get; set; }
        public string NumeroEdital { get; set; }
        public int QuantidadeNotificacao { get; set; }
        public DateTime? DataPublicacao { get; set; }
        public bool IndicadorEditalPublicado { get; set; }
        public string ConteudoEdital { get; set; }
        public string ExtratoPublicacao { get; set; }
        public DateTime DataVencimentoNotificacao { get; set; }
        public DateTime DataVencimentoEdital { get; set; }
        public int PrazoVencimentoEdital { get; set; }
        public string EditalCompletoArquivoNome { get; set; }
        public string EditalCompletoArquivoNomeFisico { get; set; }
        public int? EditalCompletoArquivoTamanho { get; set; }
        public string EditalExtratoArquivoNome { get; set; }
        public string EditalExtratoArquivoNomeFisico { get; set; }
        public int? EditalExtratoArquivoTamanho { get; set; }
        public string EnderecoUrlPublicacaoEditalDou { get; set; }
        public DateTime? EditalCompletoArquivoDataGeracao { get; set; }
        public int CodigoInfracaoNotificacaoEditalSituacaoArquivoCompleto { get; set; }
        public string Observacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public int NumeroEditalSequencia { get; set; }

        public virtual TblInfracaoNotificacaoEditalSituacaoArquivo CodigoInfracaoNotificacaoEditalSituacaoArquivoCompletoNavigation { get; set; }
        public virtual TblInfracaoNotificacaoEditalTipo CodigoInfracaoNotificacaoEditalTipoNavigation { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoEditalArquivo> TblInfracaoNotificacaoEditalArquivo { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoEditalEvento> TblInfracaoNotificacaoEditalEvento { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoEditalNotificacao> TblInfracaoNotificacaoEditalNotificacao { get; set; }
    }
}
