using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoDaevento
    {
        public long CodigoInfracaoDaevento { get; set; }
        public long CodigoInfracaoDa { get; set; }
        public int CodigoInfracaoDasituacao { get; set; }
        public int CodigoInfracaoDafase { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblInfracaoDa CodigoInfracaoDaNavigation { get; set; }
        public virtual TblInfracaoDafase CodigoInfracaoDafaseNavigation { get; set; }
        public virtual TblInfracaoDasituacao CodigoInfracaoDasituacaoNavigation { get; set; }
    }
}
