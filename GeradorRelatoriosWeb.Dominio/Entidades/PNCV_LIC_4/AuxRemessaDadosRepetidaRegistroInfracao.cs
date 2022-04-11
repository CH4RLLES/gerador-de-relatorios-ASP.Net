using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_LIC_4
{
    public partial class AuxRemessaDadosRepetidaRegistroInfracao
    {
        public long CodigoRegistroInfracao { get; set; }
        public long CodigoRemessaDados { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public DateTime DataHora { get; set; }
        public short ValorMedido { get; set; }
        public string ImagemCometimentoNome { get; set; }
        public string ImagemCometimentoSequencia { get; set; }
        public long? CodigoInfracaoPreAutuacao { get; set; }
        public int? CodigoInfracaoPreAutuacaoSituacao { get; set; }
        public int? CodigoInfracaoPreAutuacaoFase { get; set; }
        public long? CodigoInfracao { get; set; }
        public string NumeroAutoInfracao { get; set; }
        public int? CodigoInfracaoSituacao { get; set; }
        public int? CodigoInfracaoFase { get; set; }
        public string ImagemCometimentoNomeFisico { get; set; }
        public bool? IndicadorImagemExcluida { get; set; }
    }
}
