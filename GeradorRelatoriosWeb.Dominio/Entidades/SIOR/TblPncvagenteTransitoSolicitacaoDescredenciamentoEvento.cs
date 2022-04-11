using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvagenteTransitoSolicitacaoDescredenciamentoEvento
    {
        public int CodigoPncvagenteTransitoSolicitacaoDescredenciamentoEvento { get; set; }
        public int CodigoPncvagenteTransitoSolicitacaoDescredenciamento { get; set; }
        public int CodigoPncvagenteTransitoSolicitacaoDescredenciamentoSituacao { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblPncvagenteTransitoSolicitacaoDescredenciamento CodigoPncvagenteTransitoSolicitacaoDescredenciamentoNavigation { get; set; }
        public virtual TblPncvagenteTransitoSolicitacaoDescredenciamentoSituacao CodigoPncvagenteTransitoSolicitacaoDescredenciamentoSituacaoNavigation { get; set; }
    }
}
