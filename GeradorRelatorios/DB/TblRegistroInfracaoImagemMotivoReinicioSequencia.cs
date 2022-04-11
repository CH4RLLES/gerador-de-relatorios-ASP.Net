using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblRegistroInfracaoImagemMotivoReinicioSequencia
    {
        public TblRegistroInfracaoImagemMotivoReinicioSequencia()
        {
            TblRegistroInfracaoImagem = new HashSet<TblRegistroInfracaoImagem>();
        }

        public int CodigoRegistroInfracaoImagemMotivoReinicioSequencia { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TblRegistroInfracaoImagem> TblRegistroInfracaoImagem { get; set; }
    }
}
