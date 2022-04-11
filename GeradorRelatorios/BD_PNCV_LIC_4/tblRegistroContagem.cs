namespace GeradorRelatorios.BD_PNCV_LIC_4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRegistroContagem")]
    public partial class tblRegistroContagem
    {
        [Key]
        public long CodigoRegistroContagem { get; set; }

        public long CodigoRemessaDados { get; set; }

        public int CodigoRemessaDadosTipo { get; set; }

        public int? CodigoRegistroClasseVeiculo { get; set; }

        public DateTime DataHora { get; set; }

        public byte Hora { get; set; }

        public short? Velocidade { get; set; }

        public virtual tblRegistroClasseVeiculo tblRegistroClasseVeiculo { get; set; }

        public virtual tblRemessaDados tblRemessaDados { get; set; }

        public virtual tblRemessaDadosTipo tblRemessaDadosTipo { get; set; }
    }
}
