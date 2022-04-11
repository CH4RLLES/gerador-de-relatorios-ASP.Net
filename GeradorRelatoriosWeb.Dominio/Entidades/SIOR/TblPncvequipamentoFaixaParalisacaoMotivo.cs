using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvequipamentoFaixaParalisacaoMotivo
    {
        public TblPncvequipamentoFaixaParalisacaoMotivo()
        {
            TblPncvequipamentoFaixaParalisacao = new HashSet<TblPncvequipamentoFaixaParalisacao>();
        }

        public int CodigoPncvequipamentoFaixaParalisacaoMotivo { get; set; }
        public string Nome { get; set; }
        public bool? DocumentoRequerido { get; set; }

        public virtual ICollection<TblPncvequipamentoFaixaParalisacao> TblPncvequipamentoFaixaParalisacao { get; set; }
    }
}
