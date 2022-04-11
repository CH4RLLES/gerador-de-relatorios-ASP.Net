using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoIdentificacaoInfratorCondutor
    {
        public TblInfracaoIdentificacaoInfratorCondutor()
        {
            TblInfracaoIdentificacaoInfratorCondutorArquivo = new HashSet<TblInfracaoIdentificacaoInfratorCondutorArquivo>();
            TblInfracaoIdentificacaoInfratorCondutorEvento = new HashSet<TblInfracaoIdentificacaoInfratorCondutorEvento>();
        }

        public long CodigoInfracaoIdentificacaoInfratorCondutor { get; set; }
        public long CodigoInfracao { get; set; }
        public int CodigoInfracaoIdentificacaoInfratorCondutorSituacao { get; set; }
        public int CodigoInfracaoIdentificacaoInfratorCondutorFase { get; set; }
        public int? CodigoInfracaoIdentificacaoInfratorCondutorIndicadorResultadoConferencia { get; set; }
        public int? CodigoInfracaoIdentificacaoInfratorCondutorMotivoInvalidacao { get; set; }
        public int? CodigoSistemaUsuarioConferencia { get; set; }
        public int? CodigoRenavammodeloCh { get; set; }
        public int? CodigoRenavamtipoDocumentoCondutorNaoHabilitado { get; set; }
        public int? CodigoRenavampaisExpedicaoChestrangeira { get; set; }
        public int? CodigoUfexpedicaoCnh { get; set; }
        public string NumeroProcesso { get; set; }
        public DateTime DataProtocolo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataConferencia { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public DateTime PrazoConferencia { get; set; }
        public string Nome { get; set; }
        public string NumeroCpf { get; set; }
        public string NumeroCpfformatado { get; set; }
        public string NumeroRegistroCh { get; set; }
        public string NumeroDocumentoIdentificacao { get; set; }
        public string Observacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public byte[] RowVersion { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public long CodigoInfracaoProprietario { get; set; }
        public string NumeroAuto { get; set; }
        public DateTime DataInfracao { get; set; }
        public string VeiculoPlaca { get; set; }
        public string VeiculoPlacaUf { get; set; }
        public int? CodigoInfracaoIdentificacaoInfratorCondutorOrigem { get; set; }
        public bool? IndicadorRegistroRenainf { get; set; }
        public int? CodigoInfracaoIdentificacaoInfratorCondutorConferenciaEspecial { get; set; }

        public virtual TblInfracaoIdentificacaoInfratorCondutorConferenciaEspecial CodigoInfracaoIdentificacaoInfratorCondutorConferenciaEspecialNavigation { get; set; }
        public virtual TblInfracaoIdentificacaoInfratorCondutorFase CodigoInfracaoIdentificacaoInfratorCondutorFaseNavigation { get; set; }
        public virtual TblInfracaoIdentificacaoInfratorCondutorIndicadorResultado CodigoInfracaoIdentificacaoInfratorCondutorIndicadorResultadoConferenciaNavigation { get; set; }
        public virtual TblInfracaoIdentificacaoInfratorCondutorMotivoInvalidacao CodigoInfracaoIdentificacaoInfratorCondutorMotivoInvalidacaoNavigation { get; set; }
        public virtual TblInfracaoIdentificacaoInfratorCondutorOrigem CodigoInfracaoIdentificacaoInfratorCondutorOrigemNavigation { get; set; }
        public virtual TblInfracaoIdentificacaoInfratorCondutorSituacao CodigoInfracaoIdentificacaoInfratorCondutorSituacaoNavigation { get; set; }
        public virtual TblInfracao CodigoInfracaoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioEmConferenciaNavigation { get; set; }
        public virtual TblBaseUf CodigoUfexpedicaoCnhNavigation { get; set; }
        public virtual ICollection<TblInfracaoIdentificacaoInfratorCondutorArquivo> TblInfracaoIdentificacaoInfratorCondutorArquivo { get; set; }
        public virtual ICollection<TblInfracaoIdentificacaoInfratorCondutorEvento> TblInfracaoIdentificacaoInfratorCondutorEvento { get; set; }
    }
}
