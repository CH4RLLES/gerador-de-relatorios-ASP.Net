namespace GeradorRelatorios.BD_RENAVAM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRENAVAMMunicipio")]
    public partial class tblRENAVAMMunicipio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoRENAVAMMunicipio { get; set; }

        public short? CodigoBaseUF { get; set; }

        [StringLength(4)]
        public string CodigoRENAVAM { get; set; }

        [StringLength(1)]
        public string DigitoMunicipio { get; set; }

        [Required]
        [StringLength(60)]
        public string Nome { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(5)]
        public string CodigoRENAVAM5D { get; set; }
    }
}
