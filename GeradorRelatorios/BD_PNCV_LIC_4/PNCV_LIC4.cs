namespace GeradorRelatorios.BD_PNCV_LIC_4
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PNCV_LIC4 : DbContext
    {
        public PNCV_LIC4()
            : base("name=PNCV_LIC4")
        {
        }

        public virtual DbSet<DatabaseLog> DatabaseLog { get; set; }
        public virtual DbSet<tblRegistroClasseVeiculo> tblRegistroClasseVeiculo { get; set; }
        public virtual DbSet<tblRegistroContagem> tblRegistroContagem { get; set; }
        public virtual DbSet<tblRegistroInfracao> tblRegistroInfracao { get; set; }
        public virtual DbSet<tblRegistroInfracaoImagem> tblRegistroInfracaoImagem { get; set; }
        public virtual DbSet<tblRegistroInfracaoImagemMotivoReinicioSequencia> tblRegistroInfracaoImagemMotivoReinicioSequencia { get; set; }
        public virtual DbSet<tblRegistroInfracaoImagemTipo> tblRegistroInfracaoImagemTipo { get; set; }
        public virtual DbSet<tblRegistroInfracaoVeiculoTipo> tblRegistroInfracaoVeiculoTipo { get; set; }
        public virtual DbSet<tblRegistroTesteEquipamento> tblRegistroTesteEquipamento { get; set; }
        public virtual DbSet<tblRemessaDados> tblRemessaDados { get; set; }
        public virtual DbSet<tblRemessaDadosErro> tblRemessaDadosErro { get; set; }
        public virtual DbSet<tblRemessaDadosEvento> tblRemessaDadosEvento { get; set; }
        public virtual DbSet<tblRemessaDadosIdentificadorErro> tblRemessaDadosIdentificadorErro { get; set; }
        public virtual DbSet<tblRemessaDadosSituacao> tblRemessaDadosSituacao { get; set; }
        public virtual DbSet<tblRemessaDadosSituacaoArquivoRetorno> tblRemessaDadosSituacaoArquivoRetorno { get; set; }
        public virtual DbSet<tblRemessaDadosTipo> tblRemessaDadosTipo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblRegistroClasseVeiculo>()
                .Property(e => e.Classe)
                .IsUnicode(false);

            modelBuilder.Entity<tblRegistroClasseVeiculo>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<tblRegistroInfracao>()
                .Property(e => e.LimiteRegulamentado)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tblRegistroInfracao>()
                .Property(e => e.ValorConsiderado)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tblRegistroInfracao>()
                .Property(e => e.ValorOriginal)
                .HasPrecision(7, 2);

            modelBuilder.Entity<tblRegistroInfracao>()
                .Property(e => e.ValorOriginal80Porcento)
                .HasPrecision(7, 2);

            modelBuilder.Entity<tblRegistroInfracao>()
                .Property(e => e.ValorOriginal60Porcento)
                .HasPrecision(7, 2);

            modelBuilder.Entity<tblRegistroInfracao>()
                .HasMany(e => e.tblRegistroInfracaoImagem)
                .WithRequired(e => e.tblRegistroInfracao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblRegistroInfracaoImagem>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tblRegistroInfracaoImagem>()
                .Property(e => e.NomeFisico)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblRegistroInfracaoImagemMotivoReinicioSequencia>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<tblRegistroInfracaoImagemTipo>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tblRegistroInfracaoImagemTipo>()
                .HasMany(e => e.tblRegistroInfracaoImagem)
                .WithRequired(e => e.tblRegistroInfracaoImagemTipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblRegistroInfracaoVeiculoTipo>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tblRegistroTesteEquipamento>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tblRegistroTesteEquipamento>()
                .Property(e => e.NomeFisico)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblRemessaDados>()
                .Property(e => e.Identificador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblRemessaDados>()
                .Property(e => e.CodigoEquipamentoDNIT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblRemessaDados>()
                .Property(e => e.LocalRodovia)
                .IsUnicode(false);

            modelBuilder.Entity<tblRemessaDados>()
                .Property(e => e.LocalKm)
                .HasPrecision(7, 3);

            modelBuilder.Entity<tblRemessaDados>()
                .Property(e => e.LocalSentidoRodovia)
                .IsUnicode(false);

            modelBuilder.Entity<tblRemessaDados>()
                .Property(e => e.LocalTipoVia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblRemessaDados>()
                .Property(e => e.ArquivoDadosNome)
                .IsUnicode(false);

            modelBuilder.Entity<tblRemessaDados>()
                .Property(e => e.ArquivoRetornoNome)
                .IsUnicode(false);

            modelBuilder.Entity<tblRemessaDados>()
                .Property(e => e.ArquivoRetornoConteudo)
                .IsUnicode(false);

            modelBuilder.Entity<tblRemessaDados>()
                .Property(e => e.EquipamentoAfericaoMarca)
                .IsUnicode(false);

            modelBuilder.Entity<tblRemessaDados>()
                .Property(e => e.EquipamentoAfericaoModelo)
                .IsUnicode(false);

            modelBuilder.Entity<tblRemessaDados>()
                .HasMany(e => e.tblRegistroContagem)
                .WithRequired(e => e.tblRemessaDados)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblRemessaDados>()
                .HasMany(e => e.tblRegistroInfracao)
                .WithRequired(e => e.tblRemessaDados)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblRemessaDados>()
                .HasMany(e => e.tblRegistroTesteEquipamento)
                .WithRequired(e => e.tblRemessaDados)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblRemessaDados>()
                .HasMany(e => e.tblRemessaDadosErro)
                .WithRequired(e => e.tblRemessaDados)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblRemessaDados>()
                .HasMany(e => e.tblRemessaDadosEvento)
                .WithRequired(e => e.tblRemessaDados)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblRemessaDadosErro>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<tblRemessaDadosIdentificadorErro>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<tblRemessaDadosIdentificadorErro>()
                .HasMany(e => e.tblRemessaDadosErro)
                .WithRequired(e => e.tblRemessaDadosIdentificadorErro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblRemessaDadosSituacao>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tblRemessaDadosSituacao>()
                .HasMany(e => e.tblRemessaDados)
                .WithRequired(e => e.tblRemessaDadosSituacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblRemessaDadosSituacao>()
                .HasMany(e => e.tblRemessaDadosEvento)
                .WithRequired(e => e.tblRemessaDadosSituacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblRemessaDadosSituacaoArquivoRetorno>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tblRemessaDadosSituacaoArquivoRetorno>()
                .HasMany(e => e.tblRemessaDados)
                .WithRequired(e => e.tblRemessaDadosSituacaoArquivoRetorno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblRemessaDadosTipo>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tblRemessaDadosTipo>()
                .HasMany(e => e.tblRegistroContagem)
                .WithRequired(e => e.tblRemessaDadosTipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblRemessaDadosTipo>()
                .HasMany(e => e.tblRemessaDados)
                .WithRequired(e => e.tblRemessaDadosTipo)
                .WillCascadeOnDelete(false);
        }
    }
}
