using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoNumeroAutoPrefixo
    {
        public TblInfracaoNumeroAutoPrefixo()
        {
            TblInfracaoEnquadramento = new HashSet<TblInfracaoEnquadramento>();
        }

        public int CodigoInfracaoNumeroAutoPrefixo { get; set; }
        public string LetraPrefixo { get; set; }
        public decimal FaixaInicio { get; set; }
        public decimal FaixaTermino { get; set; }

        public virtual ICollection<TblInfracaoEnquadramento> TblInfracaoEnquadramento { get; set; }
    }
}
