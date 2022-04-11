using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvtipoPlacaSinalizacao
    {
        public TblPncvtipoPlacaSinalizacao()
        {
            TblPncvequipamentoFaixaVerificacaoPlaca = new HashSet<TblPncvequipamentoFaixaVerificacaoPlaca>();
            TblPncvestudoTecnicoInstalacaoSinalizacaoVertical = new HashSet<TblPncvestudoTecnicoInstalacaoSinalizacaoVertical>();
        }

        public byte CodigoPncvtipoPlacaSinalizacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvequipamentoFaixaVerificacaoPlaca> TblPncvequipamentoFaixaVerificacaoPlaca { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoSinalizacaoVertical> TblPncvestudoTecnicoInstalacaoSinalizacaoVertical { get; set; }
    }
}
