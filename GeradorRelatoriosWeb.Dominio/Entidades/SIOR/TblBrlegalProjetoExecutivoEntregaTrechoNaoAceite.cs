using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBrlegalProjetoExecutivoEntregaTrechoNaoAceite
    {
        public int CodigoBrlegalProjetoExecutivoEntregaTrechoNaoAceite { get; set; }
        public int CodigoBrlegalProjetoExecutivoEntrega { get; set; }
        public int CodigoSnvtrecho { get; set; }
        public decimal? KmInicial { get; set; }
        public decimal? KmFinal { get; set; }
        public decimal? Extensao { get; set; }
        public DateTime DataNaoAceite { get; set; }
        public DateTime DataCorrecaoEntrega { get; set; }
        public DateTime NovaDataLimiteAnalise { get; set; }
        public string EngenheirosFiscais { get; set; }
        public string Observacao { get; set; }
        public DateTime? DataNovaEntrega { get; set; }

        public virtual TblBrlegalProjetoExecutivoEntrega CodigoBrlegalProjetoExecutivoEntregaNavigation { get; set; }
        public virtual TblSnvtrecho CodigoSnvtrechoNavigation { get; set; }
    }
}
