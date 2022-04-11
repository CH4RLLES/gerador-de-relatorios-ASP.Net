using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBrlegalImplantacaoPlanejamentoSituacao
    {
        public TblBrlegalImplantacaoPlanejamentoSituacao()
        {
            TblBrlegalImplantacaoPlanejamento = new HashSet<TblBrlegalImplantacaoPlanejamento>();
            TblBrlegalImplantacaoPlanejamentoEvento = new HashSet<TblBrlegalImplantacaoPlanejamentoEvento>();
        }

        public int CodigoBrlegalImplantacaoPlanejamentoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblBrlegalImplantacaoPlanejamento> TblBrlegalImplantacaoPlanejamento { get; set; }
        public virtual ICollection<TblBrlegalImplantacaoPlanejamentoEvento> TblBrlegalImplantacaoPlanejamentoEvento { get; set; }
    }
}
