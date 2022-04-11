using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvagenteTransitoSolicitacaoDescredenciamento
    {
        public TblPncvagenteTransitoSolicitacaoDescredenciamento()
        {
            TblPncvagenteTransitoCredenciamento = new HashSet<TblPncvagenteTransitoCredenciamento>();
            TblPncvagenteTransitoSolicitacaoDescredenciamentoArquivo = new HashSet<TblPncvagenteTransitoSolicitacaoDescredenciamentoArquivo>();
            TblPncvagenteTransitoSolicitacaoDescredenciamentoEvento = new HashSet<TblPncvagenteTransitoSolicitacaoDescredenciamentoEvento>();
        }

        public int CodigoPncvagenteTransitoSolicitacaoDescredenciamento { get; set; }
        public int CodigoPncvagenteTransitoSolicitacaoDescredenciamentoSituacao { get; set; }
        public int CodigoPncvagenteTransitoCredenciamento { get; set; }
        public int? CodigoPncvagenteTransitoIndicadorResultadoVerificacao { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime SolicitacaoData { get; set; }
        public string SolicitacaoNomeSolicitante { get; set; }
        public string SolicitacaoJustificativa { get; set; }
        public int? PortariaDescredenciamentoNumero { get; set; }
        public DateTime? PortariaDescredenciamentoData { get; set; }
        public DateTime? PortariaDescredenciamentoDataPublicacaoDou { get; set; }
        public string PortariaDescredenciamentoArquivoNome { get; set; }
        public string PortariaDescredenciamentoArquivoNomeFisico { get; set; }
        public int? PortariaDescredenciamentoArquivoTamanho { get; set; }

        public virtual TblPncvagenteTransitoCredenciamento CodigoPncvagenteTransitoCredenciamentoNavigation { get; set; }
        public virtual TblPncvagenteTransitoIndicadorResultadoVerificacao CodigoPncvagenteTransitoIndicadorResultadoVerificacaoNavigation { get; set; }
        public virtual TblPncvagenteTransitoSolicitacaoDescredenciamentoSituacao CodigoPncvagenteTransitoSolicitacaoDescredenciamentoSituacaoNavigation { get; set; }
        public virtual ICollection<TblPncvagenteTransitoCredenciamento> TblPncvagenteTransitoCredenciamento { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoDescredenciamentoArquivo> TblPncvagenteTransitoSolicitacaoDescredenciamentoArquivo { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoDescredenciamentoEvento> TblPncvagenteTransitoSolicitacaoDescredenciamentoEvento { get; set; }
    }
}
