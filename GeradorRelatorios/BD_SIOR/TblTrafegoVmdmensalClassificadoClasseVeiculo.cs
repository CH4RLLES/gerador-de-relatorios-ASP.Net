using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblTrafegoVmdmensalClassificadoClasseVeiculo
    {
        public int CodigoTrafegoVmdmensalClassificadoClasseVeiculo { get; set; }
        public int CodigoTrafegoVmdmensalClassificado { get; set; }
        public int CodigoTrafegoVmdclasseVeiculo { get; set; }
        public int VolumeMensal { get; set; }

        public virtual TblTrafegoVmdclasseVeiculo CodigoTrafegoVmdclasseVeiculoNavigation { get; set; }
        public virtual TblTrafegoVmdmensalClassificado CodigoTrafegoVmdmensalClassificadoNavigation { get; set; }
    }
}
