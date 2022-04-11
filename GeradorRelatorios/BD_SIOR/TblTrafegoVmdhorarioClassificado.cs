using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblTrafegoVmdhorarioClassificado
    {
        public TblTrafegoVmdhorarioClassificado()
        {
            TblTrafegoVmdhorarioClassificadoClasseVeiculo = new HashSet<TblTrafegoVmdhorarioClassificadoClasseVeiculo>();
        }

        public int CodigoTrafegoVmdhorarioClassificado { get; set; }
        public int CodigoTrafegoVmdfonteDados { get; set; }
        public int CodigoBaseMes { get; set; }
        public int CodigoBaseHora { get; set; }
        public decimal? Quilometro { get; set; }
        public int CodigoBaseUf { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public int AnoReferencia { get; set; }
        public string CodigoSnv { get; set; }

        public virtual TblBaseHora CodigoBaseHoraNavigation { get; set; }
        public virtual TblBaseMes CodigoBaseMesNavigation { get; set; }
        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual TblTrafegoVmdfonteDados CodigoTrafegoVmdfonteDadosNavigation { get; set; }
        public virtual ICollection<TblTrafegoVmdhorarioClassificadoClasseVeiculo> TblTrafegoVmdhorarioClassificadoClasseVeiculo { get; set; }
    }
}
