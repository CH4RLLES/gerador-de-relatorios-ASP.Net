using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvequipamentoFaixa
    {
        public TblPncvequipamentoFaixa()
        {
            TblPncvequipamentoEstudoTecnicoFaixa = new HashSet<TblPncvequipamentoEstudoTecnicoFaixa>();
            TblPncvequipamentoFaixaParalisacao = new HashSet<TblPncvequipamentoFaixaParalisacao>();
            TblPncvequipamentoFaixaVerificacao = new HashSet<TblPncvequipamentoFaixaVerificacao>();
        }

        public int CodigoPncvequipamentoFaixa { get; set; }
        public int CodigoPncvequipamento { get; set; }
        public byte CodigoPncvsentidoRodovia { get; set; }
        public byte CodigoPncvtipoVia { get; set; }
        public int CodigoPncvequipamentoFaixaSituacao { get; set; }
        public byte Numero { get; set; }
        public DateTime? DataInicioOperacao { get; set; }
        public DateTime? DataCancelamento { get; set; }

        public virtual TblPncvequipamentoFaixaSituacao CodigoPncvequipamentoFaixaSituacaoNavigation { get; set; }
        public virtual TblPncvequipamento CodigoPncvequipamentoNavigation { get; set; }
        public virtual TblPncvsentidoRodovia CodigoPncvsentidoRodoviaNavigation { get; set; }
        public virtual TblPncvtipoVia CodigoPncvtipoViaNavigation { get; set; }
        public virtual ICollection<TblPncvequipamentoEstudoTecnicoFaixa> TblPncvequipamentoEstudoTecnicoFaixa { get; set; }
        public virtual ICollection<TblPncvequipamentoFaixaParalisacao> TblPncvequipamentoFaixaParalisacao { get; set; }
        public virtual ICollection<TblPncvequipamentoFaixaVerificacao> TblPncvequipamentoFaixaVerificacao { get; set; }
    }
}
