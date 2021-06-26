using Microsoft.EntityFrameworkCore.Migrations;

namespace CotoviaSite2.Data.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 2,
                column: "Tema",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Estado", "Tema" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 4,
                column: "Tema",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 5,
                column: "Tema",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Estado", "Tema" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 7,
                column: "Tema",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Estado", "Tema" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Estado", "Tema" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Estado", "Tema" },
                values: new object[] { 1, 8 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 2,
                column: "Tema",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Estado", "Tema" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 4,
                column: "Tema",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 5,
                column: "Tema",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Estado", "Tema" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 7,
                column: "Tema",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Estado", "Tema" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Estado", "Tema" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Estado", "Tema" },
                values: new object[] { 0, 0 });
        }
    }
}
