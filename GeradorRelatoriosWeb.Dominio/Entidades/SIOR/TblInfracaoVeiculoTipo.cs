using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoVeiculoTipo
    {
        public TblInfracaoVeiculoTipo()
        {
            TblInfracaoPreAutuacao = new HashSet<TblInfracaoPreAutuacao>();
            TblInfracaoVeiculo = new HashSet<TblInfracaoVeiculo>();
        }

        public int CodigoInfracaoVeiculoTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacao { get; set; }
        public virtual ICollection<TblInfracaoVeiculo> TblInfracaoVeiculo { get; set; }
    }
}
