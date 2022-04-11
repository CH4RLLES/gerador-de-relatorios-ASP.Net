namespace GeradorRelatorios.BD_RENAVAM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRENAVAMVeiculoCarroceria")]
    public partial class tblRENAVAMVeiculoCarroceria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoRENAVAMVeiculoCarroceria { get; set; }

        [Required]
        [StringLength(45)]
        public string Nome { get; set; }
    }
}
