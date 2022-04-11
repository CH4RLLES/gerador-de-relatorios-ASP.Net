using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSegurancaAcidenteTransitoCausa
    {
        public TblSegurancaAcidenteTransitoCausa()
        {
            TblSegurancaAcidenteTransito = new HashSet<TblSegurancaAcidenteTransito>();
        }

        public int CodigoSegurancaAcidenteTransitoCausa { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<TblSegurancaAcidenteTransito> TblSegurancaAcidenteTransito { get; set; }
    }
}
