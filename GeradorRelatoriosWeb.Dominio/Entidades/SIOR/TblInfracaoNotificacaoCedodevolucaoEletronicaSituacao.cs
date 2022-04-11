using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoCedodevolucaoEletronicaSituacao
    {
        public TblInfracaoNotificacaoCedodevolucaoEletronicaSituacao()
        {
            TblInfracaoNotificacaoCedodevolucaoEletronica = new HashSet<TblInfracaoNotificacaoCedodevolucaoEletronica>();
        }

        public int CodigoInfracaoNotificacaoCedodevolucaoEletronicaSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoNotificacaoCedodevolucaoEletronica> TblInfracaoNotificacaoCedodevolucaoEletronica { get; set; }
    }
}
