using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvestudoIndicadorDispositivoSeguranca
    {
        public TblPncvestudoIndicadorDispositivoSeguranca()
        {
            TblPncvestudoTecnicoInstalacao = new HashSet<TblPncvestudoTecnicoInstalacao>();
        }

        public int CodigoPncvestudoIndicadorDispositivoSeguranca { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoTecnicoInstalacao> TblPncvestudoTecnicoInstalacao { get; set; }
    }
}
