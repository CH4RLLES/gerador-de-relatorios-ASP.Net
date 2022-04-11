using System;
using GeradorRelatoriosWeb.Dominio.Entidades.PNCV_LIC_4;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_LIC_4
{
    public partial class BD_SIOR_PNCV_DISP_LIC_4_2018Context : DbContext
    {
        public BD_SIOR_PNCV_DISP_LIC_4_2018Context()
        {
        }

        public BD_SIOR_PNCV_DISP_LIC_4_2018Context(DbContextOptions<BD_SIOR_PNCV_DISP_LIC_4_2018Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AuxRegistroInfracaoAnalise> AuxRegistroInfracaoAnalise { get; set; }
        public virtual DbSet<AuxRemessaDadosRepetida> AuxRemessaDadosRepetida { get; set; }
        public virtual DbSet<AuxRemessaDadosRepetidaRegistroInfracao> AuxRemessaDadosRepetidaRegistroInfracao { get; set; }
        public virtual DbSet<AuxRemessaDadosRepetidaRegistroTesteEquipamento> AuxRemessaDadosRepetidaRegistroTesteEquipamento { get; set; }
        public virtual DbSet<DatabaseLog> DatabaseLog { get; set; }
        public virtual DbSet<TblRegistroClasseVeiculo> TblRegistroClasseVeiculo { get; set; }
        public virtual DbSet<TblRegistroContagem> TblRegistroContagem { get; set; }
        public virtual DbSet<TblRegistroInfracao> TblRegistroInfracao { get; set; }
        public virtual DbSet<TblRegistroInfracaoImagem> TblRegistroInfracaoImagem { get; set; }
        public virtual DbSet<TblRegistroInfracaoImagemMotivoReinicioSequencia> TblRegistroInfracaoImagemMotivoReinicioSequencia { get; set; }
        public virtual DbSet<TblRegistroInfracaoImagemTipo> TblRegistroInfracaoImagemTipo { get; set; }
        public virtual DbSet<TblRegistroInfracaoVeiculoTipo> TblRegistroInfracaoVeiculoTipo { get; set; }
        public virtual DbSet<TblRegistroTesteEquipamento> TblRegistroTesteEquipamento { get; set; }
        public virtual DbSet<TblRemessaDados> TblRemessaDados { get; set; }
        public virtual DbSet<TblRemessaDadosErro> TblRemessaDadosErro { get; set; }
        public virtual DbSet<TblRemessaDadosEvento> TblRemessaDadosEvento { get; set; }
        public virtual DbSet<TblRemessaDadosIdentificadorErro> TblRemessaDadosIdentificadorErro { get; set; }
        public virtual DbSet<TblRemessaDadosSituacao> TblRemessaDadosSituacao { get; set; }
        public virtual DbSet<TblRemessaDadosSituacaoArquivoRetorno> TblRemessaDadosSituacaoArquivoRetorno { get; set; }
        public virtual DbSet<TblRemessaDadosTipo> TblRemessaDadosTipo { get; set; }

        // Unable to generate entity type for table 'dbo.AUX_RemessaDados_REPETIDA_RegistroInfracao_Imagem'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=10.100.10.144\\SIOR;initial catalog=BD_SIOR_PNCV_DISP_LIC_4_2018;persist security info=True;user id=nestor.santos;password=Ns92878@;MultipleActiveResultSets=True;App=EntityFramework;"
                    , x => x.CommandTimeout(180));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<AuxRegistroInfracaoAnalise>(entity =>
            {
                entity.HasKey(e => e.CodigoRegistroInfracao)
                    .HasName("prkAUX_RegistroInfracao_ANALISE");

                entity.ToTable("AUX_RegistroInfracao_ANALISE");

                entity.Property(e => e.CodigoRegistroInfracao).ValueGeneratedNever();

                entity.Property(e => e.CodigoRenavamunidadeMedida).HasColumnName("CodigoRENAVAMUnidadeMedida");

                entity.Property(e => e.DataHora).HasColumnType("datetime");

                entity.Property(e => e.ImagemCometimentoNome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImagemCometimentoNomeCalculado)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InsertImagemCometimentoNome)
                    .HasColumnName("INSERT_ImagemCometimentoNome")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InsertImagemCometimentoNomeFisico)
                    .HasColumnName("INSERT_ImagemCometimentoNomeFisico")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.InsertImagemCometimentoSequencia).HasColumnName("INSERT_ImagemCometimentoSequencia");

                entity.Property(e => e.InsertImagemCometimentoTamanho).HasColumnName("INSERT_ImagemCometimentoTamanho");

                entity.Property(e => e.LimiteRegulamentado).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorConsiderado).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorOriginal).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal60Porcento).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal80Porcento).HasColumnType("decimal(7, 2)");
            });

            modelBuilder.Entity<AuxRemessaDadosRepetida>(entity =>
            {
                entity.HasKey(e => e.CodigoRemessaDados)
                    .HasName("PK_AUX_RemessaDados_DUPLICADA");

                entity.ToTable("AUX_RemessaDados_REPETIDA");

                entity.Property(e => e.CodigoRemessaDados).ValueGeneratedNever();

                entity.Property(e => e.ArquivoDadosDataCriacao).HasColumnType("datetime");

                entity.Property(e => e.ArquivoDadosNome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEquipamentoDnit)
                    .IsRequired()
                    .HasColumnName("CodigoEquipamentoDNIT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncveditalLote).HasColumnName("CodigoPNCVEditalLote");

                entity.Property(e => e.CodigoPncvequipamentoFaixa).HasColumnName("CodigoPNCVEquipamentoFaixa");

                entity.Property(e => e.ColetaDadosData).HasColumnType("date");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataProcessamento).HasColumnType("datetime");

                entity.Property(e => e.DataRecebimento).HasColumnType("datetime");

                entity.Property(e => e.Identificador)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LocalSentidoRodovia)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LocalTipoVia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuxRemessaDadosRepetidaRegistroInfracao>(entity =>
            {
                entity.HasKey(e => e.CodigoRegistroInfracao)
                    .HasName("PK_AUX_RemessaDados_DUPLICADA_RegistroInfracao");

                entity.ToTable("AUX_RemessaDados_REPETIDA_RegistroInfracao");

                entity.Property(e => e.CodigoRegistroInfracao).ValueGeneratedNever();

                entity.Property(e => e.DataHora).HasColumnType("datetime");

                entity.Property(e => e.ImagemCometimentoNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImagemCometimentoNomeFisico)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ImagemCometimentoSequencia)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.NumeroAutoInfracao)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuxRemessaDadosRepetidaRegistroTesteEquipamento>(entity =>
            {
                entity.HasKey(e => e.CodigoRegistroTesteEquipamento)
                    .HasName("PK_AUX_RemessaDados_DUPLICADA_RegistroTesteEquipamento");

                entity.ToTable("AUX_RemessaDados_REPETIDA_RegistroTesteEquipamento");

                entity.Property(e => e.CodigoRegistroTesteEquipamento).ValueGeneratedNever();

                entity.Property(e => e.DataHora).HasColumnType("datetime");

                entity.Property(e => e.ImagemCometimentoNomeFisico)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ImagemNome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImagemSequencia)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<DatabaseLog>(entity =>
            {
                entity.HasKey(e => e.DatabaseLogId)
                    .HasName("prk_DatabaseLog_DatabaseLogID")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.DatabaseLogId).HasColumnName("DatabaseLogID");

                entity.Property(e => e.DatabaseUser)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Object).HasMaxLength(128);

                entity.Property(e => e.PostTime).HasColumnType("datetime");

                entity.Property(e => e.Schema).HasMaxLength(128);

                entity.Property(e => e.Tsql)
                    .IsRequired()
                    .HasColumnName("TSQL");

                entity.Property(e => e.XmlEvent)
                    .IsRequired()
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<TblRegistroClasseVeiculo>(entity =>
            {
                entity.HasKey(e => e.CodigoRegistroClasseVeiculo)
                    .HasName("prkRegistroClasseVeiculo");

                entity.ToTable("tblRegistroClasseVeiculo");

                entity.Property(e => e.CodigoRegistroClasseVeiculo).ValueGeneratedNever();

                entity.Property(e => e.Classe)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRegistroContagem>(entity =>
            {
                entity.HasKey(e => e.CodigoRegistroContagem)
                    .HasName("prkRegistroContagem");

                entity.ToTable("tblRegistroContagem");

                entity.HasIndex(e => e.CodigoRemessaDados)
                    .HasName("idxRegistroContagem_RemessaDados");

                entity.HasIndex(e => new { e.CodigoRemessaDados, e.Hora })
                    .HasName("idxRegistroContagem_ApuracaoMedicao");

                entity.Property(e => e.DataHora).HasColumnType("datetime");

                entity.HasOne(d => d.CodigoRegistroClasseVeiculoNavigation)
                    .WithMany(p => p.TblRegistroContagem)
                    .HasForeignKey(d => d.CodigoRegistroClasseVeiculo)
                    .HasConstraintName("frkRegistroContagem_RegistroClasseVeiculo");

                entity.HasOne(d => d.CodigoRemessaDadosNavigation)
                    .WithMany(p => p.TblRegistroContagem)
                    .HasForeignKey(d => d.CodigoRemessaDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkRegistroContagem_RemessaDados");

                entity.HasOne(d => d.CodigoRemessaDadosTipoNavigation)
                    .WithMany(p => p.TblRegistroContagem)
                    .HasForeignKey(d => d.CodigoRemessaDadosTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkRegistroContagem_RemessaDadosTipo");
            });

            modelBuilder.Entity<TblRegistroInfracao>(entity =>
            {
                entity.HasKey(e => e.CodigoRegistroInfracao)
                    .HasName("prkRegistroInfracao");

                entity.ToTable("tblRegistroInfracao");

                entity.HasIndex(e => e.CodigoRemessaDados)
                    .HasName("idxRegistroInfracao_RemessaDados");

                entity.HasIndex(e => new { e.CodigoRemessaDados, e.Hora })
                    .HasName("idxRegistroInfracao_ApuracaoMedicao");

                entity.Property(e => e.CodigoRenavamunidadeMedida).HasColumnName("CodigoRENAVAMUnidadeMedida");

                entity.Property(e => e.DataHora).HasColumnType("datetime");

                entity.Property(e => e.LimiteRegulamentado).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorConsiderado).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorOriginal).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal60Porcento).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ValorOriginal80Porcento).HasColumnType("decimal(7, 2)");

                entity.HasOne(d => d.CodigoRegistroInfracaoVeiculoTipoNavigation)
                    .WithMany(p => p.TblRegistroInfracao)
                    .HasForeignKey(d => d.CodigoRegistroInfracaoVeiculoTipo)
                    .HasConstraintName("frkRegistroInfracao_VeiculoTipo");

                entity.HasOne(d => d.CodigoRemessaDadosNavigation)
                    .WithMany(p => p.TblRegistroInfracao)
                    .HasForeignKey(d => d.CodigoRemessaDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkRegistroInfracao_RemessaDados");
            });

            modelBuilder.Entity<TblRegistroInfracaoImagem>(entity =>
            {
                entity.HasKey(e => e.CodigoRegistroInfracaoImagem)
                    .HasName("prkRegistroInfracaoImagem");

                entity.ToTable("tblRegistroInfracaoImagem");

                entity.HasIndex(e => e.CodigoRegistroInfracao)
                    .HasName("idxRegistroInfracaoImagem");

                entity.Property(e => e.DataHora).HasColumnType("datetime");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoRegistroInfracaoNavigation)
                    .WithMany(p => p.TblRegistroInfracaoImagem)
                    .HasForeignKey(d => d.CodigoRegistroInfracao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkRegistroInfracaoImagem_RegistroInfracao");

                entity.HasOne(d => d.CodigoRegistroInfracaoImagemMotivoReinicioSequenciaNavigation)
                    .WithMany(p => p.TblRegistroInfracaoImagem)
                    .HasForeignKey(d => d.CodigoRegistroInfracaoImagemMotivoReinicioSequencia)
                    .HasConstraintName("frkRegistroInfracaoImagem_RegistroInfracaoImagemMotivoReinicioSequencia");

                entity.HasOne(d => d.CodigoRegistroInfracaoImagemTipoNavigation)
                    .WithMany(p => p.TblRegistroInfracaoImagem)
                    .HasForeignKey(d => d.CodigoRegistroInfracaoImagemTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkRegistroInfracaoImagem_RegistroInfracaoImagemTipo");
            });

            modelBuilder.Entity<TblRegistroInfracaoImagemMotivoReinicioSequencia>(entity =>
            {
                entity.HasKey(e => e.CodigoRegistroInfracaoImagemMotivoReinicioSequencia)
                    .HasName("prkRegistroInfracaoImagemMotivoReinicioSequencia");

                entity.ToTable("tblRegistroInfracaoImagemMotivoReinicioSequencia");

                entity.Property(e => e.CodigoRegistroInfracaoImagemMotivoReinicioSequencia).ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRegistroInfracaoImagemTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoRegistroInfracaoImagemTipo)
                    .HasName("prkPNCVRegistroInfracaoImagemTipo");

                entity.ToTable("tblRegistroInfracaoImagemTipo");

                entity.Property(e => e.CodigoRegistroInfracaoImagemTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRegistroInfracaoVeiculoTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoRegistroInfracaoVeiculoTipo)
                    .HasName("prkPNCVRegistroInfracaoVeiculoTipo");

                entity.ToTable("tblRegistroInfracaoVeiculoTipo");

                entity.Property(e => e.CodigoRegistroInfracaoVeiculoTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRegistroTesteEquipamento>(entity =>
            {
                entity.HasKey(e => e.CodigoRegistroTesteEquipamento)
                    .HasName("prkRegistroTesteEquipamento");

                entity.ToTable("tblRegistroTesteEquipamento");

                entity.HasIndex(e => e.CodigoRemessaDados)
                    .HasName("idxRegistroTesteEquipamento_RemessaDados");

                entity.HasIndex(e => new { e.CodigoRemessaDados, e.Hora })
                    .HasName("idxRegistroTesteEquipamento_ApuracaoMedicao");

                entity.Property(e => e.DataHora).HasColumnType("datetime");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFisico)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoRemessaDadosNavigation)
                    .WithMany(p => p.TblRegistroTesteEquipamento)
                    .HasForeignKey(d => d.CodigoRemessaDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkRegistroTesteEquipamento_RemessaDados");
            });

            modelBuilder.Entity<TblRemessaDados>(entity =>
            {
                entity.HasKey(e => e.CodigoRemessaDados)
                    .HasName("prkRemessaDados");

                entity.ToTable("tblRemessaDados");

                entity.HasIndex(e => new { e.CodigoRemessaDados, e.CodigoRemessaDadosTipo, e.CodigoPncvequipamentoFaixa, e.ColetaDadosData, e.CodigoRemessaDadosSituacao, e.MedicaoContratoIndicadorApuracao, e.CodigoPncveditalLote })
                    .HasName("idxRemessaDados_ApuracaoMedicao");

                entity.Property(e => e.ArquivoDadosDataCriacao).HasColumnType("datetime");

                entity.Property(e => e.ArquivoDadosNome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ArquivoRetornoConteudo).IsUnicode(false);

                entity.Property(e => e.ArquivoRetornoDataEnvio).HasColumnType("datetime");

                entity.Property(e => e.ArquivoRetornoNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEquipamentoDnit)
                    .HasColumnName("CodigoEquipamentoDNIT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPncveditalLote).HasColumnName("CodigoPNCVEditalLote");

                entity.Property(e => e.CodigoPncvequipamentoEstudoTecnicoFaixa).HasColumnName("CodigoPNCVEquipamentoEstudoTecnicoFaixa");

                entity.Property(e => e.CodigoPncvequipamentoFaixa).HasColumnName("CodigoPNCVEquipamentoFaixa");

                entity.Property(e => e.CodigoRenavammunicipio).HasColumnName("CodigoRENAVAMMunicipio");

                entity.Property(e => e.CodigoUf).HasColumnName("CodigoUF");

                entity.Property(e => e.ColetaDadosData).HasColumnType("date");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataProcessamento).HasColumnType("datetime");

                entity.Property(e => e.DataRecebimento).HasColumnType("datetime");

                entity.Property(e => e.EquipamentoAfericaoInmetroVerificacaoData).HasColumnType("date");

                entity.Property(e => e.EquipamentoAfericaoMarca)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EquipamentoAfericaoModelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Identificador)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LocalKm).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.LocalRodovia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalSentidoRodovia)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LocalTipoVia)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoRemessaDadosSituacaoNavigation)
                    .WithMany(p => p.TblRemessaDados)
                    .HasForeignKey(d => d.CodigoRemessaDadosSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkRemessaDados_RemessaDadosSituacao");

                entity.HasOne(d => d.CodigoRemessaDadosSituacaoArquivoRetornoNavigation)
                    .WithMany(p => p.TblRemessaDados)
                    .HasForeignKey(d => d.CodigoRemessaDadosSituacaoArquivoRetorno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkRemessaDados_RemessaDadosSituacaoRetorno");

                entity.HasOne(d => d.CodigoRemessaDadosTipoNavigation)
                    .WithMany(p => p.TblRemessaDados)
                    .HasForeignKey(d => d.CodigoRemessaDadosTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkRemessaDados_RemessaDadosTipo");
            });

            modelBuilder.Entity<TblRemessaDadosErro>(entity =>
            {
                entity.HasKey(e => e.CodigoRemessaDadosErro)
                    .HasName("prkRemessaDadosErro");

                entity.ToTable("tblRemessaDadosErro");

                entity.HasIndex(e => e.CodigoRemessaDados)
                    .HasName("idxRemessaDadosErro");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoRemessaDadosNavigation)
                    .WithMany(p => p.TblRemessaDadosErro)
                    .HasForeignKey(d => d.CodigoRemessaDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkRemessaDadosErro_RemessaDados");

                entity.HasOne(d => d.CodigoRemessaDadosIdentificadorErroNavigation)
                    .WithMany(p => p.TblRemessaDadosErro)
                    .HasForeignKey(d => d.CodigoRemessaDadosIdentificadorErro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkRemessaDadosErro_RemessaDadosIdentificadorErro");
            });

            modelBuilder.Entity<TblRemessaDadosEvento>(entity =>
            {
                entity.HasKey(e => e.CodigoRemessaDadosEvento)
                    .HasName("prkRemessaDadosEvento");

                entity.ToTable("tblRemessaDadosEvento");

                entity.HasIndex(e => e.CodigoRemessaDados)
                    .HasName("idxRemessaDadosEvento");

                entity.Property(e => e.DataEvento).HasColumnType("datetime");

                entity.HasOne(d => d.CodigoRemessaDadosNavigation)
                    .WithMany(p => p.TblRemessaDadosEvento)
                    .HasForeignKey(d => d.CodigoRemessaDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkRemessaDadosEvento_RemessaDados");

                entity.HasOne(d => d.CodigoRemessaDadosSituacaoNavigation)
                    .WithMany(p => p.TblRemessaDadosEvento)
                    .HasForeignKey(d => d.CodigoRemessaDadosSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkRemessaDadosEvento_RemessaDadosSituacao");
            });

            modelBuilder.Entity<TblRemessaDadosIdentificadorErro>(entity =>
            {
                entity.HasKey(e => e.CodigoRemessaDadosIdentificadorErro)
                    .HasName("prkRemessaDadosIdentificadorErro");

                entity.ToTable("tblRemessaDadosIdentificadorErro");

                entity.Property(e => e.CodigoRemessaDadosIdentificadorErro).ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRemessaDadosSituacao>(entity =>
            {
                entity.HasKey(e => e.CodigoRemessaDadosSituacao)
                    .HasName("prkRemessaDadosSituacao");

                entity.ToTable("tblRemessaDadosSituacao");

                entity.Property(e => e.CodigoRemessaDadosSituacao).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRemessaDadosSituacaoArquivoRetorno>(entity =>
            {
                entity.HasKey(e => e.CodigoRemessaDadosSituacaoArquivoRetorno)
                    .HasName("prkRemessaDadosSituacaoArquivoRetorno");

                entity.ToTable("tblRemessaDadosSituacaoArquivoRetorno");

                entity.Property(e => e.CodigoRemessaDadosSituacaoArquivoRetorno).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRemessaDadosTipo>(entity =>
            {
                entity.HasKey(e => e.CodigoRemessaDadosTipo)
                    .HasName("prkRemessaDadosTipo");

                entity.ToTable("tblRemessaDadosTipo");

                entity.Property(e => e.CodigoRemessaDadosTipo).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
