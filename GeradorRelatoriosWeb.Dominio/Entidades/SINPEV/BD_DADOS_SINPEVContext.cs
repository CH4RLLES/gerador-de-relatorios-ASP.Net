using System;
using GeradorRelatoriosWeb.Dominio.Entidades.SINPEV;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SINPEV
{
    public partial class BD_DADOS_SINPEVContext : DbContext
    {
        public BD_DADOS_SINPEVContext()
        {
        }

        public BD_DADOS_SINPEVContext(DbContextOptions<BD_DADOS_SINPEVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDadosSinpev> TblDadosSinpev { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=10.100.10.144\\SIOR;initial catalog=BD_DADOS_SINPEV;persist security info=True;user id=nestor.santos;password=​Ns92878@;MultipleActiveResultSets=True;App=EntityFramework"
                    , x => x.CommandTimeout(180));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<TblDadosSinpev>(entity =>
            {
                entity.HasKey(e => e.NumeroAit);

                entity.ToTable("tblDadosSINPEV");

                entity.Property(e => e.NumeroAit)
                    .HasColumnName("NumeroAIT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AnoFabricacaoVeiculo)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AnoModeloVeiculo)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CargaTransportada)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ChassiVeiculo)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.ClassificacaoVeiculo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPpv)
                    .HasColumnName("CodigoPPV")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MunicipioDestinoCarga)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MunicipioOrigemCarga)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NotasFiscais)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NumRemessaSgpv).HasColumnName("NumRemessaSGPV");

                entity.Property(e => e.NumeroAetveiculo)
                    .HasColumnName("NumeroAETVeiculo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PesoDeclaradoVeiculo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TaraVeiculo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCargaTransportada)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.VersaoSgpv)
                    .HasColumnName("VersaoSGPV")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
        }
    }
}
