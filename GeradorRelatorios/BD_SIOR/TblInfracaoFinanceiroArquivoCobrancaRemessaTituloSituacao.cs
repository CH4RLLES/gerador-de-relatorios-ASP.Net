using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoFinanceiroArquivoCobrancaRemessaTituloSituacao
    {
        public TblInfracaoFinanceiroArquivoCobrancaRemessaTituloSituacao()
        {
            TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo = new HashSet<TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo>();
        }

        public int CodigoInfracaoFinanceiroArquivoCobrancaRemessaTituloSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo> TblInfracaoFinanceiroArquivoCobrancaRemessaTitulo { get; set; }
    }
}
