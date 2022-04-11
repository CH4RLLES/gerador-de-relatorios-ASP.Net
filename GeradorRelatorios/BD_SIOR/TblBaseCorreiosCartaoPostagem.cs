using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBaseCorreiosCartaoPostagem
    {
        public TblBaseCorreiosCartaoPostagem()
        {
            TblInfracaoNotificacaoExpedicao = new HashSet<TblInfracaoNotificacaoExpedicao>();
        }

        public long CodigoBaseCorreiosCartaoPostagem { get; set; }
        public string NumeroContrato { get; set; }
        public string CodigoAdministrativo { get; set; }
        public string NumeroCartaoPostagem { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TblInfracaoNotificacaoExpedicao> TblInfracaoNotificacaoExpedicao { get; set; }
    }
}
