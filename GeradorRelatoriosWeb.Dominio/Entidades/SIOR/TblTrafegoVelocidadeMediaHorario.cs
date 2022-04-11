using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblTrafegoVelocidadeMediaHorario
    {
        public int CodigoTrafegoVelocidadeMediaHorario { get; set; }
        public int CodigoBaseMes { get; set; }
        public decimal? Quilometro { get; set; }
        public int? VelocidadeMediaHora00 { get; set; }
        public int? VelocidadeMediaHora01 { get; set; }
        public int? VelocidadeMediaHora02 { get; set; }
        public int? VelocidadeMediaHora03 { get; set; }
        public int? VelocidadeMediaHora04 { get; set; }
        public int? VelocidadeMediaHora05 { get; set; }
        public int? VelocidadeMediaHora06 { get; set; }
        public int? VelocidadeMediaHora07 { get; set; }
        public int? VelocidadeMediaHora08 { get; set; }
        public int? VelocidadeMediaHora09 { get; set; }
        public int? VelocidadeMediaHora10 { get; set; }
        public int? VelocidadeMediaHora11 { get; set; }
        public int? VelocidadeMediaHora12 { get; set; }
        public int? VelocidadeMediaHora13 { get; set; }
        public int? VelocidadeMediaHora14 { get; set; }
        public int? VelocidadeMediaHora15 { get; set; }
        public int? VelocidadeMediaHora16 { get; set; }
        public int? VelocidadeMediaHora17 { get; set; }
        public int? VelocidadeMediaHora18 { get; set; }
        public int? VelocidadeMediaHora19 { get; set; }
        public int? VelocidadeMediaHora20 { get; set; }
        public int? VelocidadeMediaHora21 { get; set; }
        public int? VelocidadeMediaHora22 { get; set; }
        public int? VelocidadeMediaHora23 { get; set; }
        public int CodigoBaseUf { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public int AnoReferencia { get; set; }
        public string CodigoSnv { get; set; }

        public virtual TblBaseMes CodigoBaseMesNavigation { get; set; }
        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
    }
}
