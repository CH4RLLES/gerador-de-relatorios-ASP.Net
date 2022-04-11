using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoDesvinculacaoMultaEvento
    {
        public long CodigoInfracaoDesvinculacaoMultaEvento { get; set; }
        public long CodigoInfracaoDesvinculacaoMulta { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }
        public int CodigoInfracaoDesvinculacaoMultaSituacao { get; set; }

        public virtual TblInfracaoDesvinculacaoMulta CodigoInfracaoDesvinculacaoMultaNavigation { get; set; }
        public virtual TblInfracaoDesvinculacaoMultaSituacao CodigoInfracaoDesvinculacaoMultaSituacaoNavigation { get; set; }
    }
}
