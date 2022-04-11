using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoRecursoEvento
    {
        public long CodigoInfracaoRecursoEvento { get; set; }
        public long CodigoInfracaoRecurso { get; set; }
        public int CodigoInfracaoRecursoSituacao { get; set; }
        public int CodigoInfracaoRecursoFase { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblInfracaoRecursoFase CodigoInfracaoRecursoFaseNavigation { get; set; }
        public virtual TblInfracaoRecurso CodigoInfracaoRecursoNavigation { get; set; }
        public virtual TblInfracaoRecursoSituacao CodigoInfracaoRecursoSituacaoNavigation { get; set; }
    }
}
