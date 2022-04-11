using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBaseCorreiosPlanoTriagemFaixaCep
    {
        public int CodigoBaseCorreiosPlanoTriagemFaixaCep { get; set; }
        public int CodigoBaseCorreiosPlanoTriagem { get; set; }
        public int Numero { get; set; }
        public string CepInicial { get; set; }
        public string CepFinal { get; set; }
        public string Dr { get; set; }
        public string UnidadeDistribuicao { get; set; }
        public string Centralizador { get; set; }

        public virtual TblBaseCorreiosPlanoTriagem CodigoBaseCorreiosPlanoTriagemNavigation { get; set; }
    }
}
