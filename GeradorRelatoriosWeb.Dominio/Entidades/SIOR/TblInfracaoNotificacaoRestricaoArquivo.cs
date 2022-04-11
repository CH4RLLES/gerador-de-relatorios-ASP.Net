using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoRestricaoArquivo
    {
        public int CodigoInfracaoNotificacaoRestricaoArquivo { get; set; }
        public int CodigoInfracaoNotificacaoRestricao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? Tamanho { get; set; }
        public string NomeFisico { get; set; }
        public DateTime DataCriacao { get; set; }

        public virtual TblInfracaoNotificacaoRestricao CodigoInfracaoNotificacaoRestricaoNavigation { get; set; }
    }
}
