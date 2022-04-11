using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoNotificacaoExpedicaoFalha
    {
        public TblInfracaoNotificacaoExpedicaoFalha()
        {
            TblInfracaoNotificacaoExpedicao = new HashSet<TblInfracaoNotificacaoExpedicao>();
        }

        public int CodigoInfracaoNotificacaoExpedicaoFalha { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoNotificacaoExpedicao> TblInfracaoNotificacaoExpedicao { get; set; }
    }
}
