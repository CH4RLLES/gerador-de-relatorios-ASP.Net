using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblJarisessaoJulgamento
    {
        public TblJarisessaoJulgamento()
        {
            TblInfracaoRecurso = new HashSet<TblInfracaoRecurso>();
            TblJarisessaoJulgamentoArquivo = new HashSet<TblJarisessaoJulgamentoArquivo>();
            TblJarisessaoJulgamentoColegiado = new HashSet<TblJarisessaoJulgamentoColegiado>();
            TblJarisessaoJulgamentoEvento = new HashSet<TblJarisessaoJulgamentoEvento>();
            TblJarisessaoJulgamentoPauta = new HashSet<TblJarisessaoJulgamentoPauta>();
            TblJarisessaoJulgamentoVoto = new HashSet<TblJarisessaoJulgamentoVoto>();
        }

        public long CodigoJarisessaoJulgamento { get; set; }
        public byte[] RowVersion { get; set; }
        public int CodigoJarisessaoJulgamentoSituacao { get; set; }
        public int CodigoInfracaoRecursoTipo { get; set; }
        public int? CodigoJari { get; set; }
        public string NumeroSessaoJulgamento { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int TotalRecursosPauta { get; set; }

        public virtual TblInfracaoRecursoTipo CodigoInfracaoRecursoTipoNavigation { get; set; }
        public virtual TblJari CodigoJariNavigation { get; set; }
        public virtual TblJarisessaoJulgamentoSituacao CodigoJarisessaoJulgamentoSituacaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecurso { get; set; }
        public virtual ICollection<TblJarisessaoJulgamentoArquivo> TblJarisessaoJulgamentoArquivo { get; set; }
        public virtual ICollection<TblJarisessaoJulgamentoColegiado> TblJarisessaoJulgamentoColegiado { get; set; }
        public virtual ICollection<TblJarisessaoJulgamentoEvento> TblJarisessaoJulgamentoEvento { get; set; }
        public virtual ICollection<TblJarisessaoJulgamentoPauta> TblJarisessaoJulgamentoPauta { get; set; }
        public virtual ICollection<TblJarisessaoJulgamentoVoto> TblJarisessaoJulgamentoVoto { get; set; }
    }
}
