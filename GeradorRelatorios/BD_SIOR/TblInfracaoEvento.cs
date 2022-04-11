using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoEvento
    {
        public long CodigoInfracaoEvento { get; set; }
        public long CodigoInfracao { get; set; }
        public int CodigoInfracaoSituacao { get; set; }
        public int CodigoInfracaoFase { get; set; }
        public long? CodigoIcompoolEnvioTransacao { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblInfracaoFase CodigoInfracaoFaseNavigation { get; set; }
        public virtual TblInfracao CodigoInfracaoNavigation { get; set; }
        public virtual TblInfracaoSituacao CodigoInfracaoSituacaoNavigation { get; set; }
    }
}
