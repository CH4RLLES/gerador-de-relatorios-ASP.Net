namespace GeradorRelatorios.DB_SINPEV
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BD_SINPEVContext : DbContext
    {
        public BD_SINPEVContext()
            : base("name=BD_SINPEVContext")
        {
        }

        public virtual DbSet<tblDadosSINPEV> tblDadosSINPEV { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblDadosSINPEV>()
                .Property(e => e.NumeroAIT)
                .IsUnicode(false);

            modelBuilder.Entity<tblDadosSINPEV>()
                .Property(e => e.CodigoPPV)
                .IsUnicode(false);

            modelBuilder.Entity<tblDadosSINPEV>()
                .Property(e => e.ClassificacaoVeiculo)
                .IsUnicode(false);

            modelBuilder.Entity<tblDadosSINPEV>()
                .Property(e => e.PesoDeclaradoVeiculo)
                .IsUnicode(false);

            modelBuilder.Entity<tblDadosSINPEV>()
                .Property(e => e.NumeroAETVeiculo)
                .IsUnicode(false);

            modelBuilder.Entity<tblDadosSINPEV>()
                .Property(e => e.AnoFabricacaoVeiculo)
                .IsUnicode(false);

            modelBuilder.Entity<tblDadosSINPEV>()
                .Property(e => e.AnoModeloVeiculo)
                .IsUnicode(false);

            modelBuilder.Entity<tblDadosSINPEV>()
                .Property(e => e.TaraVeiculo)
                .IsUnicode(false);

            modelBuilder.Entity<tblDadosSINPEV>()
                .Property(e => e.ChassiVeiculo)
                .IsUnicode(false);

            modelBuilder.Entity<tblDadosSINPEV>()
                .Property(e => e.MunicipioOrigemCarga)
                .IsUnicode(false);

            modelBuilder.Entity<tblDadosSINPEV>()
                .Property(e => e.MunicipioDestinoCarga)
                .IsUnicode(false);

            modelBuilder.Entity<tblDadosSINPEV>()
                .Property(e => e.VersaoSGPV)
                .IsUnicode(false);

            modelBuilder.Entity<tblDadosSINPEV>()
                .Property(e => e.CargaTransportada)
                .IsUnicode(false);

            modelBuilder.Entity<tblDadosSINPEV>()
                .Property(e => e.TipoCargaTransportada)
                .IsUnicode(false);

            modelBuilder.Entity<tblDadosSINPEV>()
                .Property(e => e.NotasFiscais)
                .IsUnicode(false);
        }
    }
}
