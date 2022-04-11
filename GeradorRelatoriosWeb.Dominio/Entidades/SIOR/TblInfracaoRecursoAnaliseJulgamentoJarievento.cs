using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoRecursoAnaliseJulgamentoJarievento
    {
        public long CodigoInfracaoRecursoAnaliseJulgamentoJarievento { get; set; }
        public long CodigoInfracaoRecursoAnaliseJulgamentoJari { get; set; }
        public int CodigoInfracaoRecursoAnaliseJulgamentoJarisituacao { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblInfracaoRecursoAnaliseJulgamentoJari CodigoInfracaoRecursoAnaliseJulgamentoJariNavigation { get; set; }
        public virtual TblInfracaoRecursoAnaliseJulgamentoJarisituacao CodigoInfracaoRecursoAnaliseJulgamentoJarisituacaoNavigation { get; set; }
    }
}
