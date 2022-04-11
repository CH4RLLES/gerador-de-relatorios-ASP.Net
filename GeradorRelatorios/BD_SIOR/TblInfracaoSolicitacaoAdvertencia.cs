using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoSolicitacaoAdvertencia
    {
        public TblInfracaoSolicitacaoAdvertencia()
        {
            TblInfracaoSolicitacaoAdvertenciaArquivo = new HashSet<TblInfracaoSolicitacaoAdvertenciaArquivo>();
            TblInfracaoSolicitacaoAdvertenciaEvento = new HashSet<TblInfracaoSolicitacaoAdvertenciaEvento>();
            TblInfracaoSolicitacaoAdvertenciaNaoConhecer = new HashSet<TblInfracaoSolicitacaoAdvertenciaNaoConhecer>();
        }

        public long CodigoInfracaoSolicitacaoAdvertencia { get; set; }
        public long CodigoInfracao { get; set; }
        public int CodigoInfracaoSolicitacaoAdvertenciaSituacao { get; set; }
        public int CodigoInfracaoSolicitacaoAdvertenciaFase { get; set; }
        public int CodigoInfracaoSolicitacaoAdvertenciaOrigem { get; set; }
        public int? CodigoInfracaoSolicitacaoAdvertenciaIndicadorRecorrente { get; set; }
        public int? CodigoInfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidade { get; set; }
        public int? CodigoInfracaoSolicitacaoAdvertenciaIndicadorMerito { get; set; }
        public int? CodigoInfracaoSolicitacaoAdvertenciaIndicadorResultadoJulgamento { get; set; }
        public int? CodigoSistemaUsuarioInstrucao { get; set; }
        public string NumeroProcesso { get; set; }
        public DateTime? DataCadastroDnit { get; set; }
        public DateTime? DataCadastroDetran { get; set; }
        public DateTime DataProtocolo { get; set; }
        public DateTime? DataInstrucao { get; set; }
        public DateTime? DataJulgamento { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public DateTime PrazoJulgamento { get; set; }
        public string RecorrenteNome { get; set; }
        public string RecorrenteNumeroCpfcnpj { get; set; }
        public string RecorrenteNumeroCpfcnpjformatado { get; set; }
        public string InstrucaoFundamentacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public byte[] RowVersion { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public long? CodigoInfracaoProprietario { get; set; }
        public string NumeroAuto { get; set; }
        public DateTime DataInfracao { get; set; }
        public string VeiculoPlaca { get; set; }
        public string VeiculoPlacaUf { get; set; }
        public bool IndicadorRegistroRenainf { get; set; }

        public virtual TblInfracao CodigoInfracaoNavigation { get; set; }
        public virtual TblInfracaoSolicitacaoAdvertenciaFase CodigoInfracaoSolicitacaoAdvertenciaFaseNavigation { get; set; }
        public virtual TblInfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidade CodigoInfracaoSolicitacaoAdvertenciaIndicadorAdmissibilidadeNavigation { get; set; }
        public virtual TblInfracaoSolicitacaoAdvertenciaIndicadorMerito CodigoInfracaoSolicitacaoAdvertenciaIndicadorMeritoNavigation { get; set; }
        public virtual TblInfracaoSolicitacaoAdvertenciaIndicadorRecorrente CodigoInfracaoSolicitacaoAdvertenciaIndicadorRecorrenteNavigation { get; set; }
        public virtual TblInfracaoSolicitacaoAdvertenciaIndicadorResultado CodigoInfracaoSolicitacaoAdvertenciaIndicadorResultadoJulgamentoNavigation { get; set; }
        public virtual TblInfracaoSolicitacaoAdvertenciaOrigem CodigoInfracaoSolicitacaoAdvertenciaOrigemNavigation { get; set; }
        public virtual TblInfracaoSolicitacaoAdvertenciaSituacao CodigoInfracaoSolicitacaoAdvertenciaSituacaoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioEmInstrucaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoSolicitacaoAdvertenciaArquivo> TblInfracaoSolicitacaoAdvertenciaArquivo { get; set; }
        public virtual ICollection<TblInfracaoSolicitacaoAdvertenciaEvento> TblInfracaoSolicitacaoAdvertenciaEvento { get; set; }
        public virtual ICollection<TblInfracaoSolicitacaoAdvertenciaNaoConhecer> TblInfracaoSolicitacaoAdvertenciaNaoConhecer { get; set; }
    }
}
