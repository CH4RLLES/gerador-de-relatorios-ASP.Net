using Microsoft.EntityFrameworkCore.Migrations;

namespace GeradorRelatoriosWeb.Infra.Dados.Migrations
{
    public partial class menu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeMenu",
                table: "PaginasAcessos",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeMenu",
                table: "PaginasAcessos");
        }
    }
}
