using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GeradorRelatoriosWeb.Infra.Dados.Migrations
{
    public partial class perfilacesso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ControleAcesso",
                table: "Usuarios");

            migrationBuilder.AddColumn<Guid>(
                name: "IdPerfil",
                table: "Usuarios",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "PaginasAcessos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Controller = table.Column<string>(nullable: false),
                    View = table.Column<string>(nullable: false),
                    Desativado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaginasAcessos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PerfisAcesso",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfisAcesso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PerfilPaginas",
                columns: table => new
                {
                    IdPagina = table.Column<Guid>(nullable: false),
                    IdPerfil = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilPaginas", x => new { x.IdPagina, x.IdPerfil });
                    table.ForeignKey(
                        name: "FK_PerfilPaginas_PaginasAcessos_IdPagina",
                        column: x => x.IdPagina,
                        principalTable: "PaginasAcessos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerfilPaginas_PerfisAcesso_IdPerfil",
                        column: x => x.IdPerfil,
                        principalTable: "PerfisAcesso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdPerfil",
                table: "Usuarios",
                column: "IdPerfil");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilPaginas_IdPerfil",
                table: "PerfilPaginas",
                column: "IdPerfil");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_PerfisAcesso_IdPerfil",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "PerfilPaginas");

            migrationBuilder.DropTable(
                name: "PaginasAcessos");

            migrationBuilder.DropTable(
                name: "PerfisAcesso");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_IdPerfil",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IdPerfil",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "ControleAcesso",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0);
        }
    }
}
