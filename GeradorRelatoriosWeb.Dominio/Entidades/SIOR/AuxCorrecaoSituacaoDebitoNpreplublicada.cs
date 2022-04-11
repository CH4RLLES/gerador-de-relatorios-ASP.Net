using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class AuxCorrecaoSituacaoDebitoNpreplublicada
    {
        public long InfracaoCodigoProcesso { get; set; }
        public int InfracaoCodigoSituacao { get; set; }
        public bool InfracaoIndicadorReconhecidoCometimento { get; set; }
        public int? DebitoCodigoSituacaoAtual { get; set; }
        public decimal? DebitoValorOriginal { get; set; }
        public decimal? DebitoValorOriginal80Porcento { get; set; }
        public decimal? DebitoValorOriginal60Porcento { get; set; }
        public decimal? DebitoValorPagoTotal { get; set; }
        public decimal? DebitoValorPagoAteVencimentoNp { get; set; }
        public bool? ProcessamentoDebitoSituacaoIndicadorQuitacao { get; set; }
        public bool? ProcessamentoDebitoSituacaoIndicadorAtualizado { get; set; }
    }
}
