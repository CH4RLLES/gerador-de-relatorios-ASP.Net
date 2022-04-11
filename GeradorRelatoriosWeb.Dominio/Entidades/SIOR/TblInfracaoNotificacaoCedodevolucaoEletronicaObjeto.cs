using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoCedodevolucaoEletronicaObjeto
    {
        public long CodigoInfracaoNotificacaoCedodevolucaoEletronicaObjeto { get; set; }
        public int CodigoInfracaoNotificacaoCedodevolucaoEletronica { get; set; }
        public int CodigoInfracaoNotificacaoCedodevolucaoEletronicaObjetoSituacao { get; set; }
        public int? CodigoBaseCorreiosMotivoDevolucaoCedo { get; set; }
        public long? CodigoInfracaoNotificacao { get; set; }
        public string IdentificacaoObjeto { get; set; }
        public string Linha { get; set; }
        public string Observacao { get; set; }

        public virtual TblInfracaoNotificacaoCedodevolucaoEletronica CodigoInfracaoNotificacaoCedodevolucaoEletronicaNavigation { get; set; }
        public virtual TblInfracaoNotificacaoCedodevolucaoEletronicaObjetoSituacao CodigoInfracaoNotificacaoCedodevolucaoEletronicaObjetoSituacaoNavigation { get; set; }
    }
}
