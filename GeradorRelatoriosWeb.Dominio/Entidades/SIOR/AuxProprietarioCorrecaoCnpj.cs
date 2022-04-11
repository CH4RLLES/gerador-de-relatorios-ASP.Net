using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class AuxProprietarioCorrecaoCnpj
    {
        public long CodigoInfracao { get; set; }
        public long CodigoInfracaoSistemaOrigem { get; set; }
        public long CodigoInfracaoProprietario { get; set; }
        public string NumeroAuto { get; set; }
        public DateTime DataInfracao { get; set; }
        public string Nome { get; set; }
        public string NumeroCpfcnpj { get; set; }
        public string NumeroCpfcnpjformatado { get; set; }
        public int? CodigoRenavampossuidorTipoDocumento { get; set; }
        public string AnaliseNumeroCnpj { get; set; }
        public string AnaliseNumeroCnpjformatado { get; set; }
        public bool? AnaliseIndicadorValidade { get; set; }
        public bool? AnaliseIndicadorProcessado { get; set; }
        public string Analise2NumeroCnpj { get; set; }
        public string Analise2NumeroCnpjformatado { get; set; }
        public bool? Analise2IndicadorValidade { get; set; }
        public bool? Analise2IndicadorProcessado { get; set; }
    }
}
