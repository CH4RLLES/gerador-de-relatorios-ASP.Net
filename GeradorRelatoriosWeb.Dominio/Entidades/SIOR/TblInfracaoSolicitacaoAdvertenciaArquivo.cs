using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoSolicitacaoAdvertenciaArquivo
    {
        public long CodigoInfracaoSolicitacaoAdvertenciaArquivo { get; set; }
        public long CodigoInfracaoSolicitacaoAdvertencia { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Tamanho { get; set; }
        public string NomeFisico { get; set; }
        public DateTime DataCriacao { get; set; }
        public string NumeroIdentificacaoCaixa { get; set; }

        public virtual TblInfracaoSolicitacaoAdvertencia CodigoInfracaoSolicitacaoAdvertenciaNavigation { get; set; }
    }
}
