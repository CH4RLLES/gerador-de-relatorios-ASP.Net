using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoEditalArquivo
    {
        public int CodigoInfracaoNotificacaoEditalArquivo { get; set; }
        public int CodigoInfracaoNotificacaoEdital { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? Tamanho { get; set; }
        public string NomeFisico { get; set; }
        public DateTime DataCriacao { get; set; }

        public virtual TblInfracaoNotificacaoEdital CodigoInfracaoNotificacaoEditalNavigation { get; set; }
    }
}
