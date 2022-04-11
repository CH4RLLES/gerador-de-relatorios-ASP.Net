using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvagenteTransitoCredenciamento
    {
        public TblPncvagenteTransitoCredenciamento()
        {
            TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada = new HashSet<TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada>();
            TblPncvagenteTransitoCredenciamentoCredencial = new HashSet<TblPncvagenteTransitoCredenciamentoCredencial>();
            TblPncvagenteTransitoCredenciamentoEvento = new HashSet<TblPncvagenteTransitoCredenciamentoEvento>();
            TblPncvagenteTransitoSolicitacaoDescredenciamento = new HashSet<TblPncvagenteTransitoSolicitacaoDescredenciamento>();
        }

        public int CodigoPncvagenteTransitoCredenciamento { get; set; }
        public int CodigoPncvagenteTransitoCredenciamentoSituacao { get; set; }
        public int CodigoPncvagenteTransitoIndicadorVinculo { get; set; }
        public int? CodigoPncvagenteTransitoSolicitacaoCredenciamento { get; set; }
        public int? CodigoPncvagenteTransitoSolicitacaoDescredenciamento { get; set; }
        public int CodigoUflotacao { get; set; }
        public int CodigoSistemaUsuarioAgenteTransito { get; set; }
        public byte[] RowVersion { get; set; }
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
        public int? CertificadoArquivoTamanho { get; set; }
        public int PortariaCredenciamentoNumero { get; set; }
        public DateTime PortariaCredenciamentoData { get; set; }
        public DateTime PortariaCredenciamentoDataPublicacaoDou { get; set; }
        public string PortariaCredenciamentoArquivoNome { get; set; }
        public string PortariaCredenciamentoArquivoNomeFisico { get; set; }
        public int? PortariaCredenciamentoArquivoTamanho { get; set; }
        public string AgenteTransitoNumeroCpfformatado { get; set; }
        public int? PortariaDescredenciamentoNumero { get; set; }
        public DateTime? PortariaDescredenciamentoData { get; set; }
        public DateTime? PortariaDescredenciamentoDataPublicacaoDou { get; set; }
        public string PortariaDescredenciamentoArquivoNome { get; set; }
        public string PortariaDescredenciamentoArquivoNomeFisico { get; set; }
        public int? PortariaDescredenciamentoArquivoTamanho { get; set; }
        public DateTime? VigenciaDataInicio { get; set; }
        public DateTime? VigenciaDataTermino { get; set; }

        public virtual TblPncvagenteTransitoCredenciamentoSituacao CodigoPncvagenteTransitoCredenciamentoSituacaoNavigation { get; set; }
        public virtual TblPncvagenteTransitoIndicadorVinculo CodigoPncvagenteTransitoIndicadorVinculoNavigation { get; set; }
        public virtual TblPncvagenteTransitoSolicitacaoCredenciamento CodigoPncvagenteTransitoSolicitacaoCredenciamentoNavigation { get; set; }
        public virtual TblPncvagenteTransitoSolicitacaoDescredenciamento CodigoPncvagenteTransitoSolicitacaoDescredenciamentoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioAgenteTransitoNavigation { get; set; }
        public virtual TblBaseUf CodigoUflotacaoNavigation { get; set; }
        public virtual ICollection<TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada> TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada { get; set; }
        public virtual ICollection<TblPncvagenteTransitoCredenciamentoCredencial> TblPncvagenteTransitoCredenciamentoCredencial { get; set; }
        public virtual ICollection<TblPncvagenteTransitoCredenciamentoEvento> TblPncvagenteTransitoCredenciamentoEvento { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoDescredenciamento> TblPncvagenteTransitoSolicitacaoDescredenciamento { get; set; }
    }
}
