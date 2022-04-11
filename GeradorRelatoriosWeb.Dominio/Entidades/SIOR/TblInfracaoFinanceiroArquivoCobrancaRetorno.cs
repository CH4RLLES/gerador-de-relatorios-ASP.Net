using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroArquivoCobrancaRetorno
    {
        public TblInfracaoFinanceiroArquivoCobrancaRetorno()
        {
            TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo = new HashSet<TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo>();
            TblInfracaoFinanceiroGru = new HashSet<TblInfracaoFinanceiroGru>();
        }

        public long CodigoInfracaoFinanceiroArquivoCobrancaRetorno { get; set; }
        public int CodigoInfracaoFinanceiroArquivoCobrancaRetornoSituacao { get; set; }
        public string CodigoRecolhimentoTes { get; set; }
        public string NumeroConvenio { get; set; }
        public string NumeroContrato { get; set; }
        public DateTime? DataHoraGeracao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAnalise { get; set; }
        public DateTime? DataProcessamento { get; set; }
        public string ArquivoNome { get; set; }
        public string ArquivoNomeFisico { get; set; }
        public int ArquivoTamanho { get; set; }
        public string HeaderNumeroSequencial { get; set; }
        public int? QuantidadeTitulos { get; set; }
        public int? QuantidadeTitulosProcessados { get; set; }
        public int? QuantidadeTitulosNaoIdentificado { get; set; }
        public string NomeSistemaUsuario { get; set; }
        public string Observacao { get; set; }
        public int? QuantidadePagamentosProcessados { get; set; }
        public int? QuantidadeTitulosErroProcessamento { get; set; }

        public virtual TblInfracaoFinanceiroArquivoCobrancaRetornoSituacao CodigoInfracaoFinanceiroArquivoCobrancaRetornoSituacaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo> TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroGru> TblInfracaoFinanceiroGru { get; set; }
    }
}
