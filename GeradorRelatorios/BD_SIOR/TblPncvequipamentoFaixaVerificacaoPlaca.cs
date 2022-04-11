using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvequipamentoFaixaVerificacaoPlaca
    {
        public int CodigoPncvequipamentoFaixaVerificacaoPlaca { get; set; }
        public byte CodigoPncvtipoPlacaSinalizacao { get; set; }
        public int CodigoPncvequipamentoFaixaVerificacao { get; set; }
        public short DistanciaEquipamento { get; set; }
        public string FotoNome { get; set; }
        public string FotoNomeFisico { get; set; }
        public int? FotoTamanho { get; set; }

        public virtual TblPncvequipamentoFaixaVerificacao CodigoPncvequipamentoFaixaVerificacaoNavigation { get; set; }
        public virtual TblPncvtipoPlacaSinalizacao CodigoPncvtipoPlacaSinalizacaoNavigation { get; set; }
    }
}
