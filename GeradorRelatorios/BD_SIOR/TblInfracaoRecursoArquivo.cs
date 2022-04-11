using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoRecursoArquivo
    {
        public long CodigoInfracaoRecursoArquivo { get; set; }
        public long CodigoInfracaoRecurso { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Tamanho { get; set; }
        public string NomeFisico { get; set; }
        public DateTime DataCriacao { get; set; }
        public string NumeroIdentificacaoCaixa { get; set; }

        public virtual TblInfracaoRecurso CodigoInfracaoRecursoNavigation { get; set; }
    }
}
