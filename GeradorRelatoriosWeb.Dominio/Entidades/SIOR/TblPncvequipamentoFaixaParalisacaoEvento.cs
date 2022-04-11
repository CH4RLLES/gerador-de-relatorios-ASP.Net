using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvequipamentoFaixaParalisacaoEvento
    {
        public long CodigoPncvequipamentoFaixaParalisacaoEvento { get; set; }
        public int CodigoPncvequipamentoFaixaParalisacao { get; set; }
        public int CodigoPncvequipamentoFaixaParalisacaoSituacao { get; set; }
        public DateTime Data { get; set; }
        public string NomeSistemaUsuario { get; set; }
        public string Descricao { get; set; }

        public virtual TblPncvequipamentoFaixaParalisacao CodigoPncvequipamentoFaixaParalisacaoNavigation { get; set; }
        public virtual TblPncvequipamentoFaixaParalisacaoSituacao CodigoPncvequipamentoFaixaParalisacaoSituacaoNavigation { get; set; }
    }
}
