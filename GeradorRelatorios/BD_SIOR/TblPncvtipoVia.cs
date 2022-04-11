using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvtipoVia
    {
        public TblPncvtipoVia()
        {
            TblPncvequipamentoFaixa = new HashSet<TblPncvequipamentoFaixa>();
            TblPncvestudoTecnicoInstalacaoFaixa = new HashSet<TblPncvestudoTecnicoInstalacaoFaixa>();
            TblPncvestudoViabilidadeFaixa = new HashSet<TblPncvestudoViabilidadeFaixa>();
        }

        public byte CodigoPncvtipoVia { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<TblPncvequipamentoFaixa> TblPncvequipamentoFaixa { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoFaixa> TblPncvestudoTecnicoInstalacaoFaixa { get; set; }
        public virtual ICollection<TblPncvestudoViabilidadeFaixa> TblPncvestudoViabilidadeFaixa { get; set; }
    }
}
