using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Match_Game.Migrations
{
    public partial class Bancoentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ID_Generos",
                table: "Jogos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ModoJogo",
                table: "Jogos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Orcamento",
                table: "Jogos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Plataforma",
                table: "Jogos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID_Generos",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "ModoJogo",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "Orcamento",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "Plataforma",
                table: "Jogos");
        }
    }
}
