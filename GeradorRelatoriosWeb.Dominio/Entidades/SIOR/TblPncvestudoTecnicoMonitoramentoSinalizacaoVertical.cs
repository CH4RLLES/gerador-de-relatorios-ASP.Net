using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoTecnicoMonitoramentoSinalizacaoVertical
    {
        public int CodigoPncvestudoTecnicoMonitoramentoSinalizacaoVertical { get; set; }
        public int CodigoPncvestudoTecnicoMonitoramento { get; set; }
        public byte CodigoPncvsentidoRodovia { get; set; }
        public byte CodigoPncvtipoPlacaSinalizacao { get; set; }
        public int CodigoPncvestudoIndicadorSinalizacaoLadoRodovia { get; set; }
        public decimal DistanciaAteEquipamento { get; set; }
        public decimal DimensaoAltura { get; set; }
        public decimal DimensaoLargura { get; set; }

        public virtual TblPncvestudoIndicadorSinalizacaoLadoRodovia CodigoPncvestudoIndicadorSinalizacaoLadoRodoviaNavigation { get; set; }
        public virtual TblPncvestudoTecnicoMonitoramento CodigoPncvestudoTecnicoMonitoramentoNavigation { get; set; }
        public virtual TblPncvsentidoRodovia CodigoPncvsentidoRodoviaNavigation { get; set; }
        public virtual TblPncvtipoPlacaSinalizacao CodigoPncvtipoPlacaSinalizacaoNavigation { get; set; }
    }
}
