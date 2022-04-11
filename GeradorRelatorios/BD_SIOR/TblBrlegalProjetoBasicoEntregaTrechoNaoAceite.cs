using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBrlegalProjetoBasicoEntregaTrechoNaoAceite
    {
        public int CodigoBrlegalProjetoBasicoEntregaTrechoNaoAceite { get; set; }
        public int CodigoBrlegalProjetoBasicoEntrega { get; set; }
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

        public virtual TblBrlegalProjetoBasicoEntrega CodigoBrlegalProjetoBasicoEntregaNavigation { get; set; }
        public virtual TblSnvtrecho CodigoSnvtrechoNavigation { get; set; }
    }
}
