using Microsoft.EntityFrameworkCore.Migrations;

namespace GeradorRelatoriosWeb.Infra.Dados.Migrations
{
    public partial class perfilacesso2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_PerfisAcesso_IdPerfil",
                table: "Usuarios",
                column: "IdPerfil",
                principalTable: "PerfisAcesso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
