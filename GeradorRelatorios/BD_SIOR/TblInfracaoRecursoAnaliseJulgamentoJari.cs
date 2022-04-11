using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoRecursoAnaliseJulgamentoJari
    {
        public TblInfracaoRecursoAnaliseJulgamentoJari()
        {
            TblInfracaoRecursoAnaliseJulgamentoJarievento = new HashSet<TblInfracaoRecursoAnaliseJulgamentoJarievento>();
        }

        public long CodigoInfracaoRecursoAnaliseJulgamentoJari { get; set; }
        public byte[] RowVersion { get; set; }
        public long CodigoInfracaoRecurso { get; set; }
        public int CodigoInfracaoRecursoAnaliseJulgamentoJarisituacao { get; set; }
        public int? CodigoSistemaUsuarioEmAnalise { get; set; }
        public bool? IndicadorAcompanharDecisaoJari { get; set; }
        public DateTime? DataAnalise { get; set; }
        public string NomeSistemaUsuarioAnalise { get; set; }

        public virtual TblInfracaoRecursoAnaliseJulgamentoJarisituacao CodigoInfracaoRecursoAnaliseJulgamentoJarisituacaoNavigation { get; set; }
        public virtual TblInfracaoRecurso CodigoInfracaoRecursoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioEmAnaliseNavigation { get; set; }
        public virtual ICollection<TblInfracaoRecursoAnaliseJulgamentoJarievento> TblInfracaoRecursoAnaliseJulgamentoJarievento { get; set; }
    }
}
