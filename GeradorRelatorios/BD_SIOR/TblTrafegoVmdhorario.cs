using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblTrafegoVmdhorario
    {
        public int CodigoTrafegoVmdhorario { get; set; }
        public int CodigoTrafegoVmdfonteDados { get; set; }
        public int CodigoBaseMes { get; set; }
        public int? VolumeAnual { get; set; }
        public int? VolumeMensal { get; set; }
        public int? VolumeHora00 { get; set; }
        public int? VolumeHora01 { get; set; }
        public int? VolumeHora02 { get; set; }
        public int? VolumeHora03 { get; set; }
        public int? VolumeHora04 { get; set; }
        public int? VolumeHora05 { get; set; }
        public int? VolumeHora06 { get; set; }
        public int? VolumeHora07 { get; set; }
        public int? VolumeHora08 { get; set; }
        public int? VolumeHora09 { get; set; }
        public int? VolumeHora10 { get; set; }
        public int? VolumeHora11 { get; set; }
        public int? VolumeHora12 { get; set; }
        public int? VolumeHora13 { get; set; }
        public int? VolumeHora14 { get; set; }
        public int? VolumeHora15 { get; set; }
        public int? VolumeHora16 { get; set; }
        public int? VolumeHora17 { get; set; }
        public int? VolumeHora18 { get; set; }
        public int? VolumeHora19 { get; set; }
        public int? VolumeHora20 { get; set; }
        public int? VolumeHora21 { get; set; }
        public int? VolumeHora22 { get; set; }
        public int? VolumeHora23 { get; set; }
        public decimal? Quilometro { get; set; }
        public int CodigoBaseUf { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public int AnoReferencia { get; set; }
        public string CodigoSnv { get; set; }

        public virtual TblBaseMes CodigoBaseMesNavigation { get; set; }
        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual TblTrafegoVmdfonteDados CodigoTrafegoVmdfonteDadosNavigation { get; set; }
    }
}
