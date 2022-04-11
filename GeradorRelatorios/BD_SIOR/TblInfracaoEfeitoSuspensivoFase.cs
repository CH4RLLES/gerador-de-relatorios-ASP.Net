using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoEfeitoSuspensivoFase
    {
        public TblInfracaoEfeitoSuspensivoFase()
        {
            TblInfracaoEfeitoSuspensivo = new HashSet<TblInfracaoEfeitoSuspensivo>();
            TblInfracaoEfeitoSuspensivoEvento = new HashSet<TblInfracaoEfeitoSuspensivoEvento>();
        }

        public int CodigoInfracaoEfeitoSuspensivoFase { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoEfeitoSuspensivo> TblInfracaoEfeitoSuspensivo { get; set; }
        public virtual ICollection<TblInfracaoEfeitoSuspensivoEvento> TblInfracaoEfeitoSuspensivoEvento { get; set; }
    }
}
