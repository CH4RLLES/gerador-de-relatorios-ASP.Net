using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblRegistroInfracaoVeiculoTipo
    {
        public TblRegistroInfracaoVeiculoTipo()
        {
            TblRegistroInfracao = new HashSet<TblRegistroInfracao>();
        }

        public int CodigoRegistroInfracaoVeiculoTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblRegistroInfracao> TblRegistroInfracao { get; set; }
    }
}
