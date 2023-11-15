using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Match_Game_Oficial.Migrations
{
    public partial class AT03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserLink",
                table: "Usuarios",
                newName: "UsuarioLink");

            migrationBuilder.AlterColumn<string>(
            name: "UsuarioLink",
            table: "Usuarios",
            nullable: true, // Isso indica que a coluna pode ser nula
            oldNullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsuarioLink",
                table: "Usuarios",
                newName: "UserLink");
        }
    }
}
