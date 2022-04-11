using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoVelocidadeRegulamentada
    {
        public TblPncvestudoVelocidadeRegulamentada()
        {
            TblPncvestudoVelocidadeBarreiraEletronica = new HashSet<TblPncvestudoVelocidadeBarreiraEletronica>();
        }

        public int CodigoPncvestudoVelocidadeRegulamentada { get; set; }
        public int VelocidadeVeiculoLeve { get; set; }
        public int VelocidadeVeiculoPesado { get; set; }

        public virtual ICollection<TblPncvestudoVelocidadeBarreiraEletronica> TblPncvestudoVelocidadeBarreiraEletronica { get; set; }
    }
}
