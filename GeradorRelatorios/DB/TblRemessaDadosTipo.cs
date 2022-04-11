using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblRemessaDadosTipo
    {
        public TblRemessaDadosTipo()
        {
            TblRegistroContagem = new HashSet<TblRegistroContagem>();
            TblRemessaDados = new HashSet<TblRemessaDados>();
        }

        public int CodigoRemessaDadosTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblRegistroContagem> TblRegistroContagem { get; set; }
        public virtual ICollection<TblRemessaDados> TblRemessaDados { get; set; }
    }
}
