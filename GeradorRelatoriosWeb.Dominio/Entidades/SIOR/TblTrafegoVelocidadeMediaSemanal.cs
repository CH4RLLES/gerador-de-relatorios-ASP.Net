using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblTrafegoVelocidadeMediaSemanal
    {
        public int CodigoTrafegoVelocidadeMediaSemanal { get; set; }
        public int CodigoBaseMes { get; set; }
        public decimal? Quilometro { get; set; }
        public int? VelocidadeMediaDomingo { get; set; }
        public int? VelocidadeMediaSegunda { get; set; }
        public int? VelocidadeMediaTerca { get; set; }
        public int? VelocidadeMediaQuarta { get; set; }
        public int? VelocidadeMediaQuinta { get; set; }
        public int? VelocidadeMediaSexta { get; set; }
        public int? VelocidadeMediaSabado { get; set; }
        public int CodigoBaseUf { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public int AnoReferencia { get; set; }
        public string CodigoSnv { get; set; }

        public virtual TblBaseMes CodigoBaseMesNavigation { get; set; }
        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
    }
}
