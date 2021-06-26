using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CotoviaSite2.Data.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FotosNoticias",
                columns: table => new
                {
                    FotoFK = table.Column<int>(type: "int", nullable: false),
                    NoticiaFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotosNoticias", x => new { x.FotoFK, x.NoticiaFK });
                    table.ForeignKey(
                        name: "FK_FotosNoticias_Fotografias_FotoFK",
                        column: x => x.FotoFK,
                        principalTable: "Fotografias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FotosNoticias_Noticias_NoticiaFK",
                        column: x => x.NoticiaFK,
                        principalTable: "Noticias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Fotografias",
                columns: new[] { "ID", "AutorFK", "DataFoto", "Foto", "Fotografo", "LocalFoto" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto1", "João Silva", "Tomar" },
                    { 2, null, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto2", "Maria dos Santos", "Leiria" },
                    { 3, null, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto3", "Joana Lopes", "Coimbra" },
                    { 4, null, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto4", "Manuel Oliveira", "Aveiro" },
                    { 5, null, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto5", "João Silva", "Tomar" },
                    { 6, null, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto6", "João Silva", "Tomar" },
                    { 7, null, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto7", "Carolina Cunha", "Lisboa" },
                    { 8, null, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto8", "Francisco Rodrigues", "Porto" },
                    { 9, null, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto9", "Francisco Rodrigues", "Porto" }
                });

            migrationBuilder.InsertData(
                table: "Noticias",
                columns: new[] { "ID", "AutorFK", "Conteudo", "Data", "Estado", "Resumo", "RevisorFK", "Tema", "Titulo", "UtilizadoresID", "UtilizadoresID1" },
                values: new object[,]
                {
                    { 10, 2, "Conteudo 10", new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 10", 3, 0, "Titulo 10", null, null },
                    { 9, 1, "Conteudo 9", new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 9", 2, 0, "Titulo 9", null, null },
                    { 8, 5, "Conteudo 8", new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 8", 3, 0, "Titulo 8", null, null },
                    { 7, 4, "Conteudo 7", new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 7", 3, 0, "Titulo 7", null, null },
                    { 6, 3, "Conteudo 6", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 6", 1, 0, "Titulo 6", null, null },
                    { 3, 2, "Conteudo 3", new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 3", 2, 0, "Titulo 3", null, null },
                    { 4, 1, "Conteudo 4", new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 4", 1, 0, "Titulo 4", null, null },
                    { 2, 2, "Conteudo 2", new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 2", 1, 0, "Titulo 2", null, null },
                    { 1, 4, "Conteudo 1", new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 1", 1, 0, "Titulo 1", null, null },
                    { 5, 5, "Conteudo 5", new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 5", 3, 0, "Titulo 5", null, null }
                });

            migrationBuilder.InsertData(
                table: "Utilizadores",
                columns: new[] { "ID", "Email", "Foto", "Nome" },
                values: new object[,]
                {
                    { 4, "a2002@cotovia.pt", "C:/Imagens/N_Faria_A.jpg", "Nuno Faria" },
                    { 1, "a2101@cotovia.pt", "C:/Imagens/A_Mendonca_A.jpg", "Álvaro Mendonça" },
                    { 2, "a2004@cotovia.pt", "C:/Imagens/C_Domingues_A.jpg", "Cátia Domingues" },
                    { 3, "a2003@cotovia.pt", "C:/Imagens/F_Lopes_A.jpg", "Francisco Lopes" },
                    { 5, "a2001@cotovia.pt", "C:/Imagens/I_Pereira_A.jpg", "Inês Pereira" }
                });

            migrationBuilder.InsertData(
                table: "FotosNoticias",
                columns: new[] { "FotoFK", "NoticiaFK" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 2 },
                    { 8, 3 },
                    { 3, 4 },
                    { 7, 5 },
                    { 1, 6 },
                    { 5, 7 },
                    { 9, 8 },
                    { 2, 9 },
                    { 6, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FotosNoticias_NoticiaFK",
                table: "FotosNoticias",
                column: "NoticiaFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FotosNoticias");

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 10);
        }
    }
}
