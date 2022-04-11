﻿// <auto-generated />
using System;
using GeradorRelatoriosWeb.Infra.Dados.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GeradorRelatoriosWeb.Infra.Dados.Migrations
{
    [DbContext(typeof(SistemaContext))]
    [Migration("20190708180258_usuarios")]
    partial class usuarios
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GeradorRelatoriosWeb.Dominio.Entidades.Sistema.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnName("CPF");

                    b.Property<int>("ControleAcesso")
                        .HasColumnName("ControleAcesso");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("Senha");

                    b.Property<int>("Status")
                        .HasColumnName("Status");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnName("Token");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}