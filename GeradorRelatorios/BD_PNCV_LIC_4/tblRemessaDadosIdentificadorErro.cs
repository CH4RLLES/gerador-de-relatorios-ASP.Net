namespace GeradorRelatorios.BD_PNCV_LIC_4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRemessaDadosIdentificadorErro")]
    public partial class tblRemessaDadosIdentificadorErro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRemessaDadosIdentificadorErro()
        {
            tblRemessaDadosErro = new HashSet<tblRemessaDadosErro>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoRemessaDadosIdentificadorErro { get; set; }

        [Required]
        [StringLength(500)]
        public string Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRemessaDadosErro> tblRemessaDadosErro { get; set; }
    }
}
