﻿using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvestudoTecnicoInstalacaoFaixa
    {
        public int CodigoPncvestudoTecnicoInstalacaoFaixa { get; set; }
        public int CodigoPncvestudoTecnicoInstalacao { get; set; }
        public byte CodigoPncvtipoVia { get; set; }
        public byte CodigoPncvsentidoRodovia { get; set; }
        public int? CodigoPncvestudoTecnicoInstalacaoEquipamento { get; set; }
        public int? CodigoPncvequipamentoIndicadorCapturaImagem { get; set; }
        public int? CodigoPncvestudoIndicadorCondicaoPavimento { get; set; }
        public int? CodigoPncvestudoIndicadorGeometriaVia { get; set; }
        public int? CodigoPncvestudoIndicadorTracadoVia { get; set; }
        public int NumeroFaixa { get; set; }
        public decimal? LarguraFaixa { get; set; }
        public decimal? LarguraAcostamento { get; set; }
        public int? Vmdano { get; set; }
        public int? Vmdvalor { get; set; }
        public int? VmdpercentualVeiculosPesados { get; set; }
        public short? TrechoAnteriorVelocidadePraticada { get; set; }
        public DateTime? TrechoAnteriorVelocidadePraticadaDataLevantamento { get; set; }
        public short? TrechoAnteriorVelocidadeRegulamentadaVeiculoLeve { get; set; }
        public short? TrechoAnteriorVelocidadeRegulamentadaVeiculoPesado { get; set; }
        public short? VelocidadeRegulamentadaVeiculoLeve { get; set; }
        public short? VelocidadeRegulamentadaVeiculoPesado { get; set; }
        public short? TempoPermanencia { get; set; }
        public short? TempoRetardo { get; set; }
        public int? CodigoPncvestudoIndicadorComparacaoVelocidade { get; set; }

        public virtual TblPncvequipamentoIndicadorCapturaImagem CodigoPncvequipamentoIndicadorCapturaImagemNavigation { get; set; }
        public virtual TblPncvestudoIndicadorComparacaoVelocidade CodigoPncvestudoIndicadorComparacaoVelocidadeNavigation { get; set; }
        public virtual TblPncvestudoIndicadorCondicaoPavimento CodigoPncvestudoIndicadorCondicaoPavimentoNavigation { get; set; }
        public virtual TblPncvestudoIndicadorGeometriaVia CodigoPncvestudoIndicadorGeometriaViaNavigation { get; set; }
        public virtual TblPncvestudoIndicadorTracadoVia CodigoPncvestudoIndicadorTracadoViaNavigation { get; set; }
        public virtual TblPncvestudoTecnicoInstalacaoEquipamento CodigoPncvestudoTecnicoInstalacaoEquipamentoNavigation { get; set; }
        public virtual TblPncvestudoTecnicoInstalacao CodigoPncvestudoTecnicoInstalacaoNavigation { get; set; }
        public virtual TblPncvsentidoRodovia CodigoPncvsentidoRodoviaNavigation { get; set; }
        public virtual TblPncvtipoVia CodigoPncvtipoViaNavigation { get; set; }
    }
}
