namespace GeradorRelatorios.BD_PNCV_LIC_4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRegistroInfracaoImagem")]
    public partial class tblRegistroInfracaoImagem
    {
        [Key]
        public long CodigoRegistroInfracaoImagem { get; set; }

        public long CodigoRegistroInfracao { get; set; }

        public int CodigoRegistroInfracaoImagemTipo { get; set; }

        public int? CodigoRegistroInfracaoImagemMotivoReinicioSequencia { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [Required]
        [StringLength(32)]
        public string NomeFisico { get; set; }

        public int Tamanho { get; set; }

        public DateTime DataHora { get; set; }

        public int SequenciaImagem { get; set; }

        public virtual tblRegistroInfracao tblRegistroInfracao { get; set; }

        public virtual tblRegistroInfracaoImagemMotivoReinicioSequencia tblRegistroInfracaoImagemMotivoReinicioSequencia { get; set; }

        public virtual tblRegistroInfracaoImagemTipo tblRegistroInfracaoImagemTipo { get; set; }
    }
}
