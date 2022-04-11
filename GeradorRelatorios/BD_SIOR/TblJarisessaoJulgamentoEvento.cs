using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblJarisessaoJulgamentoEvento
    {
        public long CodigoJarisessaoJulgamentoEvento { get; set; }
        public long CodigoJarisessaoJulgamento { get; set; }
        public int CodigoJarisessaoJulgamentoSituacao { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblJarisessaoJulgamento CodigoJarisessaoJulgamentoNavigation { get; set; }
        public virtual TblJarisessaoJulgamentoSituacao CodigoJarisessaoJulgamentoSituacaoNavigation { get; set; }
    }
}
