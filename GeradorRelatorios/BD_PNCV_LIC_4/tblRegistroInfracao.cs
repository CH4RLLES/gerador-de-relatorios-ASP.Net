namespace GeradorRelatorios.BD_PNCV_LIC_4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRegistroInfracao")]
    public partial class tblRegistroInfracao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRegistroInfracao()
        {
            tblRegistroInfracaoImagem = new HashSet<tblRegistroInfracaoImagem>();
        }

        [Key]
        public long CodigoRegistroInfracao { get; set; }

        public long CodigoRemessaDados { get; set; }

        public int CodigoInfracaoEnquadramento { get; set; }

        public DateTime DataHora { get; set; }

        public byte Hora { get; set; }

        public short ValorMedido { get; set; }

        public int? CodigoInfracaoGravidade { get; set; }

        public int? CodigoInfracaoIndicadorResponsavel { get; set; }

        public int? CodigoRENAVAMUnidadeMedida { get; set; }

        public decimal? LimiteRegulamentado { get; set; }

        public decimal? ValorConsiderado { get; set; }

        public byte? PontosCnh { get; set; }

        public decimal? ValorOriginal { get; set; }

        public decimal? ValorOriginal80Porcento { get; set; }

        public decimal? ValorOriginal60Porcento { get; set; }

        public int? CodigoRegistroInfracaoVeiculoTipo { get; set; }

        public virtual tblRemessaDados tblRemessaDados { get; set; }

        public virtual tblRegistroInfracaoVeiculoTipo tblRegistroInfracaoVeiculoTipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRegistroInfracaoImagem> tblRegistroInfracaoImagem { get; set; }
    }
}
