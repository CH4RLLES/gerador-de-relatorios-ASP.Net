namespace GeradorRelatorios.BD_RENAVAM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRENAVAMMarcaModeloVeiculo")]
    public partial class tblRENAVAMMarcaModeloVeiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoRENAVAMMarcaModeloVeiculo { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }
    }
}
