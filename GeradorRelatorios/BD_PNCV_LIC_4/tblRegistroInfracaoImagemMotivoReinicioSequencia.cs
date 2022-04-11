namespace GeradorRelatorios.BD_PNCV_LIC_4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRegistroInfracaoImagemMotivoReinicioSequencia")]
    public partial class tblRegistroInfracaoImagemMotivoReinicioSequencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRegistroInfracaoImagemMotivoReinicioSequencia()
        {
            tblRegistroInfracaoImagem = new HashSet<tblRegistroInfracaoImagem>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoRegistroInfracaoImagemMotivoReinicioSequencia { get; set; }

        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRegistroInfracaoImagem> tblRegistroInfracaoImagem { get; set; }
    }
}
