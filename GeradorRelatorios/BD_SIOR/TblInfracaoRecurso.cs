using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoRecurso
    {
        public TblInfracaoRecurso()
        {
            TblCobrancaInfracaoCodigoInfracaoRecursoPrimeiraInstanciaNavigation = new HashSet<TblCobrancaInfracao>();
            TblCobrancaInfracaoCodigoInfracaoRecursoSegundaInstanciaNavigation = new HashSet<TblCobrancaInfracao>();
            TblInfracaoRecursoAnaliseJulgamentoJari = new HashSet<TblInfracaoRecursoAnaliseJulgamentoJari>();
            TblInfracaoRecursoArquivo = new HashSet<TblInfracaoRecursoArquivo>();
            TblInfracaoRecursoEvento = new HashSet<TblInfracaoRecursoEvento>();
            TblInfracaoRecursoInstrucaoNaoConhecer = new HashSet<TblInfracaoRecursoInstrucaoNaoConhecer>();
            TblInfracaoRecursoRelatoNaoConhecer = new HashSet<TblInfracaoRecursoRelatoNaoConhecer>();
            TblJarisessaoJulgamentoPauta = new HashSet<TblJarisessaoJulgamentoPauta>();
            TblJarisessaoJulgamentoVoto = new HashSet<TblJarisessaoJulgamentoVoto>();
        }

        public long CodigoInfracaoRecurso { get; set; }
        public long CodigoInfracao { get; set; }
        public int CodigoInfracaoRecursoTipo { get; set; }
        public int CodigoInfracaoRecursoSituacao { get; set; }
        public int CodigoInfracaoRecursoFase { get; set; }
        public int CodigoInfracaoRecursoOrigem { get; set; }
        public int? CodigoInfracaoRecursoIndicadorRecorrente { get; set; }
        public int? CodigoInfracaoRecursoIndicadorResultadoInstrucao { get; set; }
        public int? CodigoInfracaoRecursoIndicadorResultadoVotoRelato { get; set; }
        public int? CodigoInfracaoRecursoIndicadorResultadoJulgamento { get; set; }
        public int? CodigoInfracaoRecursoIndicadorAdmissibilidadeInstrucao { get; set; }
        public int? CodigoInfracaoRecursoIndicadorMeritoInstrucao { get; set; }
        public int? CodigoInfracaoRecursoIndicadorAdmissibilidadeRelato { get; set; }
        public int? CodigoInfracaoRecursoIndicadorMeritoRelato { get; set; }
        public int? CodigoSistemaUsuarioInstrucao { get; set; }
        public int? CodigoSistemaUsuarioRelato { get; set; }
        public int? CodigoSistemaUsuarioEmVistas { get; set; }
        public int? CodigoJari { get; set; }
        public long? CodigoJarisessaoJulgamento { get; set; }
        public string NumeroProcesso { get; set; }
        public DateTime DataProtocolo { get; set; }
        public DateTime PrazoJulgamento { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataJulgamento { get; set; }
        public DateTime? DataPedidoVistas { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public string RecorrenteNome { get; set; }
        public string RecorrenteNumeroCpfcnpj { get; set; }
        public string RecorrenteNumeroCpfcnpjformatado { get; set; }
        public string InstrucaoAlegacao { get; set; }
        public string InstrucaoFundamentacao { get; set; }
        public string RelatoAlegacao { get; set; }
        public string RelatoFundamentacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public byte[] RowVersion { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public long? CodigoInfracaoProprietario { get; set; }
        public string NumeroAuto { get; set; }
        public DateTime DataInfracao { get; set; }
        public string VeiculoPlaca { get; set; }
        public string VeiculoPlacaUf { get; set; }
        public DateTime? DataInstrucao { get; set; }
        public DateTime? DataRecebimentoDetran { get; set; }
        public DateTime? DataRecebimentoDnit { get; set; }
        public DateTime? DataEncaminhamento { get; set; }
        public DateTime? DataRevisao { get; set; }
        public DateTime? DataRelato { get; set; }
        public int? CodigoSistemaUsuarioRevisao { get; set; }
        public bool IndicadorRegistroRenainf { get; set; }

        public virtual TblInfracao CodigoInfracaoNavigation { get; set; }
        public virtual TblInfracaoRecursoFase CodigoInfracaoRecursoFaseNavigation { get; set; }
        public virtual TblInfracaoRecursoIndicadorAdmissibilidade CodigoInfracaoRecursoIndicadorAdmissibilidadeInstrucaoNavigation { get; set; }
        public virtual TblInfracaoRecursoIndicadorAdmissibilidade CodigoInfracaoRecursoIndicadorAdmissibilidadeRelatoNavigation { get; set; }
        public virtual TblInfracaoRecursoIndicadorMerito CodigoInfracaoRecursoIndicadorMeritoInstrucaoNavigation { get; set; }
        public virtual TblInfracaoRecursoIndicadorMerito CodigoInfracaoRecursoIndicadorMeritoRelatoNavigation { get; set; }
        public virtual TblInfracaoRecursoIndicadorRecorrente CodigoInfracaoRecursoIndicadorRecorrenteNavigation { get; set; }
        public virtual TblInfracaoRecursoIndicadorResultado CodigoInfracaoRecursoIndicadorResultadoInstrucaoNavigation { get; set; }
        public virtual TblInfracaoRecursoIndicadorResultado CodigoInfracaoRecursoIndicadorResultadoJulgamentoNavigation { get; set; }
        public virtual TblInfracaoRecursoIndicadorResultado CodigoInfracaoRecursoIndicadorResultadoVotoRelatoNavigation { get; set; }
        public virtual TblInfracaoRecursoOrigem CodigoInfracaoRecursoOrigemNavigation { get; set; }
        public virtual TblInfracaoRecursoSituacao CodigoInfracaoRecursoSituacaoNavigation { get; set; }
        public virtual TblInfracaoRecursoTipo CodigoInfracaoRecursoTipoNavigation { get; set; }
        public virtual TblJari CodigoJariNavigation { get; set; }
        public virtual TblJarisessaoJulgamento CodigoJarisessaoJulgamentoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioEmVistasNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioInstrucaoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioRelatoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioRevisaoNavigation { get; set; }
        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracaoCodigoInfracaoRecursoPrimeiraInstanciaNavigation { get; set; }
        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracaoCodigoInfracaoRecursoSegundaInstanciaNavigation { get; set; }
        public virtual ICollection<TblInfracaoRecursoAnaliseJulgamentoJari> TblInfracaoRecursoAnaliseJulgamentoJari { get; set; }
        public virtual ICollection<TblInfracaoRecursoArquivo> TblInfracaoRecursoArquivo { get; set; }
        public virtual ICollection<TblInfracaoRecursoEvento> TblInfracaoRecursoEvento { get; set; }
        public virtual ICollection<TblInfracaoRecursoInstrucaoNaoConhecer> TblInfracaoRecursoInstrucaoNaoConhecer { get; set; }
        public virtual ICollection<TblInfracaoRecursoRelatoNaoConhecer> TblInfracaoRecursoRelatoNaoConhecer { get; set; }
        public virtual ICollection<TblJarisessaoJulgamentoPauta> TblJarisessaoJulgamentoPauta { get; set; }
        public virtual ICollection<TblJarisessaoJulgamentoVoto> TblJarisessaoJulgamentoVoto { get; set; }
    }
}
