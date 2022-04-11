using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaSolicitacaoAcesso
    {
        public int CodigoSistemaSolicitacaoAcesso { get; set; }
        public int CodigoSistemaSolicitacaoAcessoSituacao { get; set; }
        public DateTime DataSolicitacaoAcesso { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public bool IndicadorUsuarioDnit { get; set; }
        public string MatriculaDnit { get; set; }
        public string NomeInstituicao { get; set; }
        public string ObservacaoSolicitacao { get; set; }
        public DateTime? DataAnalise { get; set; }
        public string NomeAnalista { get; set; }
        public string ObservacaoAnalise { get; set; }
        public string NumeroMatriculaSiape { get; set; }

        public virtual TblSistemaSolicitacaoAcessoSituacao CodigoSistemaSolicitacaoAcessoSituacaoNavigation { get; set; }
    }
}
