using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoFinanceiroArquivoCobrancaRetornoSituacao
    {
        public TblInfracaoFinanceiroArquivoCobrancaRetornoSituacao()
        {
            TblInfracaoFinanceiroArquivoCobrancaRetorno = new HashSet<TblInfracaoFinanceiroArquivoCobrancaRetorno>();
        }

        public int CodigoInfracaoFinanceiroArquivoCobrancaRetornoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroArquivoCobrancaRetorno> TblInfracaoFinanceiroArquivoCobrancaRetorno { get; set; }
    }
}
