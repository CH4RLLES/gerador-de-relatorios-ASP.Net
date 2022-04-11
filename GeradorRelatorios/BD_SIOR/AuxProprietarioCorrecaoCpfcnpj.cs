using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class AuxProprietarioCorrecaoCpfcnpj
    {
        public long CodigoInfracao { get; set; }
        public long CodigoInfracaoProprietario { get; set; }
        public string NumeroAuto { get; set; }
        public DateTime DataInfracao { get; set; }
        public string Nome { get; set; }
        public string NumeroCpfcnpj { get; set; }
        public string NumeroCpfcnpjformatado { get; set; }
        public int? CodigoRenavampossuidorTipoDocumento { get; set; }
        public string Analise1NumeroCpf { get; set; }
        public string Analise1NumeroCpfformatado { get; set; }
        public bool? Analise1IndicadorValidade { get; set; }
        public bool? Analise1IndicadorProcessado { get; set; }
        public string Analise2NumeroCpfcnpj { get; set; }
        public string Analise2NumeroCpfcnpjformatado { get; set; }
        public int? Analise2CodigoRenavampossuidorTipoDocumento { get; set; }
        public bool? Analise2IndicadorProcessado { get; set; }
        public string Analise3NumeroCnpj { get; set; }
        public string Analise3NumeroCnpjformatado { get; set; }
        public bool? Analise3IndicadorValidade { get; set; }
        public bool? Analise3IndicadorProcessado { get; set; }
    }
}
