using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoArquivoAnexo
    {
        public long CodigoInfracaoArquivoAnexo { get; set; }
        public long CodigoInfracao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Tamanho { get; set; }
        public string NomeFisico { get; set; }
        public DateTime DataCriacao { get; set; }
        public string NumeroIdentificacaoCaixa { get; set; }

        public virtual TblInfracao CodigoInfracaoNavigation { get; set; }
    }
}
