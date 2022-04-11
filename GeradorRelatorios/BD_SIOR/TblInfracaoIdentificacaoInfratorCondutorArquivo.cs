using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoIdentificacaoInfratorCondutorArquivo
    {
        public long CodigoInfracaoIdentificacaoInfratorCondutorArquivo { get; set; }
        public long CodigoInfracaoIdentificacaoInfratorCondutor { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public int Tamanho { get; set; }
        public string NomeFisico { get; set; }
        public DateTime DataCriacao { get; set; }
        public string NumeroIdentificacaoCaixa { get; set; }

        public virtual TblInfracaoIdentificacaoInfratorCondutor CodigoInfracaoIdentificacaoInfratorCondutorNavigation { get; set; }
    }
}
