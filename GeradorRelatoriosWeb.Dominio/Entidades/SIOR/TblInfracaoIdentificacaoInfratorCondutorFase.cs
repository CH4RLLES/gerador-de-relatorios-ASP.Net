using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoIdentificacaoInfratorCondutorFase
    {
        public TblInfracaoIdentificacaoInfratorCondutorFase()
        {
            TblInfracaoIdentificacaoInfratorCondutor = new HashSet<TblInfracaoIdentificacaoInfratorCondutor>();
            TblInfracaoIdentificacaoInfratorCondutorEvento = new HashSet<TblInfracaoIdentificacaoInfratorCondutorEvento>();
        }

        public int CodigoInfracaoIdentificacaoInfratorCondutorFase { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoIdentificacaoInfratorCondutor> TblInfracaoIdentificacaoInfratorCondutor { get; set; }
        public virtual ICollection<TblInfracaoIdentificacaoInfratorCondutorEvento> TblInfracaoIdentificacaoInfratorCondutorEvento { get; set; }
    }
}
