using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblTrafegoVmdsemanalClassificadoClasseVeiculo
    {
        public int CodigoTrafegoVmdsemanalClassificadoClasseVeiculo { get; set; }
        public int CodigoTrafegoVmdsemanalClassificado { get; set; }
        public int CodigoTrafegoVmdclasseVeiculo { get; set; }
        public int VolumeDiaSemana { get; set; }

        public virtual TblTrafegoVmdclasseVeiculo CodigoTrafegoVmdclasseVeiculoNavigation { get; set; }
        public virtual TblTrafegoVmdsemanalClassificado CodigoTrafegoVmdsemanalClassificadoNavigation { get; set; }
    }
}
