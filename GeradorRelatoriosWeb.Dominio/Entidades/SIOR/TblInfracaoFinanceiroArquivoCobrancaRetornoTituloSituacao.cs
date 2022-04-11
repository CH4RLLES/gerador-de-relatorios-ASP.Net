using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
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
