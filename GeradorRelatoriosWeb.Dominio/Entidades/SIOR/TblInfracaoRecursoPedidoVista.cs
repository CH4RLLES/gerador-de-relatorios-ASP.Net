using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoRecursoPedidoVista
    {
        public long CodigoInfracaoRecursoPedidoVista { get; set; }
        public long CodigoInfracaoRecurso { get; set; }
        public int CodigoInfracaoRecursoPedidoVistaSituacao { get; set; }
        public int CodigoSistemaUsuarioPedidoVista { get; set; }
        public string SolicitacaoNumeroSessaoJulgamento { get; set; }
        public DateTime? SolicitacaoData { get; set; }
        public string SolicitacaoMotivo { get; set; }
        public DateTime? DevolucaoData { get; set; }
        public string DevolucaoParecer { get; set; }
        public int? CodigoInfracaoRecursoPedidoVistaEncaminhamento { get; set; }

        public virtual TblInfracaoRecursoPedidoVistaEncaminhamento CodigoInfracaoRecursoPedidoVistaEncaminhamentoNavigation { get; set; }
        public virtual TblInfracaoRecursoPedidoVistaSituacao CodigoInfracaoRecursoPedidoVistaSituacaoNavigation { get; set; }
    }
}
