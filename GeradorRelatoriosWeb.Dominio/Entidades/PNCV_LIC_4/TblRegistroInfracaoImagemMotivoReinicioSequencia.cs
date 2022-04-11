using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_LIC_4
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
