namespace GeradorRelatorios.BD_RENAVAM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRENAVAMVeiculoEspecie")]
    public partial class tblRENAVAMVeiculoEspecie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoRENAVAMVeiculoEspecie { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }
    }
}
