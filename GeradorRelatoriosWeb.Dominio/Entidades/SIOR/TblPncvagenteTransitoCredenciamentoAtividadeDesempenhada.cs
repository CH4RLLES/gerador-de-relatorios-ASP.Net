using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvagenteTransitoCredenciamentoAtividadeDesempenhada
    {
        public int CodigoPncvagenteTransitoCredenciamentoAtividadeDesempenhada { get; set; }
        public int CodigoPncvagenteTransitoCredenciamento { get; set; }
        public int CodigoPncvagenteTransitoAtividadeDesempenhada { get; set; }

        public virtual TblPncvagenteTransitoAtividadeDesempenhada CodigoPncvagenteTransitoAtividadeDesempenhadaNavigation { get; set; }
        public virtual TblPncvagenteTransitoCredenciamento CodigoPncvagenteTransitoCredenciamentoNavigation { get; set; }
    }
}
