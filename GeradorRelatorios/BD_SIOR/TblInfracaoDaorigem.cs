using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoDaorigem
    {
        public TblInfracaoDaorigem()
        {
            TblInfracaoDa = new HashSet<TblInfracaoDa>();
        }

        public int CodigoInfracaoDaorigem { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<TblInfracaoDa> TblInfracaoDa { get; set; }
    }
}
