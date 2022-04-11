using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBrlegalContratoTrechoSuspenso
    {
        public int CodigoBrlegalContratoTrechoSuspenso { get; set; }
        public int CodigoBrlegalContratoTrecho { get; set; }
        public int? CodigoBrlegalContratoTrechoSuspensoMotivo { get; set; }
        public decimal KmInicial { get; set; }
        public decimal KmFinal { get; set; }
        public decimal Extensao { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public string Observacao { get; set; }
        public DateTime? DataLiberacao { get; set; }
        public DateTime? NovaDataLimiteEntrega { get; set; }
        public bool IndicadorSuspensoBasico { get; set; }
        public bool IndicadorSuspensoExecutivo { get; set; }
        public bool IndicadorSuspensoImplantacao { get; set; }

        public virtual TblBrlegalContratoTrecho CodigoBrlegalContratoTrechoNavigation { get; set; }
        public virtual TblBrlegalContratoTrechoSuspensoMotivo CodigoBrlegalContratoTrechoSuspensoMotivoNavigation { get; set; }
    }
}
