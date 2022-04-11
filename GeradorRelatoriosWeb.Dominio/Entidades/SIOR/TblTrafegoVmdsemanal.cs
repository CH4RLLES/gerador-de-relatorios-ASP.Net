using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblTrafegoVmdsemanal
    {
        public int CodigoTrafegoVmdsemanal { get; set; }
        public int CodigoTrafegoVmdfonteDados { get; set; }
        public int CodigoBaseMes { get; set; }
        public int? VolumeAnual { get; set; }
        public int? VolumeMensal { get; set; }
        public int? VolumeDomingo { get; set; }
        public int? VolumeSegunda { get; set; }
        public int? VolumeTerca { get; set; }
        public int? VolumeQuarta { get; set; }
        public int? VolumeQuinta { get; set; }
        public int? VolumeSexta { get; set; }
        public int? VolumeSabado { get; set; }
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
