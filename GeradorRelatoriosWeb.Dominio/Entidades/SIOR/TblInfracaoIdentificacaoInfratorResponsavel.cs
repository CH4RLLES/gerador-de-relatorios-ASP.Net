using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoIdentificacaoInfratorResponsavel
    {
        public TblInfracaoIdentificacaoInfratorResponsavel()
        {
            TblInfracaoIdentificacaoInfratorResponsavelArquivo = new HashSet<TblInfracaoIdentificacaoInfratorResponsavelArquivo>();
            TblInfracaoIdentificacaoInfratorResponsavelDocumentoFiscal = new HashSet<TblInfracaoIdentificacaoInfratorResponsavelDocumentoFiscal>();
            TblInfracaoIdentificacaoInfratorResponsavelEvento = new HashSet<TblInfracaoIdentificacaoInfratorResponsavelEvento>();
        }

        public long CodigoInfracaoIdentificacaoInfratorResponsavel { get; set; }
        public byte[] RowVersion { get; set; }
        public long CodigoInfracao { get; set; }
        public int CodigoInfracaoIdentificacaoInfratorResponsavelSituacao { get; set; }
        public int CodigoInfracaoIdentificacaoInfratorResponsavelFase { get; set; }
        public int? CodigoInfracaoIdentificacaoInfratorResponsavelIndicadorResultadoConferencia { get; set; }
        public int? CodigoInfracaoIdentificacaoInfratorResponsavelMotivoInvalidacao { get; set; }
        public int? CodigoInfracaoIndicadorResponsavel { get; set; }
        public int? CodigoRenavamtipoDocumentoEmbarcadorTransportador { get; set; }
        public int? CodigoSistemaUsuarioConferencia { get; set; }
        public int? CodigoInfracaoIdentificacaoInfratorResponsavelOrigem { get; set; }
        public long CodigoInfracaoProprietario { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public string NumeroProcesso { get; set; }
        public DateTime DataProtocolo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataConferencia { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public DateTime PrazoConferencia { get; set; }
        public string Nome { get; set; }
        public string NumeroCpfcnpj { get; set; }
        public string NumeroCpfcnpjformatado { get; set; }
        public string Observacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string NumeroAuto { get; set; }
        public string VeiculoPlaca { get; set; }
        public DateTime DataInfracao { get; set; }
        public string VeiculoPlacaUf { get; set; }
        public bool IndicadorRegistroRenainf { get; set; }
        public string DocumentoFiscalNumero { get; set; }
        public int CodigoInfracaoProcessoOrdemTramitacao { get; set; }
        public DateTime? RequerenteDataNascimento { get; set; }
        public int? RequerenteIdade { get; set; }
        public bool? RequerenteIndicadorDoencaDeficiencia { get; set; }

        public virtual TblInfracaoIdentificacaoInfratorResponsavelFase CodigoInfracaoIdentificacaoInfratorResponsavelFaseNavigation { get; set; }
        public virtual TblInfracaoIdentificacaoInfratorResponsavelIndicadorResultado CodigoInfracaoIdentificacaoInfratorResponsavelIndicadorResultadoConferenciaNavigation { get; set; }
        public virtual TblInfracaoIdentificacaoInfratorResponsavelMotivoInvalidacao CodigoInfracaoIdentificacaoInfratorResponsavelMotivoInvalidacaoNavigation { get; set; }
        public virtual TblInfracaoIdentificacaoInfratorResponsavelOrigem CodigoInfracaoIdentificacaoInfratorResponsavelOrigemNavigation { get; set; }
        public virtual TblInfracaoIdentificacaoInfratorResponsavelSituacao CodigoInfracaoIdentificacaoInfratorResponsavelSituacaoNavigation { get; set; }
        public virtual TblInfracaoIndicadorResponsavel CodigoInfracaoIndicadorResponsavelNavigation { get; set; }
        public virtual TblInfracao CodigoInfracaoNavigation { get; set; }
        public virtual TblInfracaoProcessoOrdemTramitacao CodigoInfracaoProcessoOrdemTramitacaoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioConferenciaNavigation { get; set; }
        public virtual ICollection<TblInfracaoIdentificacaoInfratorResponsavelArquivo> TblInfracaoIdentificacaoInfratorResponsavelArquivo { get; set; }
        public virtual ICollection<TblInfracaoIdentificacaoInfratorResponsavelDocumentoFiscal> TblInfracaoIdentificacaoInfratorResponsavelDocumentoFiscal { get; set; }
        public virtual ICollection<TblInfracaoIdentificacaoInfratorResponsavelEvento> TblInfracaoIdentificacaoInfratorResponsavelEvento { get; set; }
    }
}
