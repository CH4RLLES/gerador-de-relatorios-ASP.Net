using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvagenteTransitoCredenciamento
    {
        public TblPncvagenteTransitoCredenciamento()
        {
            TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada = new HashSet<TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada>();
            TblPncvagenteTransitoCredenciamentoEvento = new HashSet<TblPncvagenteTransitoCredenciamentoEvento>();
            TblPncvagenteTransitoSolicitacaoDescredenciamento = new HashSet<TblPncvagenteTransitoSolicitacaoDescredenciamento>();
        }

        public int CodigoPncvagenteTransitoCredenciamento { get; set; }
        public byte[] RowVersion { get; set; }
        public int CodigoPncvagenteTransitoSolicitacaoCredenciamento { get; set; }
        public int CodigoSistemaUsuario { get; set; }
        public int CodigoPncvagenteTransitoCredenciamentoSituacao { get; set; }
        public int CodigoRenavammunicipioNaturalidade { get; set; }
        public int CodigoUfnaturalidade { get; set; }
        public int CodigoUforgaoExpedidor { get; set; }
        public int CodigoUflotacao { get; set; }
        public int CodigoPncvagenteTransitoIndicadorTipoSanguineo { get; set; }
        public int? CodigoPncvagenteTransitoSolicitacaoDescredenciamento { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Rg { get; set; }
        public string RgsiglaOrgaoExpedidor { get; set; }
        public bool? IndicadorSexoMasculino { get; set; }
        public bool? IndicadorFatorRhpositivo { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public string FotoArquivoNome { get; set; }
        public string FotoArquivoNomeFisico { get; set; }
        public int FotoArquivoTamanho { get; set; }
        public string PortariaArquivoNome { get; set; }
        public string PortariaArquivoNomeFisico { get; set; }
        public int PortariaArquivoTamanho { get; set; }
        public int NumeroPortaria { get; set; }
        public DateTime DataPortaria { get; set; }
        public DateTime DataPublicacaoPortariaDou { get; set; }
        public string NomeCargo { get; set; }
        public string CertificadoCursoArquivoNome { get; set; }
        public string CertificadoCursoArquivoNomeFisico { get; set; }
        public int CertificadoCursoArquivoTamanho { get; set; }

        public virtual TblPncvagenteTransitoCredenciamentoSituacao CodigoPncvagenteTransitoCredenciamentoSituacaoNavigation { get; set; }
        public virtual TblPncvagenteTransitoIndicadorTipoSanguineo CodigoPncvagenteTransitoIndicadorTipoSanguineoNavigation { get; set; }
        public virtual TblPncvagenteTransitoSolicitacaoCredenciamento CodigoPncvagenteTransitoSolicitacaoCredenciamentoNavigation { get; set; }
        public virtual TblPncvagenteTransitoSolicitacaoDescredenciamento CodigoPncvagenteTransitoSolicitacaoDescredenciamentoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioNavigation { get; set; }
        public virtual TblBaseUf CodigoUflotacaoNavigation { get; set; }
        public virtual TblBaseUf CodigoUfnaturalidadeNavigation { get; set; }
        public virtual TblBaseUf CodigoUforgaoExpedidorNavigation { get; set; }
        public virtual ICollection<TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada> TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada { get; set; }
        public virtual ICollection<TblPncvagenteTransitoCredenciamentoEvento> TblPncvagenteTransitoCredenciamentoEvento { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoDescredenciamento> TblPncvagenteTransitoSolicitacaoDescredenciamento { get; set; }
    }
}
