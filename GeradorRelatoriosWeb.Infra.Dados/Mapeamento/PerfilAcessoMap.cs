using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorRelatoriosWeb.Infra.Dados.Mapeamento
{
    public class PerfilAcessoMap : IEntityTypeConfiguration<PerfilAcesso>
    {
        public void Configure(EntityTypeBuilder<PerfilAcesso> builder)
        {
            builder.ToTable("PerfisAcesso");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnName("Nome");

            builder.HasMany(a => a.Paginas)
                .WithOne();
        }
    }
}
