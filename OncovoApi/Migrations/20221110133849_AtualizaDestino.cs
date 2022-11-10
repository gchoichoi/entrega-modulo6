using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OncovoApi.Migrations
{
    public partial class AtualizaDestino : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "estado_pais_nome",
                table: "destinos",
                newName: "estado_pais");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "estado_pais",
                table: "destinos",
                newName: "estado_pais_nome");
        }
    }
}
