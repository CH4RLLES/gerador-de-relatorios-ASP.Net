using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoExpedicaoTipo
    {
        public TblInfracaoNotificacaoExpedicaoTipo()
        {
            TblInfracao = new HashSet<TblInfracao>();
            TblInfracaoNotificacaoExpedicao = new HashSet<TblInfracaoNotificacaoExpedicao>();
        }

        public int CodigoInfracaoNotificacaoExpedicaoTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoExpedicao> TblInfracaoNotificacaoExpedicao { get; set; }
    }
}
