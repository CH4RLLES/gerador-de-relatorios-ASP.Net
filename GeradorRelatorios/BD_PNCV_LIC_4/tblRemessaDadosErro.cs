namespace GeradorRelatorios.BD_PNCV_LIC_4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRemessaDadosErro")]
    public partial class tblRemessaDadosErro
    {
        [Key]
        public long CodigoRemessaDadosErro { get; set; }

        public long CodigoRemessaDados { get; set; }

        public int CodigoRemessaDadosIdentificadorErro { get; set; }

        public int Sequencia { get; set; }

        [Required]
        [StringLength(500)]
        public string Descricao { get; set; }

        public virtual tblRemessaDados tblRemessaDados { get; set; }

        public virtual tblRemessaDadosIdentificadorErro tblRemessaDadosIdentificadorErro { get; set; }
    }
}
