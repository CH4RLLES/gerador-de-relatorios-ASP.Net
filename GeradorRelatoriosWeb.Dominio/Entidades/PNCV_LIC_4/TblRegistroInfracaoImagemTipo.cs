using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_LIC_4
{
    public partial class TblRegistroInfracaoImagemTipo
    {
        public TblRegistroInfracaoImagemTipo()
        {
            TblRegistroInfracaoImagem = new HashSet<TblRegistroInfracaoImagem>();
        }

        public int CodigoRegistroInfracaoImagemTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblRegistroInfracaoImagem> TblRegistroInfracaoImagem { get; set; }
    }
}
