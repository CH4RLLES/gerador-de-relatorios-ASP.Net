using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoIdentificacaoInfratorCondutorEvento
    {
        public long CodigoInfracaoIdentificacaoInfratorCondutorEvento { get; set; }
        public long CodigoInfracaoIdentificacaoInfratorCondutor { get; set; }
        public int CodigoInfracaoIdentificacaoInfratorCondutorSituacao { get; set; }
        public int CodigoInfracaoIdentificacaoInfratorCondutorFase { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblInfracaoIdentificacaoInfratorCondutorFase CodigoInfracaoIdentificacaoInfratorCondutorFaseNavigation { get; set; }
        public virtual TblInfracaoIdentificacaoInfratorCondutor CodigoInfracaoIdentificacaoInfratorCondutorNavigation { get; set; }
        public virtual TblInfracaoIdentificacaoInfratorCondutorSituacao CodigoInfracaoIdentificacaoInfratorCondutorSituacaoNavigation { get; set; }
    }
}
