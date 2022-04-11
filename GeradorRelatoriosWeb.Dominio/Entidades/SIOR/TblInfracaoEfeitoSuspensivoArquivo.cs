using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoEfeitoSuspensivoArquivo
    {
        public long CodigoInfracaoEfeitoSuspensivoArquivo { get; set; }
        public long CodigoInfracaoEfeitoSuspensivo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Tamanho { get; set; }
        public string NomeFisico { get; set; }
        public DateTime DataCriacao { get; set; }
        public string NumeroIdentificacaoCaixa { get; set; }

        public virtual TblInfracaoEfeitoSuspensivo CodigoInfracaoEfeitoSuspensivoNavigation { get; set; }
    }
}
