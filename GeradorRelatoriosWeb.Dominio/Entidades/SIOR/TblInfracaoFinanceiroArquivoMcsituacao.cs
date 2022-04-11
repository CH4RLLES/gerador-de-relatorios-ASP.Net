using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroArquivoMcsituacao
    {
        public TblInfracaoFinanceiroArquivoMcsituacao()
        {
            TblInfracaoFinanceiroArquivoMc = new HashSet<TblInfracaoFinanceiroArquivoMc>();
        }

        public int CodigoInfracaoFinanceiroArquivoMcsituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroArquivoMc> TblInfracaoFinanceiroArquivoMc { get; set; }
    }
}
