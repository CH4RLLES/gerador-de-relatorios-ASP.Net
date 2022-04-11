using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBrlegalContratoTrechoContratado
    {
        public int CodigoBrlegalContratoTrechoContratado { get; set; }
        public int CodigoBrlegalContrato { get; set; }
        public int CodigoSnvtrecho { get; set; }
        public decimal KmInicial { get; set; }
        public decimal KmFinal { get; set; }
        public decimal Extensao { get; set; }
        public string Observacao { get; set; }
        public bool IndicadorTrechoAlterado { get; set; }
        public bool? Mp082 { get; set; }
        public int? AnoSnv { get; set; }

        public virtual TblBrlegalContrato CodigoBrlegalContratoNavigation { get; set; }
        public virtual TblSnvtrecho CodigoSnvtrechoNavigation { get; set; }
    }
}
