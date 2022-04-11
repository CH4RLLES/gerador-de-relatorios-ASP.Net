using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroArquivoCobrancaRemessaSituacao
    {
        public TblInfracaoFinanceiroArquivoCobrancaRemessaSituacao()
        {
            TblInfracaoFinanceiroArquivoCobrancaRemessa = new HashSet<TblInfracaoFinanceiroArquivoCobrancaRemessa>();
        }

        public int CodigoInfracaoFinanceiroArquivoCobrancaRemessaSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroArquivoCobrancaRemessa> TblInfracaoFinanceiroArquivoCobrancaRemessa { get; set; }
    }
}
