using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoFinanceiroArquivoCobrancaRemessaTipoEnvio
    {
        public TblInfracaoFinanceiroArquivoCobrancaRemessaTipoEnvio()
        {
            TblInfracaoFinanceiroArquivoCobrancaRemessa = new HashSet<TblInfracaoFinanceiroArquivoCobrancaRemessa>();
        }

        public int CodigoInfracaoFinanceiroArquivoCobrancaRemessaTipoEnvio { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroArquivoCobrancaRemessa> TblInfracaoFinanceiroArquivoCobrancaRemessa { get; set; }
    }
}
