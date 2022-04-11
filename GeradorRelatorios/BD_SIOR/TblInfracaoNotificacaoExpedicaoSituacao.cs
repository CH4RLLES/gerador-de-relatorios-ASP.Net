using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoNotificacaoExpedicaoSituacao
    {
        public TblInfracaoNotificacaoExpedicaoSituacao()
        {
            TblInfracaoNotificacaoExpedicao = new HashSet<TblInfracaoNotificacaoExpedicao>();
            TblInfracaoNotificacaoExpedicaoEvento = new HashSet<TblInfracaoNotificacaoExpedicaoEvento>();
        }

        public int CodigoInfracaoNotificacaoExpedicaoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoNotificacaoExpedicao> TblInfracaoNotificacaoExpedicao { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoExpedicaoEvento> TblInfracaoNotificacaoExpedicaoEvento { get; set; }
    }
}
