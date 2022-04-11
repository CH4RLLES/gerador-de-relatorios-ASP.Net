using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class AuxInfracaoPreAutuacaoUpdateRegistroInfracao
    {
        public long CodigoInfracaoPreAutuacao { get; set; }
        public DateTime? DataHoraInfracao { get; set; }
        public string ImagemPrincipalArquivoNome { get; set; }
        public int? CodigoInfracaoGravidade { get; set; }
        public int? CodigoInfracaoIndicadorResponsavel { get; set; }
        public int? CodigoRenavamunidadeMedida { get; set; }
        public decimal? LimiteRegulamentado { get; set; }
        public decimal? ValorConsiderado { get; set; }
        public byte? PontosCnh { get; set; }
        public decimal? ValorOriginal { get; set; }
        public decimal? ValorOriginal80Porcento { get; set; }
        public decimal? ValorOriginal60Porcento { get; set; }
        public int? CodigoInfracaoVeiculoTipo { get; set; }
    }
}
