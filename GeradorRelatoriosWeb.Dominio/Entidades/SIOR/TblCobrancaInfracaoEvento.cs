using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblCobrancaInfracaoEvento
    {
        public long CodigoCobrancaInfracaoEvento { get; set; }
        public long CodigoCobrancaInfracao { get; set; }
        public int CodigoCobrancaInfracaoSituacao { get; set; }
        public int CodigoCobrancaInfracaoFase { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblCobrancaInfracaoFase CodigoCobrancaInfracaoFaseNavigation { get; set; }
        public virtual TblCobrancaInfracao CodigoCobrancaInfracaoNavigation { get; set; }
        public virtual TblCobrancaInfracaoSituacao CodigoCobrancaInfracaoSituacaoNavigation { get; set; }
    }
}
