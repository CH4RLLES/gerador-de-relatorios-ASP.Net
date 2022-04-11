namespace GeradorRelatorios.BD_RENAVAM
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RENAVAMContext : DbContext
    {
        public RENAVAMContext()
            : base("name=RENAVAMModel")
        {
        }

        public virtual DbSet<tblRENAVAMEnquadramento> tblRENAVAMEnquadramento { get; set; }
        public virtual DbSet<tblRENAVAMMarcaModeloVeiculo> tblRENAVAMMarcaModeloVeiculo { get; set; }
        public virtual DbSet<tblRENAVAMMunicipio> tblRENAVAMMunicipio { get; set; }
        public virtual DbSet<tblRENAVAMPais> tblRENAVAMPais { get; set; }
        public virtual DbSet<tblRENAVAMTipoVeiculo> tblRENAVAMTipoVeiculo { get; set; }
        public virtual DbSet<tblRENAVAMVeiculoCarroceria> tblRENAVAMVeiculoCarroceria { get; set; }
        public virtual DbSet<tblRENAVAMVeiculoCategoria> tblRENAVAMVeiculoCategoria { get; set; }
        public virtual DbSet<tblRENAVAMVeiculoCor> tblRENAVAMVeiculoCor { get; set; }
        public virtual DbSet<tblRENAVAMVeiculoEspecie> tblRENAVAMVeiculoEspecie { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblRENAVAMEnquadramento>()
                .Property(e => e.CodigoRENAVAMEnquadramentoTexto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblRENAVAMEnquadramento>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<tblRENAVAMEnquadramento>()
                .Property(e => e.AmparoLegal)
                .IsUnicode(false);

            modelBuilder.Entity<tblRENAVAMMarcaModeloVeiculo>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tblRENAVAMMunicipio>()
                .Property(e => e.CodigoRENAVAM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblRENAVAMMunicipio>()
                .Property(e => e.DigitoMunicipio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblRENAVAMMunicipio>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tblRENAVAMMunicipio>()
                .Property(e => e.CodigoRENAVAM5D)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblRENAVAMPais>()
                .Property(e => e.CodigoRENAVAM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblRENAVAMPais>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tblRENAVAMPais>()
                .Property(e => e.Sigla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblRENAVAMTipoVeiculo>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tblRENAVAMVeiculoCarroceria>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tblRENAVAMVeiculoCategoria>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tblRENAVAMVeiculoCor>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tblRENAVAMVeiculoEspecie>()
                .Property(e => e.Nome)
                .IsUnicode(false);
        }
    }
}
