using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoViabilidadeFaixa
    {
        public int CodigoPncvestudoViabilidadeFaixa { get; set; }
        public int CodigoPncvestudoViabilidade { get; set; }
        public byte CodigoPncvtipoVia { get; set; }
        public byte CodigoPncvsentidoRodovia { get; set; }
        public int? CodigoPncvestudoIndicadorCondicaoPavimento { get; set; }
        public int? CodigoPncvestudoIndicadorGeometriaVia { get; set; }
        public int? CodigoPncvestudoIndicadorTracadoVia { get; set; }
        public int NumeroFaixa { get; set; }
        public decimal? LarguraFaixa { get; set; }
        public decimal? LarguraAcostamento { get; set; }
        public int? Vmdano { get; set; }
        public int? Vmdvalor { get; set; }
        public int? VmdpercentualVeiculosPesados { get; set; }
        public short? VelocidadeRegulamentadaVeiculoLeve { get; set; }
        public short? VelocidadeRegulamentadaVeiculoPesado { get; set; }
        public short? FiscalizacaoVelocidadeVeiculoLeve { get; set; }
        public short? FiscalizacaoVelocidadeVeiculoPesado { get; set; }

        public virtual TblPncvestudoIndicadorCondicaoPavimento CodigoPncvestudoIndicadorCondicaoPavimentoNavigation { get; set; }
        public virtual TblPncvestudoIndicadorGeometriaVia CodigoPncvestudoIndicadorGeometriaViaNavigation { get; set; }
        public virtual TblPncvestudoIndicadorTracadoVia CodigoPncvestudoIndicadorTracadoViaNavigation { get; set; }
        public virtual TblPncvestudoViabilidade CodigoPncvestudoViabilidadeNavigation { get; set; }
        public virtual TblPncvsentidoRodovia CodigoPncvsentidoRodoviaNavigation { get; set; }
        public virtual TblPncvtipoVia CodigoPncvtipoViaNavigation { get; set; }
    }
}
