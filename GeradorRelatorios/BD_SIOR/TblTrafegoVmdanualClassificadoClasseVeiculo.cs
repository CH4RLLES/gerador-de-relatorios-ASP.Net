using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblTrafegoVmdanualClassificadoClasseVeiculo
    {
        public int CodigoTrafegoVmdanualClassificadoClasseVeiculo { get; set; }
        public int CodigoTrafegoVmdanualClassificado { get; set; }
        public int CodigoTrafegoVmdclasseVeiculo { get; set; }
        public int VolumeAnual { get; set; }

        public virtual TblTrafegoVmdanualClassificado CodigoTrafegoVmdanualClassificadoNavigation { get; set; }
        public virtual TblTrafegoVmdclasseVeiculo CodigoTrafegoVmdclasseVeiculoNavigation { get; set; }
    }
}
