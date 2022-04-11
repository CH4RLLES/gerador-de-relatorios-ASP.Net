using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_168
{
    public partial class TblRemessaDadosEvento
    {
        public long CodigoRemessaDadosEvento { get; set; }
        public long CodigoRemessaDados { get; set; }
        public int CodigoRemessaDadosSituacao { get; set; }
        public DateTime DataEvento { get; set; }

        public virtual TblRemessaDados CodigoRemessaDadosNavigation { get; set; }
        public virtual TblRemessaDadosSituacao CodigoRemessaDadosSituacaoNavigation { get; set; }
    }
}
