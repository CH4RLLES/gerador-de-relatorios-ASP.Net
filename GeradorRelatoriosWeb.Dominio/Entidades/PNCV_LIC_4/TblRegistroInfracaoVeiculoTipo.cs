using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_LIC_4
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
