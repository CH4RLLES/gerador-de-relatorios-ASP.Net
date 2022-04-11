using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBaseDiaSemana
    {
        public TblBaseDiaSemana()
        {
            TblTrafegoVmdsemanalClassificado = new HashSet<TblTrafegoVmdsemanalClassificado>();
        }

        public int CodigoBaseDiaSemana { get; set; }
        public byte Numero { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string NomeExtenso { get; set; }

        public virtual ICollection<TblTrafegoVmdsemanalClassificado> TblTrafegoVmdsemanalClassificado { get; set; }
    }
}
