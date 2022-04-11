using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorRelatoriosWeb.Infra.Dados.Mapeamento
{
    public class PerfilPaginasMap : IEntityTypeConfiguration<PerfilPaginas>
    {
        public void Configure(EntityTypeBuilder<PerfilPaginas> builder)
        {
            builder.ToTable("PerfilPaginas");

            builder.HasKey(c => new { c.IdPagina, c.IdPerfil });

            builder.HasOne(f => f.Perfil)
                .WithMany(a => a.Paginas)
                .HasForeignKey(fk => fk.IdPerfil);
        }
    }
}
