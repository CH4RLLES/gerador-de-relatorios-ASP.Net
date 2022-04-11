namespace GeradorRelatorios.BD_RENAVAM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRENAVAMVeiculoCategoria")]
    public partial class tblRENAVAMVeiculoCategoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoRENAVAMVeiculoCategoria { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }
    }
}
