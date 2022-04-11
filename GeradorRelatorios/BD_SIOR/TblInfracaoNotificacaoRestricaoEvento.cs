using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoNotificacaoRestricaoEvento
    {
        public long CodigoInfracaoNotificacaoRestricaoEvento { get; set; }
        public int CodigoInfracaoNotificacaoRestricao { get; set; }
        public bool? IndicadorRestricaoAtiva { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblInfracaoNotificacaoRestricao CodigoInfracaoNotificacaoRestricaoNavigation { get; set; }
    }
}
