using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Match_Game_Oficial.Migrations
{
    public partial class M01ListaDeJogos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Igdb",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Storyline = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstReleaseDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Igdb", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Igdb");
        }
    }
}
