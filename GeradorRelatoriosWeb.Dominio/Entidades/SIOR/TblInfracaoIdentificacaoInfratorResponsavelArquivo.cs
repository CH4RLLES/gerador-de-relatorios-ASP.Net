using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoIdentificacaoInfratorResponsavelArquivo
    {
        public long CodigoInfracaoIdentificacaoInfratorResponsavelArquivo { get; set; }
        public long CodigoInfracaoIdentificacaoInfratorResponsavel { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public int Tamanho { get; set; }
        public string NomeFisico { get; set; }
        public DateTime DataCriacao { get; set; }
        public string NumeroIdentificacaoCaixa { get; set; }

        public virtual TblInfracaoIdentificacaoInfratorResponsavel CodigoInfracaoIdentificacaoInfratorResponsavelNavigation { get; set; }
    }
}
