using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoModeloImpressao
    {
        public int CodigoInfracaoNotificacaoModeloImpressao { get; set; }
        public int CodigoInfracaoNotificacaoTipo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual TblInfracaoNotificacaoTipo CodigoInfracaoNotificacaoTipoNavigation { get; set; }
    }
}
