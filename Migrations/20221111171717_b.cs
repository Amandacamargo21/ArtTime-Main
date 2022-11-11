using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtTime.Migrations
{
    public partial class b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAgendamento",
                table: "Agendamentos");

            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "Agendamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dia",
                table: "Agendamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mes",
                table: "Agendamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "Dia",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "Mes",
                table: "Agendamentos");

            migrationBuilder.AddColumn<string>(
                name: "DataAgendamento",
                table: "Agendamentos",
                type: "TEXT",
                nullable: true);
        }
    }
}
