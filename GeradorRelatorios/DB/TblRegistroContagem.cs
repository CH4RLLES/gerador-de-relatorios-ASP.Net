using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblRegistroContagem
    {
        public long CodigoRegistroContagem { get; set; }
        public long CodigoRemessaDados { get; set; }
        public int CodigoRemessaDadosTipo { get; set; }
        public int? CodigoRegistroClasseVeiculo { get; set; }
        public DateTime DataHora { get; set; }
        public byte Hora { get; set; }
        public short Velocidade { get; set; }
        public string PlacaVeiculo { get; set; }
        public byte HoraFracao { get; set; }

        public virtual TblRegistroClasseVeiculo CodigoRegistroClasseVeiculoNavigation { get; set; }
        public virtual TblRemessaDados CodigoRemessaDadosNavigation { get; set; }
        public virtual TblRemessaDadosTipo CodigoRemessaDadosTipoNavigation { get; set; }
    }
}
