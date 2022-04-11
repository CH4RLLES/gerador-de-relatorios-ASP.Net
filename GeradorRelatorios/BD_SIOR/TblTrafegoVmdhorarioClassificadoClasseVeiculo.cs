using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblTrafegoVmdhorarioClassificadoClasseVeiculo
    {
        public int CodigoTrafegoVmdhorarioClassificadoClasseVeiculo { get; set; }
        public int CodigoTrafegoVmdhorarioClassificado { get; set; }
        public int CodigoTrafegoVmdclasseVeiculo { get; set; }
        public int VolumeHorario { get; set; }

        public virtual TblTrafegoVmdclasseVeiculo CodigoTrafegoVmdclasseVeiculoNavigation { get; set; }
        public virtual TblTrafegoVmdhorarioClassificado CodigoTrafegoVmdhorarioClassificadoNavigation { get; set; }
    }
}
