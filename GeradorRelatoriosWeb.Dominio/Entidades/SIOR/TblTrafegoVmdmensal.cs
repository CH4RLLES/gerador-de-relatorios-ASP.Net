using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblTrafegoVmdmensal
    {
        public int CodigoTrafegoVmdmensal { get; set; }
        public int CodigoTrafegoVmdfonteDados { get; set; }
        public int? VolumeAnual { get; set; }
        public int? VolumeJaneiro { get; set; }
        public int? VolumeFevereiro { get; set; }
        public int? VolumeMarco { get; set; }
        public int? VolumeAbril { get; set; }
        public int? VolumeMaio { get; set; }
        public int? VolumeJunho { get; set; }
        public int? VolumeJulho { get; set; }
        public int? VolumeAgosto { get; set; }
        public int? VolumeSetembro { get; set; }
        public int? VolumeOutubro { get; set; }
        public int? VolumeNovembro { get; set; }
        public int? VolumeDezembro { get; set; }
        public decimal? Quilometro { get; set; }
        public int CodigoBaseUf { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public int AnoReferencia { get; set; }
        public string CodigoSnv { get; set; }

        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual TblTrafegoVmdfonteDados CodigoTrafegoVmdfonteDadosNavigation { get; set; }
    }
}
