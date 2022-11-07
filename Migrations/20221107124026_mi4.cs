using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtTime.Migrations
{
    public partial class mi4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contato",
                table: "Artistas");

            migrationBuilder.DropColumn(
                name: "DataAgendamento",
                table: "Artistas");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Artistas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contato",
                table: "Artistas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataAgendamento",
                table: "Artistas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Artistas",
                type: "TEXT",
                nullable: true);
        }
    }
}
