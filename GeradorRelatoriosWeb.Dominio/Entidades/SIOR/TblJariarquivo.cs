using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblJariarquivo
    {
        public int CodigoJariarquivo { get; set; }
        public int CodigoJari { get; set; }
        public string Nome { get; set; }
        public string NomeFisico { get; set; }
        public DateTime DataCriacao { get; set; }
        public int Tamanho { get; set; }
        public string Descricao { get; set; }

        public virtual TblJari CodigoJariNavigation { get; set; }
    }
}
