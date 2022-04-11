using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoArquivoBaixa
    {
        public TblInfracaoNotificacaoArquivoBaixa()
        {
            TblInfracaoNotificacao = new HashSet<TblInfracaoNotificacao>();
        }

        public int CodigoInfracaoNotificacaoArquivoBaixa { get; set; }
        public int CodigoInfracaoNotificacaoArquivoBaixaSituacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataGeracao { get; set; }
        public int? QuantidadeRegistros { get; set; }
        public int? QuantidadeBaixa { get; set; }
        public DateTime? DataProcessamento { get; set; }
        public string ArquivoNome { get; set; }
        public string ArquivoNomeFisico { get; set; }
        public int ArquivoTamanho { get; set; }
        public string Observacao { get; set; }

        public virtual TblInfracaoNotificacaoArquivoBaixaSituacao CodigoInfracaoNotificacaoArquivoBaixaSituacaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoNotificacao> TblInfracaoNotificacao { get; set; }
    }
}
