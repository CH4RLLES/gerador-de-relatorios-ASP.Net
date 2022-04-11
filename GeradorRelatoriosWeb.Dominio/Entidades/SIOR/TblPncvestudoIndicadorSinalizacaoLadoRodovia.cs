using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoIndicadorSinalizacaoLadoRodovia
    {
        public TblPncvestudoIndicadorSinalizacaoLadoRodovia()
        {
            TblPncvestudoTecnicoInstalacaoSinalizacaoVertical = new HashSet<TblPncvestudoTecnicoInstalacaoSinalizacaoVertical>();
            TblPncvestudoTecnicoMonitoramentoSinalizacaoVertical = new HashSet<TblPncvestudoTecnicoMonitoramentoSinalizacaoVertical>();
        }

        public int CodigoPncvestudoIndicadorSinalizacaoLadoRodovia { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvestudoTecnicoInstalacaoSinalizacaoVertical> TblPncvestudoTecnicoInstalacaoSinalizacaoVertical { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramentoSinalizacaoVertical> TblPncvestudoTecnicoMonitoramentoSinalizacaoVertical { get; set; }
    }
}
