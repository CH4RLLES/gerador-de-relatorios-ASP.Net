using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoFinanceiroArquivoCobrancaRetornoTituloSituacao
    {
        public TblInfracaoFinanceiroArquivoCobrancaRetornoTituloSituacao()
        {
            TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo = new HashSet<TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo>();
        }

        public int CodigoInfracaoFinanceiroArquivoCobrancaRetornoTituloSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo> TblInfracaoFinanceiroArquivoCobrancaRetornoTitulo { get; set; }
    }
}
