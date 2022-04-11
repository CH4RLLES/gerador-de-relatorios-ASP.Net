using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoProtocoloAutomatico
    {
        public long CodigoInfracaoProtocoloAutomatico { get; set; }
        public string NomeArquivo { get; set; }
        public int? TamanhoArquivo { get; set; }
        public DateTime DataCriacaoArquivo { get; set; }
        public string NumeroAuto { get; set; }
        public string PlacaVeiculo { get; set; }
        public string TipoProcesso { get; set; }
        public string OrigemProcesso { get; set; }
        public DateTime? DataProtocolo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataProcessamento { get; set; }
        public bool IndicadorPreValidado { get; set; }
        public bool IndicadorProcessado { get; set; }
        public bool? IndicadorFalha { get; set; }
        public string SufixoErroRetorno { get; set; }
    }
}
