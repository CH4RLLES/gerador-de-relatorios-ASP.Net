using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoDa
    {
        public TblInfracaoDa()
        {
            TblCobrancaInfracao = new HashSet<TblCobrancaInfracao>();
            TblInfracaoDaarquivo = new HashSet<TblInfracaoDaarquivo>();
            TblInfracaoDaevento = new HashSet<TblInfracaoDaevento>();
            TblInfracaoDanaoConhecer = new HashSet<TblInfracaoDanaoConhecer>();
        }

        public long CodigoInfracaoDa { get; set; }
        public long CodigoInfracao { get; set; }
        public int CodigoInfracaoDasituacao { get; set; }
        public int CodigoInfracaoDafase { get; set; }
        public int CodigoInfracaoDaorigem { get; set; }
        public int? CodigoInfracaoDaindicadorRecorrente { get; set; }
        public int? CodigoInfracaoDaindicadorAdmissibilidade { get; set; }
        public int? CodigoInfracaoDaindicadorMerito { get; set; }
        public int? CodigoInfracaoDaindicadorResultadoJulgamento { get; set; }
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
        public string InstrucaoAlegacao { get; set; }
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

        public virtual TblInfracaoDafase CodigoInfracaoDafaseNavigation { get; set; }
        public virtual TblInfracaoDaindicadorAdmissibilidade CodigoInfracaoDaindicadorAdmissibilidadeNavigation { get; set; }
        public virtual TblInfracaoDaindicadorMerito CodigoInfracaoDaindicadorMeritoNavigation { get; set; }
        public virtual TblInfracaoDaindicadorRecorrente CodigoInfracaoDaindicadorRecorrenteNavigation { get; set; }
        public virtual TblInfracaoDaindicadorResultado CodigoInfracaoDaindicadorResultadoJulgamentoNavigation { get; set; }
        public virtual TblInfracaoDaorigem CodigoInfracaoDaorigemNavigation { get; set; }
        public virtual TblInfracaoDasituacao CodigoInfracaoDasituacaoNavigation { get; set; }
        public virtual TblInfracao CodigoInfracaoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioEmInstrucaoNavigation { get; set; }
        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracao { get; set; }
        public virtual ICollection<TblInfracaoDaarquivo> TblInfracaoDaarquivo { get; set; }
        public virtual ICollection<TblInfracaoDaevento> TblInfracaoDaevento { get; set; }
        public virtual ICollection<TblInfracaoDanaoConhecer> TblInfracaoDanaoConhecer { get; set; }
    }
}
