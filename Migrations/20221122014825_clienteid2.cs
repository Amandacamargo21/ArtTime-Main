using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtTime.Migrations
{
    public partial class clienteid2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pessoa",
                table: "Agendamentos");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clientes",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Artistas",
                newName: "ArtistaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Clientes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ArtistaId",
                table: "Artistas",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Pessoa",
                table: "Agendamentos",
                type: "TEXT",
                nullable: true);
        }
    }
}
