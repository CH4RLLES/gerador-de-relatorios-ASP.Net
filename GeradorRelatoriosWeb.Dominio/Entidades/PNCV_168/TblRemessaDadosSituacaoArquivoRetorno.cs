using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_168
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
