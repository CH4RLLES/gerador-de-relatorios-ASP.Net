using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblRemessaDadosErro
    {
        public long CodigoRemessaDadosErro { get; set; }
        public long CodigoRemessaDados { get; set; }
        public int CodigoRemessaDadosIdentificadorErro { get; set; }
        public int Sequencia { get; set; }
        public string Descricao { get; set; }

        public virtual TblRemessaDadosIdentificadorErro CodigoRemessaDadosIdentificadorErroNavigation { get; set; }
        public virtual TblRemessaDados CodigoRemessaDadosNavigation { get; set; }
    }
}
