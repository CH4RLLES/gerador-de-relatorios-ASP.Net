using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoFinanceiroArquivoCobrancaRemessa
    {
        public TblInfracaoFinanceiroArquivoCobrancaRemessa()
        {
            TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo = new HashSet<TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo>();
            TblInfracaoFinanceiroGru = new HashSet<TblInfracaoFinanceiroGru>();
        }

        public long CodigoInfracaoFinanceiroArquivoCobrancaRemessa { get; set; }
        public int CodigoInfracaoFinanceiroArquivoCobrancaRemessaSituacao { get; set; }
        public int CodigoInfracaoFinanceiroArquivoCobrancaRemessaTipoEnvio { get; set; }
        public string BancoAgenciaMantenedora { get; set; }
        public string BancoAgenciaDigitoVerificador { get; set; }
        public string BancoContaCorrenteNumero { get; set; }
        public string BancoContaCorrenteDigitoVerificador { get; set; }
        public string CodigoRecolhimentoTes { get; set; }
        public string DescricaoCodigoRecolhimentoTes { get; set; }
        public string NumeroConvenio { get; set; }
        public string NumeroContrato { get; set; }
        public string NumeroCarteira { get; set; }
        public string NumeroCarteiraVariacao { get; set; }
        public string NomeSistemaUsuario { get; set; }
        public DateTime DataCadastro { get; set; }
        public string ArquivoNome { get; set; }
        public string ArquivoNomeFisico { get; set; }
        public int? ArquivoTamanho { get; set; }
        public int? QuantidadeTitulos { get; set; }
        public string Observacao { get; set; }
        public DateTime? DataEnvio { get; set; }
        public string UsuarioEnvio { get; set; }

        public virtual TblInfracaoFinanceiroArquivoCobrancaRemessaSituacao CodigoInfracaoFinanceiroArquivoCobrancaRemessaSituacaoNavigation { get; set; }
        public virtual TblInfracaoFinanceiroArquivoCobrancaRemessaTipoEnvio CodigoInfracaoFinanceiroArquivoCobrancaRemessaTipoEnvioNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo> TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroGru> TblInfracaoFinanceiroGru { get; set; }
    }
}
