using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSegurancaAcidenteTransitoGravidade
    {
        public TblSegurancaAcidenteTransitoGravidade()
        {
            TblSegurancaAcidenteTransito = new HashSet<TblSegurancaAcidenteTransito>();
        }

        public int CodigoSegurancaAcidenteTransitoGravidade { get; set; }
        public string Nome { get; set; }
        public int NivelGravidade { get; set; }

        public virtual ICollection<TblSegurancaAcidenteTransito> TblSegurancaAcidenteTransito { get; set; }
    }
}
