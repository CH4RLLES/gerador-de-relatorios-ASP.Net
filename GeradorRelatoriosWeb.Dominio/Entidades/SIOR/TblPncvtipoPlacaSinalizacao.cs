using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvtipoPlacaSinalizacao
    {
        public TblPncvtipoPlacaSinalizacao()
        {
            TblPncvequipamentoFaixaVerificacaoPlaca = new HashSet<TblPncvequipamentoFaixaVerificacaoPlaca>();
            TblPncvestudoTecnicoInstalacaoSinalizacaoVertical = new HashSet<TblPncvestudoTecnicoInstalacaoSinalizacaoVertical>();
            TblPncvestudoTecnicoMonitoramentoSinalizacaoVertical = new HashSet<TblPncvestudoTecnicoMonitoramentoSinalizacaoVertical>();
        }

        public byte CodigoPncvtipoPlacaSinalizacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvequipamentoFaixaVerificacaoPlaca> TblPncvequipamentoFaixaVerificacaoPlaca { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoSinalizacaoVertical> TblPncvestudoTecnicoInstalacaoSinalizacaoVertical { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramentoSinalizacaoVertical> TblPncvestudoTecnicoMonitoramentoSinalizacaoVertical { get; set; }
    }
}
