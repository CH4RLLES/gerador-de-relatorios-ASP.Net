using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_168
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
