using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Match_Game.Migrations
{
    public partial class FT01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FotoUser",
                table: "Usuarios",
                newName: "FotoUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FotoUsuario",
                table: "Usuarios",
                newName: "FotoUser");
        }
    }
}
