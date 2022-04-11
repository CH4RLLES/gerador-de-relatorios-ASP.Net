using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoRecursoPedidoVistaSituacao
    {
        public TblInfracaoRecursoPedidoVistaSituacao()
        {
            TblInfracaoRecursoPedidoVista = new HashSet<TblInfracaoRecursoPedidoVista>();
        }

        public int CodigoInfracaoRecursoPedidoVistaSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoRecursoPedidoVista> TblInfracaoRecursoPedidoVista { get; set; }
    }
}
