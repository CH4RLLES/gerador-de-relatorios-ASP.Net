using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvestudoTecnicoInstalacaoSinalizacaoVertical
    {
        public int CodigoPncvestudoTecnicoInstalacaoSinalizacaoVertical { get; set; }
        public int CodigoPncvestudoTecnicoInstalacao { get; set; }
        public byte CodigoPncvsentidoRodovia { get; set; }
        public byte CodigoPncvtipoPlacaSinalizacao { get; set; }
        public int CodigoPncvestudoIndicadorSinalizacaoLadoRodovia { get; set; }
        public decimal DistanciaAteEquipamento { get; set; }
        public decimal DimensaoAltura { get; set; }
        public decimal DimensaoLargura { get; set; }

        public virtual TblPncvestudoIndicadorSinalizacaoLadoRodovia CodigoPncvestudoIndicadorSinalizacaoLadoRodoviaNavigation { get; set; }
        public virtual TblPncvestudoTecnicoInstalacao CodigoPncvestudoTecnicoInstalacaoNavigation { get; set; }
        public virtual TblPncvsentidoRodovia CodigoPncvsentidoRodoviaNavigation { get; set; }
        public virtual TblPncvtipoPlacaSinalizacao CodigoPncvtipoPlacaSinalizacaoNavigation { get; set; }
    }
}
