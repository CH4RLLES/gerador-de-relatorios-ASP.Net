namespace GeradorRelatorios.BD_RENAVAM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRENAVAMEnquadramento")]
    public partial class tblRENAVAMEnquadramento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoRENAVAMEnquadramento { get; set; }

        [Required]
        [StringLength(9)]
        public string CodigoRENAVAMEnquadramentoTexto { get; set; }

        public int CodigoEnquadramentoInfracao { get; set; }

        public int Desdobramento { get; set; }

        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }

        [Required]
        [StringLength(200)]
        public string AmparoLegal { get; set; }

        public int? Gravidade { get; set; }

        public int? FatorGravidade { get; set; }
    }
}
