using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSegurancaSegmentoHomogeneo
    {
        public int CodigoSegurancaSegmentoHomogeneo { get; set; }
        public int CodigoBaseUf { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public string CodigoSnvtrecho { get; set; }
        public decimal QuilometroInicial { get; set; }
        public decimal QuilometroFinal { get; set; }
        public string Terreno { get; set; }
        public string Superficie { get; set; }
        public string UsoSolo { get; set; }
        public string Classe { get; set; }
        public int AnoReferencia { get; set; }

        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
    }
}
