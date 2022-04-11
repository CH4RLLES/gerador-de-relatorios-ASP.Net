using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBaseHora
    {
        public TblBaseHora()
        {
            TblTrafegoVmdhorarioClassificado = new HashSet<TblTrafegoVmdhorarioClassificado>();
        }

        public int CodigoBaseHora { get; set; }
        public byte Hora { get; set; }
        public string FaixaHoraria { get; set; }

        public virtual ICollection<TblTrafegoVmdhorarioClassificado> TblTrafegoVmdhorarioClassificado { get; set; }
    }
}
