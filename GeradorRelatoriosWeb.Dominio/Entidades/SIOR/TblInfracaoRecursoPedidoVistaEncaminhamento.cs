using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoRecursoPedidoVistaEncaminhamento
    {
        public TblInfracaoRecursoPedidoVistaEncaminhamento()
        {
            TblInfracaoRecursoPedidoVista = new HashSet<TblInfracaoRecursoPedidoVista>();
        }

        public int CodigoInfracaoRecursoPedidoVistaEncaminhamento { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoRecursoPedidoVista> TblInfracaoRecursoPedidoVista { get; set; }
    }
}
