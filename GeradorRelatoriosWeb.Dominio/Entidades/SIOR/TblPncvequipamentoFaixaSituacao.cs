using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvequipamentoFaixaSituacao
    {
        public TblPncvequipamentoFaixaSituacao()
        {
            TblPncvequipamentoFaixa = new HashSet<TblPncvequipamentoFaixa>();
        }

        public int CodigoPncvequipamentoFaixaSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvequipamentoFaixa> TblPncvequipamentoFaixa { get; set; }
    }
}
