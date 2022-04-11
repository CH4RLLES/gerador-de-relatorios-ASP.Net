using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using GeradorRelatoriosWeb.Infra.Dados.Mapeamento;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorRelatoriosWeb.Infra.Dados.Contexto
{
    public class SistemaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
             //   optionsBuilder.UseSqlServer("server=DFCPT0054D\\BDLOCAL;database=GeradorRelsWeb;trusted_connection=true;"); // Máquina local - Thiago
            //if (!optionsBuilder.IsConfigured)
            //    optionsBuilder.UseSqlServer("server=DFTYPE00101M\\CPTSERVER;database=GeradorRelsWeb;trusted_connection=true;"); // Servidor impressão
            //if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("server=DFCPT000407D;database=GeradorRelsWeb;trusted_connection=true;"); // Novo servidor
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<PaginasAcesso>(new PaginasAcessoMap().Configure);
            modelBuilder.Entity<PerfilAcesso>(new PerfilAcessoMap().Configure);
            modelBuilder.Entity<PerfilPaginas>(new PerfilPaginasMap().Configure);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PaginasAcesso> PaginasAcessos { get; set; }
        public DbSet<PerfilAcesso> PerfisAcesso { get; set; }
        public DbSet<PerfilPaginas> PerfilPaginas { get; set; }
    }
}
