using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBrlegalProjetoBasicoEntrega
    {
        public TblBrlegalProjetoBasicoEntrega()
        {
            TblBrlegalProjetoBasicoEntregaTrecho = new HashSet<TblBrlegalProjetoBasicoEntregaTrecho>();
            TblBrlegalProjetoBasicoEntregaTrechoNaoAceite = new HashSet<TblBrlegalProjetoBasicoEntregaTrechoNaoAceite>();
        }

        public int CodigoBrlegalProjetoBasicoEntrega { get; set; }
        public int CodigoBrlegalContrato { get; set; }
        public int CodigoBaseUf { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public int NumeroEntrega { get; set; }
        public DateTime? DataEntregaProjetoSede { get; set; }
        public DateTime? DataLimiteAnalise { get; set; }
        public decimal? Extensao { get; set; }

        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual TblBrlegalContrato CodigoBrlegalContratoNavigation { get; set; }
        public virtual ICollection<TblBrlegalProjetoBasicoEntregaTrecho> TblBrlegalProjetoBasicoEntregaTrecho { get; set; }
        public virtual ICollection<TblBrlegalProjetoBasicoEntregaTrechoNaoAceite> TblBrlegalProjetoBasicoEntregaTrechoNaoAceite { get; set; }
    }
}
