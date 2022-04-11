namespace GeradorRelatorios.BD_RENAVAM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRENAVAMVeiculoCor")]
    public partial class tblRENAVAMVeiculoCor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoRENAVAMVeiculoCor { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }
    }
}
