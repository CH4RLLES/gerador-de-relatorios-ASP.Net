using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorRelatoriosWeb.Infra.Dados.Mapeamento
{
    public class PaginasAcessoMap : IEntityTypeConfiguration<PaginasAcesso>
    {
        public void Configure(EntityTypeBuilder<PaginasAcesso> builder)
        {
            builder.ToTable("PaginasAcessos");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.NomeMenu)
                .IsRequired()
                .HasColumnName("NomeMenu");
            builder.Property(c => c.Controller)
                .IsRequired()
                .HasColumnName("Controller");
            builder.Property(c => c.Desativado)
                .IsRequired()
                .HasColumnName("Desativado");
            builder.Property(c => c.View)
                .IsRequired()
                .HasColumnName("View");
        }
    }
}
