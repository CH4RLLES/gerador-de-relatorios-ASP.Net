namespace GeradorRelatorios.BD_PNCV_LIC_4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRegistroInfracaoImagemTipo")]
    public partial class tblRegistroInfracaoImagemTipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRegistroInfracaoImagemTipo()
        {
            tblRegistroInfracaoImagem = new HashSet<tblRegistroInfracaoImagem>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoRegistroInfracaoImagemTipo { get; set; }

        [Required]
        [StringLength(60)]
        public string Nome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRegistroInfracaoImagem> tblRegistroInfracaoImagem { get; set; }
    }
}
