using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFase
    {
        public TblInfracaoFase()
        {
            TblInfracao = new HashSet<TblInfracao>();
            TblInfracaoEvento = new HashSet<TblInfracaoEvento>();
        }

        public int CodigoInfracaoFase { get; set; }
        public int CodigoInfracaoFaseGrupo { get; set; }
        public byte Ordem { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual TblInfracaoFaseGrupo CodigoInfracaoFaseGrupoNavigation { get; set; }
        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
        public virtual ICollection<TblInfracaoEvento> TblInfracaoEvento { get; set; }
    }
}
