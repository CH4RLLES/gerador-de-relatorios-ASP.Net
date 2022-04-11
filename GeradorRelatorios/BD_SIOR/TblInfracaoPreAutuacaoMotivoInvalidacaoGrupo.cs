using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoPreAutuacaoMotivoInvalidacaoGrupo
    {
        public TblInfracaoPreAutuacaoMotivoInvalidacaoGrupo()
        {
            TblInfracaoPreAutuacaoMotivoInvalidacao = new HashSet<TblInfracaoPreAutuacaoMotivoInvalidacao>();
        }

        public int CodigoInfracaoPreAutuacaoMotivoInvalidacaoGrupo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoPreAutuacaoMotivoInvalidacao> TblInfracaoPreAutuacaoMotivoInvalidacao { get; set; }
    }
}
