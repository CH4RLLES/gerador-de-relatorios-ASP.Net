using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class AuxExpedicaoCorrecaoDataVencimentoControle1
    {
        public long? ExpedicaoCodigoProcesso { get; set; }
        public int? ExpedicaoNotificacaoCodigoTipo { get; set; }
        public string ExpedicaoNumeroRemessa { get; set; }
        public DateTime? ExpedicaoDataVencimentoAtual { get; set; }
        public DateTime? ExpedicaoDataVencimentoConsiderada { get; set; }
        public bool? ProcessamentoExpedicaoIndicadorCorrecao { get; set; }
        public bool? ProcessamentoExpedicaoIndicadorAtualizado { get; set; }
        public bool? ProcessamentoNotificacaoIndicadorAtualizado { get; set; }
        public bool? ProcessamentoControle2IndicadorInsercao { get; set; }
    }
}
