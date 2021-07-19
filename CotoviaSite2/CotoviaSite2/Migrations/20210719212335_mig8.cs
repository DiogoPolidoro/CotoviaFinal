using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CotoviaSite2.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FotosNoticias",
                keyColumns: new[] { "FotoFK", "NoticiaFK" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "FotosNoticias",
                keyColumns: new[] { "FotoFK", "NoticiaFK" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "FotosNoticias",
                keyColumns: new[] { "FotoFK", "NoticiaFK" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "FotosNoticias",
                keyColumns: new[] { "FotoFK", "NoticiaFK" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "FotosNoticias",
                keyColumns: new[] { "FotoFK", "NoticiaFK" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "FotosNoticias",
                keyColumns: new[] { "FotoFK", "NoticiaFK" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "FotosNoticias",
                keyColumns: new[] { "FotoFK", "NoticiaFK" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "FotosNoticias",
                keyColumns: new[] { "FotoFK", "NoticiaFK" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "FotosNoticias",
                keyColumns: new[] { "FotoFK", "NoticiaFK" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "FotosNoticias",
                keyColumns: new[] { "FotoFK", "NoticiaFK" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 8);

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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "ceca60e6-2d09-430b-acb1-80f43c5de512");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "r",
                column: "ConcurrencyStamp",
                value: "825b2de5-3230-4015-a92c-6a67d16f2059");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "eb555e3a-9032-444b-ab3d-d4f57925dcd0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "r",
                column: "ConcurrencyStamp",
                value: "4c74565e-b00c-4064-908c-41f8e14d2030");

            migrationBuilder.InsertData(
                table: "Fotografias",
                columns: new[] { "ID", "DataFoto", "Foto", "Fotografo", "LocalFoto", "NomeFoto" },
                values: new object[,]
                {
                    { 9, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto9", "Francisco Rodrigues", "Porto", "Foto9" },
                    { 8, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto8", "Francisco Rodrigues", "Porto", "Foto8" },
                    { 7, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto7", "Carolina Cunha", "Lisboa", "Foto7" },
                    { 1, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto1", "João Silva", "Tomar", "Foto1" },
                    { 5, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto5", "João Silva", "Tomar", "Foto5" },
                    { 4, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto4", "Manuel Oliveira", "Aveiro", "Foto4" },
                    { 3, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto3", "Joana Lopes", "Coimbra", "Foto3" },
                    { 2, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto2", "Maria dos Santos", "Leiria", "Foto2" },
                    { 6, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto6", "João Silva", "Tomar", "Foto6" }
                });

            migrationBuilder.InsertData(
                table: "Utilizadores",
                columns: new[] { "ID", "Cargo", "Email", "Foto", "Nome", "UserID" },
                values: new object[,]
                {
                    { 2, 1, "r2000@cotovia.pt", "C:/Imagens/foto2", "Manuel Lopes", null },
                    { 3, 1, "r2001@cotovia.pt", "C:/Imagens/foto3", "Raquel Andrade", null },
                    { 4, 1, "r2002@cotovia.pt", "C:/Imagens/foto4", "Ana Gomes", null },
                    { 5, 0, "a2001@cotovia.pt", "C:/Imagens/foto5", "João Maria", null },
                    { 6, 0, "a2002@cotovia.pt", "C:/Imagens/foto6", "Carlos Pinha", null },
                    { 7, 1, "r2003@cotovia.pt", "C:/Imagens/foto7", "Maria Antónia", null },
                    { 8, 0, "a2003@cotovia.pt", "C:/Imagens/foto8", "Giselle Marie", null },
                    { 1, 0, "a2000@cotovia.pt", "C:/Imagens/foto1", "António Maria", null }
                });

            migrationBuilder.InsertData(
                table: "Noticias",
                columns: new[] { "ID", "AutorFK", "Conteudo", "Data", "Estado", "Resumo", "RevisorFK", "Tema", "Titulo" },
                values: new object[,]
                {
                    { 4, 1, "Conteudo 4", new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 4", 1, 6, "Titulo 4" },
                    { 2, 2, "Conteudo 2", new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 2", 1, 4, "Titulo 2" },
                    { 3, 2, "Conteudo 3", new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Resumo 3", 2, 2, "Titulo 3" },
                    { 9, 1, "Conteudo 9", new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Resumo 9", 2, 7, "Titulo 9" },
                    { 6, 3, "Conteudo 6", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Resumo 6", 1, 3, "Titulo 6" },
                    { 10, 2, "Conteudo 10", new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Resumo 10", 3, 8, "Titulo 10" },
                    { 1, 4, "Conteudo 1", new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 1", 1, 0, "Titulo 1" },
                    { 7, 4, "Conteudo 7", new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 7", 3, 5, "Titulo 7" },
                    { 5, 5, "Conteudo 5", new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 5", 3, 1, "Titulo 5" },
                    { 8, 5, "Conteudo 8", new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Resumo 8", 3, 2, "Titulo 8" }
                });

            migrationBuilder.InsertData(
                table: "FotosNoticias",
                columns: new[] { "FotoFK", "NoticiaFK", "Default" },
                values: new object[,]
                {
                    { 3, 4, 0 },
                    { 4, 2, 0 },
                    { 8, 3, 0 },
                    { 2, 9, 0 },
                    { 1, 6, 0 },
                    { 6, 10, 0 },
                    { 1, 1, 0 },
                    { 5, 7, 0 },
                    { 7, 5, 0 },
                    { 9, 8, 0 }
                });
        }
    }
}
