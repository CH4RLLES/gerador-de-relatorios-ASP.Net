using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvequipamentoFaixaVerificacaoEvento
    {
        public long CodigoPncvequipamentoFaixaVerificacaoEvento { get; set; }
        public int CodigoPncvequipamentoFaixaVerificacao { get; set; }
        public int CodigoPncvequipamentoFaixaVerificacaoSituacao { get; set; }
        public DateTime Data { get; set; }
        public string NomeSistemaUsuario { get; set; }
        public string Descricao { get; set; }

        public virtual TblPncvequipamentoFaixaVerificacao CodigoPncvequipamentoFaixaVerificacaoNavigation { get; set; }
        public virtual TblPncvequipamentoFaixaVerificacaoSituacao CodigoPncvequipamentoFaixaVerificacaoSituacaoNavigation { get; set; }
    }
}
