using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvagenteTransitoSolicitacaoDescredenciamentoArquivo
    {
        public int CodigoPncvagenteTransitoSolicitacaoDescredenciamentoArquivo { get; set; }
        public int CodigoPncvagenteTransitoSolicitacaoDescredenciamento { get; set; }
        public string Nome { get; set; }
        public string NomeFisico { get; set; }
        public int Tamanho { get; set; }
        public string Descricao { get; set; }

        public virtual TblPncvagenteTransitoSolicitacaoDescredenciamento CodigoPncvagenteTransitoSolicitacaoDescredenciamentoNavigation { get; set; }
    }
}
