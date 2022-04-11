using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSegurancaSegmentoCritico
    {
        public int CodigoSegmentoCritico { get; set; }
        public int CodigoBaseUf { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public string CodigoSnvtrechoDnit { get; set; }
        public int AnoReferencia { get; set; }
        public decimal QuilometroInicial { get; set; }
        public decimal QuilometroFinal { get; set; }
        public string Municipio { get; set; }
        public int Vmda { get; set; }
        public int NumeroAcidentes { get; set; }
        public string Classe { get; set; }
        public string SiglaTipoSuperficie { get; set; }
        public string Criticidade { get; set; }

        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
    }
}
