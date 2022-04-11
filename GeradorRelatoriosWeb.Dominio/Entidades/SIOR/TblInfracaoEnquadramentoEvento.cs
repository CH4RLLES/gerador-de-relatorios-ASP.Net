using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoEnquadramentoEvento
    {
        public long CodigoInfracaoEnquadramentoEvento { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblInfracaoEnquadramento CodigoInfracaoEnquadramentoNavigation { get; set; }
    }
}
