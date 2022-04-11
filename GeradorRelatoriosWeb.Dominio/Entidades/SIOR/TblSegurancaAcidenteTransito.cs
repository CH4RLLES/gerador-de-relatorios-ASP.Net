using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSegurancaAcidenteTransito
    {
        public long CodigoSegurancaAcidenteTransito { get; set; }
        public int CodigoBaseUf { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public int CodigoSegurancaAcidenteTransitoSentido { get; set; }
        public int CodigoSegurancaAcidenteTransitoGravidade { get; set; }
        public int CodigoSegurancaAcidenteTransitoTipo { get; set; }
        public int CodigoSegurancaAcidenteTransitoUsoSolo { get; set; }
        public decimal Quilometro { get; set; }
        public DateTime Data { get; set; }
        public int? NumeroFeridos { get; set; }
        public int? NumeroMortos { get; set; }
        public string Snvtrecho { get; set; }
        public int? CodigoSegurancaAcidenteTransitoCausa { get; set; }

        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual TblSegurancaAcidenteTransitoCausa CodigoSegurancaAcidenteTransitoCausaNavigation { get; set; }
        public virtual TblSegurancaAcidenteTransitoGravidade CodigoSegurancaAcidenteTransitoGravidadeNavigation { get; set; }
        public virtual TblSegurancaAcidenteTransitoSentido CodigoSegurancaAcidenteTransitoSentidoNavigation { get; set; }
        public virtual TblSegurancaAcidenteTransitoTipo CodigoSegurancaAcidenteTransitoTipoNavigation { get; set; }
        public virtual TblSegurancaAcidenteTransitoUsoSolo CodigoSegurancaAcidenteTransitoUsoSoloNavigation { get; set; }
    }
}
