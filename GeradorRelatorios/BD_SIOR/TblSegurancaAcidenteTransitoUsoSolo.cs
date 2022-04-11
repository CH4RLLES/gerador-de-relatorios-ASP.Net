using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSegurancaAcidenteTransitoUsoSolo
    {
        public TblSegurancaAcidenteTransitoUsoSolo()
        {
            TblSegurancaAcidenteTransito = new HashSet<TblSegurancaAcidenteTransito>();
        }

        public int CodigoSegurancaAcidenteTransitoUsoSolo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblSegurancaAcidenteTransito> TblSegurancaAcidenteTransito { get; set; }
    }
}
