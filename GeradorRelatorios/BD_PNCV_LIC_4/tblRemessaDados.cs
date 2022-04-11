namespace GeradorRelatorios.BD_PNCV_LIC_4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblRemessaDados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRemessaDados()
        {
            tblRegistroContagem = new HashSet<tblRegistroContagem>();
            tblRegistroInfracao = new HashSet<tblRegistroInfracao>();
            tblRegistroTesteEquipamento = new HashSet<tblRegistroTesteEquipamento>();
            tblRemessaDadosErro = new HashSet<tblRemessaDadosErro>();
            tblRemessaDadosEvento = new HashSet<tblRemessaDadosEvento>();
        }

        [Key]
        public long CodigoRemessaDados { get; set; }

        public int CodigoRemessaDadosTipo { get; set; }

        public int CodigoRemessaDadosSituacao { get; set; }

        public int CodigoRemessaDadosSituacaoArquivoRetorno { get; set; }

        public int CodigoPNCVEditalLote { get; set; }

        public int? CodigoPNCVEquipamentoFaixa { get; set; }

        public int? CodigoPNCVEquipamentoEstudoTecnicoFaixa { get; set; }

        public int? CodigoInfracaoEquipamentoAfericaoTipo { get; set; }

        public DateTime DataRecebimento { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? DataProcessamento { get; set; }

        [Required]
        [StringLength(12)]
        public string Identificador { get; set; }

        [StringLength(11)]
        public string CodigoEquipamentoDNIT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ColetaDadosData { get; set; }

        [StringLength(50)]
        public string LocalRodovia { get; set; }

        public decimal? LocalKm { get; set; }

        [StringLength(2)]
        public string LocalSentidoRodovia { get; set; }

        [StringLength(1)]
        public string LocalTipoVia { get; set; }

        public byte? LocalNumeroFaixa { get; set; }

        public int QuantidadeRegistros { get; set; }

        public int QuantidadeRegistrosTesteEquipamento { get; set; }

        public int QuantidadeErros { get; set; }

        public bool MedicaoContratoIndicadorApuracao { get; set; }

        [Required]
        [StringLength(100)]
        public string ArquivoDadosNome { get; set; }

        public int ArquivoDadosTamanho { get; set; }

        public DateTime ArquivoDadosDataCriacao { get; set; }

        public bool ArquivoDadosIndicadorRemovidoOrigem { get; set; }

        [StringLength(100)]
        public string ArquivoRetornoNome { get; set; }

        public string ArquivoRetornoConteudo { get; set; }

        public DateTime? ArquivoRetornoDataEnvio { get; set; }

        public int? CodigoUF { get; set; }

        public int? CodigoRodovia { get; set; }

        public int? CodigoRENAVAMMunicipio { get; set; }

        //public DbGeometry Coordenadas { get; set; }

        [StringLength(50)]
        public string EquipamentoAfericaoMarca { get; set; }

        [StringLength(50)]
        public string EquipamentoAfericaoModelo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EquipamentoAfericaoInmetroVerificacaoData { get; set; }

        public bool RegistroInfracaoPreAutuacaoIndicadorProcessamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRegistroContagem> tblRegistroContagem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRegistroInfracao> tblRegistroInfracao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRegistroTesteEquipamento> tblRegistroTesteEquipamento { get; set; }

        public virtual tblRemessaDadosSituacao tblRemessaDadosSituacao { get; set; }

        public virtual tblRemessaDadosSituacaoArquivoRetorno tblRemessaDadosSituacaoArquivoRetorno { get; set; }

        public virtual tblRemessaDadosTipo tblRemessaDadosTipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRemessaDadosErro> tblRemessaDadosErro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRemessaDadosEvento> tblRemessaDadosEvento { get; set; }
    }
}
