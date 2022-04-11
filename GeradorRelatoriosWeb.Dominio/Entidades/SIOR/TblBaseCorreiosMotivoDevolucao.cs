using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBaseCorreiosMotivoDevolucao
    {
        public TblBaseCorreiosMotivoDevolucao()
        {
            TblInfracaoNotificacao = new HashSet<TblInfracaoNotificacao>();
        }

        public int CodigoBaseCorreiosMotivoDevolucao { get; set; }
        public string Nome { get; set; }
        public int? CodigoBaseCorreiosMotivoDevolucaoCedo { get; set; }

        public virtual ICollection<TblInfracaoNotificacao> TblInfracaoNotificacao { get; set; }
    }
}
