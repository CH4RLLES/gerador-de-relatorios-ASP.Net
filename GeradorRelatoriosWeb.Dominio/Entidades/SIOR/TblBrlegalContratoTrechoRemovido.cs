using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBrlegalContratoTrechoRemovido
    {
        public int CodigoBrlegalContratoTrechoRemovido { get; set; }
        public int CodigoBrlegalContratoTrecho { get; set; }
        public int? CodigoBrlegalContratoTrechoRemovidoMotivo { get; set; }
        public decimal KmInicial { get; set; }
        public decimal KmFinal { get; set; }
        public decimal Extensao { get; set; }
        public DateTime? DataOcorrencia { get; set; }
        public bool IndicadorRemovidoBasico { get; set; }
        public bool IndicadorRemovidoExecutivo { get; set; }
        public bool IndicadorRemovidoImplantacao { get; set; }
        public string Observacao { get; set; }

        public virtual TblBrlegalContratoTrecho CodigoBrlegalContratoTrechoNavigation { get; set; }
        public virtual TblBrlegalContratoTrechoRemovidoMotivo CodigoBrlegalContratoTrechoRemovidoMotivoNavigation { get; set; }
    }
}
