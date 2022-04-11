using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBaseNup
    {
        public long CodigoBaseNup { get; set; }
        public string Nup { get; set; }
        public string Nupformatado { get; set; }
        public decimal NupvalorNumerico { get; set; }
        public decimal UnidadeProtocolizadora5D { get; set; }
        public decimal SequencialProcesso6D { get; set; }
        public decimal AnoFormacao4D { get; set; }
        public decimal DigitoVerificador2D { get; set; }
        public string IdentificacaoDocumentoOriginal { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IndicadorFaixaFinalAno { get; set; }
    }
}
