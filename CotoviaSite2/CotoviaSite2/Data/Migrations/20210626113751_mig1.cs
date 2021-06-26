using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CotoviaSite2.Data.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fotografias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataFoto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocalFoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fotografo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutorFK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotografias", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Utilizadores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Noticias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resumo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conteudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Tema = table.Column<int>(type: "int", nullable: false),
                    AutorFK = table.Column<int>(type: "int", nullable: false),
                    RevisorFK = table.Column<int>(type: "int", nullable: false),
                    UtilizadoresID = table.Column<int>(type: "int", nullable: true),
                    UtilizadoresID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticias", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Noticias_Utilizadores_UtilizadoresID",
                        column: x => x.UtilizadoresID,
                        principalTable: "Utilizadores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Noticias_Utilizadores_UtilizadoresID1",
                        column: x => x.UtilizadoresID1,
                        principalTable: "Utilizadores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Noticias_UtilizadoresID",
                table: "Noticias",
                column: "UtilizadoresID");

            migrationBuilder.CreateIndex(
                name: "IX_Noticias_UtilizadoresID1",
                table: "Noticias",
                column: "UtilizadoresID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fotografias");

            migrationBuilder.DropTable(
                name: "Noticias");

            migrationBuilder.DropTable(
                name: "Utilizadores");
        }
    }
}
