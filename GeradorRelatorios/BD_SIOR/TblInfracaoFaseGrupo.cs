using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoFaseGrupo
    {
        public TblInfracaoFaseGrupo()
        {
            TblInfracaoFase = new HashSet<TblInfracaoFase>();
        }

        public int CodigoInfracaoFaseGrupo { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<TblInfracaoFase> TblInfracaoFase { get; set; }
    }
}
