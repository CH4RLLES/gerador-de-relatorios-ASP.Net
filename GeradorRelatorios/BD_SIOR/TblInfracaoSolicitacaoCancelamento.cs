using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoSolicitacaoCancelamento
    {
        public TblInfracaoSolicitacaoCancelamento()
        {
            TblInfracaoSolicitacaoCancelamentoArquivo = new HashSet<TblInfracaoSolicitacaoCancelamentoArquivo>();
            TblInfracaoSolicitacaoCancelamentoEvento = new HashSet<TblInfracaoSolicitacaoCancelamentoEvento>();
            TblInfracaoSolicitacaoCancelamentoInfracao = new HashSet<TblInfracaoSolicitacaoCancelamentoInfracao>();
        }

        public int CodigoInfracaoSolicitacaoCancelamento { get; set; }
        public int CodigoInfracaoSolicitacaoCancelamentoTipo { get; set; }
        public int CodigoInfracaoSolicitacaoCancelamentoSituacao { get; set; }
        public string NumeroSolicitacao { get; set; }
        public int TotalInfracao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAnalise { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public byte[] RowVersion { get; set; }
        public string NomeSolicitante { get; set; }
        public int CodigoInfracaoSolicitacaoCancelamentoMotivo { get; set; }

        public virtual TblInfracaoSolicitacaoCancelamentoMotivo CodigoInfracaoSolicitacaoCancelamentoMotivoNavigation { get; set; }
        public virtual TblInfracaoSolicitacaoCancelamentoSituacao CodigoInfracaoSolicitacaoCancelamentoSituacaoNavigation { get; set; }
        public virtual TblInfracaoSolicitacaoCancelamentoTipo CodigoInfracaoSolicitacaoCancelamentoTipoNavigation { get; set; }
        public virtual ICollection<TblInfracaoSolicitacaoCancelamentoArquivo> TblInfracaoSolicitacaoCancelamentoArquivo { get; set; }
        public virtual ICollection<TblInfracaoSolicitacaoCancelamentoEvento> TblInfracaoSolicitacaoCancelamentoEvento { get; set; }
        public virtual ICollection<TblInfracaoSolicitacaoCancelamentoInfracao> TblInfracaoSolicitacaoCancelamentoInfracao { get; set; }
    }
}
