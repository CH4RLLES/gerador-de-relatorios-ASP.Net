using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoMidiaAr
    {
        public TblInfracaoNotificacaoMidiaAr()
        {
            TblInfracaoNotificacao = new HashSet<TblInfracaoNotificacao>();
        }

        public int CodigoInfracaoNotificacaoMidiaAr { get; set; }
        public string NumeroMidia { get; set; }
        public DateTime DataGeracaoMidia { get; set; }
        public int QuatidadeImagem { get; set; }
        public DateTime? DataProcessamento { get; set; }
        public string Observacao { get; set; }

        public virtual ICollection<TblInfracaoNotificacao> TblInfracaoNotificacao { get; set; }
    }
}
