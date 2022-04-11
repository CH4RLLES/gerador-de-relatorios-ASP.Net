using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBrlegalProjetoExecutivoEntrega
    {
        public TblBrlegalProjetoExecutivoEntrega()
        {
            TblBrlegalProjetoExecutivoEntregaTrecho = new HashSet<TblBrlegalProjetoExecutivoEntregaTrecho>();
            TblBrlegalProjetoExecutivoEntregaTrechoNaoAceite = new HashSet<TblBrlegalProjetoExecutivoEntregaTrechoNaoAceite>();
        }

        public int CodigoBrlegalProjetoExecutivoEntrega { get; set; }
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
        public virtual ICollection<TblBrlegalProjetoExecutivoEntregaTrecho> TblBrlegalProjetoExecutivoEntregaTrecho { get; set; }
        public virtual ICollection<TblBrlegalProjetoExecutivoEntregaTrechoNaoAceite> TblBrlegalProjetoExecutivoEntregaTrechoNaoAceite { get; set; }
    }
}
