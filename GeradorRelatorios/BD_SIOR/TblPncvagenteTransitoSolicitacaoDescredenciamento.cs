using System;
using System.Collections.Generic;

namespace GeradorRelatorios
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
        public int CodigoSistemaUsuario { get; set; }
        public int CodigoPncvagenteTransitoSolicitacaoDescredenciamentoSituacao { get; set; }
        public int? CodigoPncvagenteTransitoIndicadorResultadoVerificacao { get; set; }
        public int CodigoPncvagenteTransitoCredenciamento { get; set; }
        public byte[] RowVersion { get; set; }
        public int? NumeroPortaria { get; set; }
        public DateTime? DataPortaria { get; set; }
        public DateTime? DataPublicacaoPortariaDou { get; set; }
        public string PortariaArquivoNome { get; set; }
        public string PortariaArquivoNomeFisico { get; set; }
        public int? PortariaArquivoTamanho { get; set; }
        public string Observacao { get; set; }

        public virtual TblPncvagenteTransitoCredenciamento CodigoPncvagenteTransitoCredenciamentoNavigation { get; set; }
        public virtual TblPncvagenteTransitoIndicadorResultadoVerificacao CodigoPncvagenteTransitoIndicadorResultadoVerificacaoNavigation { get; set; }
        public virtual TblPncvagenteTransitoSolicitacaoDescredenciamentoSituacao CodigoPncvagenteTransitoSolicitacaoDescredenciamentoSituacaoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioNavigation { get; set; }
        public virtual ICollection<TblPncvagenteTransitoCredenciamento> TblPncvagenteTransitoCredenciamento { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoDescredenciamentoArquivo> TblPncvagenteTransitoSolicitacaoDescredenciamentoArquivo { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoDescredenciamentoEvento> TblPncvagenteTransitoSolicitacaoDescredenciamentoEvento { get; set; }
    }
}
