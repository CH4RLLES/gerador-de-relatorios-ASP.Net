using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvagenteTransitoCredenciamentoEvento
    {
        public int CodigoPncvagenteTransitoCredenciamentoEvento { get; set; }
        public int CodigoPncvagenteTransitoCredenciamento { get; set; }
        public int CodigoPncvagenteTransitoCredenciamentoSituacao { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblPncvagenteTransitoCredenciamento CodigoPncvagenteTransitoCredenciamentoNavigation { get; set; }
        public virtual TblPncvagenteTransitoCredenciamentoSituacao CodigoPncvagenteTransitoCredenciamentoSituacaoNavigation { get; set; }
    }
}
