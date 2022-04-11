using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoNotificacaoEditalSituacaoArquivo
    {
        public TblInfracaoNotificacaoEditalSituacaoArquivo()
        {
            TblInfracaoNotificacaoEdital = new HashSet<TblInfracaoNotificacaoEdital>();
        }

        public int CodigoInfracaoNotificacaoEditalSituacaoArquivo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoNotificacaoEdital> TblInfracaoNotificacaoEdital { get; set; }
    }
}
