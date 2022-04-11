using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvagenteTransitoSolicitacaoCredenciamentoArquivo
    {
        public long CodigoPncvagenteTransitoSolicitacaoCredenciamentoArquivo { get; set; }
        public int CodigoPncvagenteTransitoSolicitacaoCredenciamento { get; set; }
        public string Nome { get; set; }
        public int Tamanho { get; set; }
        public string Descricao { get; set; }
        public string NomeFisico { get; set; }

        public virtual TblPncvagenteTransitoSolicitacaoCredenciamento CodigoPncvagenteTransitoSolicitacaoCredenciamentoNavigation { get; set; }
    }
}
