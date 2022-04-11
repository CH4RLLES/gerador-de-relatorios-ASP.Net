using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroArquivoMcpagamentoSituacao
    {
        public TblInfracaoFinanceiroArquivoMcpagamentoSituacao()
        {
            TblInfracaoFinanceiroArquivoMcpagamento = new HashSet<TblInfracaoFinanceiroArquivoMcpagamento>();
        }

        public int CodigoInfracaoFinanceiroArquivoMcpagamentoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroArquivoMcpagamento> TblInfracaoFinanceiroArquivoMcpagamento { get; set; }
    }
}
