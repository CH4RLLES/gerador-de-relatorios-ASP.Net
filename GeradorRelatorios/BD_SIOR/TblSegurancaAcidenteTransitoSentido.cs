using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSegurancaAcidenteTransitoSentido
    {
        public TblSegurancaAcidenteTransitoSentido()
        {
            TblSegurancaAcidenteTransito = new HashSet<TblSegurancaAcidenteTransito>();
        }

        public int CodigoSegurancaAcidenteTransitoSentido { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<TblSegurancaAcidenteTransito> TblSegurancaAcidenteTransito { get; set; }
    }
}
