namespace GeradorRelatorios.BD_PNCV_LIC_4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRegistroTesteEquipamento")]
    public partial class tblRegistroTesteEquipamento
    {
        [Key]
        public long CodigoRegistroTesteEquipamento { get; set; }

        public long CodigoRemessaDados { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [Required]
        [StringLength(32)]
        public string NomeFisico { get; set; }

        public int Tamanho { get; set; }

        public DateTime DataHora { get; set; }

        public byte Hora { get; set; }

        public int? SequenciaImagem { get; set; }

        public virtual tblRemessaDados tblRemessaDados { get; set; }
    }
}
