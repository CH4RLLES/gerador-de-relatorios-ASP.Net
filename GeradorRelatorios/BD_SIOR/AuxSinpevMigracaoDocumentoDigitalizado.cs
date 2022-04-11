using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class AuxSinpevMigracaoDocumentoDigitalizado
    {
        public long NupDocumento { get; set; }
        public string NumeroAuto { get; set; }
        public string TipoProcesso { get; set; }
        public int? NumeroRemessa { get; set; }
        public long? CodigoInfracao { get; set; }
        public long? CodigoProcesso { get; set; }
        public int ProcessamentoPesquisaInfracao { get; set; }
        public int ProcessamentoPesquisaProcesso { get; set; }
        public int ProcessamentoArquivo { get; set; }
        public bool? ArquivoNaoEncontrado { get; set; }
        public string Observacao { get; set; }
    }
}
