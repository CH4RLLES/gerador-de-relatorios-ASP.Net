namespace GeradorRelatorios.DB_SINPEV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDadosSINPEV")]
    public partial class tblDadosSINPEV
    {
        [Key]
        [StringLength(10)]
        public string NumeroAIT { get; set; }

        [StringLength(4)]
        public string CodigoPPV { get; set; }

        public int? NumRemessaSGPV { get; set; }

        [StringLength(3)]
        public string ClassificacaoVeiculo { get; set; }

        [StringLength(5)]
        public string PesoDeclaradoVeiculo { get; set; }

        [StringLength(15)]
        public string NumeroAETVeiculo { get; set; }

        [StringLength(4)]
        public string AnoFabricacaoVeiculo { get; set; }

        [StringLength(4)]
        public string AnoModeloVeiculo { get; set; }

        [StringLength(6)]
        public string TaraVeiculo { get; set; }

        [StringLength(21)]
        public string ChassiVeiculo { get; set; }

        [StringLength(45)]
        public string MunicipioOrigemCarga { get; set; }

        [StringLength(45)]
        public string MunicipioDestinoCarga { get; set; }

        [StringLength(10)]
        public string VersaoSGPV { get; set; }

        [StringLength(45)]
        public string CargaTransportada { get; set; }

        [StringLength(45)]
        public string TipoCargaTransportada { get; set; }

        [StringLength(60)]
        public string NotasFiscais { get; set; }
    }
}
