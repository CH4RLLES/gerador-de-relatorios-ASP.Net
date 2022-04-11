using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoSituacao
    {
        public TblInfracaoSituacao()
        {
            TblInfracao = new HashSet<TblInfracao>();
            TblInfracaoEvento = new HashSet<TblInfracaoEvento>();
        }

        public int CodigoInfracaoSituacao { get; set; }
        public string Nome { get; set; }
        public byte Ordem { get; set; }

        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
        public virtual ICollection<TblInfracaoEvento> TblInfracaoEvento { get; set; }
    }
}
