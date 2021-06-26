using Microsoft.EntityFrameworkCore.Migrations;

namespace CotoviaSite2.Data.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 3,
                column: "Cargo",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 5,
                column: "Cargo",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 3,
                column: "Cargo",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 5,
                column: "Cargo",
                value: 0);
        }
    }
}
