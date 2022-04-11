using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvsentidoRodovia
    {
        public TblPncvsentidoRodovia()
        {
            TblPncvequipamentoFaixa = new HashSet<TblPncvequipamentoFaixa>();
            TblPncvestudoTecnicoInstalacaoFaixa = new HashSet<TblPncvestudoTecnicoInstalacaoFaixa>();
            TblPncvestudoTecnicoInstalacaoSinalizacaoVertical = new HashSet<TblPncvestudoTecnicoInstalacaoSinalizacaoVertical>();
            TblPncvestudoViabilidadeFaixa = new HashSet<TblPncvestudoViabilidadeFaixa>();
        }

        public byte CodigoPncvsentidoRodovia { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public bool? Transversal { get; set; }

        public virtual ICollection<TblPncvequipamentoFaixa> TblPncvequipamentoFaixa { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoFaixa> TblPncvestudoTecnicoInstalacaoFaixa { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoSinalizacaoVertical> TblPncvestudoTecnicoInstalacaoSinalizacaoVertical { get; set; }
        public virtual ICollection<TblPncvestudoViabilidadeFaixa> TblPncvestudoViabilidadeFaixa { get; set; }
    }
}
