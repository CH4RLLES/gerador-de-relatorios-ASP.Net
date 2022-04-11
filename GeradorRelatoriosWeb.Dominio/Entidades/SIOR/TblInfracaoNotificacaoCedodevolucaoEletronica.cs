using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoCedodevolucaoEletronica
    {
        public TblInfracaoNotificacaoCedodevolucaoEletronica()
        {
            TblInfracaoNotificacaoCedodevolucaoEletronicaObjeto = new HashSet<TblInfracaoNotificacaoCedodevolucaoEletronicaObjeto>();
        }

        public int CodigoInfracaoNotificacaoCedodevolucaoEletronica { get; set; }
        public int CodigoInfracaoNotificacaoCedodevolucaoEletronicaSituacao { get; set; }
        public DateTime ArquivoDataRecebimento { get; set; }
        public DateTime ArquivoDataHoraGeracao { get; set; }
        public string ArquivoNome { get; set; }
        public string ArquivoNomeFisico { get; set; }
        public int ArquivoTamanho { get; set; }
        public DateTime? DataProcessamento { get; set; }
        public int QuantidadeObjetos { get; set; }
        public int QuantidadeNaoIdentificado { get; set; }
        public int QuantidadeProcessado { get; set; }
        public string Observacao { get; set; }

        public virtual TblInfracaoNotificacaoCedodevolucaoEletronicaSituacao CodigoInfracaoNotificacaoCedodevolucaoEletronicaSituacaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoCedodevolucaoEletronicaObjeto> TblInfracaoNotificacaoCedodevolucaoEletronicaObjeto { get; set; }
    }
}
