using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_168
{
    public partial class TblRemessaDadosIdentificadorErro
    {
        public TblRemessaDadosIdentificadorErro()
        {
            TblRemessaDadosErro = new HashSet<TblRemessaDadosErro>();
        }

        public int CodigoRemessaDadosIdentificadorErro { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TblRemessaDadosErro> TblRemessaDadosErro { get; set; }
    }
}
