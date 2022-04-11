using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoVelocidadeBarreiraEletronica
    {
        public int CodigoPncvestudoVelocidadeBarreiraEletronica { get; set; }
        public int CodigoPncvestudoVelocidadeRegulamentada { get; set; }
        public int VelocidadeVeiculoLeve { get; set; }
        public int VelocidadeVeiculoPesado { get; set; }
        public int? VelocidadeIntermediaria { get; set; }

        public virtual TblPncvestudoVelocidadeRegulamentada CodigoPncvestudoVelocidadeRegulamentadaNavigation { get; set; }
    }
}
