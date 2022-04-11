using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBaseFebrabanMovimentoRetorno
    {
        public TblBaseFebrabanMovimentoRetorno()
        {
            TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo = new HashSet<TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo>();
            TblInfracaoFinanceiroGru = new HashSet<TblInfracaoFinanceiroGru>();
        }

        public int CodigoBaseFebrabanMovimentoRetorno { get; set; }
        public string CodigoMovimentoRetorno { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo> TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroGru> TblInfracaoFinanceiroGru { get; set; }
    }
}
