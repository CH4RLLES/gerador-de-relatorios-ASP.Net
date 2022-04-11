using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_LIC_4
{
    public partial class TblRegistroInfracao
    {
        public TblRegistroInfracao()
        {
            TblRegistroInfracaoImagem = new HashSet<TblRegistroInfracaoImagem>();
        }

        public long CodigoRegistroInfracao { get; set; }
        public long CodigoRemessaDados { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public DateTime DataHora { get; set; }
        public byte Hora { get; set; }
        public short ValorMedido { get; set; }
        public int? CodigoInfracaoGravidade { get; set; }
        public int? CodigoInfracaoIndicadorResponsavel { get; set; }
        public int? CodigoRenavamunidadeMedida { get; set; }
        public decimal? LimiteRegulamentado { get; set; }
        public decimal? ValorConsiderado { get; set; }
        public byte? PontosCnh { get; set; }
        public decimal? ValorOriginal { get; set; }
        public decimal? ValorOriginal80Porcento { get; set; }
        public decimal? ValorOriginal60Porcento { get; set; }
        public int? CodigoRegistroInfracaoVeiculoTipo { get; set; }

        public virtual TblRegistroInfracaoVeiculoTipo CodigoRegistroInfracaoVeiculoTipoNavigation { get; set; }
        public virtual TblRemessaDados CodigoRemessaDadosNavigation { get; set; }
        public virtual ICollection<TblRegistroInfracaoImagem> TblRegistroInfracaoImagem { get; set; }
    }
}
