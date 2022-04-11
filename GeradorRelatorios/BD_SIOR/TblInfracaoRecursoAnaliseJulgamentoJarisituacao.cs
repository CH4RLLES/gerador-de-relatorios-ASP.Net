using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoRecursoAnaliseJulgamentoJarisituacao
    {
        public TblInfracaoRecursoAnaliseJulgamentoJarisituacao()
        {
            TblInfracaoRecursoAnaliseJulgamentoJari = new HashSet<TblInfracaoRecursoAnaliseJulgamentoJari>();
            TblInfracaoRecursoAnaliseJulgamentoJarievento = new HashSet<TblInfracaoRecursoAnaliseJulgamentoJarievento>();
        }

        public int CodigoInfracaoRecursoAnaliseJulgamentoJarisituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoRecursoAnaliseJulgamentoJari> TblInfracaoRecursoAnaliseJulgamentoJari { get; set; }
        public virtual ICollection<TblInfracaoRecursoAnaliseJulgamentoJarievento> TblInfracaoRecursoAnaliseJulgamentoJarievento { get; set; }
    }
}
