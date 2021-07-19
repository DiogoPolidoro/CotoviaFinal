using Microsoft.EntityFrameworkCore.Migrations;

namespace CotoviaSite2.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "eb555e3a-9032-444b-ab3d-d4f57925dcd0", "AUTOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "r",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "4c74565e-b00c-4064-908c-41f8e14d2030", "REVISOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "f07bdffa-01ae-4056-973e-ddc3b546d58a", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "r",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "09585820-ad65-4dee-8283-6dd9c6789c64", null });
        }
    }
}
