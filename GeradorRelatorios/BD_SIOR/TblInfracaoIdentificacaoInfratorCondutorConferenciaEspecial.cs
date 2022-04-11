using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoIdentificacaoInfratorCondutorConferenciaEspecial
    {
        public TblInfracaoIdentificacaoInfratorCondutorConferenciaEspecial()
        {
            TblInfracaoIdentificacaoInfratorCondutor = new HashSet<TblInfracaoIdentificacaoInfratorCondutor>();
        }

        public int CodigoInfracaoIdentificacaoInfratorCondutorConferenciaEspecial { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoIdentificacaoInfratorCondutor> TblInfracaoIdentificacaoInfratorCondutor { get; set; }
    }
}
