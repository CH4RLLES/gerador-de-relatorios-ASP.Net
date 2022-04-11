using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoDesvinculacaoMultaArquivo
    {
        public long CodigoInfracaoDesvinculacaoMultaArquivo { get; set; }
        public long CodigoInfracaoDesvinculacaoMulta { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Tamanho { get; set; }
        public string NomeFisico { get; set; }
        public DateTime DataCriacao { get; set; }
        public string NumeroIdentificacaoCaixa { get; set; }

        public virtual TblInfracaoDesvinculacaoMulta CodigoInfracaoDesvinculacaoMultaNavigation { get; set; }
    }
}
