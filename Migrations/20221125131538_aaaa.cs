using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtTime.Migrations
{
    public partial class aaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "dataAgendamento",
                table: "Agendamentos",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dataAgendamento",
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
    }
}
