using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblRemessaDadosSituacaoArquivoRetorno
    {
        public TblRemessaDadosSituacaoArquivoRetorno()
        {
            TblRemessaDados = new HashSet<TblRemessaDados>();
        }

        public int CodigoRemessaDadosSituacaoArquivoRetorno { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblRemessaDados> TblRemessaDados { get; set; }
    }
}
