using System;
using GeradorRelatoriosWeb.Dominio.Entidades.RENAVAM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GeradorRelatoriosWeb.Dominio.Entidades.RENAVAM
{
    public partial class BD_SIOR_RENAVAMContext : DbContext
    {
        public BD_SIOR_RENAVAMContext()
        {
        }

        public BD_SIOR_RENAVAMContext(DbContextOptions<BD_SIOR_RENAVAMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblRenavamenquadramento> TblRenavamenquadramento { get; set; }
        public virtual DbSet<TblRenavammarcaModeloVeiculo> TblRenavammarcaModeloVeiculo { get; set; }
        public virtual DbSet<TblRenavammunicipio> TblRenavammunicipio { get; set; }
        public virtual DbSet<TblRenavampais> TblRenavampais { get; set; }
        public virtual DbSet<TblRenavamtipoVeiculo> TblRenavamtipoVeiculo { get; set; }
        public virtual DbSet<TblRenavamveiculoCarroceria> TblRenavamveiculoCarroceria { get; set; }
        public virtual DbSet<TblRenavamveiculoCategoria> TblRenavamveiculoCategoria { get; set; }
        public virtual DbSet<TblRenavamveiculoCor> TblRenavamveiculoCor { get; set; }
        public virtual DbSet<TblRenavamveiculoEspecie> TblRenavamveiculoEspecie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=10.100.10.144\\SIOR;initial catalog=BD_SIOR_RENAVAM;persist security info=True;user id=nestor.santos;password=Ns92878@;MultipleActiveResultSets=True;App=EntityFramework;"
                    , x => x.CommandTimeout(180));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<TblRenavamenquadramento>(entity =>
            {
                entity.HasKey(e => e.CodigoRenavamenquadramento)
                    .HasName("prkRENAVAMEnquadramento");

                entity.ToTable("tblRENAVAMEnquadramento");

                entity.Property(e => e.CodigoRenavamenquadramento)
                    .HasColumnName("CodigoRENAVAMEnquadramento")
                    .ValueGeneratedNever();

                entity.Property(e => e.AmparoLegal)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRenavamenquadramentoTexto)
                    .IsRequired()
                    .HasColumnName("CodigoRENAVAMEnquadramentoTexto")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRenavammarcaModeloVeiculo>(entity =>
            {
                entity.HasKey(e => e.CodigoRenavammarcaModeloVeiculo)
                    .HasName("prkRENAVAMMarcaModeloVeiculo");

                entity.ToTable("tblRENAVAMMarcaModeloVeiculo");

                entity.Property(e => e.CodigoRenavammarcaModeloVeiculo)
                    .HasColumnName("CodigoRENAVAMMarcaModeloVeiculo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRenavammunicipio>(entity =>
            {
                entity.HasKey(e => e.CodigoRenavammunicipio)
                    .HasName("prkRENAVAMMunicipio");

                entity.ToTable("tblRENAVAMMunicipio");

                entity.Property(e => e.CodigoRenavammunicipio)
                    .HasColumnName("CodigoRENAVAMMunicipio")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodigoBaseUf).HasColumnName("CodigoBaseUF");

                entity.Property(e => e.CodigoRenavam)
                    .HasColumnName("CodigoRENAVAM")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRenavam5d)
                    .HasColumnName("CodigoRENAVAM5D")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DigitoMunicipio)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRenavampais>(entity =>
            {
                entity.HasKey(e => e.CodigoRenavampais);

                entity.ToTable("tblRENAVAMPais");

                entity.Property(e => e.CodigoRenavampais)
                    .HasColumnName("CodigoRENAVAMPais")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodigoRenavam)
                    .IsRequired()
                    .HasColumnName("CodigoRENAVAM")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRenavamtipoVeiculo>(entity =>
            {
                entity.HasKey(e => e.CodigoRenavamtipoVeiculo)
                    .HasName("prkRENAVAMTipoVeiculo");

                entity.ToTable("tblRENAVAMTipoVeiculo");

                entity.Property(e => e.CodigoRenavamtipoVeiculo)
                    .HasColumnName("CodigoRENAVAMTipoVeiculo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRenavamveiculoCarroceria>(entity =>
            {
                entity.HasKey(e => e.CodigoRenavamveiculoCarroceria)
                    .HasName("prkRENAVAMVeiculoCarroceria");

                entity.ToTable("tblRENAVAMVeiculoCarroceria");

                entity.Property(e => e.CodigoRenavamveiculoCarroceria)
                    .HasColumnName("CodigoRENAVAMVeiculoCarroceria")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRenavamveiculoCategoria>(entity =>
            {
                entity.HasKey(e => e.CodigoRenavamveiculoCategoria)
                    .HasName("prkRENAVAMVeiculoCategoria");

                entity.ToTable("tblRENAVAMVeiculoCategoria");

                entity.Property(e => e.CodigoRenavamveiculoCategoria)
                    .HasColumnName("CodigoRENAVAMVeiculoCategoria")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRenavamveiculoCor>(entity =>
            {
                entity.HasKey(e => e.CodigoRenavamveiculoCor)
                    .HasName("prkRENAVAMVeiculoCor");

                entity.ToTable("tblRENAVAMVeiculoCor");

                entity.Property(e => e.CodigoRenavamveiculoCor)
                    .HasColumnName("CodigoRENAVAMVeiculoCor")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRenavamveiculoEspecie>(entity =>
            {
                entity.HasKey(e => e.CodigoRenavamveiculoEspecie)
                    .HasName("prkRENAVAMVeiculoEspecie");

                entity.ToTable("tblRENAVAMVeiculoEspecie");

                entity.Property(e => e.CodigoRenavamveiculoEspecie)
                    .HasColumnName("CodigoRENAVAMVeiculoEspecie")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
