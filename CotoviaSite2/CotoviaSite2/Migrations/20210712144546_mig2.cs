using Microsoft.EntityFrameworkCore.Migrations;

namespace CotoviaSite2.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeFoto",
                table: "Fotografias",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeFoto",
                table: "Fotografias");
        }
    }
}
