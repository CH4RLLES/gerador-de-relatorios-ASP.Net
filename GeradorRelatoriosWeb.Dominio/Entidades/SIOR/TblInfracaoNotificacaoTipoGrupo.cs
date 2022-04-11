using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoTipoGrupo
    {
        public TblInfracaoNotificacaoTipoGrupo()
        {
            TblInfracaoNotificacaoExpedicao = new HashSet<TblInfracaoNotificacaoExpedicao>();
            TblInfracaoNotificacaoTipo = new HashSet<TblInfracaoNotificacaoTipo>();
        }

        public int CodigoInfracaoNotificacaoTipoGrupo { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<TblInfracaoNotificacaoExpedicao> TblInfracaoNotificacaoExpedicao { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoTipo> TblInfracaoNotificacaoTipo { get; set; }
    }
}
