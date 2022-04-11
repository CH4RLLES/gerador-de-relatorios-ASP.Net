using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoPreAutuacaoConferenciaSimplesPncv
    {
        public long CodigoInfracaoPreAutuacaoConferenciaSimplesPncv { get; set; }
        public long CodigoInfracaoPreAutuacao { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public int CodigoPncveditalLote { get; set; }
        public DateTime DataHoraInfracao { get; set; }
        public string PlacaVeiculo { get; set; }
        public string ImagemPrincipalArquivoNomeFisico { get; set; }
        public DateTime? DataEmProcessamento { get; set; }
        public decimal? MedicaoRealizada { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual TblInfracaoEnquadramento CodigoInfracaoEnquadramentoNavigation { get; set; }
        public virtual TblInfracaoPreAutuacao CodigoInfracaoPreAutuacaoNavigation { get; set; }
        public virtual TblPncveditalLote CodigoPncveditalLoteNavigation { get; set; }
    }
}
