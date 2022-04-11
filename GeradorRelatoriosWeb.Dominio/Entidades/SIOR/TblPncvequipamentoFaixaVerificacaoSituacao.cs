using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvequipamentoFaixaVerificacaoSituacao
    {
        public TblPncvequipamentoFaixaVerificacaoSituacao()
        {
            TblPncvequipamentoFaixaVerificacao = new HashSet<TblPncvequipamentoFaixaVerificacao>();
            TblPncvequipamentoFaixaVerificacaoEvento = new HashSet<TblPncvequipamentoFaixaVerificacaoEvento>();
        }

        public int CodigoPncvequipamentoFaixaVerificacaoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvequipamentoFaixaVerificacao> TblPncvequipamentoFaixaVerificacao { get; set; }
        public virtual ICollection<TblPncvequipamentoFaixaVerificacaoEvento> TblPncvequipamentoFaixaVerificacaoEvento { get; set; }
    }
}
