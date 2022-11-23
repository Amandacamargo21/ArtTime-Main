using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtTime.Migrations
{
    public partial class clienteid3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Artistas",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "LocalDaTattoo",
                table: "Agendamentos",
                newName: "localDaTattoo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Artistas",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "localDaTattoo",
                table: "Agendamentos",
                newName: "LocalDaTattoo");
        }
    }
}
