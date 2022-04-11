using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblJarisessaoJulgamentoArquivo
    {
        public long CodigoJarisessaoJulgamentoArquivo { get; set; }
        public long CodigoJarisessaoJulgamento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Tamanho { get; set; }
        public string NomeFisico { get; set; }
        public DateTime DataCriacao { get; set; }

        public virtual TblJarisessaoJulgamento CodigoJarisessaoJulgamentoNavigation { get; set; }
    }
}
