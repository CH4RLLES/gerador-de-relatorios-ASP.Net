using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblRegistroClasseVeiculo
    {
        public TblRegistroClasseVeiculo()
        {
            TblRegistroContagem = new HashSet<TblRegistroContagem>();
            TblRegistroInfracao = new HashSet<TblRegistroInfracao>();
        }

        public int CodigoRegistroClasseVeiculo { get; set; }
        public string Letra { get; set; }
        public string Classe { get; set; }
        public string Referencia { get; set; }

        public virtual ICollection<TblRegistroContagem> TblRegistroContagem { get; set; }
        public virtual ICollection<TblRegistroInfracao> TblRegistroInfracao { get; set; }
    }
}
