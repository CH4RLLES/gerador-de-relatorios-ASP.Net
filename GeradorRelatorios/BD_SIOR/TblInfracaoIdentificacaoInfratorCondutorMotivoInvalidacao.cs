using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoIdentificacaoInfratorCondutorMotivoInvalidacao
    {
        public TblInfracaoIdentificacaoInfratorCondutorMotivoInvalidacao()
        {
            TblInfracaoIdentificacaoInfratorCondutor = new HashSet<TblInfracaoIdentificacaoInfratorCondutor>();
        }

        public int CodigoInfracaoIdentificacaoInfratorCondutorMotivoInvalidacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoIdentificacaoInfratorCondutor> TblInfracaoIdentificacaoInfratorCondutor { get; set; }
    }
}
