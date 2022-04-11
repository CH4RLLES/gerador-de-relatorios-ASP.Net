using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorRelatoriosWeb.Infra.Dados.Mapeamento
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnName("Email");
            builder.Property(c => c.CPF)
                .IsRequired()
                .HasColumnName("CPF");
            builder.Property(c => c.IdPerfil)
                .HasColumnName("IdPerfil");
            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnName("Nome");
            builder.Property(c => c.Token)
                .IsRequired()
                .HasColumnName("Token");
            builder.Property(c => c.Senha)
                .IsRequired()
                .HasColumnName("Senha");
            builder.Property(c => c.Status)
                .IsRequired()
                .HasColumnName("Status");

        }
    }
}
