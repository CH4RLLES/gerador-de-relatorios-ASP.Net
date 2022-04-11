using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroRepasseDetranretornoExecucaoErro
    {
        public int CodigoInfracaoFinanceiroRepasseDetranretornoExecucaoErro { get; set; }
        public int CodigoInfracaoFinanceiroRepasseDetran { get; set; }
        public int? NumeroLinha { get; set; }
        public string NumeroAuto { get; set; }
        public string CodigoRetornoExecucao { get; set; }

        public virtual TblInfracaoFinanceiroRepasseDetran CodigoInfracaoFinanceiroRepasseDetranNavigation { get; set; }
    }
}
