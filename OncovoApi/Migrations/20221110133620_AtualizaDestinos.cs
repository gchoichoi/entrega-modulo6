using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OncovoApi.Migrations
{
    public partial class AtualizaDestinos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Destinos",
                table: "Destinos");

            migrationBuilder.RenameTable(
                name: "Destinos",
                newName: "destinos");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "destinos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "EstadoPaisNome",
                table: "destinos",
                newName: "estado_pais_nome");

            migrationBuilder.RenameColumn(
                name: "CidadeNome",
                table: "destinos",
                newName: "cidade");

            migrationBuilder.AddPrimaryKey(
                name: "PK_destinos",
                table: "destinos",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_destinos",
                table: "destinos");

            migrationBuilder.RenameTable(
                name: "destinos",
                newName: "Destinos");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Destinos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "estado_pais_nome",
                table: "Destinos",
                newName: "EstadoPaisNome");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "Destinos",
                newName: "CidadeNome");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Destinos",
                table: "Destinos",
                column: "Id");
        }
    }
}
