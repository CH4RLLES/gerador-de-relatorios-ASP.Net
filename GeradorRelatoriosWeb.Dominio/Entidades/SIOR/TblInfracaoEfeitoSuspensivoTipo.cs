using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoEfeitoSuspensivoTipo
    {
        public TblInfracaoEfeitoSuspensivoTipo()
        {
            TblInfracaoEfeitoSuspensivo = new HashSet<TblInfracaoEfeitoSuspensivo>();
        }

        public int CodigoInfracaoEfeitoSuspensivoTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoEfeitoSuspensivo> TblInfracaoEfeitoSuspensivo { get; set; }
    }
}
