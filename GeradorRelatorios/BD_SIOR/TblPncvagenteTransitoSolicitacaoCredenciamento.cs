using System;
using System.Collections.Generic;

namespace GeradorRelatorios
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
        public int CodigoSistemaUsuario { get; set; }
        public int CodigoPncvagenteTransitoSolicitacaoCredenciamentoSituacao { get; set; }
        public int CodigoRenavammunicipioNaturalidade { get; set; }
        public int CodigoUfnaturalidade { get; set; }
        public int CodigoUforgaoExpedidor { get; set; }
        public int? CodigoUflotacao { get; set; }
        public int CodigoPncvagenteTransitoIndicadorTipoSanguineo { get; set; }
        public int? CodigoPncvagenteTransitoIndicadorResultadoVerificacaoSolicitacao { get; set; }
        public int? CodigoPncvagenteTransitoIndicadorResultadoVerificacaoPortaria { get; set; }
        public byte[] RowVersion { get; set; }
        public string Rg { get; set; }
        public string RgsiglaOrgaoExpedidor { get; set; }
        public bool? IndicadorSexoMasculino { get; set; }
        public bool? IndicadorFatorRhpositivo { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public int? NumeroPortaria { get; set; }
        public DateTime? DataPortaria { get; set; }
        public DateTime? DataPublicacaoPortariaDou { get; set; }
        public string PortariaArquivoNome { get; set; }
        public string PortariaArquivoNomeFisico { get; set; }
        public int? PortariaArquivoTamanho { get; set; }
        public string FotoArquivoNome { get; set; }
        public string FotoArquivoNomeFisico { get; set; }
        public int? FotoArquivoTamanho { get; set; }
        public string NomeSolicitante { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string ObservacaoSolicitacao { get; set; }
        public string ObservacaoVerificacao { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NomeCargo { get; set; }
        public string CertificadoCursoArquivoNome { get; set; }
        public string CertificadoCursoArquivoNomeFisico { get; set; }
        public int CertificadoCursoArquivoTamanho { get; set; }

        public virtual TblPncvagenteTransitoIndicadorResultadoVerificacao CodigoPncvagenteTransitoIndicadorResultadoVerificacaoPortariaNavigation { get; set; }
        public virtual TblPncvagenteTransitoIndicadorResultadoVerificacao CodigoPncvagenteTransitoIndicadorResultadoVerificacaoSolicitacaoNavigation { get; set; }
        public virtual TblPncvagenteTransitoIndicadorTipoSanguineo CodigoPncvagenteTransitoIndicadorTipoSanguineoNavigation { get; set; }
        public virtual TblPncvagenteTransitoSolicitacaoCredenciamentoSituacao CodigoPncvagenteTransitoSolicitacaoCredenciamentoSituacaoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioNavigation { get; set; }
        public virtual TblBaseUf CodigoUflotacaoNavigation { get; set; }
        public virtual TblBaseUf CodigoUfnaturalidadeNavigation { get; set; }
        public virtual TblBaseUf CodigoUforgaoExpedidorNavigation { get; set; }
        public virtual ICollection<TblPncvagenteTransitoCredenciamento> TblPncvagenteTransitoCredenciamento { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoCredenciamentoArquivo> TblPncvagenteTransitoSolicitacaoCredenciamentoArquivo { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada> TblPncvagenteTransitoSolicitacaoCredenciamentoAtividadeDesempenhada { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoCredenciamentoEvento> TblPncvagenteTransitoSolicitacaoCredenciamentoEvento { get; set; }
    }
}
