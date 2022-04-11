using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSegurancaAcidenteTransitoTipo
    {
        public TblSegurancaAcidenteTransitoTipo()
        {
            TblSegurancaAcidenteTransito = new HashSet<TblSegurancaAcidenteTransito>();
        }

        public int CodigoSegurancaAcidenteTransitoTipo { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<TblSegurancaAcidenteTransito> TblSegurancaAcidenteTransito { get; set; }
    }
}
