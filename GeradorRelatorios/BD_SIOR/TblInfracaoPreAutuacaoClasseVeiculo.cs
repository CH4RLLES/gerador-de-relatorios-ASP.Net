using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoPreAutuacaoClasseVeiculo
    {
        public TblInfracaoPreAutuacaoClasseVeiculo()
        {
            TblInfracaoPreAutuacao = new HashSet<TblInfracaoPreAutuacao>();
        }

        public int CodigoInfracaoPreAutuacaoClasseVeiculo { get; set; }
        public string Letra { get; set; }
        public string Classe { get; set; }
        public string Referencia { get; set; }

        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacao { get; set; }
    }
}
