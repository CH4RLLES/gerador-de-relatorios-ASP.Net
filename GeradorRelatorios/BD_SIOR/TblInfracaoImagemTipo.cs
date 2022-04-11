using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoImagemTipo
    {
        public TblInfracaoImagemTipo()
        {
            TblInfracaoImagem = new HashSet<TblInfracaoImagem>();
            TblInfracaoPreAutuacaoImagem = new HashSet<TblInfracaoPreAutuacaoImagem>();
        }

        public int CodigoInfracaoImagemTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoImagem> TblInfracaoImagem { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoImagem> TblInfracaoPreAutuacaoImagem { get; set; }
    }
}
