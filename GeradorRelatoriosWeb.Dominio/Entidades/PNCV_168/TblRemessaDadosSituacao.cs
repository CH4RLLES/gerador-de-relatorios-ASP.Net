using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_168
{
    public partial class TblRemessaDadosSituacao
    {
        public TblRemessaDadosSituacao()
        {
            TblRemessaDados = new HashSet<TblRemessaDados>();
            TblRemessaDadosEvento = new HashSet<TblRemessaDadosEvento>();
        }

        public int CodigoRemessaDadosSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblRemessaDados> TblRemessaDados { get; set; }
        public virtual ICollection<TblRemessaDadosEvento> TblRemessaDadosEvento { get; set; }
    }
}
