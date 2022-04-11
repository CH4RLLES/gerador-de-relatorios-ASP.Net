using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroGrucadastroTituloBanco
    {
        public TblInfracaoFinanceiroGrucadastroTituloBanco()
        {
            TblInfracaoFinanceiroGru = new HashSet<TblInfracaoFinanceiroGru>();
            TblInfracaoNotificacaoExpedicao = new HashSet<TblInfracaoNotificacaoExpedicao>();
        }

        public int CodigoInfracaoFinanceiroGrucadastroTituloBanco { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoFinanceiroGru> TblInfracaoFinanceiroGru { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoExpedicao> TblInfracaoNotificacaoExpedicao { get; set; }
    }
}
