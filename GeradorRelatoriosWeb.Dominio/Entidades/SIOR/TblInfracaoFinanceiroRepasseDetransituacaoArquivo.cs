using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroRepasseDetransituacaoArquivo
    {
        public TblInfracaoFinanceiroRepasseDetransituacaoArquivo()
        {
            TblInfracaoFinanceiroRepasseDetranCodigoInfracaoFinanceiroRepasseDetransituacaoArquivoExclusaoNavigation = new HashSet<TblInfracaoFinanceiroRepasseDetran>();
            TblInfracaoFinanceiroRepasseDetranCodigoInfracaoFinanceiroRepasseDetransituacaoArquivoInclusaoNavigation = new HashSet<TblInfracaoFinanceiroRepasseDetran>();
        }

        public int CodigoInfracaoFinanceiroRepasseDetransituacaoArquivo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroRepasseDetran> TblInfracaoFinanceiroRepasseDetranCodigoInfracaoFinanceiroRepasseDetransituacaoArquivoExclusaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroRepasseDetran> TblInfracaoFinanceiroRepasseDetranCodigoInfracaoFinanceiroRepasseDetransituacaoArquivoInclusaoNavigation { get; set; }
    }
}
