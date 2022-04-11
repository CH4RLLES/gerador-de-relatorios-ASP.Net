using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class AuxExpedicaoCorrecaoDataVencimentoControle2DataAtualDebito
    {
        public long NotificacaoCodigoProcesso { get; set; }
        public long NotificacaoCodigoExpedicao { get; set; }
        public int NotificacaoCodigoTipo { get; set; }
        public DateTime NotificacaoDataVencimentoExpedicaoCorrigido { get; set; }
        public DateTime? NotificacaoDataVencimentoEdital { get; set; }
        public DateTime NotificacaoDataVencimentoAtualAtual { get; set; }
        public DateTime? NotificacaoDataVencimentoAtualRecalculado { get; set; }
        public long InfracaoCodigoProcesso { get; set; }
        public int? InfracaoCodigoSituacao { get; set; }
        public bool InfracaoIndicadorReconhecidoCometimento { get; set; }
        public int? DebitoCodigoSituacaoAtual { get; set; }
        public decimal? DebitoValorOriginal { get; set; }
        public decimal? DebitoValorOriginal80Porcento { get; set; }
        public decimal? DebitoValorOriginal60Porcento { get; set; }
        public decimal? DebitoValorPagoTotal { get; set; }
        public decimal? DebitoValorPagoAteVencimentoNp { get; set; }
        public bool? ProcessamentoDataVencimentoAtualIndicadorInconsistencia { get; set; }
        public bool? ProcessamentoDataVencimentoAtualIndicadorCorrecao { get; set; }
        public bool? ProcessamentoDataVencimentoAtualIndicadorAtualizado { get; set; }
        public bool? ProcessamentoDebitoSituacaoIndicadorAnalise { get; set; }
        public bool? ProcessamentoDebitoSituacaoIndicadorQuitacao { get; set; }
        public bool? ProcessamentoDebitoDataVencimentoNpIndicadorAtualizado { get; set; }
        public bool? ProcessamentoDebitoSituacaoIndicadorAtualizado { get; set; }
    }
}
