namespace GeradorRelatorios.BD_PNCV_LIC_4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRemessaDadosEvento")]
    public partial class tblRemessaDadosEvento
    {
        [Key]
        public long CodigoRemessaDadosEvento { get; set; }

        public long CodigoRemessaDados { get; set; }

        public int CodigoRemessaDadosSituacao { get; set; }

        public DateTime DataEvento { get; set; }

        public virtual tblRemessaDados tblRemessaDados { get; set; }

        public virtual tblRemessaDadosSituacao tblRemessaDadosSituacao { get; set; }
    }
}
