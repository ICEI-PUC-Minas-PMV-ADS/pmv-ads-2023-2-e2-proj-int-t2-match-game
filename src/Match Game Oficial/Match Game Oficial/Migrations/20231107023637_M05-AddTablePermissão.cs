using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Match_Game_Oficial.Migrations
{
    public partial class M05AddTablePermissão : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Perfil",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "Usuarios");
        }
    }
}
