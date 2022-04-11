using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoNotificacaoArquivoBaixaSituacao
    {
        public TblInfracaoNotificacaoArquivoBaixaSituacao()
        {
            TblInfracaoNotificacaoArquivoBaixa = new HashSet<TblInfracaoNotificacaoArquivoBaixa>();
        }

        public int CodigoInfracaoNotificacaoArquivoBaixaSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoNotificacaoArquivoBaixa> TblInfracaoNotificacaoArquivoBaixa { get; set; }
    }
}
