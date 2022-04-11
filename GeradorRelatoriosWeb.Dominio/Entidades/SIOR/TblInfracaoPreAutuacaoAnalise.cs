using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoPreAutuacaoAnalise
    {
        public long CodigoInfracaoPreAutuacaoAnalise { get; set; }
        public long CodigoInfracaoPreAutuacao { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public int? CodigoSistemaUsuario { get; set; }
        public DateTime DataHoraInfracao { get; set; }
        public DateTime? DataEmAnalise { get; set; }
        public decimal? MedicaoRealizada { get; set; }

        public virtual TblInfracaoEnquadramento CodigoInfracaoEnquadramentoNavigation { get; set; }
        public virtual TblInfracaoPreAutuacao CodigoInfracaoPreAutuacaoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioNavigation { get; set; }
    }
}
