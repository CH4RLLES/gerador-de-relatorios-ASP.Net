using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoNotificacaoExpedicaoFase
    {
        public TblInfracaoNotificacaoExpedicaoFase()
        {
            TblInfracaoNotificacaoExpedicao = new HashSet<TblInfracaoNotificacaoExpedicao>();
            TblInfracaoNotificacaoExpedicaoEvento = new HashSet<TblInfracaoNotificacaoExpedicaoEvento>();
        }

        public int CodigoInfracaoNotificacaoExpedicaoFase { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoNotificacaoExpedicao> TblInfracaoNotificacaoExpedicao { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoExpedicaoEvento> TblInfracaoNotificacaoExpedicaoEvento { get; set; }
    }
}
