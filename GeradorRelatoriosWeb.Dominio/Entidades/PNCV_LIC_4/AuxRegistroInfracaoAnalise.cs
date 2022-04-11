using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_LIC_4
{
    public partial class AuxRegistroInfracaoAnalise
    {
        public long CodigoRegistroInfracao { get; set; }
        public long CodigoRemessaDados { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public DateTime DataHora { get; set; }
        public byte Hora { get; set; }
        public short ValorMedido { get; set; }
        public int? CodigoInfracaoGravidade { get; set; }
        public int? CodigoInfracaoIndicadorResponsavel { get; set; }
        public int? CodigoRenavamunidadeMedida { get; set; }
        public decimal? LimiteRegulamentado { get; set; }
        public decimal? ValorConsiderado { get; set; }
        public byte? PontosCnh { get; set; }
        public decimal? ValorOriginal { get; set; }
        public decimal? ValorOriginal80Porcento { get; set; }
        public decimal? ValorOriginal60Porcento { get; set; }
        public int? CodigoRegistroInfracaoVeiculoTipo { get; set; }
        public int? ImagemCometimentoSequencia { get; set; }
        public string ImagemCometimentoNomeCalculado { get; set; }
        public string ImagemCometimentoNome { get; set; }
        public int? AnaliseComImagemIndicadorSequenciaRegistro { get; set; }
        public bool? AnaliseComImagemIndicadorDuplicado { get; set; }
        public bool? AnaliseSemImagemIndicadorSequenciaRegistro { get; set; }
        public bool? AnaliseSemImagemIndicadorDuplicado { get; set; }
        public string InsertImagemCometimentoNome { get; set; }
        public int? InsertImagemCometimentoSequencia { get; set; }
        public string InsertImagemCometimentoNomeFisico { get; set; }
        public int? InsertImagemCometimentoTamanho { get; set; }
    }
}
