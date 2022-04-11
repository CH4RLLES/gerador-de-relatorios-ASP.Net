namespace GeradorRelatorios.BD_PNCV_LIC_4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRegistroClasseVeiculo")]
    public partial class tblRegistroClasseVeiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRegistroClasseVeiculo()
        {
            tblRegistroContagem = new HashSet<tblRegistroContagem>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoRegistroClasseVeiculo { get; set; }

        [Required]
        [StringLength(50)]
        public string Classe { get; set; }

        [StringLength(50)]
        public string Referencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRegistroContagem> tblRegistroContagem { get; set; }
    }
}
