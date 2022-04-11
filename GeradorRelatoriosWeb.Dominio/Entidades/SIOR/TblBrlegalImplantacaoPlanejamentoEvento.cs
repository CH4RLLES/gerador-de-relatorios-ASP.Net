using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBrlegalImplantacaoPlanejamentoEvento
    {
        public int CodigoBrlegalImplantacaoPlanejamentoEvento { get; set; }
        public int CodigoBrlegalImplantacaoPlanejamento { get; set; }
        public int CodigoBrlegalImplantacaoPlanejamentoSituacao { get; set; }
        public string Descricao { get; set; }
        public DateTime DataEvento { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblBrlegalImplantacaoPlanejamento CodigoBrlegalImplantacaoPlanejamentoNavigation { get; set; }
        public virtual TblBrlegalImplantacaoPlanejamentoSituacao CodigoBrlegalImplantacaoPlanejamentoSituacaoNavigation { get; set; }
    }
}
