using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvagenteTransitoSolicitacaoCredenciamento
    {
        public TblPncvagenteTransitoSolicitacaoCredenciamento()
        {
            TblPncvagenteTransitoCredenciamento = new HashSet<TblPncvagenteTransitoCredenciamento>();
            TblPncvagenteTransitoSolicitacaoCredenciamentoArquivo = new HashSet<TblPncvagenteTransitoSolicitacaoCredenciamentoArquivo>();
            TblPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada = new HashSet<TblPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada>();
            TblPncvagenteTransitoSolicitacaoCredenciamentoEvento = new HashSet<TblPncvagenteTransitoSolicitacaoCredenciamentoEvento>();
        }

        public int CodigoPncvagenteTransitoSolicitacaoCredenciamento { get; set; }
        public int CodigoPncvagenteTransitoSolicitacaoCredenciamentoSituacao { get; set; }
        public int CodigoPncvagenteTransitoIndicadorVinculo { get; set; }
        public int? CodigoPncvagenteTransitoIndicadorResultadoVerificacaoSolicitacao { get; set; }
        public int? CodigoPncvagenteTransitoIndicadorResultadoVerificacaoPortaria { get; set; }
        public int CodigoSistemaUsuarioAgenteTransito { get; set; }
        public int CodigoUflotacao { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime SolicitacaoData { get; set; }
        public string SolicitacaoNomeSolicitante { get; set; }
        public string SolicitacaoJustificativa { get; set; }
        public string AgenteTransitoNome { get; set; }
        public string AgenteTransitoNumeroIdentificacao { get; set; }
        public string AgenteTransitoNumeroCpf { get; set; }
        public string AgenteTransitoMatriculaSiape { get; set; }
        public string AgenteTransitoCargo { get; set; }
        public string AgenteTransitoEmail { get; set; }
        public string AgenteTransitoTelefone { get; set; }
        public string AgenteTransitoVinculoInstituicao { get; set; }
        public string CertificadoArquivoNome { get; set; }
        public string CertificadoArquivoNomeFisico { get; set; }
        public int CertificadoArquivoTamanho { get; set; }
        public int? PortariaCredenciamentoNumero { get; set; }
        public DateTime? PortariaCredenciamentoData { get; set; }
        public DateTime? PortariaCredenciamentoDataPublicacaoDou { get; set; }
        public string PortariaCredenciamentoArquivoNome { get; set; }
        public string PortariaCredenciamentoArquivoNomeFisico { get; set; }
        public int? PortariaCredenciamentoArquivoTamanho { get; set; }
        public string VerificacaoObservacao { get; set; }
        public string AgenteTransitoNumeroCpfformatado { get; set; }

        public virtual TblPncvagenteTransitoIndicadorResultadoVerificacao CodigoPncvagenteTransitoIndicadorResultadoVerificacaoPortariaNavigation { get; set; }
        public virtual TblPncvagenteTransitoIndicadorResultadoVerificacao CodigoPncvagenteTransitoIndicadorResultadoVerificacaoSolicitacaoNavigation { get; set; }
        public virtual TblPncvagenteTransitoIndicadorVinculo CodigoPncvagenteTransitoIndicadorVinculoNavigation { get; set; }
        public virtual TblPncvagenteTransitoSolicitacaoCredenciamentoSituacao CodigoPncvagenteTransitoSolicitacaoCredenciamentoSituacaoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioAgenteTransitoNavigation { get; set; }
        public virtual TblBaseUf CodigoUflotacaoNavigation { get; set; }
        public virtual ICollection<TblPncvagenteTransitoCredenciamento> TblPncvagenteTransitoCredenciamento { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoCredenciamentoArquivo> TblPncvagenteTransitoSolicitacaoCredenciamentoArquivo { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada> TblPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoCredenciamentoEvento> TblPncvagenteTransitoSolicitacaoCredenciamentoEvento { get; set; }
    }
}
