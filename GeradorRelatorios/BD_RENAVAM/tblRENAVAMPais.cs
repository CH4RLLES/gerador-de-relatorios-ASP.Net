namespace GeradorRelatorios.BD_RENAVAM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblRENAVAMPais
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoRENAVAMPais { get; set; }

        [Required]
        [StringLength(2)]
        public string CodigoRENAVAM { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        [Required]
        [StringLength(2)]
        public string Sigla { get; set; }
    }
}
