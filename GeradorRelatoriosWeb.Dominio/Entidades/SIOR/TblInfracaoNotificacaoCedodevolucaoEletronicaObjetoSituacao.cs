using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoCedodevolucaoEletronicaObjetoSituacao
    {
        public TblInfracaoNotificacaoCedodevolucaoEletronicaObjetoSituacao()
        {
            TblInfracaoNotificacaoCedodevolucaoEletronicaObjeto = new HashSet<TblInfracaoNotificacaoCedodevolucaoEletronicaObjeto>();
        }

        public int CodigoInfracaoNotificacaoCedodevolucaoEletronicaObjetoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoNotificacaoCedodevolucaoEletronicaObjeto> TblInfracaoNotificacaoCedodevolucaoEletronicaObjeto { get; set; }
    }
}
