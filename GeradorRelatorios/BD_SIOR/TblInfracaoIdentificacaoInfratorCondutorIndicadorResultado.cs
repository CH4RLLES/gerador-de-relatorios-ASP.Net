using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoIdentificacaoInfratorCondutorIndicadorResultado
    {
        public TblInfracaoIdentificacaoInfratorCondutorIndicadorResultado()
        {
            TblInfracaoIdentificacaoInfratorCondutor = new HashSet<TblInfracaoIdentificacaoInfratorCondutor>();
        }

        public int CodigoInfracaoIdentificacaoInfratorCondutorIndicadorResultado { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoIdentificacaoInfratorCondutor> TblInfracaoIdentificacaoInfratorCondutor { get; set; }
    }
}
