using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoTecnicoInstalacaoSituacao
    {
        public TblPncvestudoTecnicoInstalacaoSituacao()
        {
            TblPncvestudoTecnicoInstalacao = new HashSet<TblPncvestudoTecnicoInstalacao>();
            TblPncvestudoTecnicoInstalacaoEvento = new HashSet<TblPncvestudoTecnicoInstalacaoEvento>();
        }

        public int CodigoPncvestudoTecnicoInstalacaoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoTecnicoInstalacao> TblPncvestudoTecnicoInstalacao { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoEvento> TblPncvestudoTecnicoInstalacaoEvento { get; set; }
    }
}
