using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvequipamentoEstudoTecnicoFaixa
    {
        public int CodigoPncvequipamentoEstudoTecnicoFaixa { get; set; }
        public int CodigoPncvequipamentoEstudoTecnico { get; set; }
        public int? CodigoPncvequipamentoFaixa { get; set; }
        public short? TempoPermanencia { get; set; }
        public short? TempoRetardo { get; set; }
        public short? VelocidadeVeiculoLeve { get; set; }
        public short? VelocidadeVeiculoPesado { get; set; }

        public virtual TblPncvequipamentoEstudoTecnico CodigoPncvequipamentoEstudoTecnicoNavigation { get; set; }
        public virtual TblPncvequipamentoFaixa CodigoPncvequipamentoFaixaNavigation { get; set; }
    }
}
