namespace GeradorRelatorios.BD_PNCV_LIC_4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRemessaDadosSituacaoArquivoRetorno")]
    public partial class tblRemessaDadosSituacaoArquivoRetorno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRemessaDadosSituacaoArquivoRetorno()
        {
            tblRemessaDados = new HashSet<tblRemessaDados>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoRemessaDadosSituacaoArquivoRetorno { get; set; }

        [Required]
        [StringLength(10)]
        public string Nome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRemessaDados> tblRemessaDados { get; set; }
    }
}
