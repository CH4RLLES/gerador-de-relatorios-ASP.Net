using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvparametros
    {
        public TblPncvparametros()
        {
            TblPncvparametrosEditalLote = new HashSet<TblPncvparametrosEditalLote>();
        }

        public int CodigoPncvparametros { get; set; }
        public string ServidorSftpEndereco { get; set; }
        public int ServidorSftpPorta { get; set; }
        public string ServidorSftpUsuarioNome { get; set; }
        public string ServidorSftpUsuarioSenha { get; set; }
        public string ServidorSftpCaminhoPastaRaiz { get; set; }
        public string CaminhoLogRemessaInfracao { get; set; }
        public string CaminhoLogRemessaContagem { get; set; }
        public int NumeroMaximoErros { get; set; }
        public int ProcessoColetaLimiteRemessas { get; set; }
        public int ProcessoCargaLimiteRemessas { get; set; }

        public virtual ICollection<TblPncvparametrosEditalLote> TblPncvparametrosEditalLote { get; set; }
    }
}
