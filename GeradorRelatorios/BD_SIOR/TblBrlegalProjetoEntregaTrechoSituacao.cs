using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBrlegalProjetoEntregaTrechoSituacao
    {
        public TblBrlegalProjetoEntregaTrechoSituacao()
        {
            TblBrlegalProjetoBasicoEntregaTrecho = new HashSet<TblBrlegalProjetoBasicoEntregaTrecho>();
            TblBrlegalProjetoExecutivoEntregaTrecho = new HashSet<TblBrlegalProjetoExecutivoEntregaTrecho>();
        }

        public int CodigoBrlegalProjetoEntregaTrechoSituacao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TblBrlegalProjetoBasicoEntregaTrecho> TblBrlegalProjetoBasicoEntregaTrecho { get; set; }
        public virtual ICollection<TblBrlegalProjetoExecutivoEntregaTrecho> TblBrlegalProjetoExecutivoEntregaTrecho { get; set; }
    }
}
