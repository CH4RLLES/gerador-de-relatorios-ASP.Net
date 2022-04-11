using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvequipamentoFaixaParalisacaoSituacao
    {
        public TblPncvequipamentoFaixaParalisacaoSituacao()
        {
            TblPncvequipamentoFaixaParalisacao = new HashSet<TblPncvequipamentoFaixaParalisacao>();
            TblPncvequipamentoFaixaParalisacaoEvento = new HashSet<TblPncvequipamentoFaixaParalisacaoEvento>();
        }

        public int CodigoPncvequipamentoFaixaParalisacaoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvequipamentoFaixaParalisacao> TblPncvequipamentoFaixaParalisacao { get; set; }
        public virtual ICollection<TblPncvequipamentoFaixaParalisacaoEvento> TblPncvequipamentoFaixaParalisacaoEvento { get; set; }
    }
}
