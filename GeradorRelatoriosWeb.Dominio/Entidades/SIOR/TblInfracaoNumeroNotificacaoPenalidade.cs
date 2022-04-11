using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNumeroNotificacaoPenalidade
    {
        public long CodigoInfracaoNumeroNotificacaoPenalidade { get; set; }
        public string NumeroNotificacaoRenainf { get; set; }
        public decimal NumeroSequencial { get; set; }
    }
}
