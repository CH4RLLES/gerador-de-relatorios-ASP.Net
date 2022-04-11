using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class AuxUpdatePreAutuacaoRegistroInfracao
    {
        public long CodigoInfracaoPreAutuacao { get; set; }
        public int CodigoPncveditalLote { get; set; }
        public long CodigoInfracaoSistemaOrigem { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataHoraInfracao { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public int CodigoInfracaoGravidade { get; set; }
        public int CodigoInfracaoIndicadorResponsavel { get; set; }
        public int CodigoRenavamunidadeMedida { get; set; }
        public decimal MedicaoRealizada { get; set; }
        public decimal LimiteRegulamentado { get; set; }
        public decimal ValorConsiderado { get; set; }
        public byte PontosCnh { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal ValorOriginal80Porcento { get; set; }
        public decimal ValorOriginal60Porcento { get; set; }
        public string EquipamentoAfericaoCodigoDnit { get; set; }
        public string LocalInfracaoRodoviaFaixa { get; set; }
        public int ImagemPrincipalSequencia { get; set; }
        public string ImagemPrincipalArquivoNome { get; set; }
        public string ImagemPrincipalArquivoNomeCalculado { get; set; }
        public int? CodigoInfracaoVeiculoTipo { get; set; }
        public long? CodigoInfracaoOrigemContratacao { get; set; }
        public long? CodigoInfracaoOrigemContrato { get; set; }
        public long? CodigoInfracaoOrigemRemessaDados { get; set; }
        public long? CodigoInfracaoOrigemRegistro { get; set; }
        public DateTime? RemessaDataProcessamento { get; set; }
    }
}
