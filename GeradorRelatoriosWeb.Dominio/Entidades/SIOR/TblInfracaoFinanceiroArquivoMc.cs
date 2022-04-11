using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroArquivoMc
    {
        public TblInfracaoFinanceiroArquivoMc()
        {
            TblInfracaoFinanceiroArquivoMcpagamento = new HashSet<TblInfracaoFinanceiroArquivoMcpagamento>();
        }

        public int CodigoInfracaoFinanceiroArquivoMc { get; set; }
        public int CodigoInfracaoFinanceiroArquivoMcsituacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataReferencia { get; set; }
        public int? TotalRegistros { get; set; }
        public int? TotalPagamentosNaoRecebidos { get; set; }
        public string ArquivoNome { get; set; }
        public int? ArquivoTamanho { get; set; }
        public string ArquivoNomeFisico { get; set; }

        public virtual TblInfracaoFinanceiroArquivoMcsituacao CodigoInfracaoFinanceiroArquivoMcsituacaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroArquivoMcpagamento> TblInfracaoFinanceiroArquivoMcpagamento { get; set; }
    }
}
