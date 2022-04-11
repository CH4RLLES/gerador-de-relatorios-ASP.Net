using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoNotificacaoRestricaoPncvequipamento
    {
        public int CodigoInfracaoNotificacaoRestricaoPncvequipamento { get; set; }
        public int CodigoInfracaoNotificacaoRestricao { get; set; }
        public int CodigoPncvequipamento { get; set; }

        public virtual TblInfracaoNotificacaoRestricao CodigoInfracaoNotificacaoRestricaoNavigation { get; set; }
        public virtual TblPncvequipamento CodigoPncvequipamentoNavigation { get; set; }
    }
}
