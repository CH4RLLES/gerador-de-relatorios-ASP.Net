using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_LIC_4
{
    public partial class TblRegistroClasseVeiculo
    {
        public TblRegistroClasseVeiculo()
        {
            TblRegistroContagem = new HashSet<TblRegistroContagem>();
        }

        public int CodigoRegistroClasseVeiculo { get; set; }
        public string Classe { get; set; }
        public string Referencia { get; set; }

        public virtual ICollection<TblRegistroContagem> TblRegistroContagem { get; set; }
    }
}
