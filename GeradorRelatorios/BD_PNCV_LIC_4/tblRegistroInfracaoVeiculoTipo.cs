namespace GeradorRelatorios.BD_PNCV_LIC_4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRegistroInfracaoVeiculoTipo")]
    public partial class tblRegistroInfracaoVeiculoTipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRegistroInfracaoVeiculoTipo()
        {
            tblRegistroInfracao = new HashSet<tblRegistroInfracao>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoRegistroInfracaoVeiculoTipo { get; set; }

        [Required]
        [StringLength(10)]
        public string Nome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRegistroInfracao> tblRegistroInfracao { get; set; }
    }
}
