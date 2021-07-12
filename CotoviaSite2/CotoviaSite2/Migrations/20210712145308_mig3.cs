using Microsoft.EntityFrameworkCore.Migrations;

namespace CotoviaSite2.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 1,
                column: "NomeFoto",
                value: "Foto1");

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 2,
                column: "NomeFoto",
                value: "Foto2");

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 3,
                column: "NomeFoto",
                value: "Foto3");

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 4,
                column: "NomeFoto",
                value: "Foto4");

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 5,
                column: "NomeFoto",
                value: "Foto5");

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 6,
                column: "NomeFoto",
                value: "Foto6");

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 7,
                column: "NomeFoto",
                value: "Foto7");

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 8,
                column: "NomeFoto",
                value: "Foto8");

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 9,
                column: "NomeFoto",
                value: "Foto9");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 1,
                column: "NomeFoto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 2,
                column: "NomeFoto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 3,
                column: "NomeFoto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 4,
                column: "NomeFoto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 5,
                column: "NomeFoto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 6,
                column: "NomeFoto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 7,
                column: "NomeFoto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 8,
                column: "NomeFoto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "ID",
                keyValue: 9,
                column: "NomeFoto",
                value: null);
        }
    }
}
