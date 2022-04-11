using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblRegistroInfracao
    {
        public TblRegistroInfracao()
        {
            TblRegistroInfracaoImagem = new HashSet<TblRegistroInfracaoImagem>();
        }

        public long CodigoRegistroInfracao { get; set; }
        public long CodigoRemessaDados { get; set; }
        public int? CodigoRegistroClasseVeiculo { get; set; }
        public int? CodigoRegistroInfracaoVeiculoTipo { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public int? CodigoInfracaoGravidade { get; set; }
        public int? CodigoInfracaoIndicadorResponsavel { get; set; }
        public int? CodigoRenavamunidadeMedida { get; set; }
        public DateTime DataHora { get; set; }
        public byte Hora { get; set; }
        public string PlacaVeiculo { get; set; }
        public short ValorMedido { get; set; }
        public decimal? LimiteRegulamentado { get; set; }
        public decimal? ValorConsiderado { get; set; }
        public byte? PontosCnh { get; set; }
        public decimal? ValorOriginal { get; set; }
        public decimal? ValorOriginal80Porcento { get; set; }
        public decimal? ValorOriginal60Porcento { get; set; }
        public byte HoraFracao { get; set; }

        public virtual TblRegistroClasseVeiculo CodigoRegistroClasseVeiculoNavigation { get; set; }
        public virtual TblRegistroInfracaoVeiculoTipo CodigoRegistroInfracaoVeiculoTipoNavigation { get; set; }
        public virtual TblRemessaDados CodigoRemessaDadosNavigation { get; set; }
        public virtual ICollection<TblRegistroInfracaoImagem> TblRegistroInfracaoImagem { get; set; }
    }
}
